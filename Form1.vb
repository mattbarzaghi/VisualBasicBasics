Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnHelloWorld.Click

        ' two ways to show messages
        MsgBox("Hello VB .NET")
        MsgBox("This is the first type of Message box")

        ' object oriented approach to show message
        MessageBox.Show("This is the second type of Message box")

    End Sub

    Private Sub btnVariables_Click(sender As Object, e As EventArgs) Handles btnVariables.Click

        ' a variable is a location in the computer memory where is stored an information

        ' declaring a variable
        Dim shortForDimension As String = "This is stored somewhere in the memory"
        MessageBox.Show(shortForDimension)

        Dim name As String = "Matteo"
        Dim surname As String = "Barzaghi"

        MessageBox.Show("Hello " & name & " " & surname & ", this is an example of string concatenation")

    End Sub

    Private Sub btnDataTypes_Click(sender As Object, e As EventArgs) Handles btnDataTypes.Click

        ' declaring variables with different Data Type

        Dim carModel As String = "Ford Focus"
        Dim carDoors As Integer = 5
        Dim carAvailable As Boolean = True
        Dim carPrice As Decimal = "999.99"
        Dim registrationDate As Date = #03/25/2022# '# are used as appendix ' 

        MessageBox.Show(carModel & vbNewLine &
                        carDoors & vbNewLine &
                        carPrice & vbNewLine &
                        carAvailable & vbNewLine &
                        registrationDate)

    End Sub
End Class