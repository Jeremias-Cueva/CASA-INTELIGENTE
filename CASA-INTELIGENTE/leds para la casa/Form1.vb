Public Class Form1

    Private ultimaTemperatura As String = "0"
    Private ultimaLuz As String = "0"
    Private ultimoMovimiento As String = "No detectado"


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            With SerialPort1
                .PortName = "COM3"
                .BaudRate = 9600
                .Parity = IO.Ports.Parity.None
                .DataBits = 8
                .StopBits = IO.Ports.StopBits.One
            End With

            SerialPort1.Open()
            apagados()

            Timer1.Interval = 200 ' Leer cada 200 ms
            Timer1.Start()
            Timer2.Interval = 2000 '  minuto
            Timer2.Start()

        Catch ex As Exception
            MsgBox("Error al abrir el puerto COM3: " & ex.Message)
        End Try
    End Sub

    ' BOTONES INDIVIDUALES (PINES 13 AL 6)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        toggle(Button1, "a", "b") ' Pin 13
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        toggle(Button2, "c", "d") ' Pin 12
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        toggle(Button3, "e", "f") ' Pin 11
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        toggle(Button4, "g", "h") ' Pin 10
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        toggle(Button5, "i", "j") ' Pin 9
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        toggle(Button6, "k", "l") ' Pin 8
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        toggle(Button7, "m", "n") ' Pin 7
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        toggle(Button8, "o", "p") ' Pin 6
    End Sub

    ' ENCENDER TODOS
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        SerialPort1.Write("a")
        Button1.BackColor = Color.Lime

        SerialPort1.Write("c")
        Button2.BackColor = Color.Lime

        SerialPort1.Write("e")
        Button3.BackColor = Color.Lime

        SerialPort1.Write("g")
        Button4.BackColor = Color.Lime

        SerialPort1.Write("i")
        Button5.BackColor = Color.Lime

        SerialPort1.Write("k")
        Button6.BackColor = Color.Lime

        SerialPort1.Write("m")
        Button7.BackColor = Color.Lime

        SerialPort1.Write("o")
        Button8.BackColor = Color.Lime

        Button11.Enabled = False
        Button12.Enabled = True
    End Sub

    ' APAGAR TODOS
    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        apagados()
    End Sub

    ' SALIR DEL SISTEMA
    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim salida As String
        salida = MsgBox("¿Deseas salir del sistema?", vbYesNo + vbInformation, "Salir")
        If salida = vbYes Then
            End
        End If
    End Sub

    ' ENCENDER/APAGAR INDIVIDUAL
    Private Sub toggle(btn As Button, onCmd As String, offCmd As String)
        If btn.BackColor = Color.Red Then
            btn.BackColor = Color.Lime
            SerialPort1.Write(onCmd)
        Else
            btn.BackColor = Color.Red
            SerialPort1.Write(offCmd)
        End If
    End Sub

    ' FUNCIÓN PARA APAGAR TODO (INICIO O BOTÓN)
    Private Sub apagados()
        SerialPort1.Write("b")
        Button1.BackColor = Color.Red

        SerialPort1.Write("d")
        Button2.BackColor = Color.Red

        SerialPort1.Write("f")
        Button3.BackColor = Color.Red

        SerialPort1.Write("h")
        Button4.BackColor = Color.Red

        SerialPort1.Write("j")
        Button5.BackColor = Color.Red

        SerialPort1.Write("l")
        Button6.BackColor = Color.Red

        SerialPort1.Write("n")
        Button7.BackColor = Color.Red

        SerialPort1.Write("p")
        Button8.BackColor = Color.Red

        Button11.Enabled = True
        Button12.Enabled = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            If SerialPort1.IsOpen AndAlso SerialPort1.BytesToRead > 0 Then
                Dim linea As String = SerialPort1.ReadLine().Trim()

                If linea.ToLower().StartsWith("humedad:") Then
                    ultimaTemperatura = linea.Split(":"c)(1).Replace("%", "").Trim()
                    txtTemperatura.Text = ultimaTemperatura

                ElseIf linea.ToLower().StartsWith("luz:") Then
                    ultimaLuz = linea.Split(":"c)(1).Replace("%", "").Trim()
                    txtLuz.Text = ultimaLuz

                ElseIf linea.ToLower().StartsWith("movimiento:") Then
                    Dim valor As String = linea.Split(":"c)(1).Trim()
                    If valor.ToLower() = "detectado" Then
                        ultimoMovimiento = "Detectado"
                        txtMovimiento.BackColor = Color.Lime
                    Else
                        ultimoMovimiento = "No detectado"
                        txtMovimiento.BackColor = Color.Red
                    End If
                    txtMovimiento.Text = ultimoMovimiento
                End If
            End If
        Catch ex As Exception
            ' Ignorar errores de lectura incompleta
        End Try
    End Sub

    Private Async Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Try
            Await conexion.SubirLectura(ultimaTemperatura, ultimaLuz, ultimoMovimiento)
        Catch ex As Exception
            ' Manejo de errores
        End Try
    End Sub


    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
