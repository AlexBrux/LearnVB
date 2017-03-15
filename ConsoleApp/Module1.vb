


Module Module1

    Sub Main()
        'blahbla
        Dim str As String = "0123456789"
        Dim inter As Integer = 1
        Dim zz As Char = CChar("z")

        'Dim bb As Byte = 0
        'For bb = bb.MinValue To bb.MaxValue [1]
        'Next

        For inter = 1 To 50 Step 5
            Console.Write("{0}- ", inter)
        Next
        If (True) Then
            Console.WriteLine(vbCrLf & "poeretr")
        End If

        str = Date.Now.ToString("d")




        Select Case inter
            Case 14
            Case Else
                Console.WriteLine(vbCrLf & "blabaz^dfpze  " & str)
        End Select

        blah(str)

        Console.WriteLine("poet {0} {1} {2} ", str.Substring(3, 3), Convert.ToString(inter), zz)
        Console.ReadLine()

    End Sub

    Sub blah(ByRef add As String)
        Console.WriteLine(add)
    End Sub

End Module
