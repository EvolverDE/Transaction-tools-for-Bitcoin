<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Bt_RemoveSignKey = New System.Windows.Forms.Button()
        Me.Bt_TXShowCheckedSecrets = New System.Windows.Forms.Button()
        Me.LV_SignKeyPairs = New System.Windows.Forms.ListView()
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Bt_showChainSwapKey = New System.Windows.Forms.Button()
        Me.TB_ChainSwapKey = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Bt_addToSignKeys = New System.Windows.Forms.Button()
        Me.ChBx_Testnet = New System.Windows.Forms.CheckBox()
        Me.Bt_convertToRipe160 = New System.Windows.Forms.Button()
        Me.Bt_convertToAddress = New System.Windows.Forms.Button()
        Me.TB_Address = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TB_RIPE160 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Bt_showPrivateKey = New System.Windows.Forms.Button()
        Me.TB_PrivateKey = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Bt_convertToRIPE160Address = New System.Windows.Forms.Button()
        Me.TB_CompPubKey = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Bt_generateFull = New System.Windows.Forms.Button()
        Me.Bt_showMnemonic = New System.Windows.Forms.Button()
        Me.TB_Mnemonic = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Bt_generate = New System.Windows.Forms.Button()
        Me.NUDLength = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RB_RandomChars = New System.Windows.Forms.RadioButton()
        Me.RB_Words = New System.Windows.Forms.RadioButton()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TB_UnlockingScript = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.LV_UnlockScripts = New System.Windows.Forms.ListView()
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LV_UnlockScript = New System.Windows.Forms.ListView()
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Bt_AddToUnlockScripts = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.LV_Transaction = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LV_Script = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Bt_TXsignTransaction = New System.Windows.Forms.Button()
        Me.Bt_TXconvertUTX = New System.Windows.Forms.Button()
        Me.TB_TXSignedTransactionBytes = New System.Windows.Forms.TextBox()
        Me.TB_TXUnsignedTransactionBytes = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NUDLength, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(714, 461)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(706, 435)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Addresses"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Bt_RemoveSignKey)
        Me.GroupBox2.Controls.Add(Me.Bt_TXShowCheckedSecrets)
        Me.GroupBox2.Controls.Add(Me.LV_SignKeyPairs)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 243)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(690, 184)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Sign Keys"
        '
        'Bt_RemoveSignKey
        '
        Me.Bt_RemoveSignKey.Location = New System.Drawing.Point(562, 46)
        Me.Bt_RemoveSignKey.Name = "Bt_RemoveSignKey"
        Me.Bt_RemoveSignKey.Size = New System.Drawing.Size(122, 22)
        Me.Bt_RemoveSignKey.TabIndex = 37
        Me.Bt_RemoveSignKey.Text = "remove checked"
        Me.Bt_RemoveSignKey.UseVisualStyleBackColor = True
        '
        'Bt_TXShowCheckedSecrets
        '
        Me.Bt_TXShowCheckedSecrets.Location = New System.Drawing.Point(562, 18)
        Me.Bt_TXShowCheckedSecrets.Name = "Bt_TXShowCheckedSecrets"
        Me.Bt_TXShowCheckedSecrets.Size = New System.Drawing.Size(122, 22)
        Me.Bt_TXShowCheckedSecrets.TabIndex = 36
        Me.Bt_TXShowCheckedSecrets.Text = "show checked secrets"
        Me.Bt_TXShowCheckedSecrets.UseVisualStyleBackColor = True
        '
        'LV_SignKeyPairs
        '
        Me.LV_SignKeyPairs.CheckBoxes = True
        Me.LV_SignKeyPairs.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader11})
        Me.LV_SignKeyPairs.FullRowSelect = True
        Me.LV_SignKeyPairs.GridLines = True
        Me.LV_SignKeyPairs.HideSelection = False
        Me.LV_SignKeyPairs.Location = New System.Drawing.Point(6, 19)
        Me.LV_SignKeyPairs.MultiSelect = False
        Me.LV_SignKeyPairs.Name = "LV_SignKeyPairs"
        Me.LV_SignKeyPairs.Size = New System.Drawing.Size(550, 159)
        Me.LV_SignKeyPairs.TabIndex = 34
        Me.LV_SignKeyPairs.UseCompatibleStateImageBehavior = False
        Me.LV_SignKeyPairs.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Private Key"
        Me.ColumnHeader5.Width = 251
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "ChainSwapKey"
        Me.ColumnHeader6.Width = 241
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Public Key"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Bt_showChainSwapKey)
        Me.GroupBox1.Controls.Add(Me.TB_ChainSwapKey)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Bt_addToSignKeys)
        Me.GroupBox1.Controls.Add(Me.ChBx_Testnet)
        Me.GroupBox1.Controls.Add(Me.Bt_convertToRipe160)
        Me.GroupBox1.Controls.Add(Me.Bt_convertToAddress)
        Me.GroupBox1.Controls.Add(Me.TB_Address)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TB_RIPE160)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Bt_showPrivateKey)
        Me.GroupBox1.Controls.Add(Me.TB_PrivateKey)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Bt_convertToRIPE160Address)
        Me.GroupBox1.Controls.Add(Me.TB_CompPubKey)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Bt_generateFull)
        Me.GroupBox1.Controls.Add(Me.Bt_showMnemonic)
        Me.GroupBox1.Controls.Add(Me.TB_Mnemonic)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Bt_generate)
        Me.GroupBox1.Controls.Add(Me.NUDLength)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.RB_RandomChars)
        Me.GroupBox1.Controls.Add(Me.RB_Words)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(690, 231)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Address Section"
        '
        'Bt_showChainSwapKey
        '
        Me.Bt_showChainSwapKey.Location = New System.Drawing.Point(502, 202)
        Me.Bt_showChainSwapKey.Name = "Bt_showChainSwapKey"
        Me.Bt_showChainSwapKey.Size = New System.Drawing.Size(40, 22)
        Me.Bt_showChainSwapKey.TabIndex = 26
        Me.Bt_showChainSwapKey.Text = "show"
        Me.Bt_showChainSwapKey.UseVisualStyleBackColor = True
        '
        'TB_ChainSwapKey
        '
        Me.TB_ChainSwapKey.Location = New System.Drawing.Point(142, 203)
        Me.TB_ChainSwapKey.Name = "TB_ChainSwapKey"
        Me.TB_ChainSwapKey.Size = New System.Drawing.Size(354, 20)
        Me.TB_ChainSwapKey.TabIndex = 25
        Me.TB_ChainSwapKey.UseSystemPasswordChar = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 205)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(130, 13)
        Me.Label15.TabIndex = 24
        Me.Label15.Text = "ChainSwapKey (Optional):"
        '
        'Bt_addToSignKeys
        '
        Me.Bt_addToSignKeys.Location = New System.Drawing.Point(548, 202)
        Me.Bt_addToSignKeys.Name = "Bt_addToSignKeys"
        Me.Bt_addToSignKeys.Size = New System.Drawing.Size(135, 22)
        Me.Bt_addToSignKeys.TabIndex = 23
        Me.Bt_addToSignKeys.Text = "add to Sign Keys"
        Me.Bt_addToSignKeys.UseVisualStyleBackColor = True
        '
        'ChBx_Testnet
        '
        Me.ChBx_Testnet.AutoSize = True
        Me.ChBx_Testnet.Location = New System.Drawing.Point(61, 179)
        Me.ChBx_Testnet.Name = "ChBx_Testnet"
        Me.ChBx_Testnet.Size = New System.Drawing.Size(58, 17)
        Me.ChBx_Testnet.TabIndex = 22
        Me.ChBx_Testnet.Text = "testnet"
        Me.ChBx_Testnet.UseVisualStyleBackColor = True
        '
        'Bt_convertToRipe160
        '
        Me.Bt_convertToRipe160.Location = New System.Drawing.Point(548, 176)
        Me.Bt_convertToRipe160.Name = "Bt_convertToRipe160"
        Me.Bt_convertToRipe160.Size = New System.Drawing.Size(135, 22)
        Me.Bt_convertToRipe160.TabIndex = 21
        Me.Bt_convertToRipe160.Text = "convert to RIPE160"
        Me.Bt_convertToRipe160.UseVisualStyleBackColor = True
        '
        'Bt_convertToAddress
        '
        Me.Bt_convertToAddress.Location = New System.Drawing.Point(548, 150)
        Me.Bt_convertToAddress.Name = "Bt_convertToAddress"
        Me.Bt_convertToAddress.Size = New System.Drawing.Size(135, 22)
        Me.Bt_convertToAddress.TabIndex = 20
        Me.Bt_convertToAddress.Text = "convert to Address"
        Me.Bt_convertToAddress.UseVisualStyleBackColor = True
        '
        'TB_Address
        '
        Me.TB_Address.Location = New System.Drawing.Point(142, 177)
        Me.TB_Address.Name = "TB_Address"
        Me.TB_Address.Size = New System.Drawing.Size(400, 20)
        Me.TB_Address.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 180)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Address:"
        '
        'TB_RIPE160
        '
        Me.TB_RIPE160.Location = New System.Drawing.Point(142, 151)
        Me.TB_RIPE160.Name = "TB_RIPE160"
        Me.TB_RIPE160.Size = New System.Drawing.Size(400, 20)
        Me.TB_RIPE160.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 154)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "RIPE160:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(549, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "( for signing Transactions)"
        '
        'Bt_showPrivateKey
        '
        Me.Bt_showPrivateKey.Location = New System.Drawing.Point(502, 97)
        Me.Bt_showPrivateKey.Name = "Bt_showPrivateKey"
        Me.Bt_showPrivateKey.Size = New System.Drawing.Size(40, 22)
        Me.Bt_showPrivateKey.TabIndex = 14
        Me.Bt_showPrivateKey.Text = "show"
        Me.Bt_showPrivateKey.UseVisualStyleBackColor = True
        '
        'TB_PrivateKey
        '
        Me.TB_PrivateKey.Location = New System.Drawing.Point(142, 98)
        Me.TB_PrivateKey.Name = "TB_PrivateKey"
        Me.TB_PrivateKey.ReadOnly = True
        Me.TB_PrivateKey.Size = New System.Drawing.Size(354, 20)
        Me.TB_PrivateKey.TabIndex = 13
        Me.TB_PrivateKey.UseSystemPasswordChar = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Private Key (Hex):"
        '
        'Bt_convertToRIPE160Address
        '
        Me.Bt_convertToRIPE160Address.Location = New System.Drawing.Point(549, 124)
        Me.Bt_convertToRIPE160Address.Name = "Bt_convertToRIPE160Address"
        Me.Bt_convertToRIPE160Address.Size = New System.Drawing.Size(135, 22)
        Me.Bt_convertToRIPE160Address.TabIndex = 11
        Me.Bt_convertToRIPE160Address.Text = "to RIPE160 / Address"
        Me.Bt_convertToRIPE160Address.UseVisualStyleBackColor = True
        '
        'TB_CompPubKey
        '
        Me.TB_CompPubKey.Location = New System.Drawing.Point(142, 125)
        Me.TB_CompPubKey.Name = "TB_CompPubKey"
        Me.TB_CompPubKey.Size = New System.Drawing.Size(400, 20)
        Me.TB_CompPubKey.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Compressed Public Key:"
        '
        'Bt_generateFull
        '
        Me.Bt_generateFull.Location = New System.Drawing.Point(548, 71)
        Me.Bt_generateFull.Name = "Bt_generateFull"
        Me.Bt_generateFull.Size = New System.Drawing.Size(136, 22)
        Me.Bt_generateFull.TabIndex = 8
        Me.Bt_generateFull.Text = "generate Keys / Address"
        Me.Bt_generateFull.UseVisualStyleBackColor = True
        '
        'Bt_showMnemonic
        '
        Me.Bt_showMnemonic.Location = New System.Drawing.Point(502, 71)
        Me.Bt_showMnemonic.Name = "Bt_showMnemonic"
        Me.Bt_showMnemonic.Size = New System.Drawing.Size(40, 22)
        Me.Bt_showMnemonic.TabIndex = 7
        Me.Bt_showMnemonic.Text = "show"
        Me.Bt_showMnemonic.UseVisualStyleBackColor = True
        '
        'TB_Mnemonic
        '
        Me.TB_Mnemonic.Location = New System.Drawing.Point(142, 72)
        Me.TB_Mnemonic.Name = "TB_Mnemonic"
        Me.TB_Mnemonic.Size = New System.Drawing.Size(354, 20)
        Me.TB_Mnemonic.TabIndex = 6
        Me.TB_Mnemonic.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Mnemonic:"
        '
        'Bt_generate
        '
        Me.Bt_generate.Location = New System.Drawing.Point(189, 46)
        Me.Bt_generate.Name = "Bt_generate"
        Me.Bt_generate.Size = New System.Drawing.Size(63, 22)
        Me.Bt_generate.TabIndex = 4
        Me.Bt_generate.Text = "generate"
        Me.Bt_generate.UseVisualStyleBackColor = True
        '
        'NUDLength
        '
        Me.NUDLength.Location = New System.Drawing.Point(142, 47)
        Me.NUDLength.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NUDLength.Name = "NUDLength"
        Me.NUDLength.Size = New System.Drawing.Size(41, 20)
        Me.NUDLength.TabIndex = 3
        Me.NUDLength.Value = New Decimal(New Integer() {24, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Length:"
        '
        'RB_RandomChars
        '
        Me.RB_RandomChars.AutoSize = True
        Me.RB_RandomChars.Location = New System.Drawing.Point(68, 19)
        Me.RB_RandomChars.Name = "RB_RandomChars"
        Me.RB_RandomChars.Size = New System.Drawing.Size(95, 17)
        Me.RB_RandomChars.TabIndex = 1
        Me.RB_RandomChars.Text = "Random Chars"
        Me.RB_RandomChars.UseVisualStyleBackColor = True
        '
        'RB_Words
        '
        Me.RB_Words.AutoSize = True
        Me.RB_Words.Checked = True
        Me.RB_Words.Location = New System.Drawing.Point(6, 19)
        Me.RB_Words.Name = "RB_Words"
        Me.RB_Words.Size = New System.Drawing.Size(56, 17)
        Me.RB_Words.TabIndex = 0
        Me.RB_Words.TabStop = True
        Me.RB_Words.Text = "Words"
        Me.RB_Words.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Controls.Add(Me.Bt_TXsignTransaction)
        Me.TabPage2.Controls.Add(Me.Bt_TXconvertUTX)
        Me.TabPage2.Controls.Add(Me.TB_TXSignedTransactionBytes)
        Me.TabPage2.Controls.Add(Me.TB_TXUnsignedTransactionBytes)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(706, 435)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Transactions"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.TB_UnlockingScript)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.LV_UnlockScripts)
        Me.GroupBox4.Controls.Add(Me.LV_UnlockScript)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Bt_AddToUnlockScripts)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 202)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(692, 197)
        Me.GroupBox4.TabIndex = 39
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Unlocking Scripts"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(141, 13)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Script need for P2SH inputs:"
        '
        'TB_UnlockingScript
        '
        Me.TB_UnlockingScript.Location = New System.Drawing.Point(153, 13)
        Me.TB_UnlockingScript.Name = "TB_UnlockingScript"
        Me.TB_UnlockingScript.Size = New System.Drawing.Size(429, 20)
        Me.TB_UnlockingScript.TabIndex = 32
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(356, 36)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(37, 13)
        Me.Label14.TabIndex = 37
        Me.Label14.Text = "Script:"
        '
        'LV_UnlockScripts
        '
        Me.LV_UnlockScripts.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader7, Me.ColumnHeader8})
        Me.LV_UnlockScripts.FullRowSelect = True
        Me.LV_UnlockScripts.GridLines = True
        Me.LV_UnlockScripts.HideSelection = False
        Me.LV_UnlockScripts.Location = New System.Drawing.Point(9, 52)
        Me.LV_UnlockScripts.MultiSelect = False
        Me.LV_UnlockScripts.Name = "LV_UnlockScripts"
        Me.LV_UnlockScripts.Size = New System.Drawing.Size(344, 139)
        Me.LV_UnlockScripts.TabIndex = 33
        Me.LV_UnlockScripts.UseCompatibleStateImageBehavior = False
        Me.LV_UnlockScripts.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Unlocking Script"
        Me.ColumnHeader7.Width = 171
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "ScriptHash"
        Me.ColumnHeader8.Width = 168
        '
        'LV_UnlockScript
        '
        Me.LV_UnlockScript.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader9, Me.ColumnHeader10})
        Me.LV_UnlockScript.FullRowSelect = True
        Me.LV_UnlockScript.GridLines = True
        Me.LV_UnlockScript.HideSelection = False
        Me.LV_UnlockScript.Location = New System.Drawing.Point(359, 52)
        Me.LV_UnlockScript.Name = "LV_UnlockScript"
        Me.LV_UnlockScript.Size = New System.Drawing.Size(326, 139)
        Me.LV_UnlockScript.TabIndex = 36
        Me.LV_UnlockScript.UseCompatibleStateImageBehavior = False
        Me.LV_UnlockScript.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Attribute"
        Me.ColumnHeader9.Width = 101
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Value"
        Me.ColumnHeader10.Width = 138
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 36)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Scripts:"
        '
        'Bt_AddToUnlockScripts
        '
        Me.Bt_AddToUnlockScripts.Location = New System.Drawing.Point(589, 12)
        Me.Bt_AddToUnlockScripts.Name = "Bt_AddToUnlockScripts"
        Me.Bt_AddToUnlockScripts.Size = New System.Drawing.Size(96, 22)
        Me.Bt_AddToUnlockScripts.TabIndex = 35
        Me.Bt_AddToUnlockScripts.Text = "add to scripts"
        Me.Bt_AddToUnlockScripts.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.LV_Transaction)
        Me.GroupBox3.Controls.Add(Me.LV_Script)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 32)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(692, 164)
        Me.GroupBox3.TabIndex = 38
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Transaction"
        '
        'LV_Transaction
        '
        Me.LV_Transaction.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.LV_Transaction.FullRowSelect = True
        Me.LV_Transaction.GridLines = True
        Me.LV_Transaction.HideSelection = False
        Me.LV_Transaction.Location = New System.Drawing.Point(5, 32)
        Me.LV_Transaction.Name = "LV_Transaction"
        Me.LV_Transaction.Size = New System.Drawing.Size(348, 126)
        Me.LV_Transaction.TabIndex = 23
        Me.LV_Transaction.UseCompatibleStateImageBehavior = False
        Me.LV_Transaction.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Attribute"
        Me.ColumnHeader1.Width = 101
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Value"
        Me.ColumnHeader2.Width = 138
        '
        'LV_Script
        '
        Me.LV_Script.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4})
        Me.LV_Script.FullRowSelect = True
        Me.LV_Script.GridLines = True
        Me.LV_Script.HideSelection = False
        Me.LV_Script.Location = New System.Drawing.Point(359, 32)
        Me.LV_Script.Name = "LV_Script"
        Me.LV_Script.Size = New System.Drawing.Size(326, 126)
        Me.LV_Script.TabIndex = 24
        Me.LV_Script.UseCompatibleStateImageBehavior = False
        Me.LV_Script.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Attribute"
        Me.ColumnHeader3.Width = 101
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Value"
        Me.ColumnHeader4.Width = 138
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(2, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(100, 13)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Inputs and Outputs:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(356, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(37, 13)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Script:"
        '
        'Bt_TXsignTransaction
        '
        Me.Bt_TXsignTransaction.Enabled = False
        Me.Bt_TXsignTransaction.Location = New System.Drawing.Point(592, 405)
        Me.Bt_TXsignTransaction.Name = "Bt_TXsignTransaction"
        Me.Bt_TXsignTransaction.Size = New System.Drawing.Size(106, 22)
        Me.Bt_TXsignTransaction.TabIndex = 28
        Me.Bt_TXsignTransaction.Text = "sign Transaction"
        Me.Bt_TXsignTransaction.UseVisualStyleBackColor = True
        '
        'Bt_TXconvertUTX
        '
        Me.Bt_TXconvertUTX.Location = New System.Drawing.Point(591, 5)
        Me.Bt_TXconvertUTX.Name = "Bt_TXconvertUTX"
        Me.Bt_TXconvertUTX.Size = New System.Drawing.Size(107, 22)
        Me.Bt_TXconvertUTX.TabIndex = 27
        Me.Bt_TXconvertUTX.Text = "convert"
        Me.Bt_TXconvertUTX.UseVisualStyleBackColor = True
        '
        'TB_TXSignedTransactionBytes
        '
        Me.TB_TXSignedTransactionBytes.Location = New System.Drawing.Point(159, 406)
        Me.TB_TXSignedTransactionBytes.Name = "TB_TXSignedTransactionBytes"
        Me.TB_TXSignedTransactionBytes.ReadOnly = True
        Me.TB_TXSignedTransactionBytes.Size = New System.Drawing.Size(427, 20)
        Me.TB_TXSignedTransactionBytes.TabIndex = 22
        '
        'TB_TXUnsignedTransactionBytes
        '
        Me.TB_TXUnsignedTransactionBytes.Location = New System.Drawing.Point(159, 6)
        Me.TB_TXUnsignedTransactionBytes.Name = "TB_TXUnsignedTransactionBytes"
        Me.TB_TXUnsignedTransactionBytes.Size = New System.Drawing.Size(425, 20)
        Me.TB_TXUnsignedTransactionBytes.TabIndex = 21
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Enabled = False
        Me.Label11.Location = New System.Drawing.Point(10, 409)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(128, 13)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Signed TransactionBytes:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(8, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(140, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Unsigned TransactionBytes:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(714, 461)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transaction tools for Bitcoin"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NUDLength, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Bt_generate As Button
    Friend WithEvents NUDLength As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents RB_RandomChars As RadioButton
    Friend WithEvents RB_Words As RadioButton
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Bt_generateFull As Button
    Friend WithEvents Bt_showMnemonic As Button
    Friend WithEvents TB_Mnemonic As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TB_CompPubKey As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Bt_convertToRIPE160Address As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Bt_showPrivateKey As Button
    Friend WithEvents TB_PrivateKey As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TB_RIPE160 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TB_Address As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Bt_convertToRipe160 As Button
    Friend WithEvents Bt_convertToAddress As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TB_TXSignedTransactionBytes As TextBox
    Friend WithEvents TB_TXUnsignedTransactionBytes As TextBox
    Friend WithEvents LV_Transaction As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents LV_Script As ListView
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents Bt_TXsignTransaction As Button
    Friend WithEvents Bt_TXconvertUTX As Button
    Friend WithEvents ChBx_Testnet As CheckBox
    Friend WithEvents TB_UnlockingScript As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Bt_addToSignKeys As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Bt_TXShowCheckedSecrets As Button
    Friend WithEvents LV_SignKeyPairs As ListView
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents LV_UnlockScripts As ListView
    Friend WithEvents Label8 As Label
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents Bt_AddToUnlockScripts As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label14 As Label
    Friend WithEvents LV_UnlockScript As ListView
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Bt_RemoveSignKey As Button
    Friend WithEvents TB_ChainSwapKey As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents Bt_showChainSwapKey As Button
End Class
