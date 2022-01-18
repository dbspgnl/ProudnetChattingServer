﻿using Nettention.Proud;

namespace ChattingCommon
{
	public class Vars
	{
		public static System.Guid m_Version = new System.Guid("{ 0x3ae33249, 0xecc6, 0x4980, { 0xbc, 0x5d, 0x7b, 0xa, 0x99, 0x9c, 0x7, 0x39 } }");
		public static int m_serverPort = 33334;

		static Vars()
		{

		}
	}
	public class User
	{
		static int UserId = 0; // User 요청 카운팅
		public HostID HostId { get; set; }
		public string UserName { get; set; }
		public int UserID { get; set; }
		public User(string UserName, HostID HostId)
		{
			UserID = ++UserId;
			this.UserName = UserName;
			this.HostId = HostId;
		}
		public User()
		{
			UserName = "Unknown";
		}
	}
}