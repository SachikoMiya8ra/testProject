<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Print_Dialog
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナで必要です。
    'Windows フォーム デザイナを使用して変更できます。  
    'コード エディタを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.ChkPrintToFile = New System.Windows.Forms.CheckBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.ChkSomePages = New System.Windows.Forms.CheckBox
        Me.ChkCurrentPage = New System.Windows.Forms.CheckBox
        Me.ChkSelection = New System.Windows.Forms.CheckBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(45, 31)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(148, 42)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Print"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ChkPrintToFile, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.ChkSomePages, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.ChkCurrentPage, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ChkSelection, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 2)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(44, 105)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(149, 98)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'ChkPrintToFile
        '
        Me.ChkPrintToFile.AutoSize = True
        Me.ChkPrintToFile.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ChkPrintToFile.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChkPrintToFile.Location = New System.Drawing.Point(118, 25)
        Me.ChkPrintToFile.Margin = New System.Windows.Forms.Padding(0)
        Me.ChkPrintToFile.Name = "ChkPrintToFile"
        Me.ChkPrintToFile.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ChkPrintToFile.Size = New System.Drawing.Size(30, 23)
        Me.ChkPrintToFile.TabIndex = 1
        Me.ChkPrintToFile.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(1, 1)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "AllowCurrentPage"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Location = New System.Drawing.Point(1, 73)
        Me.Label5.Margin = New System.Windows.Forms.Padding(0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 24)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "AllowSomePages"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ChkSomePages
        '
        Me.ChkSomePages.AutoSize = True
        Me.ChkSomePages.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ChkSomePages.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChkSomePages.Location = New System.Drawing.Point(118, 73)
        Me.ChkSomePages.Margin = New System.Windows.Forms.Padding(0)
        Me.ChkSomePages.Name = "ChkSomePages"
        Me.ChkSomePages.Size = New System.Drawing.Size(30, 24)
        Me.ChkSomePages.TabIndex = 2
        Me.ChkSomePages.UseVisualStyleBackColor = True
        '
        'ChkCurrentPage
        '
        Me.ChkCurrentPage.AutoSize = True
        Me.ChkCurrentPage.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ChkCurrentPage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChkCurrentPage.Location = New System.Drawing.Point(118, 1)
        Me.ChkCurrentPage.Margin = New System.Windows.Forms.Padding(0)
        Me.ChkCurrentPage.Name = "ChkCurrentPage"
        Me.ChkCurrentPage.Size = New System.Drawing.Size(30, 23)
        Me.ChkCurrentPage.TabIndex = 0
        Me.ChkCurrentPage.UseVisualStyleBackColor = True
        '
        'ChkSelection
        '
        Me.ChkSelection.AutoSize = True
        Me.ChkSelection.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ChkSelection.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChkSelection.Location = New System.Drawing.Point(118, 49)
        Me.ChkSelection.Margin = New System.Windows.Forms.Padding(0)
        Me.ChkSelection.Name = "ChkSelection"
        Me.ChkSelection.Size = New System.Drawing.Size(30, 23)
        Me.ChkSelection.TabIndex = 2
        Me.ChkSelection.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Location = New System.Drawing.Point(1, 25)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 23)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "AllowPrintToFile"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Location = New System.Drawing.Point(1, 49)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 23)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "AllowSelection"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(65, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 12)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Label3"
        '
        'Print_Dialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MintCream
        Me.ClientSize = New System.Drawing.Size(229, 245)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "Print_Dialog"
        Me.Text = "Form1"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ChkPrintToFile As System.Windows.Forms.CheckBox
    Friend WithEvents ChkSomePages As System.Windows.Forms.CheckBox
    Friend WithEvents ChkCurrentPage As System.Windows.Forms.CheckBox
    Friend WithEvents ChkSelection As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
