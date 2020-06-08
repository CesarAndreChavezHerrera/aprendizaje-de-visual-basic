'Visual Basic.Net Compiler version 0.0.0.5943 (Mono 4.0.1)

Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text.RegularExpressions

Namespace Dcoder
  Public Module Program
    Public Sub Main(args() As string)
      
        dim numero(2) as Single
        Dim op as Single
        dim respuesta as Single
        
        Console.WriteLine("Bienvenido a la calculadora de areas ")
        op = 0
        Console.WriteLine("Escoja la figura a calcular el area")
        Console.WriteLine("[1] area de un circulo")
        Console.WriteLine("[2] area de un cuadrado")
        Console.WriteLine("[3] area de un Rectangoulo")
        Console.WriteLine("[4] area de un Triangulo")
        
        op = Console.ReadLine()   
            
        Select Case op
            
        Case 1
            Console.WriteLine("ingrese el readio del circulo ")
            numero(0) = Console.ReadLine()
            respuesta = 3.1416 * numero(0)^2
            Console.WriteLine("el area del circulo es de :" & respuesta)
            
        case 2
            Console.WriteLine("ingrese la base del Cuadrado")
            numero(0) = Console.ReadLine()
            respuesta = numero(0) ^ 2
            Console.WriteLine("el area del cuadrado es de : " & respuesta)
            
        case 3
            numero = PedirDato("ingrese la base del rectangulo", "Ingrese la altura del rectangulo")
            respuesta = numero(0) * numero(1)
            Console.WriteLine("el area del Rectangoulo es de : " & respuesta)
        Case 4
            numero = PedirDato("ingrese la base del triangulo", "Ingrese la altura del tringulo")
            respuesta = (numero(0) * numero(1)) / 2
            Console.WriteLine("el area del triangulo es de : " & respuesta)
        Case else
            Console.WriteLine("opcion ingresada no es valida")
        end Select
    End Sub
    
    public Function PedirDato(ByVal ParamArray mensaje() as String) as Single ()
        Dim numeros(2) as Single
            
        For i as integer = 0 To 1
            Console.WriteLine(mensaje(i))
            numeros(i) = Console.ReadLine()
        next
        return numeros
    
    End Function

  End Module
End Namespace
