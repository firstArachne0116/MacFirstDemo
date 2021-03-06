// This file has been autogenerated from a class added in the UI designer.

using System;
using System.Text.RegularExpressions;

using Foundation;
using AppKit;

namespace Hello_Mac
{
	public partial class LoginDialogController : NSViewController
	{
		#region Private Variables
		private static bool firstTime = true;
		#endregion

		#region Application Access
		public static AppDelegate App
		{
			get { return (AppDelegate)NSApplication.SharedApplication.Delegate; }
		}
		#endregion

		#region Constructors
		public LoginDialogController(IntPtr handle) : base(handle)
		{
		}
		#endregion

		public bool ValidateEmail(string email)
		{
			Regex EmailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
			if (string.IsNullOrWhiteSpace(email))
				return false;

			return EmailRegex.IsMatch(email);
		}

		#region Override Methods
		public override void ViewWillAppear()
		{
			base.ViewWillAppear();
		}
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
			AcceptButton.Enabled = false;

			email.Changed += (sender, e) =>
			{
				if (email.StringValue.Length > 255)
                {
					email.StringValue = email.StringValue.Substring(0, 255);
                }
				if (ValidateEmail(email.StringValue))
                {
					email.TextColor = NSColor.Text;
					AcceptButton.Enabled = password.StringValue.Length != 0;
				}
				else
				{
					email.TextColor = NSColor.Red;
					AcceptButton.Enabled = false;
				}
			};

			password.Changed += (sender, e) =>
			{
				if (password.StringValue.Length > 255)
				{
					password.StringValue = password.StringValue.Substring(0, 255);
				}
				if(password.StringValue.Length == 0)
                {
					AcceptButton.Enabled = false;
				}
                else if (email.StringValue.Length != 0 && ValidateEmail(email.StringValue))
                {
					AcceptButton.Enabled = true;
                }
			};
        }
        #endregion

        #region Private Methods
        private void CloseDialog()
		{
			this.View.Window.Close();
			if (firstTime)
			{
				firstTime = false;
				var storyboard = NSStoryboard.FromName("Main", null);
				var controller = storyboard.InstantiateControllerWithIdentifier("MainWindow") as NSWindowController;
				controller.ShowWindow(this);
			}
		}
		#endregion
		#region Custom Actions
		partial void AcceptDialog(Foundation.NSObject sender)
		{
			if (ValidateEmail(email.StringValue))
			{
				CloseDialog();
				RaiseDialogAccepted();
			}
		}

		partial void CancelDialog(Foundation.NSObject sender)
		{
			RaiseDialogCanceled();
			NSApplication.SharedApplication.Terminate(this);
		}
		#endregion

		#region Events
		public EventHandler DialogAccepted;

		internal void RaiseDialogAccepted()
		{
			if (this.DialogAccepted != null)
				this.DialogAccepted(this, EventArgs.Empty);
		}

		public EventHandler DialogCanceled;

		internal void RaiseDialogCanceled()
		{
			if (this.DialogCanceled != null)
				this.DialogCanceled(this, EventArgs.Empty);
		}
		#endregion
	}
}
