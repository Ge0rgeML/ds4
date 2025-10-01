Public Class Perro

    Public nombre As String
    Public raza As String
    Public altura As String

    ' Método comer
    Public Function comer(carne As String) As String
        Return nombre & " mide " & altura & " y comerá " & carne
    End Function

    ' Método dormir
    Public Sub dormir()
        ' Aquí se puede implementar la lógica
    End Sub

    ' Método ladrar
    Public Sub ladrar()
        ' Aquí se puede implementar la lógica
    End Sub

    ' Método calcularCosto
    Public Function calcularCosto(costo As Double, impuesto As Double) As Double
        Dim preciototal As Double
        preciototal = costo + (costo * impuesto) ' Cálculo corregido
        Return preciototal
    End Function

    ' Constructor vacío
    Public Sub New()
        ' Constructor por defecto
    End Sub

    ' Constructor con parámetros
    Public Sub New(nombre As String, raza As String, altura As String)
        Me.nombre = nombre
        Me.raza = raza
        Me.altura = altura
    End Sub

End Class
