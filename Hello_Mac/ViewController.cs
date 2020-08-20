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

            FollowList.RowSizeStyle = NSTableViewRowSizeStyle.Large;

            var followItems = new SourceListItem("フォロー一覧");
            followItems.AddItem("フォロー1", "https://randomuser.me/api/portraits/men/1.jpg");
            followItems.AddItem("フォロー2", "https://randomuser.me/api/portraits/men/2.jpg");
            followItems.AddItem("フォロー3", "https://randomuser.me/api/portraits/men/3.jpg");
            followItems.AddItem("フォロー4", "https://randomuser.me/api/portraits/men/4.jpg");
            followItems.AddItem("フォロー5", "https://randomuser.me/api/portraits/men/5.jpg");
            FollowList.AddItem(followItems);

            // Display side list
            FollowList.ReloadData();
            FollowList.ExpandItem(null, true);

            LikeList.Initialize();

            LikeList.RowSizeStyle = NSTableViewRowSizeStyle.Large;

            var likeItems = new SourceListItem("いいね一覧");
            likeItems.AddItem("フォロワー1", "https://randomuser.me/api/portraits/men/6.jpg");
            likeItems.AddItem("フォロワー2", "https://randomuser.me/api/portraits/men/7.jpg");
            likeItems.AddItem("フォロワー3", "https://randomuser.me/api/portraits/men/8.jpg");
            likeItems.AddItem("フォロワー4", "https://randomuser.me/api/portraits/men/9.jpg");
            likeItems.AddItem("フォロワー5", "https://randomuser.me/api/portraits/men/10.jpg");
            LikeList.AddItem(likeItems);

            // Display side list
            LikeList.ReloadData();
            LikeList.ExpandItem(null, true);


            BlackList.Initialize();

            BlackList.RowSizeStyle = NSTableViewRowSizeStyle.Large;

            var blackItems = new SourceListItem("解除候補一覧");
            blackItems.AddItem("フォロワー1", "https://randomuser.me/api/portraits/men/11.jpg");
            blackItems.AddItem("フォロワー2", "https://randomuser.me/api/portraits/men/12.jpg");
            blackItems.AddItem("フォロワー3", "https://randomuser.me/api/portraits/men/13.jpg");
            blackItems.AddItem("フォロワー4", "https://randomuser.me/api/portraits/men/14.jpg");
            blackItems.AddItem("フォロワー5", "https://randomuser.me/api/portraits/men/15.jpg");
            BlackList.AddItem(blackItems);

            // Display side list
            BlackList.ReloadData();
            BlackList.ExpandItem(null, true);
        }
    }
}
