Public Class Form1

    Public Hight As String, Weight As String, PGrößeinP As String, PGewichtinP As String, Perzentilen As Double

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Alter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Alter.SelectedIndexChanged

    End Sub

    Private Sub HightInCm_TextChanged(sender As Object, e As EventArgs) Handles HightInCm.TextChanged
        Hight = HightInCm.Text
        Hight = CDbl(Hight)
    End Sub

    Private Sub WeightInKg_TextChanged(sender As Object, e As EventArgs) Handles WeightInKg.TextChanged
        Weight = WeightInKg.Text
        Weight = CDbl(Weight)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Perzentilen = Weight * Hight
        PGröße.Text = CStr(Perzentilen)
    End Sub

    Private Sub PGröße_TextChanged(sender As Object, e As EventArgs) Handles PGröße.TextChanged

    End Sub

    Private Sub PGewicht_TextChanged(sender As Object, e As EventArgs) Handles PGewicht.TextChanged

    End Sub

    Private Sub RadioMale_CheckedChanged(sender As Object, e As EventArgs) Handles RadioMale.CheckedChanged

    End Sub

    Private Sub RadioFemale_CheckedChanged(sender As Object, e As EventArgs) Handles RadioFemale.CheckedChanged

    End Sub

End Class
