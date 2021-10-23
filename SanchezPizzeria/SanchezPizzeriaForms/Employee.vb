Imports System.ComponentModel

Public Class Employee
    Private Sub EmployeeBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles EmployeeBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.EmployeeBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.SanchezPizzeriaDataSet)
            Me.EmployeeBindingSource.EndEdit()
            Me.EmployeeTableAdapter.Update(Me.SanchezPizzeriaDataSet.Employee)
        Catch ex As Exception
            MsgBox(ex.Message, "Error Saving Data")
        End Try


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SanchezPizzeriaDataSet.EmployeeTypeHistory' table. You can move, or remove it, as needed.
        Me.EmployeeTypeHistoryTableAdapter.Fill(Me.SanchezPizzeriaDataSet.EmployeeTypeHistory)
        'TODO: This line of code loads data into the 'SanchezPizzeriaDataSet.Employee' table. You can move, or remove it, as needed.
        Me.EmployeeTableAdapter.Fill(Me.SanchezPizzeriaDataSet.Employee)

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles picLogoEmployee.Click

    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Me.OpenFileDialog1.Title = "Get Employee Picture"
        Me.OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        txtFileName.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub btnUploadPhoto_Click(sender As Object, e As EventArgs) Handles btnUploadPhoto.Click
        If (txtFileName.Text.Trim() <> "") Then EmployeePictureBox.Image =
Image.FromFile(txtFileName.Text)
    End Sub

    Private Sub btnDeletePhoto_Click(sender As Object, e As EventArgs) Handles btnDeletePhoto.Click
        EmployeePictureBox.Image = Nothing
    End Sub

    Private Sub FillBy1ToolStripButton_Click(sender As Object, e As EventArgs) Handles FillBy1ToolStripButton.Click
        Try
            Me.EmployeeTableAdapter.FillBy1(Me.SanchezPizzeriaDataSet.Employee, LastNameToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class
