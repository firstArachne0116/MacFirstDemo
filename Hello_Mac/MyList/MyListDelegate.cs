using System;
using AppKit;
using CoreGraphics;
using Foundation;
using System.Collections;
using System.Collections.Generic;

namespace Hello_Mac
{
    public class MyListDelegate : NSTableViewDelegate
    {
        #region Constants 
        private const string CellIdentifier = "DataCell";
        #endregion

        #region Private Variables
        private MyListDataSource DataSource;
        #endregion

        #region Constructors
        public MyListDelegate(MyListDataSource datasource)
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

            NSTableCellView view = null;

            if ((int)row == 0)
                view = (NSTableCellView)tableView.MakeView("HeaderCell", this);
            else
                view = (NSTableCellView)tableView.MakeView("DataCell", this);

            // Setup view based on the column selected
            view.TextField.StringValue = DataSource.ListItems[(int)row].Title;
            if (view.ImageView != null)
                view.ImageView.Image = DataSource.ListItems[(int)row].Icon;

            return view;
        }

        #endregion
    }
}