




// Generated by PIDL compiler.
// Do not modify this file, but modify the source .pidl file.

using System;
using System.Net;	     

namespace C2S
{
	internal class Stub:Nettention.Proud.RmiStub
	{
public AfterRmiInvocationDelegate AfterRmiInvocation = delegate(Nettention.Proud.AfterRmiSummary summary) {};
public BeforeRmiInvocationDelegate BeforeRmiInvocation = delegate(Nettention.Proud.BeforeRmiSummary summary) {};

		public delegate bool ChatDelegate(Nettention.Proud.HostID remote,Nettention.Proud.RmiContext rmiContext, string str);  
		public ChatDelegate Chat = delegate(Nettention.Proud.HostID remote,Nettention.Proud.RmiContext rmiContext, string str)
		{ 
			return false;
		};
		public delegate bool LoginDelegate(Nettention.Proud.HostID remote,Nettention.Proud.RmiContext rmiContext, String UserName);  
		public LoginDelegate Login = delegate(Nettention.Proud.HostID remote,Nettention.Proud.RmiContext rmiContext, String UserName)
		{ 
			return false;
		};
		public delegate bool EnterRoomDelegate(Nettention.Proud.HostID remote,Nettention.Proud.RmiContext rmiContext, int RoomNumber);  
		public EnterRoomDelegate EnterRoom = delegate(Nettention.Proud.HostID remote,Nettention.Proud.RmiContext rmiContext, int RoomNumber)
		{ 
			return false;
		};
		public delegate bool LeaveRoomDelegate(Nettention.Proud.HostID remote,Nettention.Proud.RmiContext rmiContext);  
		public LeaveRoomDelegate LeaveRoom = delegate(Nettention.Proud.HostID remote,Nettention.Proud.RmiContext rmiContext)
		{ 
			return false;
		};
	public override bool ProcessReceivedMessage(Nettention.Proud.ReceivedMessage pa, Object hostTag) 
	{
		Nettention.Proud.HostID remote=pa.RemoteHostID;
		if(remote==Nettention.Proud.HostID.HostID_None)
		{
			ShowUnknownHostIDWarning(remote);
		}

		Nettention.Proud.Message __msg=pa.ReadOnlyMessage;
		int orgReadOffset = __msg.ReadOffset;
        Nettention.Proud.RmiID __rmiID = Nettention.Proud.RmiID.RmiID_None;
        if (!__msg.Read( out __rmiID))
            goto __fail;
					
		switch(__rmiID)
		{
        case Common.Chat:
            ProcessReceivedMessage_Chat(__msg, pa, hostTag, remote);
            break;
        case Common.Login:
            ProcessReceivedMessage_Login(__msg, pa, hostTag, remote);
            break;
        case Common.EnterRoom:
            ProcessReceivedMessage_EnterRoom(__msg, pa, hostTag, remote);
            break;
        case Common.LeaveRoom:
            ProcessReceivedMessage_LeaveRoom(__msg, pa, hostTag, remote);
            break;
		default:
			 goto __fail;
		}
		return true;
__fail:
	  {
			__msg.ReadOffset = orgReadOffset;
			return false;
	  }
	}
    void ProcessReceivedMessage_Chat(Nettention.Proud.Message __msg, Nettention.Proud.ReceivedMessage pa, Object hostTag, Nettention.Proud.HostID remote)
    {
        Nettention.Proud.RmiContext ctx = new Nettention.Proud.RmiContext();
        ctx.sentFrom=pa.RemoteHostID;
        ctx.relayed=pa.IsRelayed;
        ctx.hostTag=hostTag;
        ctx.encryptMode = pa.EncryptMode;
        ctx.compressMode = pa.CompressMode;

        string str; ChattingCommon.Marshaler.Read(__msg,out str);	
core.PostCheckReadMessage(__msg, RmiName_Chat);
        if(enableNotifyCallFromStub==true)
        {
        string parameterString = "";
        parameterString+=str.ToString()+",";
        NotifyCallFromStub(Common.Chat, RmiName_Chat,parameterString);
        }

        if(enableStubProfiling)
        {
        Nettention.Proud.BeforeRmiSummary summary = new Nettention.Proud.BeforeRmiSummary();
        summary.rmiID = Common.Chat;
        summary.rmiName = RmiName_Chat;
        summary.hostID = remote;
        summary.hostTag = hostTag;
        BeforeRmiInvocation(summary);
        }

        long t0 = Nettention.Proud.PreciseCurrentTime.GetTimeMs();

        // Call this method.
        bool __ret =Chat (remote,ctx , str );

        if(__ret==false)
        {
        // Error: RMI function that a user did not create has been called. 
        core.ShowNotImplementedRmiWarning(RmiName_Chat);
        }

        if(enableStubProfiling)
        {
        Nettention.Proud.AfterRmiSummary summary = new Nettention.Proud.AfterRmiSummary();
        summary.rmiID = Common.Chat;
        summary.rmiName = RmiName_Chat;
        summary.hostID = remote;
        summary.hostTag = hostTag;
        summary.elapsedTime = Nettention.Proud.PreciseCurrentTime.GetTimeMs()-t0;
        AfterRmiInvocation(summary);
        }
    }
    void ProcessReceivedMessage_Login(Nettention.Proud.Message __msg, Nettention.Proud.ReceivedMessage pa, Object hostTag, Nettention.Proud.HostID remote)
    {
        Nettention.Proud.RmiContext ctx = new Nettention.Proud.RmiContext();
        ctx.sentFrom=pa.RemoteHostID;
        ctx.relayed=pa.IsRelayed;
        ctx.hostTag=hostTag;
        ctx.encryptMode = pa.EncryptMode;
        ctx.compressMode = pa.CompressMode;

        String UserName; ChattingCommon.Marshaler.Read(__msg,out UserName);	
core.PostCheckReadMessage(__msg, RmiName_Login);
        if(enableNotifyCallFromStub==true)
        {
        string parameterString = "";
        parameterString+=UserName.ToString()+",";
        NotifyCallFromStub(Common.Login, RmiName_Login,parameterString);
        }

        if(enableStubProfiling)
        {
        Nettention.Proud.BeforeRmiSummary summary = new Nettention.Proud.BeforeRmiSummary();
        summary.rmiID = Common.Login;
        summary.rmiName = RmiName_Login;
        summary.hostID = remote;
        summary.hostTag = hostTag;
        BeforeRmiInvocation(summary);
        }

        long t0 = Nettention.Proud.PreciseCurrentTime.GetTimeMs();

        // Call this method.
        bool __ret =Login (remote,ctx , UserName );

        if(__ret==false)
        {
        // Error: RMI function that a user did not create has been called. 
        core.ShowNotImplementedRmiWarning(RmiName_Login);
        }

        if(enableStubProfiling)
        {
        Nettention.Proud.AfterRmiSummary summary = new Nettention.Proud.AfterRmiSummary();
        summary.rmiID = Common.Login;
        summary.rmiName = RmiName_Login;
        summary.hostID = remote;
        summary.hostTag = hostTag;
        summary.elapsedTime = Nettention.Proud.PreciseCurrentTime.GetTimeMs()-t0;
        AfterRmiInvocation(summary);
        }
    }
    void ProcessReceivedMessage_EnterRoom(Nettention.Proud.Message __msg, Nettention.Proud.ReceivedMessage pa, Object hostTag, Nettention.Proud.HostID remote)
    {
        Nettention.Proud.RmiContext ctx = new Nettention.Proud.RmiContext();
        ctx.sentFrom=pa.RemoteHostID;
        ctx.relayed=pa.IsRelayed;
        ctx.hostTag=hostTag;
        ctx.encryptMode = pa.EncryptMode;
        ctx.compressMode = pa.CompressMode;

        int RoomNumber; ChattingCommon.Marshaler.Read(__msg,out RoomNumber);	
core.PostCheckReadMessage(__msg, RmiName_EnterRoom);
        if(enableNotifyCallFromStub==true)
        {
        string parameterString = "";
        parameterString+=RoomNumber.ToString()+",";
        NotifyCallFromStub(Common.EnterRoom, RmiName_EnterRoom,parameterString);
        }

        if(enableStubProfiling)
        {
        Nettention.Proud.BeforeRmiSummary summary = new Nettention.Proud.BeforeRmiSummary();
        summary.rmiID = Common.EnterRoom;
        summary.rmiName = RmiName_EnterRoom;
        summary.hostID = remote;
        summary.hostTag = hostTag;
        BeforeRmiInvocation(summary);
        }

        long t0 = Nettention.Proud.PreciseCurrentTime.GetTimeMs();

        // Call this method.
        bool __ret =EnterRoom (remote,ctx , RoomNumber );

        if(__ret==false)
        {
        // Error: RMI function that a user did not create has been called. 
        core.ShowNotImplementedRmiWarning(RmiName_EnterRoom);
        }

        if(enableStubProfiling)
        {
        Nettention.Proud.AfterRmiSummary summary = new Nettention.Proud.AfterRmiSummary();
        summary.rmiID = Common.EnterRoom;
        summary.rmiName = RmiName_EnterRoom;
        summary.hostID = remote;
        summary.hostTag = hostTag;
        summary.elapsedTime = Nettention.Proud.PreciseCurrentTime.GetTimeMs()-t0;
        AfterRmiInvocation(summary);
        }
    }
    void ProcessReceivedMessage_LeaveRoom(Nettention.Proud.Message __msg, Nettention.Proud.ReceivedMessage pa, Object hostTag, Nettention.Proud.HostID remote)
    {
        Nettention.Proud.RmiContext ctx = new Nettention.Proud.RmiContext();
        ctx.sentFrom=pa.RemoteHostID;
        ctx.relayed=pa.IsRelayed;
        ctx.hostTag=hostTag;
        ctx.encryptMode = pa.EncryptMode;
        ctx.compressMode = pa.CompressMode;

        core.PostCheckReadMessage(__msg, RmiName_LeaveRoom);
        if(enableNotifyCallFromStub==true)
        {
        string parameterString = "";
                NotifyCallFromStub(Common.LeaveRoom, RmiName_LeaveRoom,parameterString);
        }

        if(enableStubProfiling)
        {
        Nettention.Proud.BeforeRmiSummary summary = new Nettention.Proud.BeforeRmiSummary();
        summary.rmiID = Common.LeaveRoom;
        summary.rmiName = RmiName_LeaveRoom;
        summary.hostID = remote;
        summary.hostTag = hostTag;
        BeforeRmiInvocation(summary);
        }

        long t0 = Nettention.Proud.PreciseCurrentTime.GetTimeMs();

        // Call this method.
        bool __ret =LeaveRoom (remote,ctx  );

        if(__ret==false)
        {
        // Error: RMI function that a user did not create has been called. 
        core.ShowNotImplementedRmiWarning(RmiName_LeaveRoom);
        }

        if(enableStubProfiling)
        {
        Nettention.Proud.AfterRmiSummary summary = new Nettention.Proud.AfterRmiSummary();
        summary.rmiID = Common.LeaveRoom;
        summary.rmiName = RmiName_LeaveRoom;
        summary.hostID = remote;
        summary.hostTag = hostTag;
        summary.elapsedTime = Nettention.Proud.PreciseCurrentTime.GetTimeMs()-t0;
        AfterRmiInvocation(summary);
        }
    }
		#if USE_RMI_NAME_STRING
// RMI name declaration.
// It is the unique pointer that indicates RMI name such as RMI profiler.
public const string RmiName_Chat="Chat";
public const string RmiName_Login="Login";
public const string RmiName_EnterRoom="EnterRoom";
public const string RmiName_LeaveRoom="LeaveRoom";
       
public const string RmiName_First = RmiName_Chat;
		#else
// RMI name declaration.
// It is the unique pointer that indicates RMI name such as RMI profiler.
public const string RmiName_Chat="";
public const string RmiName_Login="";
public const string RmiName_EnterRoom="";
public const string RmiName_LeaveRoom="";
       
public const string RmiName_First = "";
		#endif

		public override Nettention.Proud.RmiID[] GetRmiIDList { get{return Common.RmiIDList;} }
		
	}
}

