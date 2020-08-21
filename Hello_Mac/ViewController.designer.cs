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
		AppKit.NSTableView BlackList { get; set; }

		[Outlet]
		AppKit.NSTableColumn DateColumn { get; set; }

		[Outlet]
		AppKit.NSTableView FollowList { get; set; }

		[Outlet]
		AppKit.NSTextField interval { get; set; }

		[Outlet]
		AppKit.NSTableView LikeList { get; set; }

		[Outlet]
		AppKit.NSTextField maxAutomatic { get; set; }

		[Outlet]
		AppKit.NSTextField maxCancel { get; set; }

		[Outlet]
		AppKit.NSTableColumn MessageColumn { get; set; }

		[Outlet]
		AppKit.NSTableView MessageTable { get; set; }

		[Outlet]
		AppKit.NSTableColumn SectionColumn { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (BlackList != null) {
				BlackList.Dispose ();
				BlackList = null;
			}

			if (DateColumn != null) {
				DateColumn.Dispose ();
				DateColumn = null;
			}

			if (FollowList != null) {
				FollowList.Dispose ();
				FollowList = null;
			}

			if (LikeList != null) {
				LikeList.Dispose ();
				LikeList = null;
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

			if (interval != null) {
				interval.Dispose ();
				interval = null;
			}

			if (maxAutomatic != null) {
				maxAutomatic.Dispose ();
				maxAutomatic = null;
			}

			if (maxCancel != null) {
				maxCancel.Dispose ();
				maxCancel = null;
			}
		}
	}
}
