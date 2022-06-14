Public Class Form1

    Public Hight As String, Weight As String, PGrößeinP As String, PGewichtinP As String, PerzentilenHight As Double, PerzentilenWeight As Double,
    AlterBack As String, LGR As Double, LGW As Double, MGR As Double, MGW As Double, SGR As Double, SGW As Double




    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Alter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Alter.SelectedIndexChanged
        For Each item As Object In Alter.Items
            AlterBack &= CStr(item)
        Next

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

<<<<<<< HEAD
=======
<<<<<<< Updated upstream
=======
>>>>>>> #FormelBenjamin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (AlterBack = "4 Monate" And RadioMale.Checked) Then

            LGR = 0.1285
            MGR = 64.04
            SGR = 0.039
            LGW = 0.451
            MGW = 6.84
            SGW = 0.1206

        ElseIf (AlterBack = "5 Monate" And RadioMale.Checked) Then

            LGR = 0.1119
            MGR = 66.37
            SGR = 0.0375
            LGW = 0.3604
            MGW = 7.45
            SGW = 0.1186

<<<<<<< HEAD
        End If

=======
        ElseIf (AlterBack = "6 Monate" And RadioMale.Checked) Then

            LGR = 0.0959
            MGR = 68.37
            SGR = 0.0363
            LGW = 0.2774
            MGW = 7.96
            SGW = 0.1169    

        ElseIf (AlterBack = "7 Monate" And RadioMale.Checked) Then)

            LGR = 0.0806
            MGR = 70.1
            SGR = 0.0354
            LGW = 0.2022
            MGW = 8.4
            SGW = 0.1155

        ElseIf (AlterBack = "8 Monate" And RadioMale.Checked) Then)

            LGR = 0.0661
            MGR = 71.63
            SGR = 0.0347
            LGW = 0.1344
            MGW = 8.79
            SGW = 0.1144

        ElseIf (AlterBack = "9 Monate" And RadioMale.Checked) Then)

            LGR = 0.0524
            MGR = 73.01
            SGR = 0.0341
            LGW = 0.0734
            MGW = 9.15
            SGW = 0.1135
            
        ElseIf (AlterBack = "10 Monate" And RadioMale.Checked) Then)

            LGR = 0.0395
            MGR = 74.28
            SGR = 0.0337
            LGW = 0.0188
            MGW = 9.47
            SGW = 0.1128

        ElseIf (AlterBack = "11 Monate" And RadioMale.Checked) Then)

            LGR = 0.0276
            MGR = 75.48
            SGR = 0.0335
            LGW = -0.0302
            MGW = 9.76
            SGW = 0.1123

        ElseIf (AlterBack = "12 Monate" And RadioMale.Checked) Then)

            LGR = 0.0167
            MGR = 76.63
            SGR = 0.0334
            LGW = -0.0743
            MGW = 10.03
            SGW = 0.1119

        ElseIf (AlterBack = "15 Monate" And RadioMale.Checked) Then)

            LGR = -0.0111
            MGR = 79.88
            SGR = 0.0337
            LGW = -0.1852
            MGW = 10.75
            SGW = 0.1112

        ElseIf (AlterBack = "18 Monate" And RadioMale.Checked) Then)

            LGR = -0.032
            MGR = 82.88
            SGR = 0.0342
            LGW = -0.2778
            MGW = 11.41
            SGW = 0.111

        ElseIf (AlterBack = "21 Monate" And RadioMale.Checked) Then)

            LGR = -0.0472
            MGR = 85.66
            SGR = 0.0348
            LGW = -0.3615
            MGW = 12.05
            SGW = 0.1113

        ElseIf (AlterBack = "2 Jahre" And RadioMale.Checked) Then)

            LGR = -0.058
            MGR = 88.21
            SGR = 0.0352
            LGW = -0.4393
            MGW = 12.68
            SGW = 0.1117

        ElseIf (AlterBack = "2.5 Jahre" And RadioMale.Checked) Then)

            LGR = -0.0698
            MGR = 92.88
            SGR = 0.0362
            LGW = -0.5809
            MGW = 13.87
            SGW = 0.1132
            
        ElseIf (AlterBack = "3 Jahre" And RadioMale.Checked) Then)

            LGR = -0.0713
            MGR = 97.14
            SGR = 0.0375
            LGW = -0.7111
            MGW = 15.03
            SGW = 0.1152

        ElseIf (AlterBack = "3.5 Jahre" And RadioMale.Checked) Then)

            LGR = -0.0646
            MGR = 101
            SGR = 0.0385
            LGW = -0.8285
            MGW = 16.14
            SGW = 0.1177

        ElseIf (AlterBack = "4 Jahre" And RadioMale.Checked) Then)
        
            LGR = -0.0512
            MGR = 104.56
            SGR = 0.0393
            LGW = -0.9304
            MGW = 17.15
            SGW = 0.1206

        ElseIf (AlterBack = "4.5 Jahre" And RadioMale.Checked) Then)
        
            LGR = -0.032
            MGR = 107.94
            SGR = 0.04
            LGW = -1.0182
            MGW = 18.07
            SGW = 0.1239

        ElseIf (AlterBack = "5 Jahre" And RadioMale.Checked) Then)
        
            LGR = -0.0075
            MGR = 111.23
            SGR = 0.0407
            LGW = -1.1032
            MGW = 19.05
            SGW = 0.1279

        ElseIf (AlterBack = "5.5 Jahre" And RadioMale.Checked) Then)
        
            LGR = 0.0219
            MGR = 114.51
            SGR = 0.0412
            LGW = -1.1897
            MGW = 20.19
            SGW = 0.133

        ElseIf (AlterBack = "6 Jahre" And RadioMale.Checked) Then)
        
            LGR = 0.0562
            MGR = 117.78
            SGR = 0.0416
            LGW = -1.2711
            MGW = 21.5
            SGW = 0.1392

        ElseIf (AlterBack = "6.5 Jahre" And RadioMale.Checked) Then)
        
            LGR = 0.096
            MGR = 121.13
            SGR = 0.0417
            LGW = -1.3401
            MGW = 22.98
            SGW = 0.1463

        ElseIf (AlterBack = "7 Jahre" And RadioMale.Checked) Then)
        
            LGR = 0.1413
            MGR = 124.51
            SGR = 0.0419
            LGW = -1.3868
            MGW = 24.58
            SGW = 0.1537

        ElseIf (AlterBack = "7.5 Jahre" And RadioMale.Checked) Then)
        
            LGR = 0.1915
            MGR = 127.77
            SGR = 0.042
            LGW = -1.4057
            MGW = 26.17
            SGW = 0.161

        ElseIf (AlterBack = "8 Jahre" And RadioMale.Checked) Then)
        
            LGR = 0.2448
            MGR = 130.79
            SGR = 0.0424
            LGW = -1.4002
            MGW = 27.66
            SGW = 0.1676

        ElseIf (AlterBack = "8.5 Jahre" And RadioMale.Checked) Then)
        
            LGR = 0.3008
            MGR = 133.62
            SGR = 0.0428
            LGW = -1.3757
            MGW = 29.25
            SGW = 0.1738

        ElseIf (AlterBack = "9 Jahre" And RadioMale.Checked) Then)
        
            LGR = 0.3598
            MGR = 136.35
            SGR = 0.0434
            LGW = -1.334
            MGW = 31
            SGW = 0.1797

        ElseIf (AlterBack = "9.5 Jahre" And RadioMale.Checked) Then)
        
            LGR = 0.4219
            MGR = 138.98
            SGR = 0.0442
            LGW = -1.277
            MGW = 32.84
            SGW = 0.1855

        ElseIf (AlterBack = "10 Jahre" And RadioMale.Checked) Then)
        
            LGR = 0.4881
            MGR = 141.55
            SGR = 0.0452
            LGW = -1.2054
            MGW = 34.79
            SGW = 0.1915

        ElseIf (AlterBack = "10.5 Jahre" And RadioMale.Checked) Then)
        
            LGR = 0.559
            MGR = 144.09
            SGR = 0.0464
            LGW = -1.1198
            MGW = 36.81
            SGW = 0.198

        ElseIf (AlterBack = "11 Jahre" And RadioMale.Checked) Then)
        
            LGR = 0.6371
            MGR = 146.68
            SGR = 0.0478
            LGW = -1.0215
            MGW = 38.88
            SGW = 0.2047

        ElseIf (AlterBack = "11.5 Jahre" And RadioMale.Checked) Then)
        
            LGR = 0.7246
            MGR = 149.35
            SGR = 0.0492
            LGW = -0.9131
            MGW = 41
            SGW = 0.2111
            
        ElseIf (AlterBack = "12 Jahre" And RadioMale.Checked) Then)
        
            LGR = 0.8249
            MGR = 152.22
            SGR = 0.0505
            LGW = -0.8021
            MGW = 43.25
            SGW = 0.2166

        ElseIf (AlterBack = "12.5 Jahre" And RadioMale.Checked) Then)
        
            LGR = 0.9434
            MGR = 155.43
            SGR = 0.0517
            LGW = -0.698
            MGW = 45.82
            SGW = 0.2209

        ElseIf (AlterBack = "13 Jahre" And RadioMale.Checked) Then)
        
            LGR = 1.083
            MGR = 159.13
            SGR = 0.0523
            LGW = -0.6193
            MGW = 48.81
            SGW = 0.2231

        ElseIf (AlterBack = "13.5 Jahre" And RadioMale.Checked) Then)
        
            LGR = 1.2386
            MGR = 163.1
            SGR = 0.052
            LGW = -0.5799
            MGW = 52.14
            SGW = 0.2222

        ElseIf (AlterBack = "14 Jahre" And RadioMale.Checked) Then)
        
            LGR = 1.3973
            MGR = 166.93
            SGR = 0.0505
            LGW = -0.5842
            MGW = 55.51
            SGW = 0.217

        ElseIf (AlterBack = "14.5 Jahre" And RadioMale.Checked) Then)
        
            LGR = 1.5454
            MGR = 170.35
            SGR = 0.0481
            LGW = -0.6427
            MGW = 58.75
            SGW = 0.2074

        ElseIf (AlterBack = "15 Jahre" And RadioMale.Checked) Then)
        
            LGR = 1.6711
            MGR = 173.12
            SGR = 0.0452
            LGW = -0.7319
            MGW = 61.69
            SGW = 0.1953

        ElseIf (AlterBack = "15.5 Jahre" And RadioMale.Checked) Then)
        
            LGR = 1.7691
            MGR = 175.2
            SGR = 0.0426
            LGW = -0.8264
            MGW = 64.26
            SGW = 0.1832

        ElseIf (AlterBack = "16 Jahre" And RadioMale.Checked) Then)
        
            LGR = 1.8391
            MGR = 176.66
            SGR = 0.0405
            LGW = -0.9088
            MGW = 66.3
            SGW = 0.174

        ElseIf (AlterBack = "16.5 Jahre" And RadioMale.Checked) Then)
        
            LGR = 1.8857
            MGR = 177.62
            SGR = 0.0391
            LGW = -0.9795
            MGW = 67.87
            SGW = 0.168

        ElseIf (AlterBack = "17 Jahre" And RadioMale.Checked) Then)
        
            LGR = 1.9158
            MGR = 178.24
            SGR = 0.0382
            LGW = -1.0401
            MGW = 69.15
            SGW = 0.1641

        ElseIf (AlterBack = "17.5 Jahre" And RadioMale.Checked) Then)
        
            LGR = 1.9374
            MGR = 178.68
            SGR = 0.0376
            LGW = -1.0959
            MGW = 70.3
            SGW = 0.1613

        ElseIf (AlterBack = "18 Jahre" And RadioMale.Checked) Then)

            LGR = 1.9551
            MGR = 179.04
            SGR = 0.0371
            LGW = -1.1482
            MGW = 71.39
            SGW = 0.1591

        End If
>>>>>>> #FormelBenjamin

        PerzentilenHight = ((Hight / MGR) / (LGR * SGR) * 100 / 100)
        PGröße.Text = CStr(PerzentilenHight)
        PerzentilenWeight = (((Weight / MGW) - 1) / (LGW * SGW) * 100 / 100)
        PGewicht.Text = CStr(PerzentilenWeight)

    End Sub

<<<<<<< HEAD
=======
>>>>>>> Stashed changes
>>>>>>> #FormelBenjamin
End Class
