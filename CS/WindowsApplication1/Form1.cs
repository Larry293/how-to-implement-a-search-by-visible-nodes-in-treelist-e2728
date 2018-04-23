using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraTreeList;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        private DataTable CreateTable(int RowCount)
        {
            DataTable tbl = new DataTable();
            tbl.Columns.Add("Name", typeof(string));
            tbl.Columns.Add("ID", typeof(int));
            tbl.Columns.Add("Number", typeof(int));
            tbl.Columns.Add("Date", typeof(DateTime));
            tbl.Columns.Add("ParentID", typeof(int));
            for (int i = 0; i < RowCount; i++)
                tbl.Rows.Add(new object[] { String.Format("Name{0}", i), i + 1, 3 - i, DateTime.Now.AddDays(i), i % 3 });
            return tbl;
        }

        MyTreeListSearchHelper helper;

        public Form1()
        {
            InitializeComponent();
            treeList1.DataSource = CreateTable(300);
            helper = new MyTreeListSearchHelper(treeList1);
            helper.FieldName = "Name";
            helper.Text = buttonEdit1.Text;
        }

        private void buttonEdit1_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            PerformSearch(e.Button.Index == 1);
        }
        private void PerformSearch(bool forward)
        {
            helper.PerformSearch(forward);
           treeList1.FocusedNode =  helper.CurrentNode;
        }

        private void buttonEdit1_EditValueChanged(object sender, EventArgs e)
        {
            helper.Text = buttonEdit1.Text;
        }
    }
}