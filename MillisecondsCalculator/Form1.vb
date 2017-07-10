Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim first As DateTime
        Dim second As DateTime
        Dim milliseconds As Long
        Dim span As TimeSpan


        first = DateTimePicker1.Value.AddHours(-8)


        second = "1970-01-01 00:00:00"

        milliseconds = Val(mtbMilliseconds.Text)


        If rdioDateTime.Checked = True Then
            span = first.Subtract(second)
            lblResult.Text = span.TotalMilliseconds
        ElseIf rdioMilliseconds.Checked = True Then
            MsgBox(second.AddMilliseconds(milliseconds).AddHours(8))
        Else
            'Dim TimeZone = System.TimeZoneInfo.ConvertTime(Now, TimeZoneInfo.FindSystemTimeZoneById("Philippine Standard Time"))

            Dim zone As TimeZone = TimeZone.CurrentTimeZone

            Dim local As DateTime = zone.ToLocalTime(DateTime.Now)

            MsgBox(local)
        End If



    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
