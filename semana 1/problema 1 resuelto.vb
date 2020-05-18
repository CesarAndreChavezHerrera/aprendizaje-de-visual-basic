'Visual Basic.Net Compiler version 0.0.0.5943 (Mono 4.0.1)

Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text.RegularExpressions

Namespace Dcoder
  Public Module Program
    Public Sub Main(args() As string)
     
        'de claracion de variable'
        dim numero_datos as Long
        dim promedio as Long
        Console.Writeline("Bienvenido al promediador 200mill")
        Console.WriteLine("")
        Console.WriteLine("ingrese la cantidad de datos a evaluar")
        
        numero_datos = Console.ReadLine()
        numero_datos = numero_datos -1
        Console.WriteLine(numero_datos)
        'pruebas array en'
        dim datos_array(numero_datos) as Long
        
        'Console.WriteLine(datos_array.Length)
        
        
        'buscar el equivalete a hacer append en visual basic '
        'datos_array.Add(1)
        'Console.WriteLine(datos_array.Length)'
        
        
        'for test '
        For index As Integer = 0 To datos_array.Length-1
            
            Console.WriteLine("ingrese el "& index + 1 & "° valor ")
            datos_array(index) = Console.ReadLine() 
        
        next
        
        
    
    
    promedio = Media(datos_array)
    Console.WriteLine("su promedio es de "& promedio)
    
    If promedio > 5 Then
        
        Console.WriteLine("aprobado")
    Else
        Console.WriteLine("reprobado")
        
    End If
        
        
    
        
    End Sub

public Function Media(ByVal ParamArray datos() as Long) as Double
    
    Dim suma as Long
    Dim result as Double
    
        For index As Integer = 0 To datos.Length-1
        suma = suma + datos(index)
    
    next
    
    result = (suma / datos.Length-1) 
    
    return result
    
End Function
  End Module
End Namespace