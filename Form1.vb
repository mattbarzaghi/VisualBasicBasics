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

        MessageBox.Show(carModel & vbCrLf &
                        carDoors & vbCrLf &
                        carPrice & vbCrLf &
                        carAvailable & vbCrLf &
                        registrationDate)

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        Dim userName As String = txtName.Text
        Dim userSurname As String = txtSurname.Text

        MessageBox.Show("Welcome " & userName & " " & txtSurname.Text)
        MessageBox.Show("You are " & listBoxProfession.Text)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show("Hello welcome to a sample program that explores the basics of VB")
        MessageBox.Show("Press OK to continue")
    End Sub

    Private Sub btnSum_Click(sender As Object, e As EventArgs) Handles btnSum.Click

        Dim numberOne As Integer = numberOneBox.Text
        Dim numberTwo As Integer = numberTwoBox.Text
        Dim resultIs As Integer = numberOne + numberTwo

        MessageBox.Show(resultIs)

    End Sub
End Class