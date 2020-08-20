using System;
namespace Hello_Mac
{
    public class Message
    {
		#region Computed Properties
		public string Date { get; set; } = "";
		public string Section { get; set; } = "";
		public string Msg { get; set; } = "";
		#endregion

		#region Constructors
		public Message()
		{
		}

		public Message(string date, string section, string msg)
		{
			this.Date = date;
			this.Section = section;
			this.Msg = msg;
		}
		#endregion
	}
}
