
Option Strict On

''' <summary>
''' Author: Alfred Massardo
''' Project Name: DemoIfLoopArrayVB
''' Date: 01-Jan-2018
''' Description: Application to demonstrate various VB constructs.
''' </summary>

Public Class frmDemoIfLoopArray

#Region "If"

    ''' <summary>
    ''' Enter a number and click Enter. 
    ''' It will test If the number Is a... 
    '''    1. Number 
    '''    2. Double 
    '''    3. Integer
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnIfDemo_Click(sender As Object, e As EventArgs) Handles btnIfDemo.Click


        ' variables
        Dim userInput As String = String.Empty  ' Holds the user input as a string
        Dim userInputDouble As Double = 0.0     ' Holds the user input if it converts to a Double
        Dim userInputInteger As Integer = 0     ' Holds the user input if it converts to a Integer
        Dim output As String = String.Empty     ' Holds the output to be displayed to the user

        ' Enter a break point on userInput = tbIfInput.Text and you can 
        ' watch the execution of the code from start to finish
        ' press...
        '   F10 - step over
        '   F11 - step into (this is when you want to step into functions)
        userInput = tbIfInput.Text  ' Get the input from the text box


        If (Integer.TryParse(userInput, userInputInteger)) Then ' If the input is an Integer

            ' create the message to be output to the user
            output = userInputInteger.ToString("n0") & " = Integer"

        ElseIf (Double.TryParse(userInput, userInputDouble)) Then ' If the input is an Double

            ' create the message to be output to the user
            output = userInputDouble.ToString("n2") & " = Double"

        Else ' Otherwise the input is Not a Number

            ' create the message to be output to the user
            output = userInput & " = Not a Number (NaN)"

        End If

        ' output the message to the user
        lbIfOutput.Text = output

    End Sub

#End Region

#Region "Nested If"

    ''' <summary>
    ''' Enter a number and click Enter. 
    ''' It will test If the number Is a... 
    '''    1. Number 
    '''    2. Double 
    '''    3. Integer
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnNestedIfDemo_Click(sender As Object, e As EventArgs) Handles btnNestedIfDemo.Click

        ' variables
        Dim userInput As String = String.Empty  ' Holds the user input as a string
        Dim userInputDouble As Double = 0.0     ' Holds the user input if it converts to a Double
        Dim userInputInteger As Integer = 0     ' Holds the user input if it converts to a Integer
        Dim output As String = String.Empty     ' Holds the output to be displayed to the user

        ' Enter a break point on userInput = tbNestedIfInput.Text and you can 
        ' watch the execution of the code from start to finish
        ' press...
        '   F10 - step over
        '   F11 - step into (this is when you want to step into functions)

        userInput = tbNestedIfInput.Text  ' Get the input from the text box

        If (Double.TryParse(userInput, userInputDouble)) Then ' If the input is an Double

            If (Integer.TryParse(userInput, userInputInteger)) Then ' If the input is an Integer


                ' create the message to be output to the user
                ' processing
                output = userInputInteger.ToString("n0") & " = Integer"

            Else

                ' create the message to be output to the user
                ' invalid input integer required
                output = "Integer required " & userInputDouble.ToString("n2") & " = Double"

            End If


        Else ' Otherwise the input is Not a Number

            ' create the message to be output to the user
            ' invalid input integer required
            output = "Integer required " & userInput & " = Not a Number (NaN)"

        End If

        ' output the message to the user
        lbNestedIfOutput.Text = output

    End Sub

#End Region

