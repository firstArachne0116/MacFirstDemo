using System;
using System.Collections;
using System.Collections.Generic;
using AppKit;
using Foundation;

namespace Hello_Mac
{
    public class MyListItem
    {
		#region Computed Properties
		public string Title { get; set; } = "";
		private NSImage _icon;
		#endregion

		public NSImage Icon
		{
			get { return _icon; }
			set { _icon = value; }
		}
		#region Constructors
		public MyListItem()
		{
		}

		public MyListItem(string title)
		{
			this.Title = title;
		}

		public MyListItem(string title, string icon)
		{
			this.Title = title;

			this.Icon = new NSImage();
			this.Icon.AddRepresentation(NSBitmapImageRep.ImageRepFromUrl(new NSUrl(icon)));
		}
		#endregion
	}
}
