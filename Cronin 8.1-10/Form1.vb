Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim query = From line In IO.File.ReadAllLines("justices.txt")
                                                    Let data = line.Split(","c)
                                                    Let firstname = data(0)
        Let lastname = data(1)
        Let yrappointed = CInt(data(4))
        Let yrleft = CInt(data(5))
        Let fullname = firstname & " " & lastname
        Let newline = fullname & "," & yrappointed
        Order By yrappointed
        Select newline
        IO.File.WriteAllLines("Newfile.txt", query)
        


    End Sub
End Class