#Region "For Loop"

    ''' <summary>
    ''' Enter a number and click Enter. 
    ''' This will Loop until the number 
    ''' you have entered Is reached.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnForLoopDemo_Click(sender As Object, e As EventArgs) Handles btnForLoopDemo.Click

        ' variables
        Dim userInput As String = String.Empty  ' Holds the user input as a string
        Dim userInputDouble As Double = 0.0     ' Holds the user input if it converts to a Double
        Dim userInputInteger As Integer = 0     ' Holds the user input if it converts to a Integer
        Dim output As String = String.Empty     ' Holds the output to be displayed to the user

        userInput = tbForLoopDemoInput.Text  ' Get the input from the text box

        If (Double.TryParse(userInput, userInputDouble)) Then ' If the input is an Double

            If (Integer.TryParse(userInput, userInputInteger)) Then ' If the input is an Integer


                ' processing

                ' Enter a break point on For counter As Integer = 1 To userInputInteger and you can 
                ' watch the execution of the code from start to finish
                ' press...
                '   F10 - step over
                '   F11 - step into (this is when you want to step into functions)

                ' loop starting at the number 1
                ' until the counter has reached
                ' the number the user has input
                '      initializer;        condition;              iterat
                For counter As Integer = 1 To userInputInteger ' initialize the variable and specifies the test

                    ' append number to the output
                    output += counter.ToString & " "

                    ' 1 2 3 4 5
                Next counter 'pseudo incrementer - even If the counter was Not beside Next it would still increment
                ' iterator

            Else

                ' create the message to be output to the user
                ' invalid input integer required
                output = "Integer required " & userInputDouble.ToString("n2") & " = Double"

            End If


        Else ' Otherwise the input is Not a Number

            ' create the message to be output to the user
            ' invalid input integer required
            output = "Integer required " & userInput & " = Not a Number (NaN)"

        End If

        ' output the message to the user
        lbForLoopDemoOutput.Text = output

    End Sub
#End Region

#Region "For Loop with Break"

    ''' <summary>
    ''' Enter a number and click Enter. 
    ''' This will Loop until the number entered  
    ''' is reached or until the loop limit is reached.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnForLoopBreakDemo_Click(sender As Object, e As EventArgs) Handles btnForLoopBreakDemo.Click

        Const loopLimit As Integer = 20

        ' variables
        Dim userInput As String = String.Empty  ' Holds the user input as a string
        Dim userInputDouble As Double = 0.0     ' Holds the user input if it converts to a Double
        Dim userInputInteger As Integer = 0     ' Holds the user input if it converts to a Integer
        Dim output As String = String.Empty     ' Holds the output to be displayed to the user

        userInput = tbForLoopBreakDemoInput.Text  ' Get the input from the text box

        If (Double.TryParse(userInput, userInputDouble)) Then ' If the input is an Double

            If (Integer.TryParse(userInput, userInputInteger)) Then ' If the input is an Integer

                ' processing

                ' Enter a break point on For counter As Integer = 1 To userInputInteger and you can 
                ' watch the execution of the code from start to finish
                ' press...
                '   F10 - step over
                '   F11 - step into (this is when you want to step into functions)

                ' loop starting at the number 1
                ' until the counter has reached
                ' the number the user has input
                For counter As Integer = 1 To loopLimit ' initialize the variable and specifies the test

                    ' append number to the output
                    output += counter.ToString & " " ' & vbCrLf

                    ' Check if the counter has reached 
                    ' the user input
                    If userInputInteger = counter Then

                        ' set the counter to the loopLimit
                        ' to stop the loop
                        counter = loopLimit

                        ' no breaks or continues required

                    End If

                Next counter ' pseudo incrementer - even if the counter was not beside Next it would still increment

            Else

                ' create the message to be output to the user
                ' invalid input integer required
                output = "Integer required " & userInputDouble.ToString("n2") & " = Double"

            End If


        Else ' Otherwise the input is Not a Number

            ' create the message to be output to the user
            ' invalid input integer required
            output = "Integer required " & userInput & " = Not a Number (NaN)"

        End If

        ' output the message to the user
        lbForLoopBreakDemoOutput.Text = output

    End Sub
#End Region

