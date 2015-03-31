Public Class frmAddCustomer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btnAddCustomer_Click(sender As Object, e As EventArgs) Handles btnAddCustomer.Click
        If txtCust.Text = "" Then
            MessageBox.Show("Please provide the Customer Name", "All Fields Must be Provided", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCust.Focus()
        ElseIf txtSam.Text = "" Then
            MessageBox.Show("Please provide the Saml ID", "All Fields Must be Provided", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtSam.Focus()
        End If

        Dim cust = Trim(txtCust.Text)
        Dim sam = Trim(txtSam.Text)
        Dim g = New Customers(cust, sam)
        Dim l = g.CsvLine()
        frmLookUp.customerList.WriteToCSV(l, frmLookUp.customerList.FileCustomers)
        frmLookUp.customerList.ReadCustomers()
        frmLookUp.LoadDropdowns()
        txtCust.Text = ""
        txtSam.Text = ""
    End Sub

End Class