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
	[Register ("LoginDialogController")]
	partial class LoginDialogController
	{
		[Outlet]
		AppKit.NSButton AcceptButton { get; set; }

		[Outlet]
		AppKit.NSTextField email { get; set; }

		[Outlet]
		AppKit.NSSecureTextField password { get; set; }

		[Action ("AcceptDialog:")]
		partial void AcceptDialog (Foundation.NSObject sender);

		[Action ("CancelDialog:")]
		partial void CancelDialog (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (email != null) {
				email.Dispose ();
				email = null;
			}

			if (password != null) {
				password.Dispose ();
				password = null;
			}

			if (AcceptButton != null) {
				AcceptButton.Dispose ();
				AcceptButton = null;
			}
		}
	}
}