#Region "While Loop"

    ''' <summary>
    ''' Enter a number and click Enter. 
    ''' This will Loop until the number 
    ''' you have entered Is reached.
    ''' </summary>
    ''' <param name="sender"></param>
    Private Sub btnWhileLoopDemoOutput_Click(sender As Object, e As EventArgs) Handles btnWhileLoopDemo.Click


        ' variables
        Dim userInput As String = String.Empty  ' Holds the user input as a string
        Dim userInputDouble As Double = 0.0     ' Holds the user input if it converts to a Double
        Dim userInputInteger As Integer = 0     ' Holds the user input if it converts to a Integer
        Dim output As String = String.Empty     ' Holds the output to be displayed to the user
        Dim counter As Integer = 1              ' Holds the an interger used to count 

        userInput = tbWhileLoopDemoInput.Text  ' Get the input from the text box

        If (Double.TryParse(userInput, userInputDouble)) Then ' If the input is an Double

            If (Integer.TryParse(userInput, userInputInteger)) Then ' If the input is an Integer


                ' processing

                ' Enter a break point on For counter As Integer = 1 To userInputInteger and you can 
                ' watch the execution of the code from start to finish
                ' press...
                '   F10 - step over
                '   F11 - step into (this is when you want to step into functions)

                ' loop starting at the number 1
                ' until the counter has reached
                ' the number the user has input

                While (counter <= userInputInteger)

                    ' append number to the output
                    output += counter.ToString & " "

                    ' increment counter
                    counter += 1

                End While

            Else

                ' create the message to be output to the user
                ' invalid input integer required
                output = "Integer required " & userInputDouble.ToString("n2") & " = Double"

            End If


        Else ' Otherwise the input is Not a Number

            ' create the message to be output to the user
            ' invalid input integer required
            output = "Integer required " & userInput & " = Not a Number (NaN)"

        End If

        ' output the message to the user
        lbWhileLoopDemoOutput.Text = output

    End Sub
#End Region

#Region "While Loop with Break"

    ''' <summary>
    ''' Enter a number and click Enter. 
    ''' This will Loop until the number entered  
    ''' is reached or until the loop limit is reached.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnWhileLoopBreakDemoOutput_Click(sender As Object, e As EventArgs) Handles btnWhileLoopBreakDemo.Click

        Const loopLimit As Integer = 15

        ' variables
        Dim userInput As String = String.Empty  ' Holds the user input as a string
        Dim userInputDouble As Double = 0.0     ' Holds the user input if it converts to a Double
        Dim userInputInteger As Integer = 0     ' Holds the user input if it converts to a Integer
        Dim output As String = String.Empty     ' Holds the output to be displayed to the user
        Dim counter As Integer = 1              ' Holds the an interger used to count 

        userInput = tbWhileLoopBreakDemoInput.Text  ' Get the input from the text box

        If (Double.TryParse(userInput, userInputDouble)) Then ' If the input is an Double

            If (Integer.TryParse(userInput, userInputInteger)) Then ' If the input is an Integer


                ' processing

                ' Enter a break point on For counter As Integer = 1 To userInputInteger and you can 
                ' watch the execution of the code from start to finish
                ' press...
                '   F10 - step over
                '   F11 - step into (this is when you want to step into functions)

                ' loop starting at the number 1
                ' until the counter has reached
                ' the number the user has input

                While (counter <= loopLimit)

                    ' append number to the output
                    output += counter.ToString & " "

                    ' Check if the counter has reached 
                    ' the user input
                    If userInputInteger = counter Then

                        ' set the counter to the loopLimit
                        ' to stop the loop
                        counter = loopLimit + 1

                        ' no breaks or continues required
                    Else

                        ' increment counter
                        counter += 1

                    End If


                End While

            Else

                ' create the message to be output to the user
                ' invalid input integer required
                output = "Integer required " & userInputDouble.ToString("n2") & " = Double"

            End If


        Else ' Otherwise the input is Not a Number

            ' create the message to be output to the user
            ' invalid input integer required
            output = "Integer required " & userInput & " = Not a Number (NaN)"

        End If

        ' output the message to the user
        lbWhileLoopBreakDemoOutput.Text = output

    End Sub
#End Region

#Region "Do While Loop"

    ''' <summary>
    ''' Enter a number and click Enter. 
    ''' This will Loop until the number 
    ''' you have entered Is reached.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnDoWhileLoopDemo_Click(sender As Object, e As EventArgs) Handles btnDoWhileLoopDemo.Click


        ' variables
        Dim userInput As String = String.Empty  ' Holds the user input as a string
        Dim userInputDouble As Double = 0.0     ' Holds the user input if it converts to a Double
        Dim userInputInteger As Integer = 0     ' Holds the user input if it converts to a Integer
        Dim output As String = String.Empty     ' Holds the output to be displayed to the user
        Dim counter As Integer = 1              ' Holds the an interger used to count 

        userInput = tbDoWhileLoopDemoInput.Text  ' Get the input from the text box

        If (Double.TryParse(userInput, userInputDouble)) Then ' If the input is an Double

            If (Integer.TryParse(userInput, userInputInteger)) Then ' If the input is an Integer


                ' processing

                ' Enter a break point on For counter As Integer = 1 To userInputInteger and you can 
                ' watch the execution of the code from start to finish
                ' press...
                '   F10 - step over
                '   F11 - step into (this is when you want to step into functions)

                ' loop starting at the number 1
                ' until the counter has reached
                ' the number the user has input
                Do

                    ' append number to the output
                    output += counter.ToString & " "

                    ' increment counter
                    counter += 1

                Loop While (counter <= userInputInteger)

            Else

                ' create the message to be output to the user
                ' invalid input integer required
                output = "Integer required " & userInputDouble.ToString("n2") & " = Double"

            End If


        Else ' Otherwise the input is Not a Number

            ' create the message to be output to the user
            ' invalid input integer required
            output = "Integer required " & userInput & " = Not a Number (NaN)"

        End If

        ' output the message to the user
        lbDoWhileLoopDemoOutput.Text = output


    End Sub

