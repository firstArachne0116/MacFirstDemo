using System;
using AppKit;
using CoreGraphics;
using Foundation;
using System.Collections;
using System.Collections.Generic;

namespace Hello_Mac
{
    public class MessageTableDelegate : NSTableViewDelegate
    {
        #region Constants 
        private const string CellIdentifier = "ProdCell";
        #endregion

        #region Private Variables
        private MessageTableDataSource DataSource;
        #endregion

        #region Constructors
        public MessageTableDelegate(MessageTableDataSource datasource)
        {
            this.DataSource = datasource;
        }
        #endregion

        #region Override Methods
        public override NSView GetViewForItem(NSTableView tableView, NSTableColumn tableColumn, nint row)
        {
            // This pattern allows you reuse existing views when they are no-longer in use.
            // If the returned view is null, you instance up a new view
            // If a non-null view is returned, you modify it enough to reflect the new data
            NSTextField view = (NSTextField)tableView.MakeView(CellIdentifier, this);
            if (view == null)
            {
                view = new NSTextField();
                view.Identifier = CellIdentifier;
                view.BackgroundColor = NSColor.Clear;
                view.Bordered = false;
                view.Selectable = false;
                view.Editable = false;
            }

            // Setup view based on the column selected
            switch (tableColumn.Title)
            {
                case "時間":
                    view.StringValue = DataSource.Messages[(int)row].Date;
                    break;
                case "区分":
                    view.StringValue = DataSource.Messages[(int)row].Section;
                    break;
                case "メッセージ":
                    view.StringValue = DataSource.Messages[(int)row].Msg;
                    break;
            }

            switch (DataSource.Messages[(int)row].Section)
            {
                case "警告":
                    view.TextColor = NSColor.Cyan;
                    break;
                case "エラー":
                    view.TextColor = NSColor.Red;
                    break;
            }

            return view;
        }
        #endregion
    }
}