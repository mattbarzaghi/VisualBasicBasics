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
        Me.SuspendLayout()
        '
        'btnHelloWorld
        '
        Me.btnHelloWorld.Location = New System.Drawing.Point(12, 10)
        Me.btnHelloWorld.Name = "btnHelloWorld"
        Me.btnHelloWorld.Size = New System.Drawing.Size(79, 30)
        Me.btnHelloWorld.TabIndex = 0
        Me.btnHelloWorld.Text = "Hello World"
        Me.btnHelloWorld.UseVisualStyleBackColor = True
        '
        'btnVariables
        '
        Me.btnVariables.Location = New System.Drawing.Point(97, 11)
        Me.btnVariables.Name = "btnVariables"
        Me.btnVariables.Size = New System.Drawing.Size(73, 29)
        Me.btnVariables.TabIndex = 1
        Me.btnVariables.Text = "Variables"
        Me.btnVariables.UseVisualStyleBackColor = True
        '
        'btnDataTypes
        '
        Me.btnDataTypes.Location = New System.Drawing.Point(176, 10)
        Me.btnDataTypes.Name = "btnDataTypes"
        Me.btnDataTypes.Size = New System.Drawing.Size(75, 30)
        Me.btnDataTypes.TabIndex = 2
        Me.btnDataTypes.Text = "Data Types"
        Me.btnDataTypes.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(516, 413)
        Me.Controls.Add(Me.btnDataTypes)
        Me.Controls.Add(Me.btnVariables)
        Me.Controls.Add(Me.btnHelloWorld)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnHelloWorld As Button
    Friend WithEvents btnVariables As Button
    Friend WithEvents btnDataTypes As Button
End Class