#End Region

#Region "Do While Loop with Break"

    ''' <summary>
    ''' Enter a number and click Enter. 
    ''' This will Loop until the number entered  
    ''' is reached or until the loop limit is reached.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnDoWhileLoopBreakDemo_Click_1(sender As Object, e As EventArgs) Handles btnDoWhileLoopBreakDemo.Click

        Const loopLimit As Integer = 18

        ' variables
        Dim userInput As String = String.Empty  ' Holds the user input as a string
        Dim userInputDouble As Double = 0.0     ' Holds the user input if it converts to a Double
        Dim userInputInteger As Integer = 0     ' Holds the user input if it converts to a Integer
        Dim output As String = String.Empty     ' Holds the output to be displayed to the user
        Dim counter As Integer = 1              ' Holds the an interger used to count 

        userInput = tbDoWhileLoopBreakDemoInput.Text  ' Get the input from the text box

        If (Double.TryParse(userInput, userInputDouble)) Then ' If the input is an Double

            If (Integer.TryParse(userInput, userInputInteger)) Then ' If the input is an Integer


                ' processing

                ' Enter a break point on For counter As Integer = 1 To userInputInteger and you can 
                ' watch the execution of the code from start to finish
                ' press...
                '   F10 - step over
                '   F11 - step into (this is when you want to step into functions)

                ' loop starting at the number 1
                ' until the counter has reached
                ' the number the user has input

                Do

                    ' append number to the output
                    output += counter.ToString & " "

                    If userInputInteger = counter Then

                        ' set the counter to the loopLimit
                        ' to stop the loop
                        counter = loopLimit

                    End If

                    ' increment counter
                    counter += 1

                Loop While (counter <= loopLimit)

            Else

                ' create the message to be output to the user
                ' invalid input integer required
                output = "Integer required " & userInputDouble.ToString("n2") & " = Double"

            End If


        Else ' Otherwise the input is Not a Number

            ' create the message to be output to the user
            ' invalid input integer required
            output = "Integer required " & userInput & " = Not a Number (NaN)"

        End If

        ' output the message to the user
        lbDoWhileLoopBreakDemoOutput.Text = output

    End Sub
#End Region

