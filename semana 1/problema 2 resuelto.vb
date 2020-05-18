'Visual Basic.Net Compiler version 0.0.0.5943 (Mono 4.0.1)

Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text.RegularExpressions

Namespace Dcoder
  Public Module Program
    Public Sub Main(args() As string)
      
        Dim mensaje(3) as String
        Dim dato(2) as Integer
        
        
        mensaje(0) = "ingrese el primer valor "
        mensaje(1) = "ingrese el segundo valor "
        
        Console.WriteLine("Bienvenido al comprador divible 3K Full HD NOT Fail")
        For i as Integer = 0 To dato.Length-2
        
        Console.WriteLine(mensaje(i))
        dato(i) = Console.ReadLine()
        
        next
    
    
        If (dato(0) Mod dato(1)) = 0 Then
        mensaje(2)= "Si es divisible "
        Else
        mensaje(2)= "No es divisible "
        end If
    
        Console.WriteLine(mensaje(2))
    End Sub
  End Module
End Namespace