'Visual Basic.Net Compiler version 0.0.0.5943 (Mono 4.0.1)

Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text.RegularExpressions

Namespace Dcoder
  Public Module Program
    Public Sub Main(args() As string)
      'Your code goes here
        
    
        
        dim done as Integer
        dim numero as Single
        
        done = 1
        
        while done < 2
            numero = Pedir("Ingrese un numero entre 0 y 10")
            
            if (numero >= 0) and (numero <= 10) then
                'a caso esa funcion es una pyhon referencia XD '
                Print("numero es valido")
                done = done +1
            else
                
                Print("numero ingresado no es valido ")
            end if 
        end while
    End Sub
    Function Pedir(ByVal mensaje as string) as Single
        Console.WriteLine(mensaje)
        Return Console.ReadLine()
        
    end function 
        
    function Print(ByVal _mensaje as String)
        
        Console.WriteLine(_mensaje)
    end function
  End Module
End Namespace