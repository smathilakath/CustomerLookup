Imports System.Net
Imports System.Text
Imports System.IO
Imports System.Xml
Imports System.Xml.Serialization

Public Class frmLookUp
    Public customerList As New Customers
    Dim logincookie As CookieContainer
    Public Sub LoadDropdowns()
        cmbCustomers.Items.Clear()
        cmbCustomers.ResetText()
        customerList.customers.Sort(Function(x, y) x.custName.CompareTo(y.custName))
        For i As Integer = 0 To customerList.customers.ToArray.Length - 1
            cmbCustomers.Items.Add(customerList.customers(i).custName)
            cmbCustomers.Items.IndexOf(customerList.customers(i).saml_id)
        Next
    End Sub

    Private Sub Clear_Result()
        txtAuthResult.Text = ""
        txtExternalResult.Text = ""

    End Sub

    Private Sub Clear()
        txtAuthID.Text = ""
        txtExternal.Text = ""
        txtAuthResult.Text = ""
        txtExternalResult.Text = ""
        cmbCustomers.ResetText()
        LoadDropdowns()

    End Sub

    Private Sub frmLookUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDropdowns()

    End Sub

    Private Sub btnGetAuth_Click(sender As Object, e As EventArgs) Handles btnGetAuth.Click
        Clear_Result()
        If txtExternal.Text = "" Then
            MessageBox.Show("External ID Field cannot be left blank!", "Select an External ID", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtExternal.Focus()
            Exit Sub

        ElseIf cmbCustomers.SelectedItem Is Nothing Then
            MessageBox.Show("You must select a customer!", "Select a Customer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cmbCustomers.Focus()
            Exit Sub

        End If

        Dim postData As String = "<soapenv:Envelope xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:mes=""http://spc.intuit.com/idmapper/idmapper/messages/""> " &
                                 "<soapenv:Header/><soapenv:Body><mes:lookupIntuitUserIdByExternalUserIdRequestMsg><mes:externalUserId>" & Trim(txtExternal.Text) & "</mes:externalUserId>" &
                                 "<mes:identityProviderId>" & customerList.customers(cmbCustomers.SelectedIndex).saml_id & "</mes:identityProviderId></mes:lookupIntuitUserIdByExternalUserIdRequestMsg></soapenv:Body></soapenv:Envelope>"

        Dim tempCookies As New CookieContainer
        Dim encoding As New UTF8Encoding
        Dim byteData As Byte() = encoding.GetBytes(postData)
        Dim postReq As HttpWebRequest = DirectCast(WebRequest.Create("https://sdprdidfws.ea.intuit.com/IDMapper/services/IDMapperSOAP"), HttpWebRequest)
        postReq.Method = "POST"
        postReq.KeepAlive = "True"
        postReq.CookieContainer = tempCookies
        postReq.ContentType = "text/xml"
        postReq.Referer = "https://sdprdidfws.ea.intuit.com/IDMapper/services/IDMapperSOAP"
        postReq.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:26.0) Gecko/20100101 Firefox/26.0"
        postReq.ContentLength = byteData.Length

        Try
            Dim postreqstream As Stream = postReq.GetRequestStream()
            postreqstream.Write(byteData, 0, byteData.Length)
            postreqstream.Close()
            Dim postresponse As HttpWebResponse

            postresponse = DirectCast(postReq.GetResponse(), HttpWebResponse)
            tempCookies.Add(postresponse.Cookies)
            logincookie = tempCookies
            Dim postreqreader As New StreamReader(postresponse.GetResponseStream())

            Dim thepage As String = postreqreader.ReadToEnd

            RichTextBox1.Text = thepage
            Try
                Dim test = Split(thepage, "<userId>")
                Dim test1 = Split(test(1), "</userId>")
                txtAuthResult.Text = test1(0)
            Catch
                Dim test = Split(thepage, "<errorMessage>")
                Dim test1 = Split(test(1), "</errorMessage>")
                MessageBox.Show(test1(0), "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        Catch
            MessageBox.Show("Unable to connect to the server.  Try connecting to the jump box", "Unable to access Server", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try


    End Sub


    Private Sub ViewResponseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewResponseToolStripMenuItem.Click

        If RichTextBox1.Visible = False Then
            RichTextBox1.Visible = True
        Else
            RichTextBox1.Visible = False
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub btnExternalLookup_Click(sender As Object, e As EventArgs) Handles btnExternalLookup.Click
        Clear_Result()
        If txtAuthID.Text = "" Then
            MessageBox.Show("Auth ID Field cannot be left blank!", "Select an Auth ID", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtAuthID.Focus()
            Exit Sub

        ElseIf cmbCustomers.SelectedItem Is Nothing Then
            MessageBox.Show("You must select a customer!", "Select a Customer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cmbCustomers.Focus()
            Exit Sub
        End If
        Dim postData As String =
"<soapenv:Envelope xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:mes=""http://spc.intuit.com/idmapper/idmapper/messages/"">" &
    "<soapenv:Header/>" &
    "<soapenv:Body>" &
            "<mes:lookupExternalUserIdByIntuitUserIdRequestMsg>" &
                "<mes:userId>" & Trim(txtAuthID.Text) & "</mes:userId>" &
                "<mes:identityProviderId>" & customerList.customers(cmbCustomers.SelectedIndex).saml_id & "</mes:identityProviderId>" &
            "</mes:lookupExternalUserIdByIntuitUserIdRequestMsg>" &
    "</soapenv:Body>" &
"</soapenv:Envelope>"

        Dim tempCookies As New CookieContainer
        Dim encoding As New UTF8Encoding
        Dim byteData As Byte() = encoding.GetBytes(postData)
        Dim postReq As HttpWebRequest = DirectCast(WebRequest.Create("https://sdprdidfws.ea.intuit.com/IDMapper/services/IDMapperSOAP"), HttpWebRequest)
        postReq.Method = "POST"
        postReq.KeepAlive = "True"
        postReq.CookieContainer = tempCookies
        postReq.ContentType = "text/xml"
        postReq.Referer = "https://sdprdidfws.ea.intuit.com/IDMapper/services/IDMapperSOAP"
        postReq.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:26.0) Gecko/20100101 Firefox/26.0"
        postReq.ContentLength = byteData.Length

        Try
            Dim postreqstream As Stream = postReq.GetRequestStream()
            postreqstream.Write(byteData, 0, byteData.Length)
            postreqstream.Close()
            Dim postresponse As HttpWebResponse

            postresponse = DirectCast(postReq.GetResponse(), HttpWebResponse)
            tempCookies.Add(postresponse.Cookies)
            logincookie = tempCookies
            Dim postreqreader As New StreamReader(postresponse.GetResponseStream())

            Dim thepage As String = postreqreader.ReadToEnd

            RichTextBox1.Text = thepage
            Try
                Dim test = Split(thepage, "<externalUserId>")
                Dim test1 = Split(test(1), "</externalUserId>")
                txtExternalResult.Text = test1(0)
            Catch
                Dim test = Split(thepage, "<errorMessage>")
                Dim test1 = Split(test(1), "</errorMessage>")
                MessageBox.Show(test1(0), "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        Catch
            MessageBox.Show("Unable to connect to the server.  Try connecting to the jump box", "Unable to access Server", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCopyAuth.Click
        Clear()
    End Sub

    Private Sub btnAddCustomer_Click(sender As Object, e As EventArgs) Handles btnAddCustomer.Click
        frmAddCustomer.Show()
    End Sub

    Private Sub btnCopyAuthID_Click(sender As Object, e As EventArgs) Handles btnCopyAuthID.Click
        If txtAuthResult.Text = "" Then

        Else
            My.Computer.Clipboard.SetText(txtAuthResult.Text)
        End If

    End Sub

    Private Sub btnCopyExternalId_Click(sender As Object, e As EventArgs) Handles btnCopyExternalId.Click
        If txtExternalResult.Text = "" Then
        Else
            My.Computer.Clipboard.SetText(txtExternalResult.Text)
        End If
    End Sub

    Private Sub btnPastetoExternal_Click_1(sender As Object, e As EventArgs) Handles btnPastetoExternal.Click
        txtExternal.Text = My.Computer.Clipboard.GetText()
    End Sub

    Private Sub btnPastetoAuth_Click(sender As Object, e As EventArgs) Handles btnPastetoAuth.Click
        txtAuthID.Text = My.Computer.Clipboard.GetText()
    End Sub
End Class
