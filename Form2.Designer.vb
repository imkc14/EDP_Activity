<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form2))
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Panel1 = New Panel()
        PictureBox7 = New PictureBox()
        PictureBox5 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox2 = New PictureBox()
        logout_tab = New Button()
        officials_tab = New Button()
        Panel2 = New Panel()
        PictureBox12 = New PictureBox()
        purok_tab = New Button()
        residents_tab = New Button()
        dashboard_tab = New Button()
        Panel3 = New Panel()
        PictureBox8 = New PictureBox()
        total_population = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        refresh_dashboard = New Button()
        Panel7 = New Panel()
        PictureBox13 = New PictureBox()
        total_male = New TextBox()
        Label11 = New Label()
        Panel8 = New Panel()
        PictureBox14 = New PictureBox()
        total_female = New TextBox()
        Label12 = New Label()
        Panel9 = New Panel()
        PictureBox15 = New PictureBox()
        total_voters = New TextBox()
        Label13 = New Label()
        Label5 = New Label()
        dgPurok = New DataGridView()
        purokNum = New DataGridViewTextBoxColumn()
        totalPopulation = New DataGridViewTextBoxColumn()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label6 = New Label()
        TabPage2 = New TabPage()
        TextBox10 = New TextBox()
        PictureBox10 = New PictureBox()
        TextBox8 = New TextBox()
        PictureBox9 = New PictureBox()
        Label2 = New Label()
        DateTime = New Label()
        Panel4 = New Panel()
        backupBtn = New Button()
        Label7 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox12, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        Panel7.SuspendLayout()
        CType(PictureBox13, ComponentModel.ISupportInitialize).BeginInit()
        Panel8.SuspendLayout()
        CType(PictureBox14, ComponentModel.ISupportInitialize).BeginInit()
        Panel9.SuspendLayout()
        CType(PictureBox15, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgPurok, ComponentModel.ISupportInitialize).BeginInit()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        CType(PictureBox10, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox9, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(45, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(284, 19)
        Label1.TabIndex = 1
        Label1.Text = "BARANGAY INFORMATION SYSTEM"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.brgy_logo1
        PictureBox1.Location = New Point(26, 73)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(283, 272)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(26), CByte(36), CByte(80))
        Panel1.Controls.Add(PictureBox7)
        Panel1.Controls.Add(PictureBox5)
        Panel1.Controls.Add(PictureBox4)
        Panel1.Controls.Add(PictureBox3)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(logout_tab)
        Panel1.Controls.Add(officials_tab)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(purok_tab)
        Panel1.Controls.Add(residents_tab)
        Panel1.Controls.Add(dashboard_tab)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(-1, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(338, 751)
        Panel1.TabIndex = 8
        ' 
        ' PictureBox7
        ' 
        PictureBox7.Image = My.Resources.Resources.image_removebg_preview__11_
        PictureBox7.Location = New Point(26, 606)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(43, 38)
        PictureBox7.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox7.TabIndex = 21
        PictureBox7.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = My.Resources.Resources.image_removebg_preview__9_
        PictureBox5.Location = New Point(26, 545)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(43, 38)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 19
        PictureBox5.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = My.Resources.Resources.image_removebg_preview__10_
        PictureBox4.Location = New Point(26, 487)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(43, 38)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 18
        PictureBox4.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources._5363451
        PictureBox3.Location = New Point(26, 431)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(43, 38)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 17
        PictureBox3.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources._6292175
        PictureBox2.Location = New Point(26, 374)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(43, 38)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 16
        PictureBox2.TabStop = False
        ' 
        ' logout_tab
        ' 
        logout_tab.BackColor = Color.FromArgb(CByte(26), CByte(36), CByte(80))
        logout_tab.FlatAppearance.BorderSize = 0
        logout_tab.FlatStyle = FlatStyle.Flat
        logout_tab.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        logout_tab.ForeColor = Color.White
        logout_tab.Location = New Point(2, 597)
        logout_tab.Name = "logout_tab"
        logout_tab.Size = New Size(374, 51)
        logout_tab.TabIndex = 15
        logout_tab.Text = "                    Log Out"
        logout_tab.TextAlign = ContentAlignment.MiddleLeft
        logout_tab.UseVisualStyleBackColor = False
        ' 
        ' officials_tab
        ' 
        officials_tab.BackColor = Color.FromArgb(CByte(26), CByte(36), CByte(80))
        officials_tab.FlatAppearance.BorderSize = 0
        officials_tab.FlatStyle = FlatStyle.Flat
        officials_tab.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        officials_tab.ForeColor = Color.White
        officials_tab.Location = New Point(0, 538)
        officials_tab.Name = "officials_tab"
        officials_tab.Size = New Size(374, 51)
        officials_tab.TabIndex = 13
        officials_tab.Text = "                    Barangay Officials"
        officials_tab.TextAlign = ContentAlignment.MiddleLeft
        officials_tab.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Brown
        Panel2.Controls.Add(PictureBox12)
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(1, -1)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(373, 53)
        Panel2.TabIndex = 9
        ' 
        ' PictureBox12
        ' 
        PictureBox12.Image = My.Resources.Resources.image_removebg_preview__19_
        PictureBox12.Location = New Point(5, 11)
        PictureBox12.Name = "PictureBox12"
        PictureBox12.Size = New Size(42, 35)
        PictureBox12.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox12.TabIndex = 16
        PictureBox12.TabStop = False
        ' 
        ' purok_tab
        ' 
        purok_tab.BackColor = Color.FromArgb(CByte(26), CByte(36), CByte(80))
        purok_tab.FlatAppearance.BorderSize = 0
        purok_tab.FlatStyle = FlatStyle.Flat
        purok_tab.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        purok_tab.ForeColor = Color.White
        purok_tab.Location = New Point(0, 481)
        purok_tab.Name = "purok_tab"
        purok_tab.Size = New Size(374, 51)
        purok_tab.TabIndex = 12
        purok_tab.Text = "                    Purok"
        purok_tab.TextAlign = ContentAlignment.MiddleLeft
        purok_tab.UseVisualStyleBackColor = False
        ' 
        ' residents_tab
        ' 
        residents_tab.BackColor = Color.FromArgb(CByte(26), CByte(36), CByte(80))
        residents_tab.FlatAppearance.BorderSize = 0
        residents_tab.FlatStyle = FlatStyle.Flat
        residents_tab.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        residents_tab.ForeColor = Color.White
        residents_tab.Location = New Point(0, 424)
        residents_tab.Name = "residents_tab"
        residents_tab.Size = New Size(374, 51)
        residents_tab.TabIndex = 11
        residents_tab.Text = "                    Residents Record"
        residents_tab.TextAlign = ContentAlignment.MiddleLeft
        residents_tab.UseVisualStyleBackColor = False
        ' 
        ' dashboard_tab
        ' 
        dashboard_tab.BackColor = Color.FromArgb(CByte(26), CByte(36), CByte(80))
        dashboard_tab.FlatAppearance.BorderSize = 0
        dashboard_tab.FlatStyle = FlatStyle.Flat
        dashboard_tab.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        dashboard_tab.ForeColor = Color.White
        dashboard_tab.Location = New Point(0, 369)
        dashboard_tab.Name = "dashboard_tab"
        dashboard_tab.Size = New Size(374, 48)
        dashboard_tab.TabIndex = 10
        dashboard_tab.Text = "                    Dashboard"
        dashboard_tab.TextAlign = ContentAlignment.MiddleLeft
        dashboard_tab.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Brown
        Panel3.Controls.Add(PictureBox8)
        Panel3.Controls.Add(total_population)
        Panel3.Controls.Add(Label4)
        Panel3.Location = New Point(358, 134)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(234, 130)
        Panel3.TabIndex = 10
        ' 
        ' PictureBox8
        ' 
        PictureBox8.Image = My.Resources.Resources.image_removebg_preview__12_
        PictureBox8.Location = New Point(13, 32)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(67, 68)
        PictureBox8.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox8.TabIndex = 15
        PictureBox8.TabStop = False
        ' 
        ' total_population
        ' 
        total_population.BackColor = Color.Brown
        total_population.BorderStyle = BorderStyle.None
        total_population.Font = New Font("Arial", 30F, FontStyle.Bold, GraphicsUnit.Point)
        total_population.ForeColor = Color.White
        total_population.Location = New Point(93, 56)
        total_population.Name = "total_population"
        total_population.ReadOnly = True
        total_population.Size = New Size(56, 46)
        total_population.TabIndex = 14
        total_population.Text = "20"
        total_population.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(93, 35)
        Label4.Name = "Label4"
        Label4.Size = New Size(123, 18)
        Label4.TabIndex = 14
        Label4.Text = "Total Population"
        Label4.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.White
        Label3.Font = New Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(1070, 34)
        Label3.Name = "Label3"
        Label3.Size = New Size(275, 16)
        Label3.TabIndex = 13
        Label3.Text = "DANCALAN, DONSOL, SORSOGON, 4715"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.White
        Label8.Font = New Font("Arial", 13F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(355, 93)
        Label8.Name = "Label8"
        Label8.Size = New Size(236, 21)
        Label8.TabIndex = 17
        Label8.Text = "Residents' Record Summary"
        Label8.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.White
        Label9.Font = New Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.Location = New Point(358, 12)
        Label9.Name = "Label9"
        Label9.Size = New Size(101, 17)
        Label9.TabIndex = 18
        Label9.Text = "DASHBOARD"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.White
        Label10.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.Location = New Point(358, 32)
        Label10.Name = "Label10"
        Label10.Size = New Size(59, 15)
        Label10.TabIndex = 19
        Label10.Text = "TODAY IS"
        ' 
        ' refresh_dashboard
        ' 
        refresh_dashboard.BackColor = Color.FromArgb(CByte(255), CByte(173), CByte(52))
        refresh_dashboard.FlatAppearance.BorderSize = 0
        refresh_dashboard.FlatStyle = FlatStyle.Flat
        refresh_dashboard.Font = New Font("Arial", 8.5F, FontStyle.Regular, GraphicsUnit.Point)
        refresh_dashboard.ForeColor = Color.Black
        refresh_dashboard.Location = New Point(1265, 96)
        refresh_dashboard.Name = "refresh_dashboard"
        refresh_dashboard.Size = New Size(78, 24)
        refresh_dashboard.TabIndex = 20
        refresh_dashboard.Text = "Refresh"
        refresh_dashboard.UseVisualStyleBackColor = False
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.Brown
        Panel7.Controls.Add(PictureBox13)
        Panel7.Controls.Add(total_male)
        Panel7.Controls.Add(Label11)
        Panel7.Location = New Point(607, 133)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(234, 130)
        Panel7.TabIndex = 16
        ' 
        ' PictureBox13
        ' 
        PictureBox13.Image = My.Resources.Resources.image_removebg_preview__13_
        PictureBox13.Location = New Point(13, 32)
        PictureBox13.Name = "PictureBox13"
        PictureBox13.Size = New Size(67, 68)
        PictureBox13.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox13.TabIndex = 15
        PictureBox13.TabStop = False
        ' 
        ' total_male
        ' 
        total_male.BackColor = Color.Brown
        total_male.BorderStyle = BorderStyle.None
        total_male.Font = New Font("Arial", 30F, FontStyle.Bold, GraphicsUnit.Point)
        total_male.ForeColor = Color.White
        total_male.Location = New Point(95, 57)
        total_male.Name = "total_male"
        total_male.ReadOnly = True
        total_male.Size = New Size(56, 46)
        total_male.TabIndex = 14
        total_male.Text = "20"
        total_male.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.Transparent
        Label11.Font = New Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label11.ForeColor = Color.White
        Label11.Location = New Point(95, 36)
        Label11.Name = "Label11"
        Label11.Size = New Size(42, 18)
        Label11.TabIndex = 14
        Label11.Text = "Male"
        Label11.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.Brown
        Panel8.Controls.Add(PictureBox14)
        Panel8.Controls.Add(total_female)
        Panel8.Controls.Add(Label12)
        Panel8.Location = New Point(857, 133)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(234, 130)
        Panel8.TabIndex = 16
        ' 
        ' PictureBox14
        ' 
        PictureBox14.Image = My.Resources.Resources.image_removebg_preview__14_
        PictureBox14.Location = New Point(13, 32)
        PictureBox14.Name = "PictureBox14"
        PictureBox14.Size = New Size(67, 68)
        PictureBox14.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox14.TabIndex = 15
        PictureBox14.TabStop = False
        ' 
        ' total_female
        ' 
        total_female.BackColor = Color.Brown
        total_female.BorderStyle = BorderStyle.None
        total_female.Font = New Font("Arial", 30F, FontStyle.Bold, GraphicsUnit.Point)
        total_female.ForeColor = Color.White
        total_female.Location = New Point(98, 57)
        total_female.Name = "total_female"
        total_female.ReadOnly = True
        total_female.Size = New Size(56, 46)
        total_female.TabIndex = 14
        total_female.Text = "20"
        total_female.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = Color.Transparent
        Label12.Font = New Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label12.ForeColor = Color.White
        Label12.Location = New Point(98, 36)
        Label12.Name = "Label12"
        Label12.Size = New Size(59, 18)
        Label12.TabIndex = 14
        Label12.Text = "Female"
        Label12.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Panel9
        ' 
        Panel9.BackColor = Color.Brown
        Panel9.Controls.Add(PictureBox15)
        Panel9.Controls.Add(total_voters)
        Panel9.Controls.Add(Label13)
        Panel9.Location = New Point(1109, 133)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(234, 130)
        Panel9.TabIndex = 16
        ' 
        ' PictureBox15
        ' 
        PictureBox15.Image = My.Resources.Resources.image_removebg_preview__16_
        PictureBox15.Location = New Point(13, 32)
        PictureBox15.Name = "PictureBox15"
        PictureBox15.Size = New Size(67, 68)
        PictureBox15.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox15.TabIndex = 15
        PictureBox15.TabStop = False
        ' 
        ' total_voters
        ' 
        total_voters.BackColor = Color.Brown
        total_voters.BorderStyle = BorderStyle.None
        total_voters.Font = New Font("Arial", 30F, FontStyle.Bold, GraphicsUnit.Point)
        total_voters.ForeColor = Color.White
        total_voters.Location = New Point(86, 54)
        total_voters.Name = "total_voters"
        total_voters.ReadOnly = True
        total_voters.Size = New Size(56, 46)
        total_voters.TabIndex = 14
        total_voters.Text = "20"
        total_voters.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.BackColor = Color.Transparent
        Label13.Font = New Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label13.ForeColor = Color.White
        Label13.Location = New Point(86, 36)
        Label13.Name = "Label13"
        Label13.Size = New Size(136, 18)
        Label13.TabIndex = 14
        Label13.Text = "Registered Voters"
        Label13.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.White
        Label5.Font = New Font("Arial", 13F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(974, 11)
        Label5.Name = "Label5"
        Label5.Size = New Size(375, 21)
        Label5.TabIndex = 21
        Label5.Text = "SANGGUNIANG BARANGAY NG DANCALAN"
        ' 
        ' dgPurok
        ' 
        dgPurok.BackgroundColor = Color.WhiteSmoke
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = SystemColors.ActiveBorder
        DataGridViewCellStyle1.Font = New Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.HotTrack
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgPurok.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgPurok.ColumnHeadersHeight = 40
        dgPurok.Columns.AddRange(New DataGridViewColumn() {purokNum, totalPopulation})
        dgPurok.Location = New Point(1101, 323)
        dgPurok.Name = "dgPurok"
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.Gainsboro
        DataGridViewCellStyle2.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgPurok.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgPurok.RowTemplate.Height = 25
        dgPurok.Size = New Size(244, 241)
        dgPurok.TabIndex = 22
        ' 
        ' purokNum
        ' 
        purokNum.HeaderText = "Purok"
        purokNum.Name = "purokNum"
        ' 
        ' totalPopulation
        ' 
        totalPopulation.HeaderText = "Total Population"
        totalPopulation.Name = "totalPopulation"
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point)
        TabControl1.Location = New Point(358, 299)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(712, 377)
        TabControl1.TabIndex = 23
        ' 
        ' TabPage1
        ' 
        TabPage1.BackColor = Color.WhiteSmoke
        TabPage1.Controls.Add(TextBox3)
        TabPage1.Controls.Add(TextBox2)
        TabPage1.Controls.Add(TextBox1)
        TabPage1.Controls.Add(Label6)
        TabPage1.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point)
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(704, 349)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Announcements"
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = Color.WhiteSmoke
        TextBox3.BorderStyle = BorderStyle.None
        TextBox3.Location = New Point(46, 220)
        TextBox3.Multiline = True
        TextBox3.Name = "TextBox3"
        TextBox3.ReadOnly = True
        TextBox3.Size = New Size(603, 76)
        TextBox3.TabIndex = 3
        TextBox3.Text = resources.GetString("TextBox3.Text")
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.WhiteSmoke
        TextBox2.BorderStyle = BorderStyle.None
        TextBox2.Location = New Point(49, 142)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.ReadOnly = True
        TextBox2.Size = New Size(603, 76)
        TextBox2.TabIndex = 2
        TextBox2.Text = resources.GetString("TextBox2.Text")
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.WhiteSmoke
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Location = New Point(49, 68)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.Size = New Size(603, 76)
        TextBox1.TabIndex = 1
        TextBox1.Text = resources.GetString("TextBox1.Text")
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Arial", 13F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = Color.Brown
        Label6.Location = New Point(49, 32)
        Label6.Name = "Label6"
        Label6.Size = New Size(251, 21)
        Label6.TabIndex = 0
        Label6.Text = "Lorem ipsum dolor sit amet"
        ' 
        ' TabPage2
        ' 
        TabPage2.BackColor = Color.WhiteSmoke
        TabPage2.Controls.Add(TextBox10)
        TabPage2.Controls.Add(PictureBox10)
        TabPage2.Controls.Add(TextBox8)
        TabPage2.Controls.Add(PictureBox9)
        TabPage2.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point)
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(704, 349)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Events"
        ' 
        ' TextBox10
        ' 
        TextBox10.BackColor = Color.WhiteSmoke
        TextBox10.BorderStyle = BorderStyle.None
        TextBox10.Font = New Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox10.Location = New Point(56, 235)
        TextBox10.Multiline = True
        TextBox10.Name = "TextBox10"
        TextBox10.ReadOnly = True
        TextBox10.Size = New Size(593, 69)
        TextBox10.TabIndex = 4
        TextBox10.Text = resources.GetString("TextBox10.Text")
        ' 
        ' PictureBox10
        ' 
        PictureBox10.Image = CType(resources.GetObject("PictureBox10.Image"), Image)
        PictureBox10.Location = New Point(370, 82)
        PictureBox10.Name = "PictureBox10"
        PictureBox10.Size = New Size(279, 138)
        PictureBox10.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox10.TabIndex = 3
        PictureBox10.TabStop = False
        ' 
        ' TextBox8
        ' 
        TextBox8.BackColor = Color.WhiteSmoke
        TextBox8.BorderStyle = BorderStyle.None
        TextBox8.Font = New Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox8.Location = New Point(56, 42)
        TextBox8.Name = "TextBox8"
        TextBox8.ReadOnly = True
        TextBox8.Size = New Size(220, 22)
        TextBox8.TabIndex = 1
        TextBox8.Text = "BUTANDING FESTIVAL"
        ' 
        ' PictureBox9
        ' 
        PictureBox9.Image = CType(resources.GetObject("PictureBox9.Image"), Image)
        PictureBox9.Location = New Point(56, 82)
        PictureBox9.Name = "PictureBox9"
        PictureBox9.Size = New Size(292, 138)
        PictureBox9.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox9.TabIndex = 0
        PictureBox9.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.White
        Label2.Font = New Font("Arial", 13F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(1128, 291)
        Label2.Name = "Label2"
        Label2.Size = New Size(178, 21)
        Label2.TabIndex = 24
        Label2.Text = "Population per Purok"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' DateTime
        ' 
        DateTime.AutoSize = True
        DateTime.BackColor = Color.White
        DateTime.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DateTime.Location = New Point(416, 32)
        DateTime.Name = "DateTime"
        DateTime.Size = New Size(0, 15)
        DateTime.TabIndex = 25
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.White
        Panel4.BorderStyle = BorderStyle.FixedSingle
        Panel4.Controls.Add(backupBtn)
        Panel4.Controls.Add(Label7)
        Panel4.Location = New Point(1101, 581)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(244, 95)
        Panel4.TabIndex = 26
        ' 
        ' backupBtn
        ' 
        backupBtn.BackColor = Color.FromArgb(CByte(26), CByte(36), CByte(80))
        backupBtn.CausesValidation = False
        backupBtn.Font = New Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        backupBtn.ForeColor = SystemColors.Control
        backupBtn.Location = New Point(67, 41)
        backupBtn.Name = "backupBtn"
        backupBtn.Size = New Size(109, 35)
        backupBtn.TabIndex = 28
        backupBtn.Text = "BACKUP"
        backupBtn.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.White
        Label7.Font = New Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(66, 13)
        Label7.Name = "Label7"
        Label7.Size = New Size(107, 15)
        Label7.TabIndex = 27
        Label7.Text = "Database Backup"
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1364, 721)
        Controls.Add(Panel4)
        Controls.Add(DateTime)
        Controls.Add(Label2)
        Controls.Add(dgPurok)
        Controls.Add(TabControl1)
        Controls.Add(Label5)
        Controls.Add(Panel9)
        Controls.Add(Panel8)
        Controls.Add(Panel7)
        Controls.Add(refresh_dashboard)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label3)
        Controls.Add(Panel3)
        Controls.Add(Panel1)
        Margin = New Padding(3, 2, 3, 2)
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = " "
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox12, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        CType(PictureBox13, ComponentModel.ISupportInitialize).EndInit()
        Panel8.ResumeLayout(False)
        Panel8.PerformLayout()
        CType(PictureBox14, ComponentModel.ISupportInitialize).EndInit()
        Panel9.ResumeLayout(False)
        Panel9.PerformLayout()
        CType(PictureBox15, ComponentModel.ISupportInitialize).EndInit()
        CType(dgPurok, ComponentModel.ISupportInitialize).EndInit()
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        CType(PictureBox10, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox9, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents logout_tab As Button
    Friend WithEvents officials_tab As Button
    Friend WithEvents purok_tab As Button
    Friend WithEvents residents_tab As Button
    Friend WithEvents dashboard_tab As Button
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents refresh_dashboard As Button
    Friend WithEvents Panel7 As Panel
    Friend WithEvents PictureBox13 As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents PictureBox14 As PictureBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents PictureBox15 As PictureBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents dgPurok As DataGridView
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents purokNum As DataGridViewTextBoxColumn
    Friend WithEvents totalPopulation As DataGridViewTextBoxColumn
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTime As Label
    Friend WithEvents total_population As TextBox
    Friend WithEvents total_male As TextBox
    Friend WithEvents total_female As TextBox
    Friend WithEvents total_voters As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents backupBtn As Button
End Class
