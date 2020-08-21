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
	[Register ("WhiteListController")]
	partial class WhiteListController
	{
		[Outlet]
		AppKit.NSTableView WhiteList { get; set; }

		[Action ("AcceptDialog:")]
		partial void AcceptDialog (Foundation.NSObject sender);

		[Action ("CancelDialog:")]
		partial void CancelDialog (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (WhiteList != null) {
				WhiteList.Dispose ();
				WhiteList = null;
			}
		}
	}
}
