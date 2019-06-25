Imports System.Xml

Public Class WebForm2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim MessageBox As Object = Nothing
        If (IO.File.Exists("C:\Users\Junn\source\repos\FormProject\FormProject\MyXml.xml")) Then
            Dim document As XmlReader = New XmlTextReader("C:\Users\Junn\source\repos\FormProject\FormProject\MyXml.xml")
            While document.Read()
                Dim type = document.NodeType
                If (type = XmlNodeType.Element) Then
                    If (document.Name = "Firstname") Then
                        Label1.Text = document.ReadInnerXml.ToString()
                    End If
                    If (document.Name = "Secondname") Then
                        Label2.Text = document.ReadInnerXml.ToString()
                    End If
                    If (document.Name = "Lastname") Then
                        Label3.Text = document.ReadInnerXml.ToString()
                    End If
                    If (document.Name = "Location") Then
                        Label4.Text = document.ReadInnerXml.ToString()
                    End If
                    If (document.Name = "Postal") Then
                        Label5.Text = document.ReadInnerXml.ToString()
                    End If
                    If (document.Name = "Phonenumber") Then
                        Label6.Text = document.ReadInnerXml.ToString()
                    End If
                End If
            End While
        Else
            'MessageBox.Show("You have not Entered your details")
            Label1.Text = "You have not Entered your details"


        End If

    End Sub

End Class