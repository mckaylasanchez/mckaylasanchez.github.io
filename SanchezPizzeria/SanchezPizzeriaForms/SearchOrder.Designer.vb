<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchOrder
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
        Dim lblBeginDate As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SearchOrder))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.SanchezPizzeriaDataSet = New SanchezPizzeria.SanchezPizzeriaDataSet()
        Me.RestaurantBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RestaurantTableAdapter = New SanchezPizzeria.SanchezPizzeriaDataSetTableAdapters.RestaurantTableAdapter()
        Me.TableAdapterManager = New SanchezPizzeria.SanchezPizzeriaDataSetTableAdapters.TableAdapterManager()
        Me.OrderTableAdapter = New SanchezPizzeria.SanchezPizzeriaDataSetTableAdapters.OrderTableAdapter()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerTableAdapter = New SanchezPizzeria.SanchezPizzeriaDataSetTableAdapters.CustomerTableAdapter()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SanchezPizzeriaDataSet1 = New SanchezPizzeria.SanchezPizzeriaDataSet()
        Me.dtpBeginDate = New System.Windows.Forms.DateTimePicker()
        Me.OrderLineBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderLineTableAdapter = New SanchezPizzeria.SanchezPizzeriaDataSetTableAdapters.OrderLineTableAdapter()
        Me.lblEndDate = New System.Windows.Forms.Label()
        Me.dtpEndDate = New System.Windows.Forms.DateTimePicker()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.CustomerPurchasesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerPurchasesTableAdapter = New SanchezPizzeria.SanchezPizzeriaDataSetTableAdapters.CustomerPurchasesTableAdapter()
        Me.ProductTableAdapter = New SanchezPizzeria.SanchezPizzeriaDataSetTableAdapters.ProductTableAdapter()
        Me.lblCustomerName = New System.Windows.Forms.Label()
        Me.cboCustomerName = New System.Windows.Forms.ComboBox()
        Me.CustomerOrderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerOrderTableAdapter = New SanchezPizzeria.SanchezPizzeriaDataSetTableAdapters.CustomerOrderTableAdapter()
        Me.CustomerOrderDataGridView = New System.Windows.Forms.DataGridView()
        Me.lblSum = New System.Windows.Forms.Label()
        Me.lblTotalSpent = New System.Windows.Forms.Label()
        Me.btnListAll = New System.Windows.Forms.Button()
        Me.lblTotalQuantity = New System.Windows.Forms.Label()
        Me.lblTotalQuant = New System.Windows.Forms.Label()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        lblBeginDate = New System.Windows.Forms.Label()
        CType(Me.SanchezPizzeriaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RestaurantBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SanchezPizzeriaDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderLineBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerPurchasesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerOrderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerOrderDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblBeginDate
        '
        lblBeginDate.AutoSize = True
        lblBeginDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblBeginDate.Location = New System.Drawing.Point(28, 200)
        lblBeginDate.Name = "lblBeginDate"
        lblBeginDate.Size = New System.Drawing.Size(188, 20)
        lblBeginDate.TabIndex = 24
        lblBeginDate.Text = "Beginning Order Date:"
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearch.Location = New System.Drawing.Point(595, 93)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(170, 29)
        Me.lblSearch.TabIndex = 0
        Me.lblSearch.Text = "Search Order"
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
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataMember = "Customer"
        Me.CustomerBindingSource.DataSource = Me.SanchezPizzeriaDataSet
        '
        'OrderBindingSource
        '
        Me.OrderBindingSource.DataMember = "fk_restaurant_order"
        Me.OrderBindingSource.DataSource = Me.RestaurantBindingSource
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1179, 93)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(250, 211)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'ProductBindingSource
        '
        Me.ProductBindingSource.DataMember = "Product"
        Me.ProductBindingSource.DataSource = Me.SanchezPizzeriaDataSet1
        '
        'SanchezPizzeriaDataSet1
        '
        Me.SanchezPizzeriaDataSet1.DataSetName = "SanchezPizzeriaDataSet"
        Me.SanchezPizzeriaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dtpBeginDate
        '
        Me.dtpBeginDate.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OrderBindingSource, "Date", True))
        Me.dtpBeginDate.Location = New System.Drawing.Point(233, 198)
        Me.dtpBeginDate.Name = "dtpBeginDate"
        Me.dtpBeginDate.Size = New System.Drawing.Size(305, 26)
        Me.dtpBeginDate.TabIndex = 25
        Me.dtpBeginDate.Value = New Date(2020, 1, 2, 0, 0, 0, 0)
        '
        'OrderLineBindingSource
        '
        Me.OrderLineBindingSource.DataMember = "fk_order_line_order"
        Me.OrderLineBindingSource.DataSource = Me.OrderBindingSource
        '
        'OrderLineTableAdapter
        '
        Me.OrderLineTableAdapter.ClearBeforeFill = True
        '
        'lblEndDate
        '
        Me.lblEndDate.AutoSize = True
        Me.lblEndDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEndDate.Location = New System.Drawing.Point(52, 248)
        Me.lblEndDate.Name = "lblEndDate"
        Me.lblEndDate.Size = New System.Drawing.Size(164, 20)
        Me.lblEndDate.TabIndex = 27
        Me.lblEndDate.Text = "Ending Order Date:"
        '
        'dtpEndDate
        '
        Me.dtpEndDate.Location = New System.Drawing.Point(233, 243)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(305, 26)
        Me.dtpEndDate.TabIndex = 28
        Me.dtpEndDate.Value = New Date(2021, 5, 15, 0, 0, 0, 0)
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(740, 266)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(104, 38)
        Me.btnSearch.TabIndex = 29
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'CustomerPurchasesBindingSource
        '
        Me.CustomerPurchasesBindingSource.DataMember = "CustomerPurchases"
        Me.CustomerPurchasesBindingSource.DataSource = Me.SanchezPizzeriaDataSet
        '
        'CustomerPurchasesTableAdapter
        '
        Me.CustomerPurchasesTableAdapter.ClearBeforeFill = True
        '
        'ProductTableAdapter
        '
        Me.ProductTableAdapter.ClearBeforeFill = True
        '
        'lblCustomerName
        '
        Me.lblCustomerName.AutoSize = True
        Me.lblCustomerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerName.Location = New System.Drawing.Point(596, 195)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(214, 20)
        Me.lblCustomerName.TabIndex = 30
        Me.lblCustomerName.Text = "Customer Phone Number:"
        '
        'cboCustomerName
        '
        Me.cboCustomerName.DataSource = Me.CustomerBindingSource
        Me.cboCustomerName.DisplayMember = "PhoneNumber"
        Me.cboCustomerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCustomerName.FormattingEnabled = True
        Me.cboCustomerName.Location = New System.Drawing.Point(823, 192)
        Me.cboCustomerName.Name = "cboCustomerName"
        Me.cboCustomerName.Size = New System.Drawing.Size(192, 28)
        Me.cboCustomerName.TabIndex = 31
        Me.cboCustomerName.ValueMember = "PhoneNumber"
        '
        'CustomerOrderBindingSource
        '
        Me.CustomerOrderBindingSource.DataMember = "CustomerOrder"
        Me.CustomerOrderBindingSource.DataSource = Me.SanchezPizzeriaDataSet
        '
        'CustomerOrderTableAdapter
        '
        Me.CustomerOrderTableAdapter.ClearBeforeFill = True
        '
        'CustomerOrderDataGridView
        '
        Me.CustomerOrderDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CustomerOrderDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.CustomerOrderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CustomerOrderDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.Quantity, Me.Price})
        Me.CustomerOrderDataGridView.DataSource = Me.CustomerOrderBindingSource
        Me.CustomerOrderDataGridView.Location = New System.Drawing.Point(32, 395)
        Me.CustomerOrderDataGridView.Name = "CustomerOrderDataGridView"
        Me.CustomerOrderDataGridView.RowHeadersWidth = 62
        Me.CustomerOrderDataGridView.RowTemplate.Height = 28
        Me.CustomerOrderDataGridView.Size = New System.Drawing.Size(1457, 489)
        Me.CustomerOrderDataGridView.TabIndex = 37
        '
        'lblSum
        '
        Me.lblSum.AutoSize = True
        Me.lblSum.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSum.Location = New System.Drawing.Point(1198, 905)
        Me.lblSum.Name = "lblSum"
        Me.lblSum.Size = New System.Drawing.Size(107, 20)
        Me.lblSum.TabIndex = 38
        Me.lblSum.Text = "Total Spent:"
        '
        'lblTotalSpent
        '
        Me.lblTotalSpent.AutoSize = True
        Me.lblTotalSpent.Location = New System.Drawing.Point(1318, 905)
        Me.lblTotalSpent.Name = "lblTotalSpent"
        Me.lblTotalSpent.Size = New System.Drawing.Size(18, 20)
        Me.lblTotalSpent.TabIndex = 39
        Me.lblTotalSpent.Text = "0"
        '
        'btnListAll
        '
        Me.btnListAll.Location = New System.Drawing.Point(897, 266)
        Me.btnListAll.Name = "btnListAll"
        Me.btnListAll.Size = New System.Drawing.Size(118, 38)
        Me.btnListAll.TabIndex = 40
        Me.btnListAll.Text = "List All Orders"
        Me.btnListAll.UseVisualStyleBackColor = True
        '
        'lblTotalQuantity
        '
        Me.lblTotalQuantity.AutoSize = True
        Me.lblTotalQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalQuantity.Location = New System.Drawing.Point(1198, 938)
        Me.lblTotalQuantity.Name = "lblTotalQuantity"
        Me.lblTotalQuantity.Size = New System.Drawing.Size(126, 20)
        Me.lblTotalQuantity.TabIndex = 41
        Me.lblTotalQuantity.Text = "Total Quantity:"
        '
        'lblTotalQuant
        '
        Me.lblTotalQuant.AutoSize = True
        Me.lblTotalQuant.Location = New System.Drawing.Point(1337, 938)
        Me.lblTotalQuant.Name = "lblTotalQuant"
        Me.lblTotalQuant.Size = New System.Drawing.Size(18, 20)
        Me.lblTotalQuant.TabIndex = 42
        Me.lblTotalQuant.Text = "0"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "FirstName"
        Me.DataGridViewTextBoxColumn1.HeaderText = "First Name"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "LastName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Last Name"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "PhoneNumber"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Phone Number"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 140
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "OrderID"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn4.HeaderText = "Order ID"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Date"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Order Date"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 125
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Name"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'Quantity
        '
        Me.Quantity.DataPropertyName = "Quantity"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Quantity.DefaultCellStyle = DataGridViewCellStyle3
        Me.Quantity.HeaderText = "Quantity"
        Me.Quantity.MinimumWidth = 8
        Me.Quantity.Name = "Quantity"
        Me.Quantity.Width = 75
        '
        'Price
        '
        Me.Price.DataPropertyName = "Price"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "$#0.00"
        Me.Price.DefaultCellStyle = DataGridViewCellStyle4
        Me.Price.HeaderText = "Price"
        Me.Price.MinimumWidth = 8
        Me.Price.Name = "Price"
        Me.Price.Width = 60
        '
        'SearchOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(1501, 1044)
        Me.Controls.Add(Me.lblTotalQuant)
        Me.Controls.Add(Me.lblTotalQuantity)
        Me.Controls.Add(Me.btnListAll)
        Me.Controls.Add(Me.lblTotalSpent)
        Me.Controls.Add(Me.lblSum)
        Me.Controls.Add(Me.CustomerOrderDataGridView)
        Me.Controls.Add(Me.cboCustomerName)
        Me.Controls.Add(Me.lblCustomerName)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.dtpEndDate)
        Me.Controls.Add(Me.lblEndDate)
        Me.Controls.Add(lblBeginDate)
        Me.Controls.Add(Me.dtpBeginDate)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblSearch)
        Me.Name = "SearchOrder"
        Me.Text = "Search Order"
        CType(Me.SanchezPizzeriaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RestaurantBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SanchezPizzeriaDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderLineBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerPurchasesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerOrderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerOrderDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSearch As Label
    Friend WithEvents SanchezPizzeriaDataSet As SanchezPizzeriaDataSet
    Friend WithEvents RestaurantBindingSource As BindingSource
    Friend WithEvents RestaurantTableAdapter As SanchezPizzeriaDataSetTableAdapters.RestaurantTableAdapter
    Friend WithEvents TableAdapterManager As SanchezPizzeriaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents OrderTableAdapter As SanchezPizzeriaDataSetTableAdapters.OrderTableAdapter
    Friend WithEvents OrderBindingSource As BindingSource
    Friend WithEvents CustomerBindingSource As BindingSource
    Friend WithEvents CustomerTableAdapter As SanchezPizzeriaDataSetTableAdapters.CustomerTableAdapter
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents dtpBeginDate As DateTimePicker
    Friend WithEvents OrderLineBindingSource As BindingSource
    Friend WithEvents OrderLineTableAdapter As SanchezPizzeriaDataSetTableAdapters.OrderLineTableAdapter
    Friend WithEvents lblEndDate As Label
    Friend WithEvents dtpEndDate As DateTimePicker
    Friend WithEvents btnSearch As Button
    Friend WithEvents CustomerPurchasesBindingSource As BindingSource
    Friend WithEvents CustomerPurchasesTableAdapter As SanchezPizzeriaDataSetTableAdapters.CustomerPurchasesTableAdapter
    Friend WithEvents SanchezPizzeriaDataSet1 As SanchezPizzeriaDataSet
    Friend WithEvents ProductBindingSource As BindingSource
    Friend WithEvents ProductTableAdapter As SanchezPizzeriaDataSetTableAdapters.ProductTableAdapter
    Friend WithEvents lblCustomerName As Label
    Friend WithEvents cboCustomerName As ComboBox
    Friend WithEvents CustomerOrderBindingSource As BindingSource
    Friend WithEvents CustomerOrderTableAdapter As SanchezPizzeriaDataSetTableAdapters.CustomerOrderTableAdapter
    Friend WithEvents CustomerOrderDataGridView As DataGridView
    Friend WithEvents lblSum As Label
    Friend WithEvents lblTotalSpent As Label
    Friend WithEvents btnListAll As Button
    Friend WithEvents lblTotalQuantity As Label
    Friend WithEvents lblTotalQuant As Label
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents Quantity As DataGridViewTextBoxColumn
    Friend WithEvents Price As DataGridViewTextBoxColumn
End Class
