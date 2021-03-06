using Nettention.Proud;
using ChattingCommon;

namespace Client
{
    class Program
    {
        static object g_critSec = new object();
        static NetClient netClient = new NetClient();
        static S2C.Stub S2CStub = new S2C.Stub();
        static C2S.Proxy C2SProxy = new C2S.Proxy();
        static bool isConnected = false;
        static bool keepWorkerThread = true;

        static bool isLoggedin = false;
        static User me = new User();

        static void InitializeStub()
        {
            S2CStub.SystemChat = (HostID remote, RmiContext rmiContext, string str) =>
            {
                lock (g_critSec)
                {
                    Console.WriteLine("[System] {0}", str);
                }
                return true;
            };
            S2CStub.NotifyChat = (HostID remote, RmiContext rmiContext, string UserName, string str) =>
            {
                lock (g_critSec)
                {
                    Console.WriteLine("{0}: {1}", UserName, str);
                }
                return true;
            };
            S2CStub.ResponseLogin = (HostID remote, RmiContext rmiContext, User user) =>
            {
                lock (g_critSec)
                {
                    isLoggedin = true;
                    me = user;
                }
                return true;
            };
        }
        static void InitializeHandler()
        {
            netClient.JoinServerCompleteHandler = (info, replyFromServer) =>
            {
                lock (g_critSec)
                {
                    if (info.errorType == ErrorType.Ok)
                    {
                        Console.Write("Succeed to connect server. Allocated hostID={0}\n", netClient.GetLocalHostID());
                        isConnected = true;
                    }
                    else
                    {
                        Console.Write("Failed to connect server.\n");
                        Console.WriteLine("errorType = {0}, detailType = {1}, comment = {2}", info.errorType, info.detailType, info.comment);
                    }
                }
            };

            netClient.LeaveServerHandler = (errorInfo) =>
            {
                lock (g_critSec)
                {
                    Console.Write("OnLeaveServer: {0}\n", errorInfo.comment);

                    isConnected = false;
                    keepWorkerThread = false;
                }
            };

        }
        static void initializeClient()
        {
            netClient.AttachStub(S2CStub);
            netClient.AttachProxy(C2SProxy);
        }
        static void InitializeClientParameter()
        {
            NetConnectionParam cp = new NetConnectionParam();
            cp.protocolVersion.Set(Vars.m_Version);
            cp.serverIP = "localhost";
            cp.serverPort = (ushort)Vars.m_serverPort;
            netClient.Connect(cp);
        }
        static void Main(string[] args)
        {
            InitializeHandler();
            initializeClient();
            InitializeStub();
            InitializeClientParameter();

            Thread workerThread = new Thread(() =>
            {
                while (keepWorkerThread)
                {
                    Thread.Sleep(10);
                    netClient.FrameMove();
                }
            });
            workerThread.Start();

            while (!isConnected)
                Thread.Sleep(1000);

            Console.Write("UserName: ");
            while (keepWorkerThread)
            {
                string userInput = Console.ReadLine();
                if (userInput == "")
                    continue;

                if (isLoggedin)
                {
                    if (userInput == "q")
                        keepWorkerThread = false;
                    else if (me.RoomNumber == 0)
                    {
                        try
                        {
                            int RoomNumber = Int32.Parse(userInput);
                            C2SProxy.EnterRoom(HostID.HostID_Server, RmiContext.ReliableSend, RoomNumber);
                            me.RoomNumber = RoomNumber;
                        }
                        catch (FormatException ex)
                        {

                        }
                    }
                    else
                    {
                        Console.Write("Chat to Room: {0}\n", me.RoomNumber);
                        C2SProxy.Chat(HostID.HostID_Server, RmiContext.ReliableSend, userInput);
                    }
                }
                else
                {
                    Console.WriteLine("Login...");
                    Console.WriteLine("Please enter your room number.");
                    C2SProxy.Login(HostID.HostID_Server, RmiContext.ReliableSend, userInput);
                }
            }

            workerThread.Join();
            netClient.Disconnect();

        }
    }
}