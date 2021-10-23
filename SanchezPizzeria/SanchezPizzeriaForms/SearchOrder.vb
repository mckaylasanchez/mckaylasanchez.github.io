Public Class SearchOrder
    Private Sub RestaurantBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.RestaurantBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SanchezPizzeriaDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SanchezPizzeriaDataSet.CustomerOrder' table. You can move, or remove it, as needed.
        'Me.CustomerOrderTableAdapter.Fill(Me.SanchezPizzeriaDataSet.CustomerOrder)
        'TODO: This line of code loads data into the 'SanchezPizzeriaDataSet1.Product' table. You can move, or remove it, as needed.
        Me.ProductTableAdapter.Fill(Me.SanchezPizzeriaDataSet1.Product)
        'TODO: This line of code loads data into the 'SanchezPizzeriaDataSet.CustomerPurchases' table. You can move, or remove it, as needed.
        Me.CustomerPurchasesTableAdapter.Fill(Me.SanchezPizzeriaDataSet.CustomerPurchases)
        'TODO: This line of code loads data into the 'SanchezPizzeriaDataSet.OrderLine' table. You can move, or remove it, as needed.
        Me.OrderLineTableAdapter.Fill(Me.SanchezPizzeriaDataSet.OrderLine)
        'TODO: This line of code loads data into the 'SanchezPizzeriaDataSet.Customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter.Fill(Me.SanchezPizzeriaDataSet.Customer)
        'TODO: This line of code loads data into the 'SanchezPizzeriaDataSet.Order' table. You can move, or remove it, as needed.
        Me.OrderTableAdapter.Fill(Me.SanchezPizzeriaDataSet.Order)
        'TODO: This line of code loads data into the 'SanchezPizzeriaDataSet.Restaurant' table. You can move, or remove it, as needed.
        Me.RestaurantTableAdapter.Fill(Me.SanchezPizzeriaDataSet.Restaurant)

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            Me.CustomerOrderTableAdapter.FillBy(
            Me.SanchezPizzeriaDataSet.CustomerOrder,
            Me.cboCustomerName.SelectedValue,
            Me.dtpBeginDate.Value,
            Me.dtpEndDate.Value)
            CustomerInfo()
            Quant()
        Catch ex As Exception
            MsgBox(ex.Message, , "Error in the Query")
        End Try
        Dim n As Integer
        n = Me.CustomerOrderDataGridView.Rows.Count - 1
        If n = 0 Then
            MsgBox("No listings found!")
        End If
    End Sub

    Private Sub CustomerInfo()

        Dim sum As Decimal
        Dim dgvr As System.Windows.Forms.DataGridViewRow
        For Each dgvr In Me.CustomerOrderDataGridView.Rows
            sum += dgvr.Cells("Quantity").Value * dgvr.Cells("Price").Value
        Next dgvr
        lblTotalSpent.Text = sum.ToString("$#0.00")

    End Sub

    Private Sub Quant()
        Dim add As Decimal
        Dim dgvr As System.Windows.Forms.DataGridViewRow
        For Each dgvr In Me.CustomerOrderDataGridView.Rows
            add += dgvr.Cells("Quantity").Value
        Next dgvr
        lblTotalQuant.Text = add.ToString()
    End Sub

    Private Sub btnListAll_Click(sender As Object, e As EventArgs) Handles btnListAll.Click
        Try
            Me.CustomerOrderTableAdapter.Fill(Me.SanchezPizzeriaDataSet.CustomerOrder)
            CustomerInfo()
            Quant()
        Catch ex As Exception
            MsgBox(ex.Message, , "Error in the Query")
        End Try
        Dim n As Integer
        n = Me.CustomerOrderDataGridView.Rows.Count - 1
        If n = 0 Then
            MsgBox("No listings found!")
        End If
    End Sub

    Private Sub CustomerOrderDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles CustomerOrderDataGridView.CellContentClick

    End Sub
End Class