#Region "Create an Array"

    ''' <summary>
    ''' Enter a number and click Enter. 
    ''' This will create an array Of the 
    ''' number of elements specified. 
    ''' Then each element of the array
    ''' will be filled by looping the array 
    ''' and countingby 2s.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnCreateArrayDemo_Click(sender As Object, e As EventArgs) Handles btnCreateArrayDemo.Click

        Const minimumArraySize As Integer = 1

        ' variables
        Dim userInput As String = String.Empty  ' Holds the user input as a string
        Dim userInputDouble As Double = 0.0     ' Holds the user input if it converts to a Double
        Dim userInputInteger As Integer = 0     ' Holds the user input if it converts to a Integer
        Dim output As String = String.Empty     ' Holds the output to be displayed to the user
        Dim demoArray() As Integer

        userInput = tbCreateArrayInput.Text  ' Get the input from the text box

        If (Double.TryParse(userInput, userInputDouble)) Then ' If the input is an Double

            If (Integer.TryParse(userInput, userInputInteger) AndAlso ' If the input is an Integer
               userInputInteger >= minimumArraySize) Then             ' Also, there must be at least 1 element

                ' processing

                ' create the array with the number of 
                ' elements specifiedby the iuser
                ' The reason for the -1 is the VB is
                ' a little different than other languages
                ' like c#. If you create the array with a 
                ' size of 10 it will create an array with
                ' 11 elements, 0 - 10 inclusive.
                demoArray = New Integer(userInputInteger - 1) {}

                ' Enter a break point on For counter As Integer = 1 To userInputInteger and you can 
                ' watch the execution of the code from start to finish
                ' press...
                '   F10 - step over
                '   F11 - step into (this is when you want to step into functions)

                ' loop starting at the number 0
                ' until the index has reached
                ' the length/size of the array
                ' -1. (Zero based index)
                For index As Integer = 0 To demoArray.Length - 1 ' initialize the variable and specifies the test

                    ' fill the element at the
                    ' index specified
                    demoArray(index) = (index + 1) * 2

                Next index ' pseudo incrementer - even if the index was not beside Next it would still increment

                ' loop starting at the number 0
                ' until the index has reached
                ' the length/size of the array
                ' -1. (Zero based index)
                For index As Integer = 0 To demoArray.Length - 1 ' initialize the variable and specifies the test

                    ' append number to the output
                    output += demoArray(index).ToString() & " " ' & vbCrLf
                    ' 2 4 6 8 10 12...
                    ' 2
                    ' 4
                    ' 6
                    ' ...
                Next index ' pseudo incrementer - even if the index was not beside Next it would still increment

            Else

                ' create the message to be output to the user
                ' invalid input integer required
                output = "Arrays size must be an Integer/Whole number with a minimum value of " & minimumArraySize.ToString() & vbCrLf & "Your input was " & userInputDouble.ToString("n0")

            End If

        Else ' Otherwise the input is Not a Number

            ' create the message to be output to the user
            ' invalid input integer required
            output = "Integer required " & userInput & " = Not a Number (NaN)"

        End If

        ' output the message to the user
        lbCreateArrayOutput.Text = output

    End Sub

#End Region

#Region "Add Method/Function Demo"

    ''' <summary>
    ''' btnAddDemo_Click - event that fires when the btnAddDemo is click and demonstrates a method function by calling a simple add method/function.
    ''' </summary>
    ''' <param name="sender">Object</param>
    ''' <param name="e">EventArgs</param>
    Private Sub btnAddDemo_Click(sender As Object, e As EventArgs) Handles btnAddDemo.Click

        Dim inputNumberOneString As String = String.Empty   ' holds the string assigned from text box one
        Dim inputNumberTwoString As String = String.Empty   ' holds the string assigned from text box two
        Dim inputNumberOne As Double = 0.0                  ' holds the double converted and assigned from input number one string.
        Dim inputNumberTwo As Double = 0.0                  ' holds the double converted and assigned from input number two string.
        Dim summedNumber As Double = 0.0                    ' holds the double assigned from Add function.

        ' get the input from the textboxes
        inputNumberOneString = tbNumberOne.Text     ' get the string input from text box one
        inputNumberTwoString = tbNumberTwo.Text     ' get the string input from text box two

        ' convert the string input to doubles
        ' ( I'm not validating to see if the strings are doubles, so the code is much simpler. The concept to be learned here is how to create and call a method/function)
        inputNumberOne = Convert.ToDouble(inputNumberOneString) ' convert the 1st number string to a double and assign it to the input number one (double) variable
        inputNumberTwo = Convert.ToDouble(inputNumberTwoString) ' convert the 2st number string to a double and assign it to the input number two (double) variable

        ' call the Add method/function and pass it the two double variables
        ' the 1st argument passed is the input number one (double) variable
        ' the 2nd argument passed is the input number two (double) variable.
        ' The returned value of the function is assigned (=) to the summed number (double) variable
        summedNumber = Add(inputNumberOne, inputNumberTwo)

        ' display the the result to the user by
        ' converting all three variable to strings
        ' and contatenating them to show a simple 
        ' addition math equation.
        lbAddDemoOutput.Text = summedNumber.ToString("n2") & " = " & inputNumberOne.ToString("n2") & " + " & inputNumberTwo.ToString("n2")

    End Sub

    ''' <summary>
    ''' Add - Adds two numbers
    ''' </summary>
    ''' <param name="numberOne">Double</param>
    ''' <param name="numberTwo">Double</param>
    ''' <returns>Double - the sum of the two arguments passed to the Method/Function</returns>
    Private Function Add(numberOne As Double, numberTwo As Double) As Double
        ' Modifiers / Function / FunctionName / (Parameters) / Return DataType

        ' --------------------------------- Access Modifiers -------------------------------
        'Public             - No access restrictions. Access Is available To other projects, applications, etc. 
        '                       (Public should be your last consideration When deciding on an access modifier.)
        'Protected          - Access limited to containing And inherited classes. Inheritance will be covered fully in NETD II
        'Private            - Access limited To containing Class, module or structure.
        '                       (Private should be your first consideration When deciding on an access modifier.)
        'Friend             - Access limited to the current project.
        'Protected Friend   - Access limited to containing And inherited classes And the current project.
        'https://docs.microsoft.com/en-us/dotnet/visual-basic/programming-guide/language-features/declared-elements/access-levels
        ' ----------------------------------------------------------------------------------

        ' Statements - start

        ' declare a variable to hold the return value that will be summed
        ' based on the two
        Dim returnSumNumber As Double = 0.0

        ' add number one and number two and assign the
        ' value to return sum mumber.
        returnSumNumber = numberOne + numberTwo

        ' return the value in return sum number
        ' back to the code that called our Add
        ' method
        Return returnSumNumber

        ' Statements - end

    End Function

    ''' <summary>
    ''' Add - Adds any number of numbers, but the numbers must be passed in as a double array
    ''' </summary>
    ''' <param name="numbers">Double()</param>
    ''' <returns>Double - the sum of the array argument passed to the Method/Function</returns>
    Private Function Add(numbers As Double()) As Double

        ' declare a variable to hold the return value that will be summed
        ' based on the summed numbers in the array
        Dim returnSummedNumber As Double = 0.0


        ' loop the array And continually add
        ' the current element to the summed number to be returned
        For index As Integer = 0 To numbers.Length - 1

            ' add the current numbers element to
            ' the summed number to be returned
            returnSummedNumber += numbers(index)

        Next index

        ' return the value in return sum number
        ' back to the code that called our Add
        ' method
        Return returnSummedNumber

    End Function

#End Region

#Region "Method Demo"

    ''' <summary>
    ''' Enter a number and click Enter. 
    ''' This will create an array Of the 
    ''' number of elements specified. 
    ''' Then each element of the array
    ''' will be filled by looping the array 
    ''' and counting by 2s. Uses a 
    ''' method to create the array And 
    ''' a method To create output.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnMethodDemo_Click(sender As Object, e As EventArgs) Handles btnMethodDemo.Click

        ' variables
        Dim userInput As String = String.Empty  ' Holds the user input as a string
        Dim userInputInteger As Integer = 0     ' Holds the user input if it converts to a Integer
        Dim output As String = String.Empty     ' Holds the output to be displayed to the user
        Dim demoArray() As Integer              ' Holds the values

        userInput = tbMethodInput.Text  ' Get the input from the text box

        ' check if the user input passes validation
        If IsValidInput(userInput, userInputInteger) Then

            ' Processing

            ' Enter a break point on For counter As Integer = 1 To userInputInteger and you can 
            ' watch the execution of the code from start to finish
            ' press...
            '   F10 - step over
            '   F11 - step into (this is when you want to step into functions)

            ' create the array
            demoArray = CreateAndLoadArray(userInputInteger)

            ' Output
            ' loop starting at the number 0
            ' until the index has reached
            ' the length/size of the array
            ' -1. (Zero based index)
            output = CreateOutput(demoArray)

            ' output the message to the user
            lbMethodOutput.Text = output

        End If


    End Sub

    ''' <summary>
    ''' IsValidInput - check the input to determine if it is a number and also confirms if it is a whole number.
    ''' </summary>
    ''' <param name="userInput">ByVal String</param>
    ''' <param name="returnInputInteger">ByRef - Integer</param>
    ''' <returns></returns>
    Private Function IsValidInput(userInput As String, ByRef validInputInteger As Integer) As Boolean

        Const minimumArraySize As Integer = 1

        Dim userInputDouble As Double = 0.0     ' Holds the user input if it converts to a Double
        Dim userInputInteger As Integer = 0     ' Holds the user input if it converts to a Integer
        Dim returnValue As Boolean = True       ' Holds the value that return to the calling code True if it passed validation. False if it did not.
        Dim output As String = String.Empty     ' Holds the output to be displayed to the user

        If (Double.TryParse(userInput, userInputDouble)) Then ' If the input is an Double

            If (Integer.TryParse(userInputDouble.ToString(), userInputInteger) AndAlso ' If the input is an Integer
               userInputInteger >= minimumArraySize) Then             ' Also, there must be at least 1 element

                ' set the valid input integer to be passed back to the calling code.
                validInputInteger = userInputInteger

                ' set the return boolean to true as it passed validation
                returnValue = True

            Else

                ' create the message to be output to the user
                ' invalid input integer required
                output = "Arrays size must be an Integer/Whole number with a minimum value of " & minimumArraySize.ToString() & vbCrLf & "Your input was " & userInputDouble.ToString("n0")

                ' set the valid input integer to be passed back to the calling code.
                validInputInteger = 0

                ' set to false as it did not pass validation
                returnValue = False

            End If

        Else ' Otherwise the input is Not a Number

            ' create the message to be output to the user
            ' invalid input integer required
            output = "Integer required " & userInput & " = Not a Number (NaN)"

            ' set the valid input integer to be passed back to the calling code.
            validInputInteger = 0

            ' set to false as it did not pass validation
            returnValue = False

        End If


        ' if the return value is false,
        ' as it did not pass validation,
        ' show the message in the output
        ' label
        If returnValue = False Then

            ' output the message to the user
            lbMethodOutput.Text = output

        End If

        ' return the boolean True if it passed validation, False if it did not
        Return returnValue

    End Function

    ''' <summary>
    ''' Function that accepts an integer representing the length 
    ''' of size of the array. It creates the array And then proceeds
    ''' to fill each element counting up by 2s.
    ''' </summary>
    ''' <param name="arrayLength"></param>
    ''' <returns>array of type integer</returns>
    Private Function CreateAndLoadArray(arrayLength As Integer) As Integer()

        ' create the array with the number of 
        ' elements specifiedby the user
        ' The reason for the -1 is the VB is
        ' a little different than other languages
        ' like c#. If you create the array with a 
        ' size of 10 it will create an array with
        ' 11 elements, 0 - 10 inclusive.

        ' create the array with the number of 
        ' elements specified by the user
        Dim returnArray() = New Integer(arrayLength - 1) {}

        ' Enter a break point on For counter As Integer = 1 To userInputInteger And you can 
        ' watch the execution of the code from start to finish
        ' press...
        '   F10 - step over
        '   F11 - step into (this Is when you want to step into functions)

        ' loop starting at the number 0
        ' until the index has reached
        ' the length/size of the array
        ' -1. (Zero based index)

        For index As Integer = 0 To returnArray.Length - 1

            ' append number to the output
            returnArray(index) = (index + 1) * 2

        Next index

        ' return the New array 
        ' to the calling code
        Return returnArray

    End Function

    ''' <summary>
    ''' Function that accepts an integer array as an argument.
    ''' It then loops through the array And create a string
    ''' based on the values in the array.
    ''' </summary>
    ''' <param name="arrayOfValues">integer array</param>
    ''' <returns>string</returns>
    Private Function CreateOutput(arrayOfValues() As Integer) As String
        Dim returnValue As String = String.Empty

        ' loop starting at the number 0
        ' until the index has reached
        ' the length/size of the array
        ' -1. (Zero based index)
        For index As Integer = 0 To arrayOfValues.Length - 1

            ' append number to the output
            returnValue += arrayOfValues(index).ToString() & " "

        Next index

        ' return the string that was
        ' created from the array that 
        ' was passed to the function/method
        Return returnValue

    End Function

