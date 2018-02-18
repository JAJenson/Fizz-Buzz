Imports System
Public Module Module1
	Public Sub Main()
		Dim i As Integer
		
		Console.WriteLine("Give me a number you want me to count to.")
		Dim x As String
		x =Console.ReadLine()
			Try
				i = x
				Count(1,i)		
			Catch a As Exception
				Console.WriteLine("This isn't a Number")
			End Try
		console.ReadLine()
	End Sub
	
	Sub Count(Start,Limit)
		If Start <= Limit Then
			Dim Fb  as String=""
			Dim a = False
			If Start Mod 3 = 0 Then
				Fb = Fb & "Fizz"
				a = True
			End If
			If Start Mod 5 = 0 Then
				Fb = Fb & "Buzz"
				a = True
			End If
			If a = False Then
				Fb  = Start
			End If
			Console.WriteLine(Fb)
			Count(Start+1,Limit)
		End If
	End Sub
End Module
