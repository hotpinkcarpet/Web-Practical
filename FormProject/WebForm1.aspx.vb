Imports System.Xml


Public Class WebForm1

    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    End Sub

    Function xamlWrite(XmlWrt As XmlWriter)
        XmlWrt.WriteStartDocument()
        XmlWrt.WriteStartElement("Data")
        XmlWrt.WriteStartElement("Person")
        XmlWrt.WriteStartElement("Firstname")
        XmlWrt.WriteString(TextBox1.Text)
        XmlWrt.WriteEndElement()
        XmlWrt.WriteStartElement("Secondname")
        XmlWrt.WriteString(TextBox2.Text)
        XmlWrt.WriteEndElement()
        XmlWrt.WriteStartElement("Lastname")
        XmlWrt.WriteString(TextBox3.Text)
        XmlWrt.WriteEndElement()
        XmlWrt.WriteStartElement("Address")
        XmlWrt.WriteStartElement("Location")
        XmlWrt.WriteString(TextBox4.Text)
        XmlWrt.WriteEndElement()
        XmlWrt.WriteStartElement("Postal")
        XmlWrt.WriteString(TextBox5.Text)
        XmlWrt.WriteEndElement()
        XmlWrt.WriteStartElement("Phonenumber")
        XmlWrt.WriteString(TextBox6.Text)
        XmlWrt.WriteEndElement()
        XmlWrt.WriteEndElement()
        XmlWrt.WriteEndElement()
        XmlWrt.WriteEndElement()
        XmlWrt.WriteEndDocument()
        XmlWrt.Close()
        'MessageBox.Show("XML file saved.")

#Disable Warning BC42105 ' Function doesn't return a value on all code paths
    End Function
#Enable Warning BC42105 ' Function doesn't return a value on all code paths

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim MessageBox As Object = Nothing
        Dim XmlWrt As XmlWriter
        If IO.File.Exists("C:\Users\Junn\source\repos\FormProject\FormProject\MyXML.xml") = False Then
            Dim settings As New XmlWriterSettings()
            settings.Indent = True
            XmlWrt = XmlWriter.Create("C:\Users\Junn\source\repos\FormProject\FormProject\MyXml.xml", settings)
            xamlWrite(XmlWrt)
        End If


    End Sub
End Class