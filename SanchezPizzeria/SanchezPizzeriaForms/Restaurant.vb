Public Class Restaurant
    Private Sub RestaurantBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles RestaurantBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.RestaurantBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SanchezPizzeriaDataSet)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SanchezPizzeriaDataSet.Employee' table. You can move, or remove it, as needed.
        Me.EmployeeTableAdapter.Fill(Me.SanchezPizzeriaDataSet.Employee)
        'TODO: This line of code loads data into the 'SanchezPizzeriaDataSet.Customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter.Fill(Me.SanchezPizzeriaDataSet.Customer)
        'TODO: This line of code loads data into the 'SanchezPizzeriaDataSet.Order' table. You can move, or remove it, as needed.
        Me.OrderTableAdapter.Fill(Me.SanchezPizzeriaDataSet.Order)
        'TODO: This line of code loads data into the 'SanchezPizzeriaDataSet.Restaurant' table. You can move, or remove it, as needed.
        Me.RestaurantTableAdapter.Fill(Me.SanchezPizzeriaDataSet.Restaurant)

    End Sub

    Private Sub FillBy1ToolStripButton_Click(sender As Object, e As EventArgs) Handles FillBy1ToolStripButton.Click
        Try
            Me.RestaurantTableAdapter.FillBy1(Me.SanchezPizzeriaDataSet.Restaurant, CType(txtRestaurant.Text, Integer))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub OrderDataGridView_RowPrePaint(sender As Object, e As DataGridViewRowPrePaintEventArgs) Handles OrderDataGridView.RowPrePaint
        Totals()
        Resv()
    End Sub

    Private Sub BindingNavigatorMoveNextItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveNextItem.Click
        Totals()
        Resv()
    End Sub

    Private Sub Totals()
        Try
            Dim sum As Decimal
            Dim cashSum As Decimal
            Dim cardSum As Decimal
            Dim dgvr As System.Windows.Forms.DataGridViewRow

            For Each dgvr In Me.OrderDataGridView.Rows
                sum += 1
                If dgvr.Cells("PaymentType").Value = "Card" Then cardSum += 1
                If dgvr.Cells("PaymentType").Value = "Cash" Then cashSum += 1
            Next dgvr

            sum -= 1

            TotalTextBox.Text = sum.ToString("#")
            CashBox.Text = cashSum.ToString("#")
            CardBox.Text = cardSum.ToString("#")
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Function GetResvNums() As Decimal()

        Dim RSum(2) As Decimal
        Dim dgvr As System.Windows.Forms.DataGridViewRow

        For Each dgvr In Me.OrderDataGridView.Rows
            If dgvr.Cells("Reservation").Value = "Y" Then RSum(0) += 1
            If dgvr.Cells("Reservation").Value = "N" Then RSum(1) += 1
        Next dgvr

        GetResvNums = RSum

    End Function

    Private Sub Resv()
        Dim RSum() As Decimal
        RSum = GetResvNums()
        RBox.Text = RSum(0).ToString()
        NRBox.Text = RSum(1).ToString()
    End Sub


    Private Sub txtRestaurant_Validating(sender As Object, e As EventArgs) Handles txtRestaurant.Validating
        If Not (txtRestaurant.Text = 1 Or txtRestaurant.Text = 2 Or txtRestaurant.Text = 5 Or txtRestaurant.Text = 7) Then
            MsgBox("Restaurant ID does not exist")
        End If
    End Sub

    Private Sub Restaurant_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing

        RestaurantBindingSource.Dispose()
        OrderDataGridView.Dispose()

    End Sub
End Class
