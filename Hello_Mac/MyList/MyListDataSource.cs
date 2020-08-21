using System;
using AppKit;
using CoreGraphics;
using Foundation;
using System.Collections;
using System.Collections.Generic;

namespace Hello_Mac
{
    public class MyListDataSource : NSTableViewDataSource
    {
        #region Public Variables
        public List<MyListItem> ListItems = new List<MyListItem>();
        #endregion

        #region Constructors
        public MyListDataSource()
        {
        }
        #endregion

        #region Override Methods
        public override nint GetRowCount(NSTableView tableView)
        {
            return ListItems.Count;
        }
        #endregion
    }
}