Imports System.Text
Imports System.IO
Imports System.Configuration

Public Class Customers
    Property m_custName As String
    Property m_saml_id As String
    Private m_customers = New List(Of Customers)
    Private m_strFileCustomers As String = ConfigurationManager.AppSettings("CustomerFile").ToString




    Public Sub New()
        ReadCustomers()
    End Sub

    Public Sub New(ByVal name As String,
                   ByVal saml As String)
        custName = name
        saml_id = saml
    End Sub
    Public Property custName As String
        Get
            Return m_custName
        End Get
        Set(value As String)
            m_custName = value
        End Set
    End Property
    Public Property saml_id As String
        Get
            Return m_saml_id
        End Get
        Set(value As String)
            m_saml_id = value
        End Set
    End Property
    ReadOnly Property customers As List(Of Customers)
        Get
            Return m_customers
        End Get
    End Property
    ReadOnly Property FileCustomers As String
        Get
            Return m_strFileCustomers
        End Get
    End Property
    Sub ReadCustomers()
        customers.Clear()
        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(FileCustomers)
            MyReader.TextFieldType = FileIO.FieldType.Delimited
            MyReader.SetDelimiters(",")

            Dim currentRow As String()
            While Not MyReader.EndOfData
                Try
                    currentRow = MyReader.ReadFields()

                    Dim custName As String = currentRow(0)
                    Dim saml As String = currentRow(1)

                    'Add to list of paymentsOut
                    Dim cust As New Customers(custName, saml)
                    m_customers.Add(cust)

                Catch ex As Microsoft.VisualBasic.
                            FileIO.MalformedLineException
                    MsgBox("Line " & ex.Message &
                    "is not valid and will be skipped.")
                End Try
            End While
        End Using
    End Sub

    Function CsvLine() As String
        Dim strbCSVLine As New StringBuilder

        strbCSVLine.Append(Me.custName.ToString + ",")
        strbCSVLine.Append(Me.saml_id.ToString)

        Return strbCSVLine.ToString
    End Function

    Sub WriteToCSV(strCommaSeperated As String, strCSVFile As String)
        File.AppendAllText(strCSVFile, strCommaSeperated & Environment.NewLine)

        ' MsgBox("Appended: " & Environment.NewLine & strCommaSeperated)
    End Sub
End Class
