<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnHelloWorld = New System.Windows.Forms.Button()
        Me.btnVariables = New System.Windows.Forms.Button()
        Me.btnDataTypes = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.labelName = New System.Windows.Forms.Label()
        Me.labelSurname = New System.Windows.Forms.Label()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.listBoxProfession = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnHelloWorld
        '
        Me.btnHelloWorld.Location = New System.Drawing.Point(12, 10)
        Me.btnHelloWorld.Name = "btnHelloWorld"
        Me.btnHelloWorld.Size = New System.Drawing.Size(94, 30)
        Me.btnHelloWorld.TabIndex = 0
        Me.btnHelloWorld.Text = "Hello World"
        Me.btnHelloWorld.UseVisualStyleBackColor = True
        '
        'btnVariables
        '
        Me.btnVariables.Location = New System.Drawing.Point(112, 10)
        Me.btnVariables.Name = "btnVariables"
        Me.btnVariables.Size = New System.Drawing.Size(94, 29)
        Me.btnVariables.TabIndex = 1
        Me.btnVariables.Text = "Variables"
        Me.btnVariables.UseVisualStyleBackColor = True
        '
        'btnDataTypes
        '
        Me.btnDataTypes.Location = New System.Drawing.Point(212, 9)
        Me.btnDataTypes.Name = "btnDataTypes"
        Me.btnDataTypes.Size = New System.Drawing.Size(94, 30)
        Me.btnDataTypes.TabIndex = 2
        Me.btnDataTypes.Text = "Data Types"
        Me.btnDataTypes.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(58, 46)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(94, 23)
        Me.txtName.TabIndex = 4
        '
        'labelName
        '
        Me.labelName.AutoSize = True
        Me.labelName.Location = New System.Drawing.Point(11, 49)
        Me.labelName.Name = "labelName"
        Me.labelName.Size = New System.Drawing.Size(39, 15)
        Me.labelName.TabIndex = 5
        Me.labelName.Text = "Name"
        '
        'labelSurname
        '
        Me.labelSurname.AutoSize = True
        Me.labelSurname.Location = New System.Drawing.Point(163, 49)
        Me.labelSurname.Name = "labelSurname"
        Me.labelSurname.Size = New System.Drawing.Size(54, 15)
        Me.labelSurname.TabIndex = 6
        Me.labelSurname.Text = "Surname"
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(223, 46)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(94, 23)
        Me.txtSurname.TabIndex = 7
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(329, 45)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(94, 23)
        Me.btnSubmit.TabIndex = 8
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'listBoxProfession
        '
        Me.listBoxProfession.FormattingEnabled = True
        Me.listBoxProfession.ItemHeight = 15
        Me.listBoxProfession.Items.AddRange(New Object() {"Programmer", "Tester", "Unemployed"})
        Me.listBoxProfession.Location = New System.Drawing.Point(80, 88)
        Me.listBoxProfession.Name = "listBoxProfession"
        Me.listBoxProfession.Size = New System.Drawing.Size(94, 49)
        Me.listBoxProfession.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 15)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Profession"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(516, 413)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.listBoxProfession)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtSurname)
        Me.Controls.Add(Me.labelSurname)
        Me.Controls.Add(Me.labelName)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btnDataTypes)
        Me.Controls.Add(Me.btnVariables)
        Me.Controls.Add(Me.btnHelloWorld)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnHelloWorld As Button
    Friend WithEvents btnVariables As Button
    Friend WithEvents btnDataTypes As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents labelName As Label
    Friend WithEvents labelSurname As Label
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents listBoxProfession As ListBox
    Friend WithEvents Label1 As Label
End Class
