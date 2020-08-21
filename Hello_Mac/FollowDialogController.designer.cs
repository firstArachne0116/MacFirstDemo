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
	[Register ("FollowDialogController")]
	partial class FollowDialogController
	{
		[Outlet]
		AppKit.NSTableView FollowList { get; set; }

		[Action ("AcceptDialog:")]
		partial void AcceptDialog (Foundation.NSObject sender);

		[Action ("CancelDialog:")]
		partial void CancelDialog (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (FollowList != null) {
				FollowList.Dispose ();
				FollowList = null;
			}
		}
	}
}
