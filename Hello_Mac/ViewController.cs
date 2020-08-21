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

        private string toNumberString(string str)
        {
            string newStr = "";
            for (int i = 0; i < str.Length; i++)
            {
                if ('0' <= str[i] && str[i] <= '9')
                {
                    newStr += str[i];
                }
            }
            if (newStr.Length == 0) newStr = "0";

            return newStr;
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Do any additional setup after loading the view.

            AppDelegate appDelegate = NSApplication.SharedApplication.Delegate as AppDelegate;
            appDelegate.EnableMenu();

            interval.Changed += (sender, e) =>
            {
                string str = interval.StringValue;
                string newStr = toNumberString(str);
                int num = Convert.ToInt32(newStr);
                if (num < 10) num = 10;
                if (num > 300) num = 300;
                newStr = Convert.ToString(num);
                if (newStr != str)
                    interval.StringValue = newStr;
            };
            maxAutomatic.Changed += (sender, e) =>
            {
                string str = maxAutomatic.StringValue;
                string newStr = toNumberString(str);
                if (newStr != str)
                    maxAutomatic.StringValue = newStr;
            };
            maxCancel.Changed += (sender, e) =>
            {
                string str = maxCancel.StringValue;
                string newStr = toNumberString(str);
                if (newStr != str)
                    maxCancel.StringValue = newStr;
            };
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

            var FollowDataSource = new MyListDataSource();
            FollowDataSource.ListItems.Add(new MyListItem("フォロー一覧"));
            FollowDataSource.ListItems.Add(new MyListItem("フォロー1", "https://randomuser.me/api/portraits/men/1.jpg"));
            FollowDataSource.ListItems.Add(new MyListItem("フォロー2", "https://randomuser.me/api/portraits/men/2.jpg"));
            FollowDataSource.ListItems.Add(new MyListItem("フォロー3", "https://randomuser.me/api/portraits/men/3.jpg"));
            FollowDataSource.ListItems.Add(new MyListItem("フォロー4", "https://randomuser.me/api/portraits/men/4.jpg"));
            FollowDataSource.ListItems.Add(new MyListItem("フォロー5", "https://randomuser.me/api/portraits/men/5.jpg"));

            if (FollowList != null)
            {
                FollowList.DataSource = FollowDataSource;
                FollowList.Delegate = new MyListDelegate(FollowDataSource);
            }

            var LikeDataSource = new MyListDataSource();
            LikeDataSource.ListItems.Add(new MyListItem("いいね一覧"));
            LikeDataSource.ListItems.Add(new MyListItem("フォロワー1", "https://randomuser.me/api/portraits/men/6.jpg"));
            LikeDataSource.ListItems.Add(new MyListItem("フォロワー2", "https://randomuser.me/api/portraits/men/7.jpg"));
            LikeDataSource.ListItems.Add(new MyListItem("フォロワー3", "https://randomuser.me/api/portraits/men/8.jpg"));
            LikeDataSource.ListItems.Add(new MyListItem("フォロワー4", "https://randomuser.me/api/portraits/men/9.jpg"));
            LikeDataSource.ListItems.Add(new MyListItem("フォロワー5", "https://randomuser.me/api/portraits/men/10.jpg"));

            if (LikeList != null)
            {
                LikeList.DataSource = LikeDataSource;
                LikeList.Delegate = new MyListDelegate(LikeDataSource);
            }

            var BlackDataSource = new MyListDataSource();
            BlackDataSource.ListItems.Add(new MyListItem("解除候補一覧"));
            BlackDataSource.ListItems.Add(new MyListItem("フォロワー1", "https://randomuser.me/api/portraits/men/11.jpg"));
            BlackDataSource.ListItems.Add(new MyListItem("フォロワー2", "https://randomuser.me/api/portraits/men/12.jpg"));
            BlackDataSource.ListItems.Add(new MyListItem("フォロワー3", "https://randomuser.me/api/portraits/men/13.jpg"));
            BlackDataSource.ListItems.Add(new MyListItem("フォロワー4", "https://randomuser.me/api/portraits/men/14.jpg"));
            BlackDataSource.ListItems.Add(new MyListItem("フォロワー5", "https://randomuser.me/api/portraits/men/15.jpg"));

            if (BlackList != null)
            {
                BlackList.DataSource = BlackDataSource;
                BlackList.Delegate = new MyListDelegate(BlackDataSource);
            }
        }

    }
}
