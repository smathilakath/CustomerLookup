<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLookUp
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmbCustomers = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblExternal = New System.Windows.Forms.Label()
        Me.txtExternal = New System.Windows.Forms.TextBox()
        Me.btnGetAuth = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.btnExternalLookup = New System.Windows.Forms.Button()
        Me.txtAuthID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DebugToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewResponseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnPastetoAuth = New System.Windows.Forms.Button()
        Me.btnCopyExternalId = New System.Windows.Forms.Button()
        Me.txtExternalResult = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnCopyAuthID = New System.Windows.Forms.Button()
        Me.btnPastetoExternal = New System.Windows.Forms.Button()
        Me.txtAuthResult = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataSet1 = New System.Data.DataSet()
        Me.btnCopyAuth = New System.Windows.Forms.Button()
        Me.btnAddCustomer = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbCustomers
        '
        Me.cmbCustomers.FormattingEnabled = True
        Me.cmbCustomers.Items.AddRange(New Object() {"Wealth Access-Prod, wealthaccess.365159.cc.prod-intuit.ipp.prod", "LendUp-Preprod, lendup.129461.cc.dev-intuit.ipp.prod", "GuideFinancial-Prod, guidefinancial.78487.cc.prod-intuit.ipp.prod", "GuideFinancial-Dev, guidefinancial.32116.cc.dev-intuit.ipp.prod", "Expense Cloud-Dev, expensecloud.353986.cc.dev-intuit.ipp.prod", "Expense Cloud Dev-Prod, app7.ExpenseCloud-dev.prod-intuit.ipp.prod", "Expense Cloud-Prod, app7.ExpenseCloud-prod.prod-intuit.ipp.prod", "Wallaby-Prod, wallaby_prod.10736.cc.prod-intuit.ipp.prod", "Tallie-Preprod, tallie.112385.cc.dev-intuit.ipp.prod", "Aplos-Prod, aploscadapi.108539.cc.prod-intuit.ipp.prod", "CheqBook-Prod, cheqbook.359.cc.prod-intuit.ipp.prod", "GuardVest-Prod, guardvest.85431.cc.prod-intuit.ipp.prod", "Tallie-Prod,  tallie.253544.cc.prod-intuit.ipp.prod", "Acorns, acorns.120988.cc.prod-intuit.ipp.prod", "InDinero, inDinero-dev.prod-intuit.ipp.prod", "Wela-Prod, wela_customer_agg_with_batch.364433.cc.prod-intuit.ipp.prod", "SoftPro, softproautoproclear.346568.cc.prod-intuit.ipp.prod", "Nexonia, nexoniacreditcards.217758.cc.prod-intuit.ipp.prod"})
        Me.cmbCustomers.Location = New System.Drawing.Point(111, 48)
        Me.cmbCustomers.Name = "cmbCustomers"
        Me.cmbCustomers.Size = New System.Drawing.Size(403, 21)
        Me.cmbCustomers.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Select Customer:"
        '
        'lblExternal
        '
        Me.lblExternal.AutoSize = True
        Me.lblExternal.Location = New System.Drawing.Point(14, 33)
        Me.lblExternal.Name = "lblExternal"
        Me.lblExternal.Size = New System.Drawing.Size(65, 13)
        Me.lblExternal.TabIndex = 2
        Me.lblExternal.Text = "External_ID:"
        '
        'txtExternal
        '
        Me.txtExternal.Location = New System.Drawing.Point(85, 30)
        Me.txtExternal.Name = "txtExternal"
        Me.txtExternal.Size = New System.Drawing.Size(384, 20)
        Me.txtExternal.TabIndex = 3
        '
        'btnGetAuth
        '
        Me.btnGetAuth.Location = New System.Drawing.Point(85, 56)
        Me.btnGetAuth.Name = "btnGetAuth"
        Me.btnGetAuth.Size = New System.Drawing.Size(498, 41)
        Me.btnGetAuth.TabIndex = 4
        Me.btnGetAuth.Text = "Get AuthID"
        Me.btnGetAuth.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(21, 494)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(609, 126)
        Me.RichTextBox1.TabIndex = 5
        Me.RichTextBox1.Text = ""
        Me.RichTextBox1.Visible = False
        '
        'btnExternalLookup
        '
        Me.btnExternalLookup.Location = New System.Drawing.Point(81, 58)
        Me.btnExternalLookup.Name = "btnExternalLookup"
        Me.btnExternalLookup.Size = New System.Drawing.Size(502, 38)
        Me.btnExternalLookup.TabIndex = 8
        Me.btnExternalLookup.Text = "Get External ID"
        Me.btnExternalLookup.UseVisualStyleBackColor = True
        '
        'txtAuthID
        '
        Me.txtAuthID.Location = New System.Drawing.Point(81, 32)
        Me.txtAuthID.Name = "txtAuthID"
        Me.txtAuthID.Size = New System.Drawing.Size(388, 20)
        Me.txtAuthID.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Auth_ID:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.DebugToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(643, 24)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'DebugToolStripMenuItem
        '
        Me.DebugToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewResponseToolStripMenuItem})
        Me.DebugToolStripMenuItem.Name = "DebugToolStripMenuItem"
        Me.DebugToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.DebugToolStripMenuItem.Text = "Debug"
        '
        'ViewResponseToolStripMenuItem
        '
        Me.ViewResponseToolStripMenuItem.Name = "ViewResponseToolStripMenuItem"
        Me.ViewResponseToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.ViewResponseToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.ViewResponseToolStripMenuItem.Text = "View Response"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnPastetoAuth)
        Me.GroupBox1.Controls.Add(Me.btnCopyExternalId)
        Me.GroupBox1.Controls.Add(Me.txtExternalResult)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtAuthID)
        Me.GroupBox1.Controls.Add(Me.btnExternalLookup)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 257)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(618, 176)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Get External ID"
        '
        'btnPastetoAuth
        '
        Me.btnPastetoAuth.Location = New System.Drawing.Point(475, 29)
        Me.btnPastetoAuth.Name = "btnPastetoAuth"
        Me.btnPastetoAuth.Size = New System.Drawing.Size(120, 23)
        Me.btnPastetoAuth.TabIndex = 18
        Me.btnPastetoAuth.Text = "Paste From Clipboard"
        Me.btnPastetoAuth.UseVisualStyleBackColor = True
        '
        'btnCopyExternalId
        '
        Me.btnCopyExternalId.Location = New System.Drawing.Point(475, 115)
        Me.btnCopyExternalId.Name = "btnCopyExternalId"
        Me.btnCopyExternalId.Size = New System.Drawing.Size(108, 23)
        Me.btnCopyExternalId.TabIndex = 17
        Me.btnCopyExternalId.Text = "Copy to Clipboard"
        Me.btnCopyExternalId.UseVisualStyleBackColor = True
        '
        'txtExternalResult
        '
        Me.txtExternalResult.Location = New System.Drawing.Point(81, 117)
        Me.txtExternalResult.Name = "txtExternalResult"
        Me.txtExternalResult.ReadOnly = True
        Me.txtExternalResult.Size = New System.Drawing.Size(388, 20)
        Me.txtExternalResult.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "External_ID:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnCopyAuthID)
        Me.GroupBox2.Controls.Add(Me.btnPastetoExternal)
        Me.GroupBox2.Controls.Add(Me.txtAuthResult)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtExternal)
        Me.GroupBox2.Controls.Add(Me.lblExternal)
        Me.GroupBox2.Controls.Add(Me.btnGetAuth)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 75)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(618, 176)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Get Auth ID"
        '
        'btnCopyAuthID
        '
        Me.btnCopyAuthID.Location = New System.Drawing.Point(475, 113)
        Me.btnCopyAuthID.Name = "btnCopyAuthID"
        Me.btnCopyAuthID.Size = New System.Drawing.Size(108, 23)
        Me.btnCopyAuthID.TabIndex = 16
        Me.btnCopyAuthID.Text = "Copy to Clipboard"
        Me.btnCopyAuthID.UseVisualStyleBackColor = True
        '
        'btnPastetoExternal
        '
        Me.btnPastetoExternal.Location = New System.Drawing.Point(475, 28)
        Me.btnPastetoExternal.Name = "btnPastetoExternal"
        Me.btnPastetoExternal.Size = New System.Drawing.Size(120, 23)
        Me.btnPastetoExternal.TabIndex = 17
        Me.btnPastetoExternal.Text = "Paste From Clipboard"
        Me.btnPastetoExternal.UseVisualStyleBackColor = True
        '
        'txtAuthResult
        '
        Me.txtAuthResult.Location = New System.Drawing.Point(85, 116)
        Me.txtAuthResult.Name = "txtAuthResult"
        Me.txtAuthResult.ReadOnly = True
        Me.txtAuthResult.Size = New System.Drawing.Size(384, 20)
        Me.txtAuthResult.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(30, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Auth_ID:"
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        '
        'btnCopyAuth
        '
        Me.btnCopyAuth.Location = New System.Drawing.Point(93, 439)
        Me.btnCopyAuth.Name = "btnCopyAuth"
        Me.btnCopyAuth.Size = New System.Drawing.Size(502, 40)
        Me.btnCopyAuth.TabIndex = 14
        Me.btnCopyAuth.Text = "Clear All"
        Me.btnCopyAuth.UseVisualStyleBackColor = True
        '
        'btnAddCustomer
        '
        Me.btnAddCustomer.Location = New System.Drawing.Point(520, 46)
        Me.btnAddCustomer.Name = "btnAddCustomer"
        Me.btnAddCustomer.Size = New System.Drawing.Size(75, 23)
        Me.btnAddCustomer.TabIndex = 15
        Me.btnAddCustomer.Text = "Add"
        Me.btnAddCustomer.UseVisualStyleBackColor = True
        '
        'frmLookUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(643, 666)
        Me.Controls.Add(Me.btnAddCustomer)
        Me.Controls.Add(Me.btnCopyAuth)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbCustomers)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmLookUp"
        Me.Text = "Customer LookUp"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbCustomers As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblExternal As System.Windows.Forms.Label
    Friend WithEvents txtExternal As System.Windows.Forms.TextBox
    Friend WithEvents btnGetAuth As System.Windows.Forms.Button
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents btnExternalLookup As System.Windows.Forms.Button
    Friend WithEvents txtAuthID As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DebugToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewResponseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents txtExternalResult As System.Windows.Forms.TextBox
    Friend WithEvents txtAuthResult As System.Windows.Forms.TextBox
    Friend WithEvents btnCopyAuth As System.Windows.Forms.Button
    Friend WithEvents btnAddCustomer As System.Windows.Forms.Button
    Friend WithEvents btnCopyAuthID As System.Windows.Forms.Button
    Friend WithEvents btnCopyExternalId As System.Windows.Forms.Button
    Friend WithEvents btnPastetoExternal As System.Windows.Forms.Button
    Friend WithEvents btnPastetoAuth As System.Windows.Forms.Button

End Class
