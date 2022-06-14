Public Class Form1

    Public Hight As String, Weight As String, PGrößeinP As String, PGewichtinP As String, Perzentilen As Double, Alter As Double, 
    LGR As Double, LGW As Double, MGR As Double, MGW As Double, SGR As Double, SGW As Double
    

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Alter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Alter.SelectedIndexChanged
        Alter = Alter_SelectedIndexChanged
        
    End Sub

    Private Sub HightInCm_TextChanged(sender As Object, e As EventArgs) Handles HightInCm.TextChanged
        Hight = HightInCm.Text
        Hight = CDbl(Hight)
    End Sub

    Private Sub WeightInKg_TextChanged(sender As Object, e As EventArgs) Handles WeightInKg.TextChanged
        Weight = WeightInKg.Text
        Weight = CDbl(Weight)
    End Sub
    

    Private Sub PGröße_TextChanged(sender As Object, e As EventArgs) Handles PGröße.TextChanged

    End Sub

    Private Sub PGewicht_TextChanged(sender As Object, e As EventArgs) Handles PGewicht.TextChanged

    End Sub

    Private Sub RadioMale_CheckedChanged(sender As Object, e As EventArgs) Handles RadioMale.CheckedChanged

    End Sub

    Private Sub RadioFemale_CheckedChanged(sender As Object, e As EventArgs) Handles RadioFemale.CheckedChanged

    End Sub

    if (Alter = "4 Monate" && RadioMale.CheckedChanged, LGR = 0.1285, MGR = 64.04, SGR = 0.039, LGW = 0.451, MGW = 6.84, SGW = 0.1206) 

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Perzentilen = Weight * Hight
        PGröße.Text = CStr(Perzentilen)
        
    End Sub

End Class
