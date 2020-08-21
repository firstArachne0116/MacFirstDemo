using AppKit;
using Foundation;
using System;
using System.IO;
using System.Runtime.InteropServices;

namespace Hello_Mac
{
    [Register("AppDelegate")]
    public partial class AppDelegate : NSApplicationDelegate
    {

        public AppDelegate()
        {
            string fileName = "setting.ini.rtf";
            string real_path = Directory.GetCurrentDirectory() + "/../../../";
            var thmbpath = Path.Combine(real_path, fileName);
            if (!File.Exists(thmbpath))
            {
                var alert = new NSAlert()
                {
                    AlertStyle = NSAlertStyle.Critical,
                    InformativeText = "設定ファイルがありません",
                    MessageText = "エラー",
                };
                alert.RunModal();
                //NSApplication.SharedApplication.Terminate(this);
            }
        }

        public override void DidFinishLaunching(NSNotification notification)
        {
            // Insert code here to initialize your application
            if (MainMenu != null && MainMenu.Items.Length >= 3)
            {
                MainMenu.Items[1].Enabled = false;
                MainMenu.Items[2].Enabled = false;
            }
        }

        public override void WillTerminate(NSNotification notification)
        {
            // Insert code here to tear down your application
        }

        public void EnableMenu()
        {
            if (MainMenu != null && MainMenu.Items.Length >= 3)
            {
                MainMenu.Items[1].Enabled = true;
                MainMenu.Items[2].Enabled = true;
            }
        }

    }
}
