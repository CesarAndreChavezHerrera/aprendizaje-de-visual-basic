'Visual Basic.Net Compiler version 0.0.0.5943 (Mono 4.0.1)

Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text.RegularExpressions

Namespace Dcoder
  Public Module Program
    Public Sub Main(args() As string)
      'Your code goes here
        dim kilometros as Single
        Dim numero_boleto as Integer
        dim descuento as Single
        Dim total as Single
        
        
        Console.WriteLine("Bienvenido a la calculo del precio del bus")
        
        numero_boleto = Pedir("Ingrese la cantidad de Boleto a comprar")
        kilometros = Pedir("Ingrese cuantos Kilometros recorrera")
        
        total = kilometros * 0.25
        total =  total * numero_boleto
        
        
        Console.WriteLine("factura")
        Console.WriteLine("")
        Console.WriteLine("numero de Boleto a comprar           "& numero_boleto)
        Console.WriteLine("Cantiadad de Kilometros a recorrer   " & kilometros)
        
        
        if numero_boleto > 10 And Kilometros >  400 Then
           
            
            descuento = total * 0.20
            
            
            Console.WriteLine("el descuento es de                   $" & descuento)
            descuento = total - descuento 
            Console.WriteLine("el precio total de los Boletos es de $" & total)
            Console.WriteLine("el precio con el descuento es de     $"& descuento)
        
        Else
            
            Console.WriteLine("El precio es de                      $" & total)
            
        end if
        
    End Sub
    Function Pedir(ByVal mensaje as string) as Single
        Console.WriteLine(mensaje)
        Return Console.ReadLine()
        
    end function 
  End Module
End Namespace