#End Region

#Region "Reset Form"

    ''' <summary>
    ''' The Click event of the reset button Is fired when the
    ''' user clicks the reset button when they wish to clear the form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        resetForm()
    End Sub

    ''' <summary>
    ''' Private function that loops through the form And
    ''' determines if the control should be cleared. If so,
    ''' the control Is cleared.
    ''' </summary>
    Private Sub resetForm()

        ' declare a group box as 
        ' all other controls are
        ' within group boxes
        Dim groupBoxControl As GroupBox

        ' loop through each control that Is directly
        ' placed on the form (so the group boxes)
        For Each controlGroupBox As Object In Me.Controls


            ' if it Is a group box (which it will be)
            If (TypeOf (controlGroupBox) Is GroupBox) Then

                ' Convert And assign the current control to the
                ' group box variable.
                groupBoxControl = CType(controlGroupBox, GroupBox)

                ' Loop through the controls in the current group box
                For Each currentControl As Object In groupBoxControl.Controls

                    ' if the control Is a text box
                    If (TypeOf (currentControl) Is TextBox) Then

                        ' clear it
                        CType(currentControl, TextBox).Text = String.Empty

                    ElseIf (TypeOf (currentControl) Is Label) Then ' If the control Is a label

                        ' If the border style Is Fixed3D, meaning we use it
                        ' for output
                        If (CType(currentControl, Label).BorderStyle = BorderStyle.Fixed3D) Then

                            ' clear it 
                            CType(currentControl, Label).Text = String.Empty
                            ' all other labels will Not be touched
                        End If
                    End If
                Next currentControl
            End If
        Next controlGroupBox
    End Sub



