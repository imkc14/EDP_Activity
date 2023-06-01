<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ResidentsForm
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
        search_box = New TextBox()
        importdata = New Button()
        dgResidents = New DataGridView()
        Panel1 = New Panel()
        PictureBox7 = New PictureBox()
        PictureBox5 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox2 = New PictureBox()
        logout_tab = New Button()
        officials_tab = New Button()
        Panel3 = New Panel()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        purok_tab = New Button()
        residents_tab = New Button()
        dashboard_tab = New Button()
        PictureBox8 = New PictureBox()
        DateTime = New Label()
        Label5 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        Label3 = New Label()
        add_resi = New Button()
        update_resi = New Button()
        delete_resi = New Button()
        Button3 = New Button()
        sex_box = New ComboBox()
        religion_box = New TextBox()
        c_status = New ComboBox()
        age_box = New TextBox()
        fname = New TextBox()
        mname = New TextBox()
        Label11 = New Label()
        Label1 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label4 = New Label()
        lname = New TextBox()
        Label12 = New Label()
        Label13 = New Label()
        Label14 = New Label()
        Label17 = New Label()
        purokID = New ComboBox()
        Panel2 = New Panel()
        Label16 = New Label()
        r_voter = New ComboBox()
        address = New ComboBox()
        birthday = New DateTimePicker()
        Lastname = New DataGridViewTextBoxColumn()
        Label15 = New Label()
        resident_id = New DataGridViewTextBoxColumn()
        purokno = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn1 = New DataGridViewTextBoxColumn()
        Middlename = New DataGridViewTextBoxColumn()
        Firstname = New DataGridViewTextBoxColumn()
        Birthdate = New DataGridViewTextBoxColumn()
        Age = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn2 = New DataGridViewTextBoxColumn()
        Religion = New DataGridViewTextBoxColumn()
        Sex = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn3 = New DataGridViewTextBoxColumn()
        Voter = New DataGridViewTextBoxColumn()
        CType(dgResidents, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' search_box
        ' 
        search_box.BackColor = SystemColors.Control
        search_box.Font = New Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point)
        search_box.Location = New Point(415, 282)
        search_box.Name = "search_box"
        search_box.Size = New Size(282, 23)
        search_box.TabIndex = 13
        ' 
        ' importdata
        ' 
        importdata.BackColor = Color.FromArgb(CByte(255), CByte(173), CByte(52))
        importdata.FlatStyle = FlatStyle.Popup
        importdata.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point)
        importdata.ForeColor = Color.Black
        importdata.Location = New Point(723, 661)
        importdata.Margin = New Padding(3, 2, 3, 2)
        importdata.Name = "importdata"
        importdata.Size = New Size(117, 23)
        importdata.TabIndex = 2
        importdata.Text = "Import Data"
        importdata.UseVisualStyleBackColor = False
        ' 
        ' dgResidents
        ' 
        dgResidents.BackgroundColor = SystemColors.Control
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgResidents.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgResidents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgResidents.Columns.AddRange(New DataGridViewColumn() {resident_id, purokno, DataGridViewTextBoxColumn1, Middlename, Firstname, Birthdate, Age, DataGridViewTextBoxColumn2, Religion, Sex, DataGridViewTextBoxColumn3, Voter})
        dgResidents.GridColor = Color.DimGray
        dgResidents.Location = New Point(361, 324)
        dgResidents.Margin = New Padding(3, 2, 3, 2)
        dgResidents.Name = "dgResidents"
        dgResidents.RowHeadersWidth = 51
        dgResidents.RowTemplate.Height = 29
        dgResidents.Size = New Size(987, 303)
        dgResidents.TabIndex = 0
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
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(purok_tab)
        Panel1.Controls.Add(residents_tab)
        Panel1.Controls.Add(dashboard_tab)
        Panel1.Controls.Add(PictureBox8)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(338, 751)
        Panel1.TabIndex = 14
        ' 
        ' PictureBox7
        ' 
        PictureBox7.Image = My.Resources.Resources.image_removebg_preview__11_
        PictureBox7.Location = New Point(26, 609)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(43, 38)
        PictureBox7.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox7.TabIndex = 21
        PictureBox7.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = My.Resources.Resources.image_removebg_preview__9_
        PictureBox5.Location = New Point(26, 546)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(43, 38)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 19
        PictureBox5.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = My.Resources.Resources.image_removebg_preview__10_
        PictureBox4.Location = New Point(26, 488)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(43, 38)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 18
        PictureBox4.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources._5363451
        PictureBox3.Location = New Point(26, 432)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(43, 38)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 17
        PictureBox3.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources._6292175
        PictureBox2.Location = New Point(26, 375)
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
        logout_tab.Location = New Point(0, 601)
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
        officials_tab.Location = New Point(0, 539)
        officials_tab.Name = "officials_tab"
        officials_tab.Size = New Size(374, 51)
        officials_tab.TabIndex = 13
        officials_tab.Text = "                    Barangay Officials"
        officials_tab.TextAlign = ContentAlignment.MiddleLeft
        officials_tab.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Brown
        Panel3.Controls.Add(PictureBox1)
        Panel3.Controls.Add(Label2)
        Panel3.Location = New Point(1, -1)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(373, 53)
        Panel3.TabIndex = 9
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.image_removebg_preview__19_
        PictureBox1.Location = New Point(5, 11)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(42, 35)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 16
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(45, 20)
        Label2.Name = "Label2"
        Label2.Size = New Size(284, 19)
        Label2.TabIndex = 1
        Label2.Text = "BARANGAY INFORMATION SYSTEM"
        Label2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' purok_tab
        ' 
        purok_tab.BackColor = Color.FromArgb(CByte(26), CByte(36), CByte(80))
        purok_tab.FlatAppearance.BorderSize = 0
        purok_tab.FlatStyle = FlatStyle.Flat
        purok_tab.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        purok_tab.ForeColor = Color.White
        purok_tab.Location = New Point(0, 482)
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
        residents_tab.Location = New Point(0, 425)
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
        dashboard_tab.Location = New Point(0, 370)
        dashboard_tab.Name = "dashboard_tab"
        dashboard_tab.Size = New Size(374, 48)
        dashboard_tab.TabIndex = 10
        dashboard_tab.Text = "                    Dashboard"
        dashboard_tab.TextAlign = ContentAlignment.MiddleLeft
        dashboard_tab.UseVisualStyleBackColor = False
        ' 
        ' PictureBox8
        ' 
        PictureBox8.Image = My.Resources.Resources.brgy_logo1
        PictureBox8.Location = New Point(26, 73)
        PictureBox8.Margin = New Padding(3, 2, 3, 2)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(283, 272)
        PictureBox8.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox8.TabIndex = 5
        PictureBox8.TabStop = False
        ' 
        ' DateTime
        ' 
        DateTime.AutoSize = True
        DateTime.BackColor = Color.White
        DateTime.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DateTime.Location = New Point(415, 31)
        DateTime.Name = "DateTime"
        DateTime.Size = New Size(0, 15)
        DateTime.TabIndex = 30
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.White
        Label5.Font = New Font("Arial", 13F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(973, 10)
        Label5.Name = "Label5"
        Label5.Size = New Size(375, 21)
        Label5.TabIndex = 29
        Label5.Text = "SANGGUNIANG BARANGAY NG DANCALAN"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.White
        Label10.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.Location = New Point(357, 31)
        Label10.Name = "Label10"
        Label10.Size = New Size(59, 15)
        Label10.TabIndex = 28
        Label10.Text = "TODAY IS"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.White
        Label9.Font = New Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.Location = New Point(357, 11)
        Label9.Name = "Label9"
        Label9.Size = New Size(162, 17)
        Label9.TabIndex = 27
        Label9.Text = "RESIDENTS RECORD"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.White
        Label3.Font = New Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(1069, 33)
        Label3.Name = "Label3"
        Label3.Size = New Size(275, 16)
        Label3.TabIndex = 26
        Label3.Text = "DANCALAN, DONSOL, SORSOGON, 4715"
        ' 
        ' add_resi
        ' 
        add_resi.BackColor = Color.Brown
        add_resi.FlatAppearance.BorderSize = 0
        add_resi.FlatStyle = FlatStyle.Popup
        add_resi.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point)
        add_resi.ForeColor = Color.White
        add_resi.Location = New Point(872, 282)
        add_resi.Name = "add_resi"
        add_resi.Size = New Size(101, 23)
        add_resi.TabIndex = 31
        add_resi.Text = "Add"
        add_resi.UseVisualStyleBackColor = False
        ' 
        ' update_resi
        ' 
        update_resi.BackColor = Color.Brown
        update_resi.FlatAppearance.BorderSize = 0
        update_resi.FlatStyle = FlatStyle.Popup
        update_resi.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point)
        update_resi.ForeColor = Color.White
        update_resi.Location = New Point(985, 282)
        update_resi.Name = "update_resi"
        update_resi.Size = New Size(101, 23)
        update_resi.TabIndex = 32
        update_resi.Text = "Update"
        update_resi.UseVisualStyleBackColor = False
        ' 
        ' delete_resi
        ' 
        delete_resi.BackColor = Color.Brown
        delete_resi.FlatAppearance.BorderSize = 0
        delete_resi.FlatStyle = FlatStyle.Popup
        delete_resi.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point)
        delete_resi.ForeColor = Color.White
        delete_resi.Location = New Point(1098, 282)
        delete_resi.Name = "delete_resi"
        delete_resi.Size = New Size(101, 23)
        delete_resi.TabIndex = 33
        delete_resi.Text = "Delete"
        delete_resi.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(255), CByte(173), CByte(52))
        Button3.FlatStyle = FlatStyle.Popup
        Button3.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Button3.ForeColor = Color.Black
        Button3.Location = New Point(899, 661)
        Button3.Margin = New Padding(3, 2, 3, 2)
        Button3.Name = "Button3"
        Button3.Size = New Size(117, 23)
        Button3.TabIndex = 37
        Button3.Text = "Export Data"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' sex_box
        ' 
        sex_box.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point)
        sex_box.FormattingEnabled = True
        sex_box.Items.AddRange(New Object() {"Female", "Male"})
        sex_box.Location = New Point(788, 36)
        sex_box.Margin = New Padding(3, 2, 3, 2)
        sex_box.Name = "sex_box"
        sex_box.Size = New Size(86, 23)
        sex_box.TabIndex = 67
        ' 
        ' religion_box
        ' 
        religion_box.BorderStyle = BorderStyle.FixedSingle
        religion_box.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point)
        religion_box.Location = New Point(341, 108)
        religion_box.Margin = New Padding(3, 2, 3, 2)
        religion_box.Name = "religion_box"
        religion_box.Size = New Size(179, 21)
        religion_box.TabIndex = 66
        ' 
        ' c_status
        ' 
        c_status.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point)
        c_status.FormattingEnabled = True
        c_status.Items.AddRange(New Object() {"Single", "Married", "Separated", "Divorced", "Widowed"})
        c_status.Location = New Point(207, 107)
        c_status.Margin = New Padding(3, 2, 3, 2)
        c_status.Name = "c_status"
        c_status.Size = New Size(114, 23)
        c_status.TabIndex = 65
        ' 
        ' age_box
        ' 
        age_box.BorderStyle = BorderStyle.FixedSingle
        age_box.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point)
        age_box.Location = New Point(897, 36)
        age_box.Margin = New Padding(3, 2, 3, 2)
        age_box.Name = "age_box"
        age_box.Size = New Size(54, 21)
        age_box.TabIndex = 64
        ' 
        ' fname
        ' 
        fname.BorderStyle = BorderStyle.FixedSingle
        fname.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point)
        fname.Location = New Point(558, 38)
        fname.Margin = New Padding(3, 2, 3, 2)
        fname.Name = "fname"
        fname.Size = New Size(205, 21)
        fname.TabIndex = 62
        ' 
        ' mname
        ' 
        mname.BorderStyle = BorderStyle.FixedSingle
        mname.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point)
        mname.Location = New Point(309, 38)
        mname.Margin = New Padding(3, 2, 3, 2)
        mname.Name = "mname"
        mname.Size = New Size(220, 21)
        mname.TabIndex = 61
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Arial", 9F, FontStyle.Italic, GraphicsUnit.Point)
        Label11.Location = New Point(844, 88)
        Label11.Name = "Label11"
        Label11.Size = New Size(104, 15)
        Label11.TabIndex = 60
        Label11.Text = "Registered Voter*"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 9F, FontStyle.Italic, GraphicsUnit.Point)
        Label1.Location = New Point(788, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(36, 15)
        Label1.TabIndex = 59
        Label1.Text = "Sex *"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Arial", 9F, FontStyle.Italic, GraphicsUnit.Point)
        Label8.Location = New Point(339, 90)
        Label8.Name = "Label8"
        Label8.Size = New Size(61, 15)
        Label8.TabIndex = 58
        Label8.Text = "Religion *"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Arial", 9F, FontStyle.Italic, GraphicsUnit.Point)
        Label7.Location = New Point(207, 89)
        Label7.Name = "Label7"
        Label7.Size = New Size(76, 15)
        Label7.TabIndex = 57
        Label7.Text = "Civil Status *"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Arial", 9F, FontStyle.Italic, GraphicsUnit.Point)
        Label6.Location = New Point(897, 19)
        Label6.Name = "Label6"
        Label6.Size = New Size(37, 15)
        Label6.TabIndex = 56
        Label6.Text = "Age *"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial", 9F, FontStyle.Italic, GraphicsUnit.Point)
        Label4.Location = New Point(397, 194)
        Label4.Name = "Label4"
        Label4.Size = New Size(64, 15)
        Label4.TabIndex = 55
        Label4.Text = "Birthdate *"
        ' 
        ' lname
        ' 
        lname.BorderStyle = BorderStyle.FixedSingle
        lname.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lname.Location = New Point(39, 38)
        lname.Margin = New Padding(3, 2, 3, 2)
        lname.Name = "lname"
        lname.Size = New Size(242, 21)
        lname.TabIndex = 54
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Arial", 9F, FontStyle.Italic, GraphicsUnit.Point)
        Label12.Location = New Point(558, 21)
        Label12.Name = "Label12"
        Label12.Size = New Size(75, 15)
        Label12.TabIndex = 53
        Label12.Text = "First Name *"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Arial", 9F, FontStyle.Italic, GraphicsUnit.Point)
        Label13.Location = New Point(309, 21)
        Label13.Name = "Label13"
        Label13.Size = New Size(88, 15)
        Label13.TabIndex = 52
        Label13.Text = "Middle Name *"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Arial", 9F, FontStyle.Italic, GraphicsUnit.Point)
        Label14.Location = New Point(39, 21)
        Label14.Name = "Label14"
        Label14.Size = New Size(75, 15)
        Label14.TabIndex = 51
        Label14.Text = "Last Name *"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Arial", 9F, FontStyle.Italic, GraphicsUnit.Point)
        Label17.Location = New Point(540, 89)
        Label17.Name = "Label17"
        Label17.Size = New Size(48, 15)
        Label17.TabIndex = 37
        Label17.Text = "Purok *"
        ' 
        ' purokID
        ' 
        purokID.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point)
        purokID.FormattingEnabled = True
        purokID.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        purokID.Location = New Point(541, 107)
        purokID.Margin = New Padding(3, 2, 3, 2)
        purokID.Name = "purokID"
        purokID.Size = New Size(61, 23)
        purokID.TabIndex = 45
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(Label16)
        Panel2.Controls.Add(r_voter)
        Panel2.Controls.Add(Label11)
        Panel2.Controls.Add(address)
        Panel2.Controls.Add(Label17)
        Panel2.Controls.Add(purokID)
        Panel2.Controls.Add(fname)
        Panel2.Controls.Add(religion_box)
        Panel2.Controls.Add(sex_box)
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(c_status)
        Panel2.Controls.Add(Label12)
        Panel2.Controls.Add(age_box)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(mname)
        Panel2.Controls.Add(Label13)
        Panel2.Controls.Add(lname)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(Label14)
        Panel2.Location = New Point(357, 102)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(987, 156)
        Panel2.TabIndex = 69
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Arial", 9F, FontStyle.Italic, GraphicsUnit.Point)
        Label16.Location = New Point(624, 88)
        Label16.Name = "Label16"
        Label16.Size = New Size(60, 15)
        Label16.TabIndex = 70
        Label16.Text = "Address *"
        ' 
        ' r_voter
        ' 
        r_voter.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point)
        r_voter.FormattingEnabled = True
        r_voter.Items.AddRange(New Object() {"Yes", "No"})
        r_voter.Location = New Point(845, 106)
        r_voter.Margin = New Padding(3, 2, 3, 2)
        r_voter.Name = "r_voter"
        r_voter.Size = New Size(106, 23)
        r_voter.TabIndex = 69
        ' 
        ' address
        ' 
        address.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point)
        address.FormattingEnabled = True
        address.Items.AddRange(New Object() {"Purok 1 Dancalan Donsol Sorsogon", "Purok 2 Dancalan Donsol Sorsogon", "Purok 3 Dancalan Donsol Sorsogon", "Purok 4 Dancalan Donsol Sorsogon", "Purok 5 Dancalan Donsol Sorsogon", "Purok 6 Dancalan Donsol Sorsogon", "Purok 7 Dancalan Donsol Sorsogon", "Purok 8 Dancalan Donsol Sorsogon", "Purok 9 Dancalan Donsol Sorsogon", "Purok 10 Dancalan Donsol Sorsogon"})
        address.Location = New Point(624, 106)
        address.Margin = New Padding(3, 2, 3, 2)
        address.Name = "address"
        address.Size = New Size(200, 23)
        address.TabIndex = 68
        ' 
        ' birthday
        ' 
        birthday.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point)
        birthday.Location = New Point(398, 212)
        birthday.Margin = New Padding(3, 2, 3, 2)
        birthday.Name = "birthday"
        birthday.Size = New Size(146, 21)
        birthday.TabIndex = 63
        ' 
        ' Lastname
        ' 
        Lastname.HeaderText = "Last Name"
        Lastname.MinimumWidth = 6
        Lastname.Name = "Lastname"
        Lastname.Width = 125
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.BackColor = Color.FromArgb(CByte(255), CByte(173), CByte(52))
        Label15.FlatStyle = FlatStyle.Flat
        Label15.Font = New Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label15.Location = New Point(361, 286)
        Label15.Name = "Label15"
        Label15.Size = New Size(48, 16)
        Label15.TabIndex = 71
        Label15.Text = "Search"
        ' 
        ' resident_id
        ' 
        resident_id.HeaderText = "Resident ID"
        resident_id.Name = "resident_id"
        resident_id.ReadOnly = True
        ' 
        ' purokno
        ' 
        purokno.HeaderText = "Purok"
        purokno.Name = "purokno"
        ' 
        ' DataGridViewTextBoxColumn1
        ' 
        DataGridViewTextBoxColumn1.HeaderText = "Last Name"
        DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        DataGridViewTextBoxColumn1.ReadOnly = True
        ' 
        ' Middlename
        ' 
        Middlename.HeaderText = "Middle Name"
        Middlename.Name = "Middlename"
        Middlename.ReadOnly = True
        ' 
        ' Firstname
        ' 
        Firstname.HeaderText = "First Name"
        Firstname.Name = "Firstname"
        Firstname.ReadOnly = True
        ' 
        ' Birthdate
        ' 
        Birthdate.HeaderText = "Birthdate"
        Birthdate.Name = "Birthdate"
        Birthdate.ReadOnly = True
        ' 
        ' Age
        ' 
        Age.HeaderText = "Age"
        Age.Name = "Age"
        Age.ReadOnly = True
        ' 
        ' DataGridViewTextBoxColumn2
        ' 
        DataGridViewTextBoxColumn2.HeaderText = "Civil Status"
        DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        DataGridViewTextBoxColumn2.ReadOnly = True
        ' 
        ' Religion
        ' 
        Religion.HeaderText = "Religion"
        Religion.Name = "Religion"
        ' 
        ' Sex
        ' 
        Sex.HeaderText = "Sex"
        Sex.Name = "Sex"
        ' 
        ' DataGridViewTextBoxColumn3
        ' 
        DataGridViewTextBoxColumn3.HeaderText = "Address"
        DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        DataGridViewTextBoxColumn3.ReadOnly = True
        ' 
        ' Voter
        ' 
        Voter.HeaderText = "Voter Status"
        Voter.Name = "Voter"
        Voter.ReadOnly = True
        ' 
        ' ResidentsForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1364, 721)
        Controls.Add(Label15)
        Controls.Add(birthday)
        Controls.Add(Label4)
        Controls.Add(Button3)
        Controls.Add(delete_resi)
        Controls.Add(update_resi)
        Controls.Add(add_resi)
        Controls.Add(DateTime)
        Controls.Add(Label5)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label3)
        Controls.Add(Panel1)
        Controls.Add(search_box)
        Controls.Add(importdata)
        Controls.Add(dgResidents)
        Controls.Add(Panel2)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(3, 2, 3, 2)
        Name = "ResidentsForm"
        CType(dgResidents, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents search_box As TextBox
    Friend WithEvents importdata As Button
    Friend WithEvents dgResidents As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents logout_tab As Button
    Friend WithEvents officials_tab As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents purok_tab As Button
    Friend WithEvents residents_tab As Button
    Friend WithEvents dashboard_tab As Button
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents DateTime As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents add_resi As Button
    Friend WithEvents update_resi As Button
    Friend WithEvents delete_resi As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents sex_box As ComboBox
    Friend WithEvents religion_box As TextBox
    Friend WithEvents c_status As ComboBox
    Friend WithEvents age_box As TextBox
    Friend WithEvents fname As TextBox
    Friend WithEvents mname As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lname As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents purokID As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label16 As Label
    Friend WithEvents r_voter As ComboBox
    Friend WithEvents address As ComboBox
    Friend WithEvents birthday As DateTimePicker
    Friend WithEvents Lastname As DataGridViewTextBoxColumn
    Friend WithEvents Label15 As Label
    Friend WithEvents resident_id As DataGridViewTextBoxColumn
    Friend WithEvents purokno As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Middlename As DataGridViewTextBoxColumn
    Friend WithEvents Firstname As DataGridViewTextBoxColumn
    Friend WithEvents Birthdate As DataGridViewTextBoxColumn
    Friend WithEvents Age As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents Religion As DataGridViewTextBoxColumn
    Friend WithEvents Sex As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents Voter As DataGridViewTextBoxColumn
End Class
