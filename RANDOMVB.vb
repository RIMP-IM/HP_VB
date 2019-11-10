Imports System


Module Program

    Dim PILA As Stack = New Stack


    'LEE EL STACK PARA QUE CONFIRMAR QUE NO HAY ELEMENTOS REPETIDOS
    Function LeerStack(ByVal i As Integer) As Boolean


        If PILA.Count = 0 Then
            Return True
        End If

        If PILA.Contains(i) Then
            Return False
        Else
            Return True
        End If



    End Function


    'GENERA UN RANDOM Y LO MANDA A COMPROBAR QUE NO EXISTA YA EN LA PILA PARA LUEGO PUSHEARLO
    Function Rand(ByVal a As Integer) As Boolean

        Dim random As New Random()
        Dim aux As Integer = 1
        Dim r As Integer

        Do Until aux = a

            r = random.Next(1, a)


            If (LeerStack(r) = True) Then

                PILA.Push(r)

                aux += 1

            ElseIf (LeerStack(r) = False) Then
                Continue Do
            End If



        Loop

        Return True

    End Function


    Sub Main(args As String())

        Dim aux As Integer = 11     'EL VALOR ES LA CANTIDAD DE CASOS POSIBLES (MAS UNO)
        Dim i As Integer = 0

        Rand(aux)


        While PILA.Count <> 0
            Dim Aux2 As Integer = PILA.Peek
            Console.WriteLine(Aux2)
            PILA.Pop()

            i += 1


        End While





    End Sub
End Module
