﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics.CodeAnalysis;
using Nettention.Proud;
namespace ChattingServer
{
    internal class Handler
    {
        process.CommonProcess Process = new process.CommonProcess();

        public bool ConnectionRequestHandler(AddrPort clientAddr, ByteArray userDataFromClient, [NotNull] ByteArray reply)
        {
            reply = new ByteArray();
            reply.Clear();

            return true;
        }

        public void ClientHackSuspectedHandler(HostID clientId, HackType hackType)
        {

        }

        public void ClientJoinHandler(NetClientInfo clientInfo)
        {
            string message = string.Format("Host{0} entered", clientInfo.hostID);
            Console.WriteLine(message);
            Process.SystemChat(message);
        }

        public void ClientLeaveHandler(NetClientInfo clientInfo, ErrorInfo errorinfo, ByteArray comment)
        {
            string message = string.Format("Host{0} leaved", clientInfo.hostID);
            Console.WriteLine(message);
            Process.SystemChat(message);
        }

        public void ErrorHandler(ErrorInfo errorInfo)
        {

        }

        public void WarningHandler(ErrorInfo errorInfo)
        {

        }

        public void ExceptionHandler(Exception e)
        {

        }

        public void InformationHandler(ErrorInfo errorInfo)
        {

        }

        public void NoRmiProcessedHandler(RmiID rmiId)
        {

        }

        public void P2PGroupJoinMemberAckCompleteHandler(HostID groupHostId, HostID memberHostId, ErrorType result)
        {

        }

        public void TickHandler(object contextBoundObject)
        {

        }

        public void UserWorkerThreadBeginHandler()
        {

        }

        public void UserWorkerThreadEndHandler()
        {

        }
    }
}