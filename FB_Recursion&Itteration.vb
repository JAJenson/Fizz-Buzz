Imports System
Public Module Module1
	'<summary> This is where the user's input is checked and validated before counting</summary>
	Public Sub Main() 'This is where the user inputs what they want to count to and then it is checked in the TRY statement and will stop once done
		Dim i As Integer ' i is sent to count as an integer if valid
		Console.WriteLine("Give me a number you want me to count to.")
		Dim x As String 'x is a place holder for the user's input
		x =Console.ReadLine()
		Try				'< --- here is the validation
				i = x
			Count(1,i)		' the start of 1 and ends at I is sent to Count()
			Catch a As Exception
				Console.WriteLine("This isn't a Number")
			End Try
		console.ReadLine()
	End Sub
	'<summary>  This procedure is where the program counts and creates the fizzbuzz based on the conditions</summary>
	Sub Count(Start,Limit) '<--- Outputs the integer, Fizz, Buzz, OR Fizzbuzz accordingly
		If Start <= Limit Then ' controls the itteration
			Dim Fb  as String=""
			Dim a = False
			If Start Mod 3 = 0 Then ' Decides if divides into 3 completely then Adds Fizz
				Fb = Fb & "Fizz"
				a = True
			End If
			If Start Mod 5 = 0 Then ' Decides if Divides into 5 then Adds Buzz
				Fb = Fb & "Buzz"
				a = True
			End If
			If a = False Then ' flag checks if ether string phases are added and if not the number is output
				Fb  = Start
			End If
			Console.WriteLine(Fb) 'Output
			Count(Start+1,Limit) ' This is where the recursion occurs until the limit is reached and is terminated
		End If
	End Sub
	
End Module
