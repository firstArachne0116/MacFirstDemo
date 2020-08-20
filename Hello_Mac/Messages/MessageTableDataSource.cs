using System;
using AppKit;
using CoreGraphics;
using Foundation;
using System.Collections;
using System.Collections.Generic;

namespace Hello_Mac
{
    public class MessageTableDataSource : NSTableViewDataSource
    {
        #region Public Variables
        public List<Message> Messages = new List<Message>();
        #endregion

        #region Constructors
        public MessageTableDataSource()
        {
        }
        #endregion

        #region Override Methods
        public override nint GetRowCount(NSTableView tableView)
        {
            return Messages.Count;
        }
        #endregion
    }
}