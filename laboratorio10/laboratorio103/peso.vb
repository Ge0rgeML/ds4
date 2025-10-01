Imports System

Module peso

    Sub Main()

        'Declaración de variables
        Dim M As Double
        Dim G As Double
        Dim P As Double

        'Ingresar valores para las variables
        G = 9.8

        Console.Write("Ingrese la masa del objeto: ")
        M = Convert.ToDouble(Console.ReadLine()) ' Conversión de la entrada a Double

        'Realizar los procesos
        P = M * G

        'Mostrar resultados
        Console.WriteLine("Peso del objeto: {0}", P)
        Console.ReadKey()

    End Sub

End Module

