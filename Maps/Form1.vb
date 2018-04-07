Imports System.Text
Public Class FrmMaps

    Private Sub BtnFindLocation_Click(sender As System.Object, e As System.EventArgs) Handles BtnFindLocation.Click
        Dim Street As String = TxtStreet.Text
        Dim City As String = TxtCity.Text
        Dim State As String = TxtState.Text
        Dim ZipCode As String = TxtZip.Text
        Try
            Dim Query As New StringBuilder
            Query.Append("http://maps.google.com/maps?q=")

            If TxtStreet.Text <> String.Empty Then
                Query.Append(Street + "," & "+")
            End If
            If TxtCity.Text <> String.Empty Then
                Query.Append(City + "," & "+")
            End If
            If TxtState.Text <> String.Empty Then
                Query.Append(State + "," & "+")
            End If
            If TxtZip.Text <> String.Empty Then
                Query.Append(ZipCode + "," & "+")
            End If

            Maps.Navigate(Query.ToString)
        Catch ex As Exception
            MessageBox.Show("Unable To Retrieve Data")
        End Try
    End Sub
End Class
