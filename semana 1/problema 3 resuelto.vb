'Visual Basic.Net Compiler version 0.0.0.5943 (Mono 4.0.1)

Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text.RegularExpressions

Namespace Dcoder
  Public Module Program
    Public Sub Main(args() As string)
    
        Dim conejo(10) as String
        Dim input_valor as Double
        Dim iva_aplicado as Double
        Dim iva as Double
        Console.WriteLine("Bienvenido al conejo calculador del IVA")

        conejo(0) = "      (\__/)"
        conejo(1) = "      (•ㅅ•)"
        conejo(2) = "   ＿ノヽ ノ＼＿"
        conejo(3) = " /`/ ⌒Ｙ⌒ Ｙ　ヽ"
        conejo(4) = "( 　(三ヽ人　 /　|"
        conejo(5) = "|　ﾉ⌒＼ ￣￣ヽ_ ノ"
        conejo(6) = "ヽ＿＿＿＞､＿＿_／"
        conejo(7) = "　　｜( 王 ﾉ〈"
        conejo(8) = "　　/ ﾐ`ー―彡 \"
        conejo(9) = "　 /　 ╰　╯　  \"
        
        
        For i as Integer = 0 To 9
        Console.WriteLine(conejo(i))
        next
        Console.WriteLine("Ingrese la cantidad ")
        input_valor = Console.ReadLine()
        
    Console.WriteLine("")
    Console.WriteLine("Resultado")
    
        iva = input_valor * 0.13
        iva_aplicado = input_valor + iva
    
    Console.WriteLine("")
    Console.WriteLine("El iva del precio del producto $"& input_valor & " es de : $"& iva)
    Console.WriteLine("El precio del producto                                   $" & input_valor)
    Console.WriteLine("El iva aplicado es de                                    $" & iva_aplicado)
    
    End Sub
  End Module
End Namespace