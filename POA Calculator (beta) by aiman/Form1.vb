Public Class Form1

    Private Sub Label21_Click(sender As System.Object, e As System.EventArgs) Handles Label21.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox2.TextChanged
        Label12.Text = "$" & Val(TextBox1.Text) - Val(TextBox2.Text)
        TextBox14.Text = Val(TextBox1.Text) - Val(TextBox2.Text)
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)
        Label23.Text = "$" & Val(TextBox3.Text) + Val(TextBox10.Text) + Val(TextBox11.Text)
        TextBox12.Text = Val(TextBox3.Text) + Val(TextBox10.Text) + Val(TextBox11.Text)
    End Sub

    Private Sub TextBox5_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox5.TextChanged
        Label13.Text = "$" & Val(TextBox4.Text) - Val(TextBox5.Text)
        TextBox10.Text = Val(TextBox4.Text) - Val(TextBox5.Text)
        Label23.Text = "$" & Val(TextBox3.Text) + Val(TextBox10.Text) + Val(TextBox11.Text)
        TextBox12.Text = Val(TextBox3.Text) + Val(TextBox10.Text) + Val(TextBox11.Text)
    End Sub

    Private Sub TextBox4_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox4.TextChanged
        Label13.Text = "$" & Val(TextBox4.Text) - Val(TextBox5.Text)
        TextBox10.Text = Val(TextBox4.Text) - Val(TextBox5.Text)
        Label23.Text = "$" & Val(TextBox3.Text) + Val(TextBox10.Text) + Val(TextBox11.Text)
        TextBox12.Text = Val(TextBox3.Text) + Val(TextBox10.Text) + Val(TextBox11.Text)
    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged
        Label12.Text = "$" & Val(TextBox1.Text) - Val(TextBox2.Text)
        TextBox14.Text = Val(TextBox1.Text) - Val(TextBox2.Text)
    End Sub

    Private Sub TextBox6_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox6.TextChanged
        Label14.Text = "$" & Val(TextBox6.Text) + Val(TextBox7.Text) + Val(TextBox8.Text) + Val(TextBox15.Text) + Val(TextBox16.Text) + Val(TextBox17.Text)
        TextBox11.Text = Val(TextBox6.Text) + Val(TextBox7.Text) + Val(TextBox8.Text) + Val(TextBox15.Text) + Val(TextBox16.Text) + Val(TextBox17.Text)
        Label23.Text = "$" & Val(TextBox3.Text) + Val(TextBox10.Text) + Val(TextBox11.Text)
        TextBox12.Text = Val(TextBox3.Text) + Val(TextBox10.Text) + Val(TextBox11.Text)
    End Sub

    Private Sub TextBox7_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox7.TextChanged
        Label14.Text = "$" & Val(TextBox6.Text) + Val(TextBox7.Text) + Val(TextBox8.Text) + Val(TextBox15.Text) + Val(TextBox16.Text) + Val(TextBox17.Text)
        TextBox11.Text = Val(TextBox6.Text) + Val(TextBox7.Text) + Val(TextBox8.Text)
        Label23.Text = "$" & Val(TextBox3.Text) + Val(TextBox10.Text) + Val(TextBox11.Text)
        TextBox12.Text = Val(TextBox3.Text) + Val(TextBox10.Text) + Val(TextBox11.Text)
    End Sub

    Private Sub TextBox8_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox8.TextChanged
        Label14.Text = "$" & Val(TextBox6.Text) + Val(TextBox7.Text) + Val(TextBox8.Text) + Val(TextBox15.Text) + Val(TextBox16.Text) + Val(TextBox17.Text)
        TextBox11.Text = Val(TextBox6.Text) + Val(TextBox7.Text) + Val(TextBox8.Text)
        Label23.Text = "$" & Val(TextBox3.Text) + Val(TextBox10.Text) + Val(TextBox11.Text)
        TextBox12.Text = Val(TextBox3.Text) + Val(TextBox10.Text) + Val(TextBox11.Text)
    End Sub

    Private Sub Label16_Click(sender As System.Object, e As System.EventArgs) Handles Label16.Click

    End Sub

    Private Sub TextBox11_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox11.TextChanged

    End Sub

    Private Sub TextBox9_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox9.TextChanged
        Label15.Text = "$" & Val(TextBox12.Text) - Val(TextBox9.Text)
        TextBox13.Text = Val(TextBox12.Text) - Val(TextBox9.Text)
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Label16.Text = "$" & Val(TextBox14.Text) - Val(TextBox13.Text)
        TextBox47.Text = Val(TextBox14.Text) - Val(TextBox13.Text)
        Label64.Text = "$" & Val(TextBox14.Text) - Val(TextBox13.Text)
    End Sub

    Private Sub TextBox15_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox15.TextChanged
        Label14.Text = "$" & Val(TextBox6.Text) + Val(TextBox7.Text) + Val(TextBox8.Text) + Val(TextBox15.Text) + Val(TextBox16.Text) + Val(TextBox17.Text)
        TextBox11.Text = Val(TextBox6.Text) + Val(TextBox7.Text) + Val(TextBox8.Text) + Val(TextBox15.Text) + Val(TextBox16.Text) + Val(TextBox17.Text)
        Label23.Text = "$" & Val(TextBox3.Text) + Val(TextBox10.Text) + Val(TextBox11.Text)
        TextBox12.Text = Val(TextBox3.Text) + Val(TextBox10.Text) + Val(TextBox11.Text)
    End Sub

    Private Sub TextBox16_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox16.TextChanged
        Label14.Text = "$" & Val(TextBox6.Text) + Val(TextBox7.Text) + Val(TextBox8.Text) + Val(TextBox15.Text) + Val(TextBox16.Text) + Val(TextBox17.Text)
        TextBox11.Text = Val(TextBox6.Text) + Val(TextBox7.Text) + Val(TextBox8.Text) + Val(TextBox15.Text) + Val(TextBox16.Text) + Val(TextBox17.Text)
        Label23.Text = "$" & Val(TextBox3.Text) + Val(TextBox10.Text) + Val(TextBox11.Text)
        TextBox12.Text = Val(TextBox3.Text) + Val(TextBox10.Text) + Val(TextBox11.Text)
    End Sub

    Private Sub TextBox17_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox17.TextChanged
        Label14.Text = "$" & Val(TextBox6.Text) + Val(TextBox7.Text) + Val(TextBox8.Text) + Val(TextBox15.Text) + Val(TextBox16.Text) + Val(TextBox17.Text)
        TextBox11.Text = Val(TextBox6.Text) + Val(TextBox7.Text) + Val(TextBox8.Text) + Val(TextBox15.Text) + Val(TextBox16.Text) + Val(TextBox17.Text)
        Label23.Text = "$" & Val(TextBox3.Text) + Val(TextBox10.Text) + Val(TextBox11.Text)
        TextBox12.Text = Val(TextBox3.Text) + Val(TextBox10.Text) + Val(TextBox11.Text)
    End Sub

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        TextBox11.Text = ""
        TextBox12.Text = ""
        TextBox13.Text = ""
        TextBox14.Text = ""
        TextBox15.Text = ""
        TextBox16.Text = ""
        TextBox17.Text = ""
    End Sub

    Private Sub TextBox22_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox22.TextChanged
        Label65.Text = "$" & Val(TextBox22.Text) + Val(TextBox23.Text) + Val(TextBox24.Text) + Val(TextBox24.Text) + Val(TextBox25.Text) + Val(TextBox26.Text) + Val(TextBox27.Text)
        Label66.Text = "$" & Val(TextBox22.Text) + Val(TextBox23.Text) + Val(TextBox24.Text) + Val(TextBox24.Text) + Val(TextBox25.Text) + Val(TextBox26.Text) + Val(TextBox27.Text) + Val(TextBox47.Text)
        TextBox48.Text = Val(TextBox22.Text) + Val(TextBox23.Text) + Val(TextBox24.Text) + Val(TextBox24.Text) + Val(TextBox25.Text) + Val(TextBox26.Text) + Val(TextBox27.Text) + Val(TextBox47.Text)
    End Sub

    Private Sub TextBox23_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox23.TextChanged
        Label65.Text = "$" & Val(TextBox22.Text) + Val(TextBox23.Text) + Val(TextBox24.Text) + Val(TextBox24.Text) + Val(TextBox25.Text) + Val(TextBox26.Text) + Val(TextBox27.Text)
        Label66.Text = "$" & Val(TextBox22.Text) + Val(TextBox23.Text) + Val(TextBox24.Text) + Val(TextBox24.Text) + Val(TextBox25.Text) + Val(TextBox26.Text) + Val(TextBox27.Text) + Val(TextBox47.Text)
        TextBox48.Text = Val(TextBox22.Text) + Val(TextBox23.Text) + Val(TextBox24.Text) + Val(TextBox24.Text) + Val(TextBox25.Text) + Val(TextBox26.Text) + Val(TextBox27.Text) + Val(TextBox47.Text)
    End Sub

    Private Sub TextBox24_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox24.TextChanged
        Label65.Text = "$" & Val(TextBox22.Text) + Val(TextBox23.Text) + Val(TextBox24.Text) + Val(TextBox24.Text) + Val(TextBox25.Text) + Val(TextBox26.Text) + Val(TextBox27.Text)
        Label66.Text = "$" & Val(TextBox22.Text) + Val(TextBox23.Text) + Val(TextBox24.Text) + Val(TextBox24.Text) + Val(TextBox25.Text) + Val(TextBox26.Text) + Val(TextBox27.Text) + Val(TextBox47.Text)
        TextBox48.Text = Val(TextBox22.Text) + Val(TextBox23.Text) + Val(TextBox24.Text) + Val(TextBox24.Text) + Val(TextBox25.Text) + Val(TextBox26.Text) + Val(TextBox27.Text) + Val(TextBox47.Text)
    End Sub

    Private Sub TextBox25_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox25.TextChanged
        Label65.Text = "$" & Val(TextBox22.Text) + Val(TextBox23.Text) + Val(TextBox24.Text) + Val(TextBox24.Text) + Val(TextBox25.Text) + Val(TextBox26.Text) + Val(TextBox27.Text)
        Label66.Text = "$" & Val(TextBox22.Text) + Val(TextBox23.Text) + Val(TextBox24.Text) + Val(TextBox24.Text) + Val(TextBox25.Text) + Val(TextBox26.Text) + Val(TextBox27.Text) + Val(TextBox47.Text)
        TextBox48.Text = Val(TextBox22.Text) + Val(TextBox23.Text) + Val(TextBox24.Text) + Val(TextBox24.Text) + Val(TextBox25.Text) + Val(TextBox26.Text) + Val(TextBox27.Text) + Val(TextBox47.Text)
    End Sub

    Private Sub TextBox26_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox26.TextChanged
        Label65.Text = "$" & Val(TextBox22.Text) + Val(TextBox23.Text) + Val(TextBox24.Text) + Val(TextBox24.Text) + Val(TextBox25.Text) + Val(TextBox26.Text) + Val(TextBox27.Text)
        Label66.Text = "$" & Val(TextBox22.Text) + Val(TextBox23.Text) + Val(TextBox24.Text) + Val(TextBox24.Text) + Val(TextBox25.Text) + Val(TextBox26.Text) + Val(TextBox27.Text) + Val(TextBox47.Text)
        TextBox48.Text = Val(TextBox22.Text) + Val(TextBox23.Text) + Val(TextBox24.Text) + Val(TextBox24.Text) + Val(TextBox25.Text) + Val(TextBox26.Text) + Val(TextBox27.Text) + Val(TextBox47.Text)
    End Sub

    Private Sub TextBox27_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox27.TextChanged
        Label65.Text = "$" & Val(TextBox22.Text) + Val(TextBox23.Text) + Val(TextBox24.Text) + Val(TextBox24.Text) + Val(TextBox25.Text) + Val(TextBox26.Text) + Val(TextBox27.Text)
        Label66.Text = "$" & Val(TextBox22.Text) + Val(TextBox23.Text) + Val(TextBox24.Text) + Val(TextBox24.Text) + Val(TextBox25.Text) + Val(TextBox26.Text) + Val(TextBox27.Text) + Val(TextBox47.Text)
        TextBox48.Text = Val(TextBox22.Text) + Val(TextBox23.Text) + Val(TextBox24.Text) + Val(TextBox24.Text) + Val(TextBox25.Text) + Val(TextBox26.Text) + Val(TextBox27.Text) + Val(TextBox47.Text)
    End Sub

    Private Sub TextBox33_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox33.TextChanged
        Label67.Text = "($" & Val(TextBox33.Text) + Val(TextBox32.Text) + Val(TextBox31.Text) + Val(TextBox30.Text) + Val(TextBox29.Text) + Val(TextBox28.Text) + Val(TextBox39.Text) + Val(TextBox38.Text) + Val(TextBox37.Text) + Val(TextBox36.Text) + Val(TextBox35.Text) + Val(TextBox34.Text) + Val(TextBox40.Text) + Val(TextBox41.Text) + Val(TextBox42.Text) + Val(TextBox43.Text) + Val(TextBox44.Text) + Val(TextBox45.Text) + Val(TextBox46.Text) & ")"
    End Sub

    Private Sub TextBox32_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox32.TextChanged
        Label67.Text = "($" & Val(TextBox33.Text) + Val(TextBox32.Text) + Val(TextBox31.Text) + Val(TextBox30.Text) + Val(TextBox29.Text) + Val(TextBox28.Text) + Val(TextBox39.Text) + Val(TextBox38.Text) + Val(TextBox37.Text) + Val(TextBox36.Text) + Val(TextBox35.Text) + Val(TextBox34.Text) + Val(TextBox40.Text) + Val(TextBox41.Text) + Val(TextBox42.Text) + Val(TextBox43.Text) + Val(TextBox44.Text) + Val(TextBox45.Text) + Val(TextBox46.Text) & ")"
    End Sub

    Private Sub TextBox31_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox31.TextChanged
        Label67.Text = "($" & Val(TextBox33.Text) + Val(TextBox32.Text) + Val(TextBox31.Text) + Val(TextBox30.Text) + Val(TextBox29.Text) + Val(TextBox28.Text) + Val(TextBox39.Text) + Val(TextBox38.Text) + Val(TextBox37.Text) + Val(TextBox36.Text) + Val(TextBox35.Text) + Val(TextBox34.Text) + Val(TextBox40.Text) + Val(TextBox41.Text) + Val(TextBox42.Text) + Val(TextBox43.Text) + Val(TextBox44.Text) + Val(TextBox45.Text) + Val(TextBox46.Text) & ")"
    End Sub

    Private Sub TextBox30_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox30.TextChanged
        Label67.Text = "($" & Val(TextBox33.Text) + Val(TextBox32.Text) + Val(TextBox31.Text) + Val(TextBox30.Text) + Val(TextBox29.Text) + Val(TextBox28.Text) + Val(TextBox39.Text) + Val(TextBox38.Text) + Val(TextBox37.Text) + Val(TextBox36.Text) + Val(TextBox35.Text) + Val(TextBox34.Text) + Val(TextBox40.Text) + Val(TextBox41.Text) + Val(TextBox42.Text) + Val(TextBox43.Text) + Val(TextBox44.Text) + Val(TextBox45.Text) + Val(TextBox46.Text) & ")"
    End Sub

    Private Sub TextBox29_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox29.TextChanged
        Label67.Text = "($" & Val(TextBox33.Text) + Val(TextBox32.Text) + Val(TextBox31.Text) + Val(TextBox30.Text) + Val(TextBox29.Text) + Val(TextBox28.Text) + Val(TextBox39.Text) + Val(TextBox38.Text) + Val(TextBox37.Text) + Val(TextBox36.Text) + Val(TextBox35.Text) + Val(TextBox34.Text) + Val(TextBox40.Text) + Val(TextBox41.Text) + Val(TextBox42.Text) + Val(TextBox43.Text) + Val(TextBox44.Text) + Val(TextBox45.Text) + Val(TextBox46.Text) & ")"
    End Sub

    Private Sub TextBox28_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox28.TextChanged
        Label67.Text = "($" & Val(TextBox33.Text) + Val(TextBox32.Text) + Val(TextBox31.Text) + Val(TextBox30.Text) + Val(TextBox29.Text) + Val(TextBox28.Text) + Val(TextBox39.Text) + Val(TextBox38.Text) + Val(TextBox37.Text) + Val(TextBox36.Text) + Val(TextBox35.Text) + Val(TextBox34.Text) + Val(TextBox40.Text) + Val(TextBox41.Text) + Val(TextBox42.Text) + Val(TextBox43.Text) + Val(TextBox44.Text) + Val(TextBox45.Text) + Val(TextBox46.Text) & ")"
    End Sub

    Private Sub TextBox39_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox39.TextChanged
        Label67.Text = "($" & Val(TextBox33.Text) + Val(TextBox32.Text) + Val(TextBox31.Text) + Val(TextBox30.Text) + Val(TextBox29.Text) + Val(TextBox28.Text) + Val(TextBox39.Text) + Val(TextBox38.Text) + Val(TextBox37.Text) + Val(TextBox36.Text) + Val(TextBox35.Text) + Val(TextBox34.Text) + Val(TextBox40.Text) + Val(TextBox41.Text) + Val(TextBox42.Text) + Val(TextBox43.Text) + Val(TextBox44.Text) + Val(TextBox45.Text) + Val(TextBox46.Text) & ")"
    End Sub

    Private Sub TextBox38_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox38.TextChanged
        Label67.Text = "($" & Val(TextBox33.Text) + Val(TextBox32.Text) + Val(TextBox31.Text) + Val(TextBox30.Text) + Val(TextBox29.Text) + Val(TextBox28.Text) + Val(TextBox39.Text) + Val(TextBox38.Text) + Val(TextBox37.Text) + Val(TextBox36.Text) + Val(TextBox35.Text) + Val(TextBox34.Text) + Val(TextBox40.Text) + Val(TextBox41.Text) + Val(TextBox42.Text) + Val(TextBox43.Text) + Val(TextBox44.Text) + Val(TextBox45.Text) + Val(TextBox46.Text) & ")"
    End Sub

    Private Sub TextBox37_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox37.TextChanged
        Label67.Text = "($" & Val(TextBox33.Text) + Val(TextBox32.Text) + Val(TextBox31.Text) + Val(TextBox30.Text) + Val(TextBox29.Text) + Val(TextBox28.Text) + Val(TextBox39.Text) + Val(TextBox38.Text) + Val(TextBox37.Text) + Val(TextBox36.Text) + Val(TextBox35.Text) + Val(TextBox34.Text) + Val(TextBox40.Text) + Val(TextBox41.Text) + Val(TextBox42.Text) + Val(TextBox43.Text) + Val(TextBox44.Text) + Val(TextBox45.Text) + Val(TextBox46.Text) & ")"
    End Sub

    Private Sub TextBox36_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox36.TextChanged
        Label67.Text = "($" & Val(TextBox33.Text) + Val(TextBox32.Text) + Val(TextBox31.Text) + Val(TextBox30.Text) + Val(TextBox29.Text) + Val(TextBox28.Text) + Val(TextBox39.Text) + Val(TextBox38.Text) + Val(TextBox37.Text) + Val(TextBox36.Text) + Val(TextBox35.Text) + Val(TextBox34.Text) + Val(TextBox40.Text) + Val(TextBox41.Text) + Val(TextBox42.Text) + Val(TextBox43.Text) + Val(TextBox44.Text) + Val(TextBox45.Text) + Val(TextBox46.Text) & ")"
    End Sub

    Private Sub TextBox35_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox35.TextChanged
        Label67.Text = "($" & Val(TextBox33.Text) + Val(TextBox32.Text) + Val(TextBox31.Text) + Val(TextBox30.Text) + Val(TextBox29.Text) + Val(TextBox28.Text) + Val(TextBox39.Text) + Val(TextBox38.Text) + Val(TextBox37.Text) + Val(TextBox36.Text) + Val(TextBox35.Text) + Val(TextBox34.Text) + Val(TextBox40.Text) + Val(TextBox41.Text) + Val(TextBox42.Text) + Val(TextBox43.Text) + Val(TextBox44.Text) + Val(TextBox45.Text) + Val(TextBox46.Text) & ")"
    End Sub

    Private Sub TextBox34_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox34.TextChanged
        Label67.Text = "($" & Val(TextBox33.Text) + Val(TextBox32.Text) + Val(TextBox31.Text) + Val(TextBox30.Text) + Val(TextBox29.Text) + Val(TextBox28.Text) + Val(TextBox39.Text) + Val(TextBox38.Text) + Val(TextBox37.Text) + Val(TextBox36.Text) + Val(TextBox35.Text) + Val(TextBox34.Text) + Val(TextBox40.Text) + Val(TextBox41.Text) + Val(TextBox42.Text) + Val(TextBox43.Text) + Val(TextBox44.Text) + Val(TextBox45.Text) + Val(TextBox46.Text) & ")"
    End Sub

    Private Sub TextBox40_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox40.TextChanged
        Label67.Text = "($" & Val(TextBox33.Text) + Val(TextBox32.Text) + Val(TextBox31.Text) + Val(TextBox30.Text) + Val(TextBox29.Text) + Val(TextBox28.Text) + Val(TextBox39.Text) + Val(TextBox38.Text) + Val(TextBox37.Text) + Val(TextBox36.Text) + Val(TextBox35.Text) + Val(TextBox34.Text) + Val(TextBox40.Text) + Val(TextBox41.Text) + Val(TextBox42.Text) + Val(TextBox43.Text) + Val(TextBox44.Text) + Val(TextBox45.Text) + Val(TextBox46.Text) & ")"
    End Sub

    Private Sub TextBox41_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox41.TextChanged
        Label67.Text = "($" & Val(TextBox33.Text) + Val(TextBox32.Text) + Val(TextBox31.Text) + Val(TextBox30.Text) + Val(TextBox29.Text) + Val(TextBox28.Text) + Val(TextBox39.Text) + Val(TextBox38.Text) + Val(TextBox37.Text) + Val(TextBox36.Text) + Val(TextBox35.Text) + Val(TextBox34.Text) + Val(TextBox40.Text) + Val(TextBox41.Text) + Val(TextBox42.Text) + Val(TextBox43.Text) + Val(TextBox44.Text) + Val(TextBox45.Text) + Val(TextBox46.Text) & ")"
    End Sub

    Private Sub TextBox42_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox42.TextChanged
        Label67.Text = "($" & Val(TextBox33.Text) + Val(TextBox32.Text) + Val(TextBox31.Text) + Val(TextBox30.Text) + Val(TextBox29.Text) + Val(TextBox28.Text) + Val(TextBox39.Text) + Val(TextBox38.Text) + Val(TextBox37.Text) + Val(TextBox36.Text) + Val(TextBox35.Text) + Val(TextBox34.Text) + Val(TextBox40.Text) + Val(TextBox41.Text) + Val(TextBox42.Text) + Val(TextBox43.Text) + Val(TextBox44.Text) + Val(TextBox45.Text) + Val(TextBox46.Text) & ")"
    End Sub

    Private Sub TextBox43_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox43.TextChanged
        Label67.Text = "($" & Val(TextBox33.Text) + Val(TextBox32.Text) + Val(TextBox31.Text) + Val(TextBox30.Text) + Val(TextBox29.Text) + Val(TextBox28.Text) + Val(TextBox39.Text) + Val(TextBox38.Text) + Val(TextBox37.Text) + Val(TextBox36.Text) + Val(TextBox35.Text) + Val(TextBox34.Text) + Val(TextBox40.Text) + Val(TextBox41.Text) + Val(TextBox42.Text) + Val(TextBox43.Text) + Val(TextBox44.Text) + Val(TextBox45.Text) + Val(TextBox46.Text) & ")"
    End Sub

    Private Sub TextBox44_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox44.TextChanged
        Label67.Text = "($" & Val(TextBox33.Text) + Val(TextBox32.Text) + Val(TextBox31.Text) + Val(TextBox30.Text) + Val(TextBox29.Text) + Val(TextBox28.Text) + Val(TextBox39.Text) + Val(TextBox38.Text) + Val(TextBox37.Text) + Val(TextBox36.Text) + Val(TextBox35.Text) + Val(TextBox34.Text) + Val(TextBox40.Text) + Val(TextBox41.Text) + Val(TextBox42.Text) + Val(TextBox43.Text) + Val(TextBox44.Text) + Val(TextBox45.Text) + Val(TextBox46.Text) & ")"
    End Sub

    Private Sub TextBox45_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox45.TextChanged
        Label67.Text = "($" & Val(TextBox33.Text) + Val(TextBox32.Text) + Val(TextBox31.Text) + Val(TextBox30.Text) + Val(TextBox29.Text) + Val(TextBox28.Text) + Val(TextBox39.Text) + Val(TextBox38.Text) + Val(TextBox37.Text) + Val(TextBox36.Text) + Val(TextBox35.Text) + Val(TextBox34.Text) + Val(TextBox40.Text) + Val(TextBox41.Text) + Val(TextBox42.Text) + Val(TextBox43.Text) + Val(TextBox44.Text) + Val(TextBox45.Text) + Val(TextBox46.Text) & ")"
    End Sub

    Private Sub TextBox46_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox46.TextChanged
        Label67.Text = "($" & Val(TextBox33.Text) + Val(TextBox32.Text) + Val(TextBox31.Text) + Val(TextBox30.Text) + Val(TextBox29.Text) + Val(TextBox28.Text) + Val(TextBox39.Text) + Val(TextBox38.Text) + Val(TextBox37.Text) + Val(TextBox36.Text) + Val(TextBox35.Text) + Val(TextBox34.Text) + Val(TextBox40.Text) + Val(TextBox41.Text) + Val(TextBox42.Text) + Val(TextBox43.Text) + Val(TextBox44.Text) + Val(TextBox45.Text) + Val(TextBox46.Text) & ")"
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Label69.Text = "$" & Val(TextBox48.Text) - Val(TextBox33.Text) - Val(TextBox32.Text) - Val(TextBox31.Text) - Val(TextBox30.Text) - Val(TextBox29.Text) - Val(TextBox28.Text) - Val(TextBox39.Text) - Val(TextBox38.Text) - Val(TextBox37.Text) - Val(TextBox36.Text) - Val(TextBox35.Text) - Val(TextBox34.Text) - Val(TextBox40.Text) - Val(TextBox41.Text) - Val(TextBox42.Text) - Val(TextBox43.Text) - Val(TextBox44.Text) - Val(TextBox45.Text) - Val(TextBox46.Text)
    End Sub
End Class
