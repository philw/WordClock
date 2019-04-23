Module Module1

    Sub Main()

        Dim Time As Integer
        Dim Hours As Integer
        Dim Minutes As Integer
        Dim TimeString As String

        Do
            Console.Write("Enter a time: ")
            Time = Console.ReadLine
            Hours = Time \ 100
            Minutes = Time Mod 100
            TimeString = TimeToWords(Hours, Minutes)
            Console.WriteLine(TimeString)
        Loop

    End Sub

    Function TimeToWords(Hours As Integer, Minutes As Integer) As String

        Dim TimeString As String = ""

        If Minutes = 0 Then
            TimeString = IntegerToWords(Hours) & " o'clock"
        ElseIf Minutes = 30 Then
            TimeString = "half past " & IntegerToWords(Hours)
        ElseIf Minutes = 15 Then
            TimeString = "quarter past " & IntegerToWords(Hours)
        ElseIf Minutes = 45 Then
            TimeString = "quarter to " & IntegerToWords(Hours + 1)
        ElseIf Minutes < 30 Then
            TimeString = IntegerToWords(Minutes) & " minutes past " & IntegerToWords(Hours)
        ElseIf Minutes > 30 Then
            TimeString = IntegerToWords(60 - Minutes) & " minutes to " & IntegerToWords(Hours + 1)
        End If

        Return TimeString

    End Function

    Function IntegerToWords(Number As Integer) As String

        Dim UnitStrings() = {"", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"}
        Dim TeenStrings() = {"ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"}
        Dim TensStrings() = {"", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety"}

        Dim NumberString As String = ""

        If Number > 19 Then
            NumberString = TensStrings(Number \ 10)
            NumberString = NumberString & " " & UnitStrings(Number Mod 10)
        ElseIf Number > 9 Then
            NumberString = TeenStrings(Number Mod 10)
        Else
            NumberString = UnitStrings(Number Mod 10)
        End If

        Return NumberString

    End Function




End Module
