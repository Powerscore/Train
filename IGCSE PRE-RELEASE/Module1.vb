'Alaa Ashraf
Module Module1

    Sub Main()
        'Task 1 
        Dim size As Integer

        Console.WriteLine("Enter the number of accounts to be created")
        size = Console.ReadLine()
        size -= 1
        'Declaring the arrays

        Dim Home_Start_Code(4) As String
        Dim Home_Start_Price(4) As Decimal
        Dim Start_End_Code(4) As String
        Dim Start_End_Price(4) As Decimal
        Dim End_Destination_Code(4) As String
        Dim End_Destination_Price(4) As Decimal

        Dim Account_Number(size) As String
        Dim Account_Name(size) As String

        Dim Booking_Account_Number(size) As Integer
        Dim Booking_Start_Time(size) As String
        Dim Booking_Stage1_Code(size) As String
        Dim Booking_Stage2_Code(size) As String
        Dim Booking_Stage3_Code(size) As String
        Dim Booking_Number(size) As Integer

        'Initializing Arrays

        Home_Start_Code(0) = "C1"
        Home_Start_Code(1) = "C2"
        Home_Start_Code(2) = "C3"
        Home_Start_Code(3) = "C4"
        Home_Start_Code(4) = "C5"

        Home_Start_Price(0) = "1.50"
        Home_Start_Price(1) = "3.00"
        Home_Start_Price(2) = "4.50"
        Home_Start_Price(3) = "6.00"
        Home_Start_Price(4) = "8.00"

        Start_End_Code(0) = "M1"
        Start_End_Code(1) = "M2"
        Start_End_Code(2) = "M3"
        Start_End_Code(3) = "M4"
        Start_End_Code(4) = "M5"

        Start_End_Price(0) = "5.75"
        Start_End_Price(1) = "12.50"
        Start_End_Price(2) = "22.25"
        Start_End_Price(3) = "34.50"
        Start_End_Price(4) = "45.00"

        End_Destination_Code(0) = "F1"
        End_Destination_Code(1) = "F2"
        End_Destination_Code(2) = "F3"
        End_Destination_Code(3) = "F4"
        End_Destination_Code(4) = "F5"

        End_Destination_Price(0) = "1.50"
        End_Destination_Price(1) = "3.00"
        End_Destination_Price(2) = "4.50"
        End_Destination_Price(3) = "6.00"
        End_Destination_Price(4) = "8.00"



        'Task 2
        'Declaring variables

        Dim Found As Boolean = Found
        Dim Initial_Account_Number As Integer = 1000
        Dim Initial_Booking_Number As Integer = 1
        Dim To_Continue As String = ""
        Dim Index As Integer = 0
        Dim Index2 As Integer = 0
        Dim Valid As Boolean = False
        Dim Total_Journey_Price As Double = 0
        Dim Correct As Boolean = False
        Dim Account_Index As Integer = 0
        'Creating passenger accounts

        Do
            Account_Number(Account_Index) = Initial_Account_Number
            Console.WriteLine("Your passenger account number is " & Account_Number(Account_Index))
            Initial_Account_Number += 1

            Console.WriteLine("Enter your passenger account name ")
            Account_Name(Account_Index) = Console.ReadLine()

            If Account_Index <= size Then
                Console.WriteLine("Do you want to open another account? (answer with yes or no)")
                To_Continue = Console.ReadLine()
                Valid = False
                Do
                    If To_Continue = "yes" Then
                        Account_Index += 1
                        Valid = True
                    ElseIf To_Continue <> "no" Then
                        Console.WriteLine("Invalid input, please try again")
                        To_Continue = Console.ReadLine()
                    Else
                        Valid = True
                    End If
                Loop Until Valid = True
            End If

        Loop Until To_Continue = "no" Or Account_Index > size

        'Creating a booking
        Valid = False
        Index = 0
        To_Continue = ""
        Do

            Do
                Console.WriteLine("To start the booking, enter your passenger account number")
                Booking_Account_Number(Index) = Console.ReadLine()
                While Valid = False And Index2 <= size
                    Do
                        If Booking_Account_Number(Index) = Account_Number(Index2) Then
                            Found = True
                            Valid = True
                        Else
                            Index2 += 1
                        End If
                    Loop Until Found = True Or Index2 > size
                    If Found = False Then
                        Console.WriteLine("This passenger account number does not exist, please try again")
                        Booking_Account_Number(Index) = Console.ReadLine()
                    End If
                End While

                Console.WriteLine("Enter the start time of your journey in the form of HH:MM")
                Booking_Start_Time(Index) = Console.ReadLine()
                Valid = False
                While Valid = False

                    If CInt(Left(Booking_Start_Time(Index), 2)) >= 0 And CInt(Right(Booking_Start_Time(Index), 2)) < 60 Then
                        Valid = True
                    Else
                        Console.WriteLine("Start time invalid, please try again")
                        Booking_Start_Time(Index) = Console.ReadLine()
                    End If
                End While



                Console.WriteLine("Enter a code for each stage of your journey : ")
                Console.WriteLine("For the First stage choose from: C1($1.50),C2($3.00),C3(4.50),C4($6.00),C5($8.00)")
                Booking_Stage1_Code(Index) = Console.ReadLine()
                Valid = False
                Do
                    If Booking_Stage1_Code(Index) = "C1" Or Booking_Stage1_Code(Index) = "C2" Or Booking_Stage1_Code(Index) = "C3" Or Booking_Stage1_Code(Index) = "C4" Or Booking_Stage1_Code(Index) = "C5" Then
                        Valid = True
                    Else
                        Console.WriteLine("Invalid input, please try again")
                        Booking_Stage1_Code(Index) = Console.ReadLine()
                    End If
                Loop Until Valid = True
                For x = 0 To 4
                    If Booking_Stage1_Code(Index) = Home_Start_Code(x) Then
                        Total_Journey_Price += Home_Start_Price(x)
                    End If
                Next x
                Console.WriteLine("For the second stage choose from: M1($5.75),M2($12.50),M3($22.25),M4($34.50),M5($45.0)")

                Booking_Stage2_Code(Index) = Console.ReadLine()
                Valid = False
                Do
                    If Booking_Stage2_Code(Index) = "M1" Or Booking_Stage2_Code(Index) = "M2" Or Booking_Stage2_Code(Index) = "M3" Or Booking_Stage2_Code(Index) = "M4" Or Booking_Stage2_Code(Index) = "M5" Then
                        Valid = True
                    Else
                        Console.WriteLine("Invalid input, please try again")
                        Booking_Stage2_Code(Index) = Console.ReadLine()
                    End If
                Loop Until Valid = True
                For x = 0 To 4
                    If Booking_Stage2_Code(Index) = Start_End_Code(x) Then
                        Total_Journey_Price += Start_End_Price(x)
                    End If
                Next x
                Console.WriteLine("For the third stage choose from: F1($1.50),F2($3.00),F3($4.50),F4($6.00),F5($8.00)")

                Booking_Stage3_Code(Index) = Console.ReadLine()
                Valid = False
                Do
                    If Booking_Stage3_Code(Index) = "F1" Or Booking_Stage3_Code(Index) = "F2" Or Booking_Stage3_Code(Index) = "F3" Or Booking_Stage3_Code(Index) = "F4" Or Booking_Stage3_Code(Index) = "F5" Then
                        Valid = True
                    Else
                        Console.WriteLine("Invalid input, please try again")
                        Booking_Stage3_Code(Index) = Console.ReadLine()
                    End If
                Loop Until Valid = True
                For x = 0 To 4
                    If Booking_Stage3_Code(Index) = End_Destination_Code(x) Then
                        Total_Journey_Price += End_Destination_Price(x)
                    End If
                Next x
                Booking_Number(Index) = Initial_Booking_Number
                Console.WriteLine("Your Unique Booking number is " & Booking_Number(Index))
                Console.WriteLine("The total price before discount is $" & Total_Journey_Price)

                'Task 3 

                If CInt(Left(Booking_Start_Time(Index), 2)) > 10 Or (CInt(Left(Booking_Start_Time(Index), 2)) = 10 And CInt(Right(Booking_Start_Time(Index), 2)) > 0) Then
                    Total_Journey_Price = (60 / 100) * Total_Journey_Price
                End If
                Console.WriteLine("Journey details: ")
                Console.WriteLine("The total journey price is $" & Total_Journey_Price)
                Console.WriteLine("Your passenger account number is " & Booking_Account_Number(Index))
                Console.WriteLine("The start time of your journey is " & Booking_Start_Time(Index))
                Console.WriteLine("The code for 'Home to start station'stage of the journey is " & Booking_Stage1_Code(Index))
                Console.WriteLine("The code for 'Start to end station'stage of the journey is " & Booking_Stage2_Code(Index))
                Console.WriteLine("The code for 'End station to destination'stage of the journey is " & Booking_Stage3_Code(Index))
                Console.WriteLine("Your booking number is " & Booking_Number(Index))
                Console.WriteLine("Are your booking details correct? Please respond with True or False.")
                Correct = Console.ReadLine()

            Loop Until Correct = True
            Console.WriteLine("Do you want to create another booking ? (answer with yes or no)")
            To_Continue = Console.ReadLine()
            Do
                If To_Continue = "yes" Then
                    Valid = True
                ElseIf To_Continue <> "no" Then
                    Console.WriteLine("Invalid input, please try again")
                    To_Continue = Console.ReadLine()
                Else
                    Valid = True
                End If
            Loop Until Valid = True
            Initial_Account_Number += 1
            Index += 1

        Loop Until To_Continue = "no"

    End Sub

End Module
