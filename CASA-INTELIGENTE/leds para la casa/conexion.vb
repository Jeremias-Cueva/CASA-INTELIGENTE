Imports Firebase.Database
Imports Firebase.Database.Query
Imports System.Threading.Tasks

Public Class conexion
    ' URL de tu Firebase (reemplázala con la tuya)
    Private Shared firebaseUrl As String = "https://bigdata-dbeca-default-rtdb.firebaseio.com/  "
    Private Shared firebaseClient As FirebaseClient = New FirebaseClient(firebaseUrl)

    ' Método para subir temperatura, luz y movimiento a Firebase
    Public Shared Async Function SubirLectura(temperatura As String, luz As String, movimiento As String) As Task
        Dim fechaHora As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")

        Dim datos = New With {
            Key .temperatura = temperatura,
            Key .luz = luz,
            Key .movimiento = movimiento,
            Key .fecha = fechaHora
        }

        Await firebaseClient _
            .Child("lecturas") _
            .PostAsync(datos)
    End Function
End Class
