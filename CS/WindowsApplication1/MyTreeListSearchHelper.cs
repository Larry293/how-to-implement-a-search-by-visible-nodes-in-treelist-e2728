using System;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraTreeList;
using DevExpress.Utils.Paint;
using System.Drawing;

namespace WindowsApplication1
{
    public class MyTreeListSearchHelper
    {

        public MyTreeListSearchHelper(TreeList treeList)
        {
            _TreeList = treeList;
            _TreeList.CustomDrawNodeCell += _TreeList_CustomDrawNodeCell;
            _TreeList.FocusedNodeChanged += new FocusedNodeChangedEventHandler(_TreeList_FocusedNodeChanged);
        }

        void _TreeList_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e)
        {
            CurrentNode = e.Node;
        }

        XPaint paint = new XPaint();
        void _TreeList_CustomDrawNodeCell(object sender, CustomDrawNodeCellEventArgs e)
        {
            int index = e.CellText.IndexOf(Text, 0);
            if (index >= 0)
            {
                e.Handled = true;
                if (e.Node.Focused && e.Column.FieldName == FieldName)
                {
                    paint.DrawMultiColorString(e.Cache, e.Bounds, e.CellText, Text, e.Appearance, Color.Red, Color.Yellow, false, index);
                }
                else
                    paint.DrawMultiColorString(e.Cache, e.Bounds, e.CellText, Text, e.Appearance, Color.Blue, e.Appearance.GetBackColor(), false, index);
            }
            
        }

        private TreeListNode _CurrentNode;
        private readonly TreeList _TreeList;

        public TreeListNode CurrentNode
        {
            get
            {
                if (_CurrentNode == null)
                    return _TreeList.FocusedNode;
                else
                    return _CurrentNode;
            }
            set { _CurrentNode = value; }
        }

        private string _FieldName;
        public string FieldName
        {
            get { return _FieldName; }
            set { _FieldName = value; }
        }

        private string _Text;
        public string Text
        {
            get { return _Text; }
            set { _Text = value; }
        }

        public void FindNext()
        {
            PerformSearch(true);
        }

        public void FindPrev()
        {
            PerformSearch(false);
        }

        public void PerformSearch(bool forward)
        {
            CurrentNode = FindNode(forward);
        }

        private TreeListNode FindNode(bool forward)
        {
            if (CurrentNode == null)
                return CurrentNode;
            TreeListNode node = GetNextNode(CurrentNode, forward);
            if (node == null)
                return node;
            while (!MatchCondition(node))
            {
                node = GetNextNode(node, forward);
            }
            return node;
        }
        private TreeListNode GetNextNode(TreeListNode node, bool forward)
        {
            node.ExpandAll();
            return forward ? node.NextVisibleNode : node.NextVisibleNode;
        }
        private bool MatchCondition(TreeListNode node)
        {
            if (node == null)
                return true;
            if (node.GetDisplayText(FieldName).Contains(Text))
                return true;
            return false;
        }

    }
}
