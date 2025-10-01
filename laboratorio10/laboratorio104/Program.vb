Imports System
Imports System.Runtime.InteropServices.JavaScript.JSType

Public Module Program

    Public Sub Main(args() As String)
        ' Crear primer objeto perrito
        Dim perrito As Perro = New Perro()
        perrito.nombre = "Chizu"
        perrito.raza = "Pastor Alemán"
        perrito.altura = "0.70m"
        Console.WriteLine(perrito.comer("carne"))

        ' Crear segundo objeto perrito
        Dim perrito2 As Perro = New Perro()
        perrito2.nombre = "Lasy"
        perrito2.altura = "0.60m"
        Console.WriteLine(perrito2.comer("pollo"))

        ' Crear tercer objeto perrito usando el constructor con parámetros
        Dim perrito3 As Perro = New Perro("Peluchin", "Poodle", "0.50m")
        Console.WriteLine(perrito3.comer("pan"))
    End Sub

End Module

