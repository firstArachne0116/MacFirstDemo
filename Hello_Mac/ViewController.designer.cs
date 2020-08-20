// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Hello_Mac
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		Hello_Mac.SourceListView BlackList { get; set; }

		[Outlet]
		AppKit.NSTableColumn DateColumn { get; set; }

		[Outlet]
		Hello_Mac.SourceListView FollowList { get; set; }

		[Outlet]
		Hello_Mac.SourceListView LikeList { get; set; }

		[Outlet]
		AppKit.NSTableColumn MessageColumn { get; set; }

		[Outlet]
		AppKit.NSTableView MessageTable { get; set; }

		[Outlet]
		AppKit.NSTableColumn SectionColumn { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (DateColumn != null) {
				DateColumn.Dispose ();
				DateColumn = null;
			}

			if (FollowList != null) {
				FollowList.Dispose ();
				FollowList = null;
			}

			if (MessageColumn != null) {
				MessageColumn.Dispose ();
				MessageColumn = null;
			}

			if (MessageTable != null) {
				MessageTable.Dispose ();
				MessageTable = null;
			}

			if (SectionColumn != null) {
				SectionColumn.Dispose ();
				SectionColumn = null;
			}

			if (LikeList != null) {
				LikeList.Dispose ();
				LikeList = null;
			}

			if (BlackList != null) {
				BlackList.Dispose ();
				BlackList = null;
			}
		}
	}
}
