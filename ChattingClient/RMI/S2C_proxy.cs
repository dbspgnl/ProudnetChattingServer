﻿




// Generated by PIDL compiler.
// Do not modify this file, but modify the source .pidl file.

using System;
using System.Net;

namespace S2C
{
	internal class Proxy:Nettention.Proud.RmiProxy
	{
public bool NotifyChat(Nettention.Proud.HostID remote,Nettention.Proud.RmiContext rmiContext, string UserName, string str)
{
	Nettention.Proud.Message __msg=new Nettention.Proud.Message();
		__msg.SimplePacketMode = core.IsSimplePacketMode();
		Nettention.Proud.RmiID __msgid= Common.NotifyChat;
		__msg.Write(__msgid);
		ChattingCommon.Marshaler.Write(__msg, UserName);
		ChattingCommon.Marshaler.Write(__msg, str);
		
	Nettention.Proud.HostID[] __list = new Nettention.Proud.HostID[1];
	__list[0] = remote;
		
	return RmiSend(__list,rmiContext,__msg,
		RmiName_NotifyChat, Common.NotifyChat);
}

public bool NotifyChat(Nettention.Proud.HostID[] remotes,Nettention.Proud.RmiContext rmiContext, string UserName, string str)
{
	Nettention.Proud.Message __msg=new Nettention.Proud.Message();
__msg.SimplePacketMode = core.IsSimplePacketMode();
Nettention.Proud.RmiID __msgid= Common.NotifyChat;
__msg.Write(__msgid);
ChattingCommon.Marshaler.Write(__msg, UserName);
ChattingCommon.Marshaler.Write(__msg, str);
		
	return RmiSend(remotes,rmiContext,__msg,
		RmiName_NotifyChat, Common.NotifyChat);
}
public bool SystemChat(Nettention.Proud.HostID remote,Nettention.Proud.RmiContext rmiContext, string str)
{
	Nettention.Proud.Message __msg=new Nettention.Proud.Message();
		__msg.SimplePacketMode = core.IsSimplePacketMode();
		Nettention.Proud.RmiID __msgid= Common.SystemChat;
		__msg.Write(__msgid);
		ChattingCommon.Marshaler.Write(__msg, str);
		
	Nettention.Proud.HostID[] __list = new Nettention.Proud.HostID[1];
	__list[0] = remote;
		
	return RmiSend(__list,rmiContext,__msg,
		RmiName_SystemChat, Common.SystemChat);
}

public bool SystemChat(Nettention.Proud.HostID[] remotes,Nettention.Proud.RmiContext rmiContext, string str)
{
	Nettention.Proud.Message __msg=new Nettention.Proud.Message();
__msg.SimplePacketMode = core.IsSimplePacketMode();
Nettention.Proud.RmiID __msgid= Common.SystemChat;
__msg.Write(__msgid);
ChattingCommon.Marshaler.Write(__msg, str);
		
	return RmiSend(remotes,rmiContext,__msg,
		RmiName_SystemChat, Common.SystemChat);
}
public bool ResponseLogin(Nettention.Proud.HostID remote,Nettention.Proud.RmiContext rmiContext, ChattingCommon.User user)
{
	Nettention.Proud.Message __msg=new Nettention.Proud.Message();
		__msg.SimplePacketMode = core.IsSimplePacketMode();
		Nettention.Proud.RmiID __msgid= Common.ResponseLogin;
		__msg.Write(__msgid);
		ChattingCommon.Marshaler.Write(__msg, user);
		
	Nettention.Proud.HostID[] __list = new Nettention.Proud.HostID[1];
	__list[0] = remote;
		
	return RmiSend(__list,rmiContext,__msg,
		RmiName_ResponseLogin, Common.ResponseLogin);
}

public bool ResponseLogin(Nettention.Proud.HostID[] remotes,Nettention.Proud.RmiContext rmiContext, ChattingCommon.User user)
{
	Nettention.Proud.Message __msg=new Nettention.Proud.Message();
__msg.SimplePacketMode = core.IsSimplePacketMode();
Nettention.Proud.RmiID __msgid= Common.ResponseLogin;
__msg.Write(__msgid);
ChattingCommon.Marshaler.Write(__msg, user);
		
	return RmiSend(remotes,rmiContext,__msg,
		RmiName_ResponseLogin, Common.ResponseLogin);
}
	
		#if USE_RMI_NAME_STRING
// RMI name declaration.
// It is the unique pointer that indicates RMI name such as RMI profiler.
public const string RmiName_NotifyChat="NotifyChat";
public const string RmiName_SystemChat="SystemChat";
public const string RmiName_ResponseLogin="ResponseLogin";
       
public const string RmiName_First = RmiName_NotifyChat;
		#else
// RMI name declaration.
// It is the unique pointer that indicates RMI name such as RMI profiler.
public const string RmiName_NotifyChat="";
public const string RmiName_SystemChat="";
public const string RmiName_ResponseLogin="";
       
public const string RmiName_First = "";
		#endif

		public override Nettention.Proud.RmiID[] GetRmiIDList() { return Common.RmiIDList; } 
	}
}

