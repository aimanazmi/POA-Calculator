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
        Label14.Text = "$" & Val(TextBox6.Text) + Val(TextBox7.Text) + Val(TextBox8.Text)
        TextBox11.Text = Val(TextBox6.Text) + Val(TextBox7.Text) + Val(TextBox8.Text)
        Label23.Text = "$" & Val(TextBox3.Text) + Val(TextBox10.Text) + Val(TextBox11.Text)
        TextBox12.Text = Val(TextBox3.Text) + Val(TextBox10.Text) + Val(TextBox11.Text)
    End Sub

    Private Sub TextBox7_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox7.TextChanged
        Label14.Text = "$" & Val(TextBox6.Text) + Val(TextBox7.Text) + Val(TextBox8.Text)
        TextBox11.Text = Val(TextBox6.Text) + Val(TextBox7.Text) + Val(TextBox8.Text)
        Label23.Text = "$" & Val(TextBox3.Text) + Val(TextBox10.Text) + Val(TextBox11.Text)
        TextBox12.Text = Val(TextBox3.Text) + Val(TextBox10.Text) + Val(TextBox11.Text)
    End Sub

    Private Sub TextBox8_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox8.TextChanged
        Label14.Text = "$" & Val(TextBox6.Text) + Val(TextBox7.Text) + Val(TextBox8.Text)
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
    End Sub
End Class