#End Region

#Region "Assign appropriate Accept Button"

    ''' <summary>
    ''' Captures the GotFocus event for a number of controls when a specific controls gets focus this reset the accept button
    ''' to the appropriate button on the form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub input_GotFocus(sender As Object, e As EventArgs) Handles tbIfInput.GotFocus,
                                                                        tbNestedIfInput.GotFocus,
                                                                        tbForLoopDemoInput.GotFocus,
                                                                        tbForLoopBreakDemoInput.GotFocus,
                                                                        tbWhileLoopDemoInput.GotFocus,
                                                                        tbWhileLoopBreakDemoInput.GotFocus,
                                                                        tbDoWhileLoopDemoInput.GotFocus,
                                                                        tbDoWhileLoopBreakDemoInput.GotFocus,
                                                                        tbCreateArrayInput.GotFocus,
                                                                        tbMethodInput.GotFocus,
                                                                        tbNumberOne.GotFocus,
                                                                        tbNumberTwo.GotFocus

        ' set the control name
        Dim controlName As String = CType(sender, TextBox).Name

        ' check which text box has focus
        If controlName = "tbIfInput" Then

            ' set the accept button
            ' to the appropriate button
            Me.AcceptButton = btnIfDemo

        ElseIf controlName = "tbNestedIfInput" Then

            ' set the accept button
            ' to the appropriate button
            Me.AcceptButton = btnNestedIfDemo

        ElseIf controlName = "tbForLoopDemoInput" Then

            ' set the accept button
            ' to the appropriate button
            Me.AcceptButton = btnForLoopDemo

        ElseIf controlName = "tbForLoopBreakDemoInput" Then

            ' set the accept button
            ' to the appropriate button
            Me.AcceptButton = btnForLoopBreakDemo

        ElseIf controlName = "tbWhileLoopDemoInput" Then

            ' set the accept button
            ' to the appropriate button
            Me.AcceptButton = btnWhileLoopDemo

        ElseIf controlName = "tbWhileLoopBreakDemoInput" Then

            ' set the accept button
            ' to the appropriate button
            Me.AcceptButton = btnWhileLoopBreakDemo

        ElseIf controlName = "tbDoWhileLoopDemoInput" Then

            ' set the accept button
            ' to the appropriate button
            Me.AcceptButton = btnDoWhileLoopDemo

        ElseIf controlName = "tbDoWhileLoopBreakDemoInput" Then

            ' set the accept button
            ' to the appropriate button
            Me.AcceptButton = btnDoWhileLoopBreakDemo

        ElseIf controlName = "tbCreateArrayInput" Then

            ' set the accept button
            ' to the appropriate button
            Me.AcceptButton = btnCreateArrayDemo

        ElseIf controlName = "tbMethodInput" Then

            ' set the accept button
            ' to the appropriate button
            Me.AcceptButton = btnMethodDemo

        ElseIf controlName = "tbNumberOne" Or
           controlName = "tbNumberOne" Then

            ' set the accept button
            ' to the appropriate button
            Me.AcceptButton = btnAddDemo

        End If

    End Sub


#End Region

#Region "Close Form"

    ''' <summary>
    ''' btnExit_Click - when click will call the form method to close the form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        ' close the form 
        Me.Close()

    End Sub


#End Region

End Class
