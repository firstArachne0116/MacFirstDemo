using System;

using AppKit;
using Foundation;

namespace Hello_Mac
{
    public partial class ViewController : NSViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Do any additional setup after loading the view.
        }

        public override NSObject RepresentedObject
        {
            get
            {
                return base.RepresentedObject;
            }
            set
            {
                base.RepresentedObject = value;
                // Update the view, if already loaded.
            }
        }
        public override void AwakeFromNib()
        {
            base.AwakeFromNib();

            // Create the Message Table Data Source and populate it
            var DataSource = new MessageTableDataSource();
            DataSource.Messages.Add(new Message("yyyy/mm/dd hh:mm:ss", "情報", "xxxxx"));
            DataSource.Messages.Add(new Message("yyyy/mm/dd hh:mm:ss", "警告", "xxxxx"));
            DataSource.Messages.Add(new Message("yyyy/mm/dd hh:mm:ss", "エラー", "xxxxx"));
            DataSource.Messages.Add(new Message("yyyy/mm/dd hh:mm:ss", "情報", "xxxxx"));

            // Populate the Message Table
            MessageTable.DataSource = DataSource;
            MessageTable.Delegate = new MessageTableDelegate(DataSource);

            // Auto select the first row
            MessageTable.SelectRow(0, false);

            FollowList.Initialize();

            var library = new SourceListItem("Library");
            library.AddItem("フォロー1", "https://randomuser.me/api/portraits/men/1.jpg");
            library.AddItem("フォロー2", "https://randomuser.me/api/portraits/men/2.jpg");
            library.AddItem("フォロー3", "https://randomuser.me/api/portraits/men/3.jpg");
            library.AddItem("フォロー4", "https://randomuser.me/api/portraits/men/4.jpg");
            library.AddItem("フォロー5", "https://randomuser.me/api/portraits/men/5.jpg");
            FollowList.AddItem(library);

            // Display side list
            FollowList.ReloadData();
            FollowList.ExpandItem(null, true);
        }
    }
}
