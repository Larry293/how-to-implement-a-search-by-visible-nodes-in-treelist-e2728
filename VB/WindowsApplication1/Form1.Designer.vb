Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication1
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim serializableAppearanceObject1 As New DevExpress.Utils.SerializableAppearanceObject()
			Dim serializableAppearanceObject2 As New DevExpress.Utils.SerializableAppearanceObject()
			Me.treeList1 = New DevExpress.XtraTreeList.TreeList()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.buttonEdit1 = New DevExpress.XtraEditors.ButtonEdit()
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			CType(Me.buttonEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' treeList1
			' 
			Me.treeList1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.treeList1.Location = New System.Drawing.Point(0, 43)
			Me.treeList1.Name = "treeList1"
			Me.treeList1.Size = New System.Drawing.Size(572, 439)
			Me.treeList1.TabIndex = 0
			' 
			' panelControl1
			' 
			Me.panelControl1.Controls.Add(Me.buttonEdit1)
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelControl1.Location = New System.Drawing.Point(0, 0)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Padding = New System.Windows.Forms.Padding(10)
			Me.panelControl1.Size = New System.Drawing.Size(572, 43)
			Me.panelControl1.TabIndex = 1
			' 
			' buttonEdit1
			' 
			Me.buttonEdit1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.buttonEdit1.EditValue = "ame1"
			Me.buttonEdit1.Location = New System.Drawing.Point(12, 12)
			Me.buttonEdit1.Name = "buttonEdit1"
			Me.buttonEdit1.Properties.AutoHeight = False
			Me.buttonEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Left, "Prev", -1, True, True, True, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", Nothing, Nothing, True), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Right, "Next", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", Nothing, Nothing, True)})
'			Me.buttonEdit1.Properties.ButtonClick += New DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(Me.buttonEdit1_Properties_ButtonClick);
			Me.buttonEdit1.Size = New System.Drawing.Size(548, 19)
			Me.buttonEdit1.TabIndex = 0
'			Me.buttonEdit1.EditValueChanged += New System.EventHandler(Me.buttonEdit1_EditValueChanged);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(572, 482)
			Me.Controls.Add(Me.treeList1)
			Me.Controls.Add(Me.panelControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			CType(Me.buttonEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private treeList1 As DevExpress.XtraTreeList.TreeList
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private WithEvents buttonEdit1 As DevExpress.XtraEditors.ButtonEdit
	End Class
End Namespace

