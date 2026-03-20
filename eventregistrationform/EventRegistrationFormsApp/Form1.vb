Public Class Form1
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim strName = txtName.Text
        Dim intAge As Integer
        Dim decBasePrice As Decimal = 0
        Dim decTotalPrice As Decimal = 0

        If txtName.Text = "" OrElse Not Integer.TryParse(txtAge.Text, intAge) Then
            MessageBox.Show("Please enter a valid name and age.")
        End If

        If intAge < 18 Then
            MessageBox.Show("You are too young to register for this event.")
        Else
            Select Case eventCategory.Text
                Case "Workshop"
                    decBasePrice = 50D
                Case "Seminar"
                    decBasePrice = 30D
                Case "Conference"
                    decBasePrice = 100D
                Case Else
                    MessageBox.Show("Please select a Category.")
            End Select
            decTotalPrice = decBasePrice

            If chkPremium.Checked And chkLaunch.Checked Then
                decTotalPrice += 25D
            ElseIf chkPremium.Checked Or chkLaunch.Checked Then
                decTotalPrice += 15
            End If

            Dim strPaymentMethod = ""

            If radCredit.Checked Then
                strPaymentMethod = "Credit Card"

                decTotalPrice *= 1.03D
            ElseIf radMomo.Checked Then
                strPaymentMethod = "Momo"
            End If

            Dim strReceipt = "Registration Succcessful!" &
                vbCrLf & "Attendee: " & strName &
                vbCrLf & "Event Category: " & eventCategory.Text &
                vbCrLf & "Payment Method: " & strPaymentMethod &
                vbCrLf & "Total Fee: " & decTotalPrice.ToString("C2")

            MessageBox.Show(strReceipt)
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
