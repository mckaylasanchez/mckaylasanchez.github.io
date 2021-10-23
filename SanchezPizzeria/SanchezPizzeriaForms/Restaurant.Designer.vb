<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Restaurant
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
        Me.components = New System.ComponentModel.Container()
        Dim StreetAddressLabel As System.Windows.Forms.Label
        Dim CityLabel As System.Windows.Forms.Label
        Dim StateLabel As System.Windows.Forms.Label
        Dim ZipCodeLabel As System.Windows.Forms.Label
        Dim PhoneNumberLabel As System.Windows.Forms.Label
        Dim lblRestaurantLocation As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Restaurant))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SanchezPizzeriaDataSet = New SanchezPizzeria.SanchezPizzeriaDataSet()
        Me.RestaurantBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RestaurantTableAdapter = New SanchezPizzeria.SanchezPizzeriaDataSetTableAdapters.RestaurantTableAdapter()
        Me.TableAdapterManager = New SanchezPizzeria.SanchezPizzeriaDataSetTableAdapters.TableAdapterManager()
        Me.OrderTableAdapter = New SanchezPizzeria.SanchezPizzeriaDataSetTableAdapters.OrderTableAdapter()
        Me.RestaurantBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.RestaurantBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.StreetAddressTextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.StateTextBox = New System.Windows.Forms.TextBox()
        Me.ZipCodeTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneNumberTextBox = New System.Windows.Forms.TextBox()
        Me.OrderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderDataGridView = New System.Windows.Forms.DataGridView()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FillBy1ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.RestaurantIDToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.txtRestaurant = New System.Windows.Forms.ToolStripTextBox()
        Me.FillBy1ToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.RestaurantIDComboBox = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CustomerTableAdapter = New SanchezPizzeria.SanchezPizzeriaDataSetTableAdapters.CustomerTableAdapter()
        Me.lblRestaurant = New System.Windows.Forms.Label()
        Me.EmployeeTableAdapter = New SanchezPizzeria.SanchezPizzeriaDataSetTableAdapters.EmployeeTableAdapter()
        Me.lblCashBox = New System.Windows.Forms.Label()
        Me.CashBox = New System.Windows.Forms.Label()
        Me.lblCardBox = New System.Windows.Forms.Label()
        Me.CardBox = New System.Windows.Forms.Label()
        Me.TotalTextBox = New System.Windows.Forms.Label()
        Me.lblTotalTextBox = New System.Windows.Forms.Label()
        Me.LoyalCustomer2 = New System.Windows.Forms.Label()
        Me.RBox = New System.Windows.Forms.Label()
        Me.LoyalCustomer3 = New System.Windows.Forms.Label()
        Me.NRBox = New System.Windows.Forms.Label()
        Me.OrderID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerName = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaymentType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Reservation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        StreetAddressLabel = New System.Windows.Forms.Label()
        CityLabel = New System.Windows.Forms.Label()
        StateLabel = New System.Windows.Forms.Label()
        ZipCodeLabel = New System.Windows.Forms.Label()
        PhoneNumberLabel = New System.Windows.Forms.Label()
        lblRestaurantLocation = New System.Windows.Forms.Label()
        CType(Me.SanchezPizzeriaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RestaurantBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RestaurantBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RestaurantBindingNavigator.SuspendLayout()
        CType(Me.OrderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillBy1ToolStrip.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StreetAddressLabel
        '
        StreetAddressLabel.AutoSize = True
        StreetAddressLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StreetAddressLabel.Location = New System.Drawing.Point(30, 141)
        StreetAddressLabel.Name = "StreetAddressLabel"
        StreetAddressLabel.Size = New System.Drawing.Size(135, 20)
        StreetAddressLabel.TabIndex = 3
        StreetAddressLabel.Text = "Street Address:"
        '
        'CityLabel
        '
        CityLabel.AutoSize = True
        CityLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CityLabel.Location = New System.Drawing.Point(121, 182)
        CityLabel.Name = "CityLabel"
        CityLabel.Size = New System.Drawing.Size(44, 20)
        CityLabel.TabIndex = 5
        CityLabel.Text = "City:"
        '
        'StateLabel
        '
        StateLabel.AutoSize = True
        StateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StateLabel.Location = New System.Drawing.Point(107, 220)
        StateLabel.Name = "StateLabel"
        StateLabel.Size = New System.Drawing.Size(58, 20)
        StateLabel.TabIndex = 7
        StateLabel.Text = "State:"
        '
        'ZipCodeLabel
        '
        ZipCodeLabel.AutoSize = True
        ZipCodeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ZipCodeLabel.Location = New System.Drawing.Point(79, 261)
        ZipCodeLabel.Name = "ZipCodeLabel"
        ZipCodeLabel.Size = New System.Drawing.Size(86, 20)
        ZipCodeLabel.TabIndex = 9
        ZipCodeLabel.Text = "Zip Code:"
        '
        'PhoneNumberLabel
        '
        PhoneNumberLabel.AutoSize = True
        PhoneNumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PhoneNumberLabel.Location = New System.Drawing.Point(510, 208)
        PhoneNumberLabel.Name = "PhoneNumberLabel"
        PhoneNumberLabel.Size = New System.Drawing.Size(132, 20)
        PhoneNumberLabel.TabIndex = 11
        PhoneNumberLabel.Text = "Phone Number:"
        '
        'lblRestaurantLocation
        '
        lblRestaurantLocation.AutoSize = True
        lblRestaurantLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblRestaurantLocation.Location = New System.Drawing.Point(496, 168)
        lblRestaurantLocation.Name = "lblRestaurantLocation"
        lblRestaurantLocation.Size = New System.Drawing.Size(178, 20)
        lblRestaurantLocation.TabIndex = 15
        lblRestaurantLocation.Text = "Restaurant Location:"
        '
        'SanchezPizzeriaDataSet
        '
        Me.SanchezPizzeriaDataSet.DataSetName = "SanchezPizzeriaDataSet"
        Me.SanchezPizzeriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RestaurantBindingSource
        '
        Me.RestaurantBindingSource.DataMember = "Restaurant"
        Me.RestaurantBindingSource.DataSource = Me.SanchezPizzeriaDataSet
        '
        'RestaurantTableAdapter
        '
        Me.RestaurantTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CustomerTableAdapter = Nothing
        Me.TableAdapterManager.EmployeeTableAdapter = Nothing
        Me.TableAdapterManager.EmployeeTypeHistoryTableAdapter = Nothing
        Me.TableAdapterManager.EmployeeTypeTableAdapter = Nothing
        Me.TableAdapterManager.OrderLineTableAdapter = Nothing
        Me.TableAdapterManager.OrderTableAdapter = Me.OrderTableAdapter
        Me.TableAdapterManager.ProductTableAdapter = Nothing
        Me.TableAdapterManager.ProductTypeTableAdapter = Nothing
        Me.TableAdapterManager.RestaurantTableAdapter = Me.RestaurantTableAdapter
        Me.TableAdapterManager.UpdateOrder = SanchezPizzeria.SanchezPizzeriaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'OrderTableAdapter
        '
        Me.OrderTableAdapter.ClearBeforeFill = True
        '
        'RestaurantBindingNavigator
        '
        Me.RestaurantBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.RestaurantBindingNavigator.BindingSource = Me.RestaurantBindingSource
        Me.RestaurantBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.RestaurantBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.RestaurantBindingNavigator.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.RestaurantBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.RestaurantBindingNavigatorSaveItem})
        Me.RestaurantBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.RestaurantBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.RestaurantBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.RestaurantBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.RestaurantBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.RestaurantBindingNavigator.Name = "RestaurantBindingNavigator"
        Me.RestaurantBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.RestaurantBindingNavigator.Size = New System.Drawing.Size(1437, 33)
        Me.RestaurantBindingNavigator.TabIndex = 0
        Me.RestaurantBindingNavigator.Text = "BindingNavigator1"
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
        'RestaurantBindingNavigatorSaveItem
        '
        Me.RestaurantBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RestaurantBindingNavigatorSaveItem.Enabled = False
        Me.RestaurantBindingNavigatorSaveItem.Image = CType(resources.GetObject("RestaurantBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.RestaurantBindingNavigatorSaveItem.Name = "RestaurantBindingNavigatorSaveItem"
        Me.RestaurantBindingNavigatorSaveItem.Size = New System.Drawing.Size(34, 28)
        Me.RestaurantBindingNavigatorSaveItem.Text = "Save Data"
        '
        'StreetAddressTextBox
        '
        Me.StreetAddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RestaurantBindingSource, "StreetAddress", True))
        Me.StreetAddressTextBox.Location = New System.Drawing.Point(176, 138)
        Me.StreetAddressTextBox.Name = "StreetAddressTextBox"
        Me.StreetAddressTextBox.Size = New System.Drawing.Size(176, 26)
        Me.StreetAddressTextBox.TabIndex = 4
        '
        'CityTextBox
        '
        Me.CityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RestaurantBindingSource, "City", True))
        Me.CityTextBox.Location = New System.Drawing.Point(176, 179)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(176, 26)
        Me.CityTextBox.TabIndex = 6
        '
        'StateTextBox
        '
        Me.StateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RestaurantBindingSource, "State", True))
        Me.StateTextBox.Location = New System.Drawing.Point(176, 217)
        Me.StateTextBox.Name = "StateTextBox"
        Me.StateTextBox.Size = New System.Drawing.Size(176, 26)
        Me.StateTextBox.TabIndex = 8
        '
        'ZipCodeTextBox
        '
        Me.ZipCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RestaurantBindingSource, "ZipCode", True))
        Me.ZipCodeTextBox.Location = New System.Drawing.Point(176, 258)
        Me.ZipCodeTextBox.Name = "ZipCodeTextBox"
        Me.ZipCodeTextBox.Size = New System.Drawing.Size(176, 26)
        Me.ZipCodeTextBox.TabIndex = 10
        '
        'PhoneNumberTextBox
        '
        Me.PhoneNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RestaurantBindingSource, "PhoneNumber", True))
        Me.PhoneNumberTextBox.Location = New System.Drawing.Point(651, 205)
        Me.PhoneNumberTextBox.Name = "PhoneNumberTextBox"
        Me.PhoneNumberTextBox.Size = New System.Drawing.Size(176, 26)
        Me.PhoneNumberTextBox.TabIndex = 12
        '
        'OrderBindingSource
        '
        Me.OrderBindingSource.DataMember = "fk_restaurant_order"
        Me.OrderBindingSource.DataSource = Me.RestaurantBindingSource
        '
        'OrderDataGridView
        '
        Me.OrderDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.OrderDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.OrderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.OrderDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OrderID, Me.CustomerName, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.PaymentType, Me.Reservation})
        Me.OrderDataGridView.DataSource = Me.OrderBindingSource
        Me.OrderDataGridView.Location = New System.Drawing.Point(25, 338)
        Me.OrderDataGridView.Name = "OrderDataGridView"
        Me.OrderDataGridView.RowHeadersWidth = 62
        Me.OrderDataGridView.RowTemplate.Height = 28
        Me.OrderDataGridView.Size = New System.Drawing.Size(1382, 507)
        Me.OrderDataGridView.TabIndex = 13
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataMember = "Customer"
        Me.CustomerBindingSource.DataSource = Me.SanchezPizzeriaDataSet
        '
        'EmployeeBindingSource
        '
        Me.EmployeeBindingSource.DataMember = "Employee"
        Me.EmployeeBindingSource.DataSource = Me.SanchezPizzeriaDataSet
        '
        'FillBy1ToolStrip
        '
        Me.FillBy1ToolStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.FillBy1ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RestaurantIDToolStripLabel, Me.txtRestaurant, Me.FillBy1ToolStripButton})
        Me.FillBy1ToolStrip.Location = New System.Drawing.Point(0, 33)
        Me.FillBy1ToolStrip.Name = "FillBy1ToolStrip"
        Me.FillBy1ToolStrip.Size = New System.Drawing.Size(1437, 34)
        Me.FillBy1ToolStrip.TabIndex = 14
        Me.FillBy1ToolStrip.Text = "FillBy1ToolStrip"
        '
        'RestaurantIDToolStripLabel
        '
        Me.RestaurantIDToolStripLabel.Name = "RestaurantIDToolStripLabel"
        Me.RestaurantIDToolStripLabel.Size = New System.Drawing.Size(117, 29)
        Me.RestaurantIDToolStripLabel.Text = "RestaurantID:"
        '
        'txtRestaurant
        '
        Me.txtRestaurant.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtRestaurant.Name = "txtRestaurant"
        Me.txtRestaurant.Size = New System.Drawing.Size(100, 34)
        '
        'FillBy1ToolStripButton
        '
        Me.FillBy1ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillBy1ToolStripButton.Name = "FillBy1ToolStripButton"
        Me.FillBy1ToolStripButton.Size = New System.Drawing.Size(68, 29)
        Me.FillBy1ToolStripButton.Text = "Search"
        '
        'RestaurantIDComboBox
        '
        Me.RestaurantIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RestaurantBindingSource, "RestaurantID", True))
        Me.RestaurantIDComboBox.DataSource = Me.RestaurantBindingSource
        Me.RestaurantIDComboBox.DisplayMember = "City"
        Me.RestaurantIDComboBox.FormattingEnabled = True
        Me.RestaurantIDComboBox.Location = New System.Drawing.Point(690, 165)
        Me.RestaurantIDComboBox.Name = "RestaurantIDComboBox"
        Me.RestaurantIDComboBox.Size = New System.Drawing.Size(137, 28)
        Me.RestaurantIDComboBox.TabIndex = 16
        Me.RestaurantIDComboBox.ValueMember = "RestaurantID"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1053, 102)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(250, 211)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'lblRestaurant
        '
        Me.lblRestaurant.AutoSize = True
        Me.lblRestaurant.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRestaurant.Location = New System.Drawing.Point(543, 102)
        Me.lblRestaurant.Name = "lblRestaurant"
        Me.lblRestaurant.Size = New System.Drawing.Size(275, 29)
        Me.lblRestaurant.TabIndex = 18
        Me.lblRestaurant.Text = "Restaurant Information"
        '
        'EmployeeTableAdapter
        '
        Me.EmployeeTableAdapter.ClearBeforeFill = True
        '
        'lblCashBox
        '
        Me.lblCashBox.AutoSize = True
        Me.lblCashBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCashBox.Location = New System.Drawing.Point(896, 888)
        Me.lblCashBox.Name = "lblCashBox"
        Me.lblCashBox.Size = New System.Drawing.Size(138, 20)
        Me.lblCashBox.TabIndex = 20
        Me.lblCashBox.Text = "Cash Payments:"
        '
        'CashBox
        '
        Me.CashBox.AutoSize = True
        Me.CashBox.Location = New System.Drawing.Point(1048, 888)
        Me.CashBox.Name = "CashBox"
        Me.CashBox.Size = New System.Drawing.Size(21, 20)
        Me.CashBox.TabIndex = 21
        Me.CashBox.Text = "   "
        '
        'lblCardBox
        '
        Me.lblCardBox.AutoSize = True
        Me.lblCardBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCardBox.Location = New System.Drawing.Point(1097, 888)
        Me.lblCardBox.Name = "lblCardBox"
        Me.lblCardBox.Size = New System.Drawing.Size(135, 20)
        Me.lblCardBox.TabIndex = 22
        Me.lblCardBox.Text = "Card Payments:"
        '
        'CardBox
        '
        Me.CardBox.AutoSize = True
        Me.CardBox.Location = New System.Drawing.Point(1248, 889)
        Me.CardBox.Name = "CardBox"
        Me.CardBox.Size = New System.Drawing.Size(21, 20)
        Me.CardBox.TabIndex = 23
        Me.CardBox.Text = "   "
        '
        'TotalTextBox
        '
        Me.TotalTextBox.AutoSize = True
        Me.TotalTextBox.Location = New System.Drawing.Point(819, 293)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.Size = New System.Drawing.Size(21, 20)
        Me.TotalTextBox.TabIndex = 24
        Me.TotalTextBox.Text = "   "
        '
        'lblTotalTextBox
        '
        Me.lblTotalTextBox.AutoSize = True
        Me.lblTotalTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalTextBox.Location = New System.Drawing.Point(700, 293)
        Me.lblTotalTextBox.Name = "lblTotalTextBox"
        Me.lblTotalTextBox.Size = New System.Drawing.Size(113, 20)
        Me.lblTotalTextBox.TabIndex = 25
        Me.lblTotalTextBox.Text = "Total Orders:"
        '
        'LoyalCustomer2
        '
        Me.LoyalCustomer2.AutoSize = True
        Me.LoyalCustomer2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoyalCustomer2.Location = New System.Drawing.Point(555, 888)
        Me.LoyalCustomer2.Name = "LoyalCustomer2"
        Me.LoyalCustomer2.Size = New System.Drawing.Size(119, 20)
        Me.LoyalCustomer2.TabIndex = 30
        Me.LoyalCustomer2.Text = "Reservations:"
        '
        'RBox
        '
        Me.RBox.AutoSize = True
        Me.RBox.Location = New System.Drawing.Point(688, 888)
        Me.RBox.Name = "RBox"
        Me.RBox.Size = New System.Drawing.Size(21, 20)
        Me.RBox.TabIndex = 31
        Me.RBox.Text = "   "
        '
        'LoyalCustomer3
        '
        Me.LoyalCustomer3.AutoSize = True
        Me.LoyalCustomer3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoyalCustomer3.Location = New System.Drawing.Point(731, 888)
        Me.LoyalCustomer3.Name = "LoyalCustomer3"
        Me.LoyalCustomer3.Size = New System.Drawing.Size(84, 20)
        Me.LoyalCustomer3.TabIndex = 32
        Me.LoyalCustomer3.Text = "Walk-Ins:"
        '
        'NRBox
        '
        Me.NRBox.AutoSize = True
        Me.NRBox.Location = New System.Drawing.Point(829, 888)
        Me.NRBox.Name = "NRBox"
        Me.NRBox.Size = New System.Drawing.Size(21, 20)
        Me.NRBox.TabIndex = 33
        Me.NRBox.Text = "   "
        '
        'OrderID
        '
        Me.OrderID.DataPropertyName = "OrderID"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.OrderID.DefaultCellStyle = DataGridViewCellStyle2
        Me.OrderID.HeaderText = "Order ID"
        Me.OrderID.MinimumWidth = 8
        Me.OrderID.Name = "OrderID"
        Me.OrderID.Width = 85
        '
        'CustomerName
        '
        Me.CustomerName.DataPropertyName = "CustomerID"
        Me.CustomerName.DataSource = Me.CustomerBindingSource
        Me.CustomerName.DisplayMember = "CustomerFullName"
        Me.CustomerName.HeaderText = "Customer Name"
        Me.CustomerName.MinimumWidth = 8
        Me.CustomerName.Name = "CustomerName"
        Me.CustomerName.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CustomerName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.CustomerName.ValueMember = "CustomerID"
        Me.CustomerName.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "EmployeeID"
        Me.DataGridViewTextBoxColumn3.DataSource = Me.EmployeeBindingSource
        Me.DataGridViewTextBoxColumn3.DisplayMember = "EmployeeFullName"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Employee Name"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn3.ValueMember = "EmployeeID"
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "RestaurantID"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn4.HeaderText = "Restaurant ID"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 120
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Date"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Order Date"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 115
        '
        'PaymentType
        '
        Me.PaymentType.DataPropertyName = "PaymentType"
        Me.PaymentType.HeaderText = "Payment Type"
        Me.PaymentType.MinimumWidth = 8
        Me.PaymentType.Name = "PaymentType"
        Me.PaymentType.Width = 120
        '
        'Reservation
        '
        Me.Reservation.DataPropertyName = "Reservation"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Reservation.DefaultCellStyle = DataGridViewCellStyle4
        Me.Reservation.HeaderText = "Reservation"
        Me.Reservation.MinimumWidth = 8
        Me.Reservation.Name = "Reservation"
        Me.Reservation.Width = 90
        '
        'Restaurant
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(1437, 1001)
        Me.Controls.Add(Me.NRBox)
        Me.Controls.Add(Me.LoyalCustomer3)
        Me.Controls.Add(Me.RBox)
        Me.Controls.Add(Me.LoyalCustomer2)
        Me.Controls.Add(Me.lblTotalTextBox)
        Me.Controls.Add(Me.TotalTextBox)
        Me.Controls.Add(Me.CardBox)
        Me.Controls.Add(Me.lblCardBox)
        Me.Controls.Add(Me.CashBox)
        Me.Controls.Add(Me.lblCashBox)
        Me.Controls.Add(Me.lblRestaurant)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(lblRestaurantLocation)
        Me.Controls.Add(Me.RestaurantIDComboBox)
        Me.Controls.Add(Me.FillBy1ToolStrip)
        Me.Controls.Add(Me.OrderDataGridView)
        Me.Controls.Add(StreetAddressLabel)
        Me.Controls.Add(Me.StreetAddressTextBox)
        Me.Controls.Add(CityLabel)
        Me.Controls.Add(Me.CityTextBox)
        Me.Controls.Add(StateLabel)
        Me.Controls.Add(Me.StateTextBox)
        Me.Controls.Add(ZipCodeLabel)
        Me.Controls.Add(Me.ZipCodeTextBox)
        Me.Controls.Add(PhoneNumberLabel)
        Me.Controls.Add(Me.PhoneNumberTextBox)
        Me.Controls.Add(Me.RestaurantBindingNavigator)
        Me.Name = "Restaurant"
        Me.Text = "Restaurant"
        CType(Me.SanchezPizzeriaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RestaurantBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RestaurantBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RestaurantBindingNavigator.ResumeLayout(False)
        Me.RestaurantBindingNavigator.PerformLayout()
        CType(Me.OrderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillBy1ToolStrip.ResumeLayout(False)
        Me.FillBy1ToolStrip.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SanchezPizzeriaDataSet As SanchezPizzeriaDataSet
    Friend WithEvents RestaurantBindingSource As BindingSource
    Friend WithEvents RestaurantTableAdapter As SanchezPizzeriaDataSetTableAdapters.RestaurantTableAdapter
    Friend WithEvents TableAdapterManager As SanchezPizzeriaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents RestaurantBindingNavigator As BindingNavigator
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
    Friend WithEvents RestaurantBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents StreetAddressTextBox As TextBox
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents StateTextBox As TextBox
    Friend WithEvents ZipCodeTextBox As TextBox
    Friend WithEvents PhoneNumberTextBox As TextBox
    Friend WithEvents OrderTableAdapter As SanchezPizzeriaDataSetTableAdapters.OrderTableAdapter
    Friend WithEvents OrderBindingSource As BindingSource
    Friend WithEvents OrderDataGridView As DataGridView
    Friend WithEvents FillBy1ToolStrip As ToolStrip
    Friend WithEvents RestaurantIDToolStripLabel As ToolStripLabel
    Friend WithEvents txtRestaurant As ToolStripTextBox
    Friend WithEvents FillBy1ToolStripButton As ToolStripButton
    Friend WithEvents RestaurantIDComboBox As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CustomerBindingSource As BindingSource
    Friend WithEvents CustomerTableAdapter As SanchezPizzeriaDataSetTableAdapters.CustomerTableAdapter
    Friend WithEvents lblRestaurant As Label
    Friend WithEvents EmployeeBindingSource As BindingSource
    Friend WithEvents EmployeeTableAdapter As SanchezPizzeriaDataSetTableAdapters.EmployeeTableAdapter
    Friend WithEvents lblCashBox As Label
    Friend WithEvents CashBox As Label
    Friend WithEvents lblCardBox As Label
    Friend WithEvents CardBox As Label
    Friend WithEvents TotalTextBox As Label
    Friend WithEvents lblTotalTextBox As Label
    Friend WithEvents LoyalCustomer2 As Label
    Friend WithEvents RBox As Label
    Friend WithEvents LoyalCustomer3 As Label
    Friend WithEvents NRBox As Label
    Friend WithEvents OrderID As DataGridViewTextBoxColumn
    Friend WithEvents CustomerName As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents PaymentType As DataGridViewTextBoxColumn
    Friend WithEvents Reservation As DataGridViewTextBoxColumn
End Class
