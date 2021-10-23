<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Employee
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim EmployeeTypeIDLabel As System.Windows.Forms.Label
        Dim EmployeeIDLabel1 As System.Windows.Forms.Label
        Dim BeginDateLabel As System.Windows.Forms.Label
        Dim EndDateLabel As System.Windows.Forms.Label
        Dim EmployeeIDLabel2 As System.Windows.Forms.Label
        Dim LastNameLabel1 As System.Windows.Forms.Label
        Dim FirstNameLabel1 As System.Windows.Forms.Label
        Dim PhoneNumberLabel1 As System.Windows.Forms.Label
        Dim BirthDateLabel1 As System.Windows.Forms.Label
        Dim HireDateLabel As System.Windows.Forms.Label
        Dim GenderLabel1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Employee))
        Me.EmployeeBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.EmployeeBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.lblEmployeeInformation = New System.Windows.Forms.Label()
        Me.EmployeePictureBox = New System.Windows.Forms.PictureBox()
        Me.picLogoEmployee = New System.Windows.Forms.PictureBox()
        Me.btnUploadPhoto = New System.Windows.Forms.Button()
        Me.btnDeletePhoto = New System.Windows.Forms.Button()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.txtFileName = New System.Windows.Forms.TextBox()
        Me.EmployeeTypeHistoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeeTypeIDTextBox = New System.Windows.Forms.TextBox()
        Me.EmployeeIDTextBox1 = New System.Windows.Forms.TextBox()
        Me.BeginDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.EndDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.EmployeeIDTextBox2 = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox1 = New System.Windows.Forms.TextBox()
        Me.FirstNameTextBox1 = New System.Windows.Forms.TextBox()
        Me.PhoneNumberTextBox1 = New System.Windows.Forms.TextBox()
        Me.BirthDateDateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.HireDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.GenderComboBox1 = New System.Windows.Forms.ComboBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.FillBy1ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.LastNameToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.LastNameToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillBy1ToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.EmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SanchezPizzeriaDataSet = New SanchezPizzeria.SanchezPizzeriaDataSet()
        Me.EmployeeTableAdapter = New SanchezPizzeria.SanchezPizzeriaDataSetTableAdapters.EmployeeTableAdapter()
        Me.TableAdapterManager = New SanchezPizzeria.SanchezPizzeriaDataSetTableAdapters.TableAdapterManager()
        Me.EmployeeTypeHistoryTableAdapter = New SanchezPizzeria.SanchezPizzeriaDataSetTableAdapters.EmployeeTypeHistoryTableAdapter()
        EmployeeTypeIDLabel = New System.Windows.Forms.Label()
        EmployeeIDLabel1 = New System.Windows.Forms.Label()
        BeginDateLabel = New System.Windows.Forms.Label()
        EndDateLabel = New System.Windows.Forms.Label()
        EmployeeIDLabel2 = New System.Windows.Forms.Label()
        LastNameLabel1 = New System.Windows.Forms.Label()
        FirstNameLabel1 = New System.Windows.Forms.Label()
        PhoneNumberLabel1 = New System.Windows.Forms.Label()
        BirthDateLabel1 = New System.Windows.Forms.Label()
        HireDateLabel = New System.Windows.Forms.Label()
        GenderLabel1 = New System.Windows.Forms.Label()
        CType(Me.EmployeeBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EmployeeBindingNavigator.SuspendLayout()
        CType(Me.EmployeePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLogoEmployee, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeTypeHistoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillBy1ToolStrip.SuspendLayout()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SanchezPizzeriaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EmployeeTypeIDLabel
        '
        EmployeeTypeIDLabel.AutoSize = True
        EmployeeTypeIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmployeeTypeIDLabel.Location = New System.Drawing.Point(529, 403)
        EmployeeTypeIDLabel.Name = "EmployeeTypeIDLabel"
        EmployeeTypeIDLabel.Size = New System.Drawing.Size(142, 20)
        EmployeeTypeIDLabel.TabIndex = 35
        EmployeeTypeIDLabel.Text = "Employee Type ID:"
        '
        'EmployeeIDLabel1
        '
        EmployeeIDLabel1.AutoSize = True
        EmployeeIDLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmployeeIDLabel1.Location = New System.Drawing.Point(570, 432)
        EmployeeIDLabel1.Name = "EmployeeIDLabel1"
        EmployeeIDLabel1.Size = New System.Drawing.Size(104, 20)
        EmployeeIDLabel1.TabIndex = 37
        EmployeeIDLabel1.Text = "Employee ID:"
        '
        'BeginDateLabel
        '
        BeginDateLabel.AutoSize = True
        BeginDateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BeginDateLabel.Location = New System.Drawing.Point(582, 464)
        BeginDateLabel.Name = "BeginDateLabel"
        BeginDateLabel.Size = New System.Drawing.Size(93, 20)
        BeginDateLabel.TabIndex = 39
        BeginDateLabel.Text = "Begin Date:"
        '
        'EndDateLabel
        '
        EndDateLabel.AutoSize = True
        EndDateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EndDateLabel.Location = New System.Drawing.Point(596, 496)
        EndDateLabel.Name = "EndDateLabel"
        EndDateLabel.Size = New System.Drawing.Size(81, 20)
        EndDateLabel.TabIndex = 41
        EndDateLabel.Text = "End Date:"
        '
        'EmployeeIDLabel2
        '
        EmployeeIDLabel2.AutoSize = True
        EmployeeIDLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmployeeIDLabel2.Location = New System.Drawing.Point(41, 156)
        EmployeeIDLabel2.Name = "EmployeeIDLabel2"
        EmployeeIDLabel2.Size = New System.Drawing.Size(104, 20)
        EmployeeIDLabel2.TabIndex = 42
        EmployeeIDLabel2.Text = "Employee ID:"
        '
        'LastNameLabel1
        '
        LastNameLabel1.AutoSize = True
        LastNameLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LastNameLabel1.Location = New System.Drawing.Point(52, 188)
        LastNameLabel1.Name = "LastNameLabel1"
        LastNameLabel1.Size = New System.Drawing.Size(90, 20)
        LastNameLabel1.TabIndex = 44
        LastNameLabel1.Text = "Last Name:"
        '
        'FirstNameLabel1
        '
        FirstNameLabel1.AutoSize = True
        FirstNameLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FirstNameLabel1.Location = New System.Drawing.Point(51, 220)
        FirstNameLabel1.Name = "FirstNameLabel1"
        FirstNameLabel1.Size = New System.Drawing.Size(90, 20)
        FirstNameLabel1.TabIndex = 46
        FirstNameLabel1.Text = "First Name:"
        '
        'PhoneNumberLabel1
        '
        PhoneNumberLabel1.AutoSize = True
        PhoneNumberLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PhoneNumberLabel1.Location = New System.Drawing.Point(25, 252)
        PhoneNumberLabel1.Name = "PhoneNumberLabel1"
        PhoneNumberLabel1.Size = New System.Drawing.Size(119, 20)
        PhoneNumberLabel1.TabIndex = 48
        PhoneNumberLabel1.Text = "Phone Number:"
        '
        'BirthDateLabel1
        '
        BirthDateLabel1.AutoSize = True
        BirthDateLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BirthDateLabel1.Location = New System.Drawing.Point(61, 286)
        BirthDateLabel1.Name = "BirthDateLabel1"
        BirthDateLabel1.Size = New System.Drawing.Size(85, 20)
        BirthDateLabel1.TabIndex = 50
        BirthDateLabel1.Text = "Birth Date:"
        '
        'HireDateLabel
        '
        HireDateLabel.AutoSize = True
        HireDateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        HireDateLabel.Location = New System.Drawing.Point(61, 317)
        HireDateLabel.Name = "HireDateLabel"
        HireDateLabel.Size = New System.Drawing.Size(81, 20)
        HireDateLabel.TabIndex = 52
        HireDateLabel.Text = "Hire Date:"
        '
        'GenderLabel1
        '
        GenderLabel1.AutoSize = True
        GenderLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GenderLabel1.Location = New System.Drawing.Point(68, 348)
        GenderLabel1.Name = "GenderLabel1"
        GenderLabel1.Size = New System.Drawing.Size(67, 20)
        GenderLabel1.TabIndex = 54
        GenderLabel1.Text = "Gender:"
        '
        'EmployeeBindingNavigator
        '
        Me.EmployeeBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.EmployeeBindingNavigator.BindingSource = Me.EmployeeBindingSource
        Me.EmployeeBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.EmployeeBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.EmployeeBindingNavigator.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.EmployeeBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.EmployeeBindingNavigatorSaveItem})
        Me.EmployeeBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.EmployeeBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.EmployeeBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.EmployeeBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.EmployeeBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.EmployeeBindingNavigator.Name = "EmployeeBindingNavigator"
        Me.EmployeeBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.EmployeeBindingNavigator.Size = New System.Drawing.Size(1278, 33)
        Me.EmployeeBindingNavigator.TabIndex = 0
        Me.EmployeeBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Enabled = False
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(54, 28)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Enabled = False
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 33)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 31)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 33)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 33)
        '
        'EmployeeBindingNavigatorSaveItem
        '
        Me.EmployeeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EmployeeBindingNavigatorSaveItem.Enabled = False
        Me.EmployeeBindingNavigatorSaveItem.Image = CType(resources.GetObject("EmployeeBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.EmployeeBindingNavigatorSaveItem.Name = "EmployeeBindingNavigatorSaveItem"
        Me.EmployeeBindingNavigatorSaveItem.Size = New System.Drawing.Size(34, 28)
        Me.EmployeeBindingNavigatorSaveItem.Text = "Save Data"
        '
        'lblEmployeeInformation
        '
        Me.lblEmployeeInformation.AutoSize = True
        Me.lblEmployeeInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeeInformation.Location = New System.Drawing.Point(454, 92)
        Me.lblEmployeeInformation.Name = "lblEmployeeInformation"
        Me.lblEmployeeInformation.Size = New System.Drawing.Size(267, 29)
        Me.lblEmployeeInformation.TabIndex = 26
        Me.lblEmployeeInformation.Text = "Employee Information"
        '
        'EmployeePictureBox
        '
        Me.EmployeePictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.EmployeeBindingSource, "Picture", True))
        Me.EmployeePictureBox.Location = New System.Drawing.Point(574, 144)
        Me.EmployeePictureBox.Name = "EmployeePictureBox"
        Me.EmployeePictureBox.Size = New System.Drawing.Size(147, 126)
        Me.EmployeePictureBox.TabIndex = 30
        Me.EmployeePictureBox.TabStop = False
        '
        'picLogoEmployee
        '
        Me.picLogoEmployee.Image = CType(resources.GetObject("picLogoEmployee.Image"), System.Drawing.Image)
        Me.picLogoEmployee.Location = New System.Drawing.Point(942, 92)
        Me.picLogoEmployee.Name = "picLogoEmployee"
        Me.picLogoEmployee.Size = New System.Drawing.Size(231, 186)
        Me.picLogoEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLogoEmployee.TabIndex = 31
        Me.picLogoEmployee.TabStop = False
        '
        'btnUploadPhoto
        '
        Me.btnUploadPhoto.Location = New System.Drawing.Point(739, 168)
        Me.btnUploadPhoto.Name = "btnUploadPhoto"
        Me.btnUploadPhoto.Size = New System.Drawing.Size(147, 36)
        Me.btnUploadPhoto.TabIndex = 32
        Me.btnUploadPhoto.Text = "Upload Photo"
        Me.btnUploadPhoto.UseVisualStyleBackColor = True
        '
        'btnDeletePhoto
        '
        Me.btnDeletePhoto.Location = New System.Drawing.Point(739, 217)
        Me.btnDeletePhoto.Name = "btnDeletePhoto"
        Me.btnDeletePhoto.Size = New System.Drawing.Size(147, 36)
        Me.btnDeletePhoto.TabIndex = 33
        Me.btnDeletePhoto.Text = "Delete Photo"
        Me.btnDeletePhoto.UseVisualStyleBackColor = True
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(574, 312)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(147, 36)
        Me.btnBrowse.TabIndex = 34
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'txtFileName
        '
        Me.txtFileName.Location = New System.Drawing.Point(746, 317)
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.Size = New System.Drawing.Size(140, 26)
        Me.txtFileName.TabIndex = 35
        '
        'EmployeeTypeHistoryBindingSource
        '
        Me.EmployeeTypeHistoryBindingSource.DataMember = "fk_employee_id"
        Me.EmployeeTypeHistoryBindingSource.DataSource = Me.EmployeeBindingSource
        '
        'EmployeeTypeIDTextBox
        '
        Me.EmployeeTypeIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeTypeHistoryBindingSource, "EmployeeTypeID", True))
        Me.EmployeeTypeIDTextBox.Location = New System.Drawing.Point(704, 400)
        Me.EmployeeTypeIDTextBox.Name = "EmployeeTypeIDTextBox"
        Me.EmployeeTypeIDTextBox.Size = New System.Drawing.Size(309, 26)
        Me.EmployeeTypeIDTextBox.TabIndex = 36
        '
        'EmployeeIDTextBox1
        '
        Me.EmployeeIDTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeTypeHistoryBindingSource, "EmployeeID", True))
        Me.EmployeeIDTextBox1.Location = New System.Drawing.Point(704, 432)
        Me.EmployeeIDTextBox1.Name = "EmployeeIDTextBox1"
        Me.EmployeeIDTextBox1.Size = New System.Drawing.Size(309, 26)
        Me.EmployeeIDTextBox1.TabIndex = 38
        '
        'BeginDateDateTimePicker
        '
        Me.BeginDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EmployeeTypeHistoryBindingSource, "BeginDate", True))
        Me.BeginDateDateTimePicker.Location = New System.Drawing.Point(704, 464)
        Me.BeginDateDateTimePicker.Name = "BeginDateDateTimePicker"
        Me.BeginDateDateTimePicker.Size = New System.Drawing.Size(309, 26)
        Me.BeginDateDateTimePicker.TabIndex = 40
        '
        'EndDateDateTimePicker
        '
        Me.EndDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EmployeeTypeHistoryBindingSource, "EndDate", True))
        Me.EndDateDateTimePicker.Location = New System.Drawing.Point(704, 496)
        Me.EndDateDateTimePicker.Name = "EndDateDateTimePicker"
        Me.EndDateDateTimePicker.Size = New System.Drawing.Size(309, 26)
        Me.EndDateDateTimePicker.TabIndex = 42
        '
        'EmployeeIDTextBox2
        '
        Me.EmployeeIDTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "EmployeeID", True))
        Me.EmployeeIDTextBox2.Location = New System.Drawing.Point(167, 153)
        Me.EmployeeIDTextBox2.Name = "EmployeeIDTextBox2"
        Me.EmployeeIDTextBox2.Size = New System.Drawing.Size(78, 26)
        Me.EmployeeIDTextBox2.TabIndex = 43
        '
        'LastNameTextBox1
        '
        Me.LastNameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "LastName", True))
        Me.LastNameTextBox1.Location = New System.Drawing.Point(167, 185)
        Me.LastNameTextBox1.Name = "LastNameTextBox1"
        Me.LastNameTextBox1.Size = New System.Drawing.Size(200, 26)
        Me.LastNameTextBox1.TabIndex = 45
        '
        'FirstNameTextBox1
        '
        Me.FirstNameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "FirstName", True))
        Me.FirstNameTextBox1.Location = New System.Drawing.Point(167, 217)
        Me.FirstNameTextBox1.Name = "FirstNameTextBox1"
        Me.FirstNameTextBox1.Size = New System.Drawing.Size(200, 26)
        Me.FirstNameTextBox1.TabIndex = 47
        '
        'PhoneNumberTextBox1
        '
        Me.PhoneNumberTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "PhoneNumber", True))
        Me.PhoneNumberTextBox1.Location = New System.Drawing.Point(167, 249)
        Me.PhoneNumberTextBox1.Name = "PhoneNumberTextBox1"
        Me.PhoneNumberTextBox1.Size = New System.Drawing.Size(165, 26)
        Me.PhoneNumberTextBox1.TabIndex = 49
        '
        'BirthDateDateTimePicker1
        '
        Me.BirthDateDateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EmployeeBindingSource, "BirthDate", True))
        Me.BirthDateDateTimePicker1.Location = New System.Drawing.Point(167, 281)
        Me.BirthDateDateTimePicker1.Name = "BirthDateDateTimePicker1"
        Me.BirthDateDateTimePicker1.Size = New System.Drawing.Size(311, 26)
        Me.BirthDateDateTimePicker1.TabIndex = 51
        '
        'HireDateDateTimePicker
        '
        Me.HireDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EmployeeBindingSource, "HireDate", True))
        Me.HireDateDateTimePicker.Location = New System.Drawing.Point(167, 313)
        Me.HireDateDateTimePicker.Name = "HireDateDateTimePicker"
        Me.HireDateDateTimePicker.Size = New System.Drawing.Size(311, 26)
        Me.HireDateDateTimePicker.TabIndex = 53
        '
        'GenderComboBox1
        '
        Me.GenderComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "Gender", True))
        Me.GenderComboBox1.FormattingEnabled = True
        Me.GenderComboBox1.Location = New System.Drawing.Point(167, 345)
        Me.GenderComboBox1.Name = "GenderComboBox1"
        Me.GenderComboBox1.Size = New System.Drawing.Size(68, 28)
        Me.GenderComboBox1.TabIndex = 55
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'FillBy1ToolStrip
        '
        Me.FillBy1ToolStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.FillBy1ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LastNameToolStripLabel, Me.LastNameToolStripTextBox, Me.FillBy1ToolStripButton})
        Me.FillBy1ToolStrip.Location = New System.Drawing.Point(0, 33)
        Me.FillBy1ToolStrip.Name = "FillBy1ToolStrip"
        Me.FillBy1ToolStrip.Size = New System.Drawing.Size(1278, 34)
        Me.FillBy1ToolStrip.TabIndex = 56
        Me.FillBy1ToolStrip.Text = "FillBy1ToolStrip"
        '
        'LastNameToolStripLabel
        '
        Me.LastNameToolStripLabel.Name = "LastNameToolStripLabel"
        Me.LastNameToolStripLabel.Size = New System.Drawing.Size(94, 29)
        Me.LastNameToolStripLabel.Text = "LastName:"
        '
        'LastNameToolStripTextBox
        '
        Me.LastNameToolStripTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LastNameToolStripTextBox.Name = "LastNameToolStripTextBox"
        Me.LastNameToolStripTextBox.Size = New System.Drawing.Size(100, 34)
        '
        'FillBy1ToolStripButton
        '
        Me.FillBy1ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillBy1ToolStripButton.Name = "FillBy1ToolStripButton"
        Me.FillBy1ToolStripButton.Size = New System.Drawing.Size(68, 29)
        Me.FillBy1ToolStripButton.Text = "Search"
        '
        'EmployeeBindingSource
        '
        Me.EmployeeBindingSource.DataMember = "Employee"
        Me.EmployeeBindingSource.DataSource = Me.SanchezPizzeriaDataSet
        '
        'SanchezPizzeriaDataSet
        '
        Me.SanchezPizzeriaDataSet.DataSetName = "SanchezPizzeriaDataSet"
        Me.SanchezPizzeriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmployeeTableAdapter
        '
        Me.EmployeeTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CustomerTableAdapter = Nothing
        Me.TableAdapterManager.EmployeeTableAdapter = Me.EmployeeTableAdapter
        Me.TableAdapterManager.EmployeeTypeHistoryTableAdapter = Nothing
        Me.TableAdapterManager.EmployeeTypeTableAdapter = Nothing
        Me.TableAdapterManager.OrderLineTableAdapter = Nothing
        Me.TableAdapterManager.OrderTableAdapter = Nothing
        Me.TableAdapterManager.ProductTableAdapter = Nothing
        Me.TableAdapterManager.ProductTypeTableAdapter = Nothing
        Me.TableAdapterManager.RestaurantTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SanchezPizzeria.SanchezPizzeriaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EmployeeTypeHistoryTableAdapter
        '
        Me.EmployeeTypeHistoryTableAdapter.ClearBeforeFill = True
        '
        'Employee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(1278, 777)
        Me.Controls.Add(Me.FillBy1ToolStrip)
        Me.Controls.Add(EmployeeIDLabel2)
        Me.Controls.Add(Me.EmployeeIDTextBox2)
        Me.Controls.Add(LastNameLabel1)
        Me.Controls.Add(Me.LastNameTextBox1)
        Me.Controls.Add(FirstNameLabel1)
        Me.Controls.Add(Me.FirstNameTextBox1)
        Me.Controls.Add(PhoneNumberLabel1)
        Me.Controls.Add(Me.PhoneNumberTextBox1)
        Me.Controls.Add(BirthDateLabel1)
        Me.Controls.Add(Me.BirthDateDateTimePicker1)
        Me.Controls.Add(HireDateLabel)
        Me.Controls.Add(Me.HireDateDateTimePicker)
        Me.Controls.Add(GenderLabel1)
        Me.Controls.Add(Me.GenderComboBox1)
        Me.Controls.Add(EmployeeTypeIDLabel)
        Me.Controls.Add(Me.EmployeeTypeIDTextBox)
        Me.Controls.Add(EmployeeIDLabel1)
        Me.Controls.Add(Me.EmployeeIDTextBox1)
        Me.Controls.Add(BeginDateLabel)
        Me.Controls.Add(Me.BeginDateDateTimePicker)
        Me.Controls.Add(EndDateLabel)
        Me.Controls.Add(Me.EndDateDateTimePicker)
        Me.Controls.Add(Me.txtFileName)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.btnDeletePhoto)
        Me.Controls.Add(Me.btnUploadPhoto)
        Me.Controls.Add(Me.picLogoEmployee)
        Me.Controls.Add(Me.EmployeePictureBox)
        Me.Controls.Add(Me.lblEmployeeInformation)
        Me.Controls.Add(Me.EmployeeBindingNavigator)
        Me.Name = "Employee"
        Me.Text = "Employee"
        CType(Me.EmployeeBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EmployeeBindingNavigator.ResumeLayout(False)
        Me.EmployeeBindingNavigator.PerformLayout()
        CType(Me.EmployeePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLogoEmployee, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeTypeHistoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillBy1ToolStrip.ResumeLayout(False)
        Me.FillBy1ToolStrip.PerformLayout()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SanchezPizzeriaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SanchezPizzeriaDataSet As SanchezPizzeriaDataSet
    Friend WithEvents EmployeeBindingSource As BindingSource
    Friend WithEvents EmployeeTableAdapter As SanchezPizzeriaDataSetTableAdapters.EmployeeTableAdapter
    Friend WithEvents TableAdapterManager As SanchezPizzeriaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EmployeeBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents EmployeeBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents lblEmployeeInformation As Label
    Friend WithEvents EmployeePictureBox As PictureBox
    Friend WithEvents picLogoEmployee As PictureBox
    Friend WithEvents btnUploadPhoto As Button
    Friend WithEvents btnDeletePhoto As Button
    Friend WithEvents btnBrowse As Button
    Friend WithEvents txtFileName As TextBox
    Friend WithEvents EmployeeTypeHistoryBindingSource As BindingSource
    Friend WithEvents EmployeeTypeHistoryTableAdapter As SanchezPizzeriaDataSetTableAdapters.EmployeeTypeHistoryTableAdapter
    Friend WithEvents EmployeeTypeIDTextBox As TextBox
    Friend WithEvents EmployeeIDTextBox1 As TextBox
    Friend WithEvents BeginDateDateTimePicker As DateTimePicker
    Friend WithEvents EndDateDateTimePicker As DateTimePicker
    Friend WithEvents EmployeeIDTextBox2 As TextBox
    Friend WithEvents LastNameTextBox1 As TextBox
    Friend WithEvents FirstNameTextBox1 As TextBox
    Friend WithEvents PhoneNumberTextBox1 As TextBox
    Friend WithEvents BirthDateDateTimePicker1 As DateTimePicker
    Friend WithEvents HireDateDateTimePicker As DateTimePicker
    Friend WithEvents GenderComboBox1 As ComboBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents FillBy1ToolStrip As ToolStrip
    Friend WithEvents LastNameToolStripLabel As ToolStripLabel
    Friend WithEvents LastNameToolStripTextBox As ToolStripTextBox
    Friend WithEvents FillBy1ToolStripButton As ToolStripButton
End Class
