'Visual Basic.Net Compiler version 0.0.0.5943 (Mono 4.0.1)

Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text.RegularExpressions

Namespace Dcoder
  Public Module Program
    Public Sub Main(args() As string)
      'Your code goes here
        Console.WriteLine("hola mundo ")
        'variable '
        Dim mensaje As String
        mensaje = "test"
        'fin de decracion de  variable'
        Console.WriteLine("mi primer texto")
        console.WriteLine(mensaje)
        
        'leer entrada , suma '
        Dim numero1, numero2,resultado As Single
        
        console.WriteLine("suma")
        console.WriteLine("ingrese el primer numero")
        numero1 = console.ReadLine()
        
        console.WriteLine("ingrese el segundo numero2")
        numero2 = console.ReadLine()
        
        resultado = numero1 + numero2
        console.WriteLine("el resultado "&resultado)
        
    End Sub
  End Module
End Namespace
