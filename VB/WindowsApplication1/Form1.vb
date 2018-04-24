Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraTreeList.Nodes
Imports DevExpress.XtraTreeList

Namespace WindowsApplication1
    Partial Public Class Form1
        Inherits Form

        Private Function CreateTable(ByVal RowCount As Integer) As DataTable
            Dim tbl As New DataTable()
            tbl.Columns.Add("Name", GetType(String))
            tbl.Columns.Add("ID", GetType(Integer))
            tbl.Columns.Add("Number", GetType(Integer))
            tbl.Columns.Add("Date", GetType(Date))
            tbl.Columns.Add("ParentID", GetType(Integer))
            For i As Integer = 0 To RowCount - 1
                tbl.Rows.Add(New Object() { String.Format("Name{0}", i), i + 1, 3 - i, Date.Now.AddDays(i), i Mod 3 })
            Next i
            Return tbl
        End Function

        Private helper As MyTreeListSearchHelper

        Public Sub New()
            InitializeComponent()
            treeList1.DataSource = CreateTable(300)
            helper = New MyTreeListSearchHelper(treeList1)
            helper.FieldName = "Name"
            helper.Text = buttonEdit1.Text
        End Sub

        Private Sub buttonEdit1_Properties_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles buttonEdit1.Properties.ButtonClick
            PerformSearch(e.Button.Index = 1)
        End Sub
        Private Sub PerformSearch(ByVal forward As Boolean)
            helper.PerformSearch(forward)
           treeList1.FocusedNode = helper.CurrentNode
        End Sub

        Private Sub buttonEdit1_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles buttonEdit1.EditValueChanged
            helper.Text = buttonEdit1.Text
        End Sub
    End Class
End Namespace