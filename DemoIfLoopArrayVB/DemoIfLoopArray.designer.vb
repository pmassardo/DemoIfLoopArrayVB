<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDemoIfLoopArray
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDemoIfLoopArray))
        Me.grpIf = New System.Windows.Forms.GroupBox()
        Me.lbIfDescription = New System.Windows.Forms.Label()
        Me.lbIfOutput = New System.Windows.Forms.Label()
        Me.lbIfInput = New System.Windows.Forms.Label()
        Me.tbIfInput = New System.Windows.Forms.TextBox()
        Me.btnIfDemo = New System.Windows.Forms.Button()
        Me.DemoTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.lbNestedIfOutput = New System.Windows.Forms.Label()
        Me.tbNestedIfInput = New System.Windows.Forms.TextBox()
        Me.btnNestedIfDemo = New System.Windows.Forms.Button()
        Me.lbForLoopDemoOutput = New System.Windows.Forms.Label()
        Me.tbForLoopDemoInput = New System.Windows.Forms.TextBox()
        Me.btnForLoopDemo = New System.Windows.Forms.Button()
        Me.lbForLoopBreakDemoOutput = New System.Windows.Forms.Label()
        Me.tbForLoopBreakDemoInput = New System.Windows.Forms.TextBox()
        Me.btnForLoopBreakDemo = New System.Windows.Forms.Button()
        Me.lbWhileLoopDemoOutput = New System.Windows.Forms.Label()
        Me.tbWhileLoopDemoInput = New System.Windows.Forms.TextBox()
        Me.btnWhileLoopDemo = New System.Windows.Forms.Button()
        Me.lbWhileLoopBreakDemoOutput = New System.Windows.Forms.Label()
        Me.tbWhileLoopBreakDemoInput = New System.Windows.Forms.TextBox()
        Me.btnWhileLoopBreakDemo = New System.Windows.Forms.Button()
        Me.lbDoWhileLoopDemoOutput = New System.Windows.Forms.Label()
        Me.tbDoWhileLoopDemoInput = New System.Windows.Forms.TextBox()
        Me.btnDoWhileLoopDemo = New System.Windows.Forms.Button()
        Me.lbDoWhileLoopBreakDemoOutput = New System.Windows.Forms.Label()
        Me.tbDoWhileLoopBreakDemoInput = New System.Windows.Forms.TextBox()
        Me.btnDoWhileLoopBreakDemo = New System.Windows.Forms.Button()
        Me.lbCreateArrayOutput = New System.Windows.Forms.Label()
        Me.tbCreateArrayInput = New System.Windows.Forms.TextBox()
        Me.btnCreateArrayDemo = New System.Windows.Forms.Button()
        Me.grpNestedIf = New System.Windows.Forms.GroupBox()
        Me.lbNestedIfDescription = New System.Windows.Forms.Label()
        Me.lbNestedIfInput = New System.Windows.Forms.Label()
        Me.grpForLoop = New System.Windows.Forms.GroupBox()
        Me.lbForLoopDemoDescription = New System.Windows.Forms.Label()
        Me.lbForLoopDemoInput = New System.Windows.Forms.Label()
        Me.grpForLoopBreak = New System.Windows.Forms.GroupBox()
        Me.lbForLoopDemoBreakDescription = New System.Windows.Forms.Label()
        Me.lbForLoopBreakDemoInput = New System.Windows.Forms.Label()
        Me.grpWhileLoop = New System.Windows.Forms.GroupBox()
        Me.lbWhileLoopDemoInputDescription = New System.Windows.Forms.Label()
        Me.lbWhileLoopDemoInput = New System.Windows.Forms.Label()
        Me.grpWhileLoopBreak = New System.Windows.Forms.GroupBox()
        Me.lbWhileLoopDemoBreakDescription = New System.Windows.Forms.Label()
        Me.lbWhileLoopBreakDemoInput = New System.Windows.Forms.Label()
        Me.grpDoWhileLoop = New System.Windows.Forms.GroupBox()
        Me.lbDoWhileLoopDemoDescription = New System.Windows.Forms.Label()
        Me.lbDoWhileLoopDemoInput = New System.Windows.Forms.Label()
        Me.grpDoWhileLoopBreak = New System.Windows.Forms.GroupBox()
        Me.lbDoWhileLoopDemoBreakDescription = New System.Windows.Forms.Label()
        Me.lbDoWhileLoopBreakDemoInput = New System.Windows.Forms.Label()
        Me.grpCreateArray = New System.Windows.Forms.GroupBox()
        Me.lbCreateArrayDescription = New System.Windows.Forms.Label()
        Me.lbCreateArrayInput = New System.Windows.Forms.Label()
        Me.grpMethodDemo = New System.Windows.Forms.GroupBox()
        Me.lbMethodDemoDesciption = New System.Windows.Forms.Label()
        Me.lbMethodOutput = New System.Windows.Forms.Label()
        Me.lbMethodInput = New System.Windows.Forms.Label()
        Me.tbMethodInput = New System.Windows.Forms.TextBox()
        Me.btnMethodDemo = New System.Windows.Forms.Button()
        Me.grpReset = New System.Windows.Forms.GroupBox()
        Me.lblReset = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grpMethodAdd = New System.Windows.Forms.GroupBox()
        Me.lbNumberTwo = New System.Windows.Forms.Label()
        Me.tbNumberTwo = New System.Windows.Forms.TextBox()
        Me.lbAddFunctionDescription = New System.Windows.Forms.Label()
        Me.lbAddDemoOutput = New System.Windows.Forms.Label()
        Me.lbNumberOne = New System.Windows.Forms.Label()
        Me.tbNumberOne = New System.Windows.Forms.TextBox()
        Me.btnAddDemo = New System.Windows.Forms.Button()
        Me.grpSelectCase = New System.Windows.Forms.GroupBox()
        Me.lblSelectCaseDescription = New System.Windows.Forms.Label()
        Me.lbSelectCaseOutput = New System.Windows.Forms.Label()
        Me.lbSelectCase = New System.Windows.Forms.Label()
        Me.tbSelectCase = New System.Windows.Forms.TextBox()
        Me.btnSelectCase = New System.Windows.Forms.Button()
        Me.grpIf.SuspendLayout()
        Me.grpNestedIf.SuspendLayout()
        Me.grpForLoop.SuspendLayout()
        Me.grpForLoopBreak.SuspendLayout()
        Me.grpWhileLoop.SuspendLayout()
        Me.grpWhileLoopBreak.SuspendLayout()
        Me.grpDoWhileLoop.SuspendLayout()
        Me.grpDoWhileLoopBreak.SuspendLayout()
        Me.grpCreateArray.SuspendLayout()
        Me.grpMethodDemo.SuspendLayout()
        Me.grpReset.SuspendLayout()
        Me.grpMethodAdd.SuspendLayout()
        Me.grpSelectCase.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpIf
        '
        Me.grpIf.Controls.Add(Me.lbIfDescription)
        Me.grpIf.Controls.Add(Me.lbIfOutput)
        Me.grpIf.Controls.Add(Me.lbIfInput)
        Me.grpIf.Controls.Add(Me.tbIfInput)
        Me.grpIf.Controls.Add(Me.btnIfDemo)
        Me.grpIf.Location = New System.Drawing.Point(12, 1)
        Me.grpIf.Name = "grpIf"
        Me.grpIf.Size = New System.Drawing.Size(190, 195)
        Me.grpIf.TabIndex = 0
        Me.grpIf.TabStop = False
        Me.grpIf.Text = "&1. If Demo"
        '
        'lbIfDescription
        '
        Me.lbIfDescription.Location = New System.Drawing.Point(12, 18)
        Me.lbIfDescription.Name = "lbIfDescription"
        Me.lbIfDescription.Size = New System.Drawing.Size(163, 67)
        Me.lbIfDescription.TabIndex = 0
        Me.lbIfDescription.Text = "Enter a number and click Enter. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "It will test if the number is a... " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    1. Num" &
    "ber " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    2. Double " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    3. Integer"
        '
        'lbIfOutput
        '
        Me.lbIfOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbIfOutput.Location = New System.Drawing.Point(15, 118)
        Me.lbIfOutput.Name = "lbIfOutput"
        Me.lbIfOutput.Size = New System.Drawing.Size(160, 46)
        Me.lbIfOutput.TabIndex = 3
        Me.DemoTip.SetToolTip(Me.lbIfOutput, "Resul/Output will display here.")
        '
        'lbIfInput
        '
        Me.lbIfInput.Location = New System.Drawing.Point(12, 96)
        Me.lbIfInput.Name = "lbIfInput"
        Me.lbIfInput.Size = New System.Drawing.Size(45, 13)
        Me.lbIfInput.TabIndex = 1
        Me.lbIfInput.Text = "Enter #:"
        '
        'tbIfInput
        '
        Me.tbIfInput.Location = New System.Drawing.Point(75, 96)
        Me.tbIfInput.Name = "tbIfInput"
        Me.tbIfInput.Size = New System.Drawing.Size(100, 20)
        Me.tbIfInput.TabIndex = 2
        Me.tbIfInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.DemoTip.SetToolTip(Me.tbIfInput, "Enter a number to test.")
        '
        'btnIfDemo
        '
        Me.btnIfDemo.Location = New System.Drawing.Point(100, 167)
        Me.btnIfDemo.Name = "btnIfDemo"
        Me.btnIfDemo.Size = New System.Drawing.Size(75, 23)
        Me.btnIfDemo.TabIndex = 4
        Me.btnIfDemo.Text = "&Enter"
        Me.DemoTip.SetToolTip(Me.btnIfDemo, "Click to begin test.")
        Me.btnIfDemo.UseVisualStyleBackColor = True
        '
        'lbNestedIfOutput
        '
        Me.lbNestedIfOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbNestedIfOutput.Location = New System.Drawing.Point(15, 118)
        Me.lbNestedIfOutput.Name = "lbNestedIfOutput"
        Me.lbNestedIfOutput.Size = New System.Drawing.Size(160, 46)
        Me.lbNestedIfOutput.TabIndex = 3
        Me.DemoTip.SetToolTip(Me.lbNestedIfOutput, "Resul/Output will display here.")
        '
        'tbNestedIfInput
        '
        Me.tbNestedIfInput.Location = New System.Drawing.Point(75, 96)
        Me.tbNestedIfInput.Name = "tbNestedIfInput"
        Me.tbNestedIfInput.Size = New System.Drawing.Size(100, 20)
        Me.tbNestedIfInput.TabIndex = 2
        Me.tbNestedIfInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.DemoTip.SetToolTip(Me.tbNestedIfInput, "Enter a number to test.")
        '
        'btnNestedIfDemo
        '
        Me.btnNestedIfDemo.Location = New System.Drawing.Point(100, 167)
        Me.btnNestedIfDemo.Name = "btnNestedIfDemo"
        Me.btnNestedIfDemo.Size = New System.Drawing.Size(75, 23)
        Me.btnNestedIfDemo.TabIndex = 4
        Me.btnNestedIfDemo.Text = "&Enter"
        Me.DemoTip.SetToolTip(Me.btnNestedIfDemo, "Click to begin test.")
        Me.btnNestedIfDemo.UseVisualStyleBackColor = True
        '
        'lbForLoopDemoOutput
        '
        Me.lbForLoopDemoOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbForLoopDemoOutput.Location = New System.Drawing.Point(15, 118)
        Me.lbForLoopDemoOutput.Name = "lbForLoopDemoOutput"
        Me.lbForLoopDemoOutput.Size = New System.Drawing.Size(160, 46)
        Me.lbForLoopDemoOutput.TabIndex = 3
        Me.DemoTip.SetToolTip(Me.lbForLoopDemoOutput, "Resul/Output will display here.")
        '
        'tbForLoopDemoInput
        '
        Me.tbForLoopDemoInput.Location = New System.Drawing.Point(75, 96)
        Me.tbForLoopDemoInput.Name = "tbForLoopDemoInput"
        Me.tbForLoopDemoInput.Size = New System.Drawing.Size(100, 20)
        Me.tbForLoopDemoInput.TabIndex = 2
        Me.tbForLoopDemoInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.DemoTip.SetToolTip(Me.tbForLoopDemoInput, "Enter a number to test.")
        '
        'btnForLoopDemo
        '
        Me.btnForLoopDemo.Location = New System.Drawing.Point(100, 167)
        Me.btnForLoopDemo.Name = "btnForLoopDemo"
        Me.btnForLoopDemo.Size = New System.Drawing.Size(75, 23)
        Me.btnForLoopDemo.TabIndex = 4
        Me.btnForLoopDemo.Text = "&Enter"
        Me.DemoTip.SetToolTip(Me.btnForLoopDemo, "Click to begin test.")
        Me.btnForLoopDemo.UseVisualStyleBackColor = True
        '
        'lbForLoopBreakDemoOutput
        '
        Me.lbForLoopBreakDemoOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbForLoopBreakDemoOutput.Location = New System.Drawing.Point(15, 118)
        Me.lbForLoopBreakDemoOutput.Name = "lbForLoopBreakDemoOutput"
        Me.lbForLoopBreakDemoOutput.Size = New System.Drawing.Size(160, 46)
        Me.lbForLoopBreakDemoOutput.TabIndex = 3
        Me.DemoTip.SetToolTip(Me.lbForLoopBreakDemoOutput, "Resul/Output will display here.")
        '
        'tbForLoopBreakDemoInput
        '
        Me.tbForLoopBreakDemoInput.Location = New System.Drawing.Point(75, 96)
        Me.tbForLoopBreakDemoInput.Name = "tbForLoopBreakDemoInput"
        Me.tbForLoopBreakDemoInput.Size = New System.Drawing.Size(100, 20)
        Me.tbForLoopBreakDemoInput.TabIndex = 2
        Me.tbForLoopBreakDemoInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.DemoTip.SetToolTip(Me.tbForLoopBreakDemoInput, "Enter a number to test.")
        '
        'btnForLoopBreakDemo
        '
        Me.btnForLoopBreakDemo.Location = New System.Drawing.Point(100, 167)
        Me.btnForLoopBreakDemo.Name = "btnForLoopBreakDemo"
        Me.btnForLoopBreakDemo.Size = New System.Drawing.Size(75, 23)
        Me.btnForLoopBreakDemo.TabIndex = 4
        Me.btnForLoopBreakDemo.Text = "&Enter"
        Me.DemoTip.SetToolTip(Me.btnForLoopBreakDemo, "Click to begin test.")
        Me.btnForLoopBreakDemo.UseVisualStyleBackColor = True
        '
        'lbWhileLoopDemoOutput
        '
        Me.lbWhileLoopDemoOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbWhileLoopDemoOutput.Location = New System.Drawing.Point(15, 118)
        Me.lbWhileLoopDemoOutput.Name = "lbWhileLoopDemoOutput"
        Me.lbWhileLoopDemoOutput.Size = New System.Drawing.Size(160, 46)
        Me.lbWhileLoopDemoOutput.TabIndex = 3
        Me.DemoTip.SetToolTip(Me.lbWhileLoopDemoOutput, "Resul/Output will display here.")
        '
        'tbWhileLoopDemoInput
        '
        Me.tbWhileLoopDemoInput.Location = New System.Drawing.Point(75, 96)
        Me.tbWhileLoopDemoInput.Name = "tbWhileLoopDemoInput"
        Me.tbWhileLoopDemoInput.Size = New System.Drawing.Size(100, 20)
        Me.tbWhileLoopDemoInput.TabIndex = 2
        Me.tbWhileLoopDemoInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.DemoTip.SetToolTip(Me.tbWhileLoopDemoInput, "Enter a number to test.")
        '
        'btnWhileLoopDemo
        '
        Me.btnWhileLoopDemo.Location = New System.Drawing.Point(101, 167)
        Me.btnWhileLoopDemo.Name = "btnWhileLoopDemo"
        Me.btnWhileLoopDemo.Size = New System.Drawing.Size(75, 23)
        Me.btnWhileLoopDemo.TabIndex = 4
        Me.btnWhileLoopDemo.Text = "&Enter"
        Me.DemoTip.SetToolTip(Me.btnWhileLoopDemo, "Click to begin test.")
        Me.btnWhileLoopDemo.UseVisualStyleBackColor = True
        '
        'lbWhileLoopBreakDemoOutput
        '
        Me.lbWhileLoopBreakDemoOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbWhileLoopBreakDemoOutput.Location = New System.Drawing.Point(15, 118)
        Me.lbWhileLoopBreakDemoOutput.Name = "lbWhileLoopBreakDemoOutput"
        Me.lbWhileLoopBreakDemoOutput.Size = New System.Drawing.Size(160, 46)
        Me.lbWhileLoopBreakDemoOutput.TabIndex = 3
        Me.DemoTip.SetToolTip(Me.lbWhileLoopBreakDemoOutput, "Resul/Output will display here.")
        '
        'tbWhileLoopBreakDemoInput
        '
        Me.tbWhileLoopBreakDemoInput.Location = New System.Drawing.Point(75, 96)
        Me.tbWhileLoopBreakDemoInput.Name = "tbWhileLoopBreakDemoInput"
        Me.tbWhileLoopBreakDemoInput.Size = New System.Drawing.Size(100, 20)
        Me.tbWhileLoopBreakDemoInput.TabIndex = 2
        Me.tbWhileLoopBreakDemoInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.DemoTip.SetToolTip(Me.tbWhileLoopBreakDemoInput, "Enter a number to test.")
        '
        'btnWhileLoopBreakDemo
        '
        Me.btnWhileLoopBreakDemo.Location = New System.Drawing.Point(100, 167)
        Me.btnWhileLoopBreakDemo.Name = "btnWhileLoopBreakDemo"
        Me.btnWhileLoopBreakDemo.Size = New System.Drawing.Size(75, 23)
        Me.btnWhileLoopBreakDemo.TabIndex = 4
        Me.btnWhileLoopBreakDemo.Text = "&Enter"
        Me.DemoTip.SetToolTip(Me.btnWhileLoopBreakDemo, "Click to begin test.")
        Me.btnWhileLoopBreakDemo.UseVisualStyleBackColor = True
        '
        'lbDoWhileLoopDemoOutput
        '
        Me.lbDoWhileLoopDemoOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbDoWhileLoopDemoOutput.Location = New System.Drawing.Point(15, 118)
        Me.lbDoWhileLoopDemoOutput.Name = "lbDoWhileLoopDemoOutput"
        Me.lbDoWhileLoopDemoOutput.Size = New System.Drawing.Size(160, 46)
        Me.lbDoWhileLoopDemoOutput.TabIndex = 3
        Me.DemoTip.SetToolTip(Me.lbDoWhileLoopDemoOutput, "Resul/Output will display here.")
        '
        'tbDoWhileLoopDemoInput
        '
        Me.tbDoWhileLoopDemoInput.Location = New System.Drawing.Point(75, 88)
        Me.tbDoWhileLoopDemoInput.Name = "tbDoWhileLoopDemoInput"
        Me.tbDoWhileLoopDemoInput.Size = New System.Drawing.Size(100, 20)
        Me.tbDoWhileLoopDemoInput.TabIndex = 2
        Me.tbDoWhileLoopDemoInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.DemoTip.SetToolTip(Me.tbDoWhileLoopDemoInput, "Enter a number to test.")
        '
        'btnDoWhileLoopDemo
        '
        Me.btnDoWhileLoopDemo.Location = New System.Drawing.Point(100, 167)
        Me.btnDoWhileLoopDemo.Name = "btnDoWhileLoopDemo"
        Me.btnDoWhileLoopDemo.Size = New System.Drawing.Size(75, 23)
        Me.btnDoWhileLoopDemo.TabIndex = 4
        Me.btnDoWhileLoopDemo.Text = "&Enter"
        Me.DemoTip.SetToolTip(Me.btnDoWhileLoopDemo, "Click to begin test.")
        Me.btnDoWhileLoopDemo.UseVisualStyleBackColor = True
        '
        'lbDoWhileLoopBreakDemoOutput
        '
        Me.lbDoWhileLoopBreakDemoOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbDoWhileLoopBreakDemoOutput.Location = New System.Drawing.Point(15, 118)
        Me.lbDoWhileLoopBreakDemoOutput.Name = "lbDoWhileLoopBreakDemoOutput"
        Me.lbDoWhileLoopBreakDemoOutput.Size = New System.Drawing.Size(160, 46)
        Me.lbDoWhileLoopBreakDemoOutput.TabIndex = 3
        Me.DemoTip.SetToolTip(Me.lbDoWhileLoopBreakDemoOutput, "Result/Output will display here.")
        '
        'tbDoWhileLoopBreakDemoInput
        '
        Me.tbDoWhileLoopBreakDemoInput.Location = New System.Drawing.Point(75, 96)
        Me.tbDoWhileLoopBreakDemoInput.Name = "tbDoWhileLoopBreakDemoInput"
        Me.tbDoWhileLoopBreakDemoInput.Size = New System.Drawing.Size(100, 20)
        Me.tbDoWhileLoopBreakDemoInput.TabIndex = 2
        Me.tbDoWhileLoopBreakDemoInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.DemoTip.SetToolTip(Me.tbDoWhileLoopBreakDemoInput, "Enter a number to test.")
        '
        'btnDoWhileLoopBreakDemo
        '
        Me.btnDoWhileLoopBreakDemo.Location = New System.Drawing.Point(100, 168)
        Me.btnDoWhileLoopBreakDemo.Name = "btnDoWhileLoopBreakDemo"
        Me.btnDoWhileLoopBreakDemo.Size = New System.Drawing.Size(75, 23)
        Me.btnDoWhileLoopBreakDemo.TabIndex = 4
        Me.btnDoWhileLoopBreakDemo.Text = "&Enter"
        Me.DemoTip.SetToolTip(Me.btnDoWhileLoopBreakDemo, "Click to begin test.")
        Me.btnDoWhileLoopBreakDemo.UseVisualStyleBackColor = True
        '
        'lbCreateArrayOutput
        '
        Me.lbCreateArrayOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbCreateArrayOutput.Location = New System.Drawing.Point(16, 148)
        Me.lbCreateArrayOutput.Name = "lbCreateArrayOutput"
        Me.lbCreateArrayOutput.Size = New System.Drawing.Size(160, 46)
        Me.lbCreateArrayOutput.TabIndex = 3
        Me.DemoTip.SetToolTip(Me.lbCreateArrayOutput, "Resul/Output will display here.")
        '
        'tbCreateArrayInput
        '
        Me.tbCreateArrayInput.Location = New System.Drawing.Point(76, 123)
        Me.tbCreateArrayInput.Name = "tbCreateArrayInput"
        Me.tbCreateArrayInput.Size = New System.Drawing.Size(100, 20)
        Me.tbCreateArrayInput.TabIndex = 2
        Me.tbCreateArrayInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.DemoTip.SetToolTip(Me.tbCreateArrayInput, "Enter a number to test.")
        '
        'btnCreateArrayDemo
        '
        Me.btnCreateArrayDemo.Location = New System.Drawing.Point(101, 195)
        Me.btnCreateArrayDemo.Name = "btnCreateArrayDemo"
        Me.btnCreateArrayDemo.Size = New System.Drawing.Size(75, 23)
        Me.btnCreateArrayDemo.TabIndex = 4
        Me.btnCreateArrayDemo.Text = "&Enter"
        Me.DemoTip.SetToolTip(Me.btnCreateArrayDemo, "Click to begin test.")
        Me.btnCreateArrayDemo.UseVisualStyleBackColor = True
        '
        'grpNestedIf
        '
        Me.grpNestedIf.Controls.Add(Me.lbNestedIfDescription)
        Me.grpNestedIf.Controls.Add(Me.lbNestedIfOutput)
        Me.grpNestedIf.Controls.Add(Me.lbNestedIfInput)
        Me.grpNestedIf.Controls.Add(Me.tbNestedIfInput)
        Me.grpNestedIf.Controls.Add(Me.btnNestedIfDemo)
        Me.grpNestedIf.Location = New System.Drawing.Point(206, 1)
        Me.grpNestedIf.Name = "grpNestedIf"
        Me.grpNestedIf.Size = New System.Drawing.Size(190, 195)
        Me.grpNestedIf.TabIndex = 1
        Me.grpNestedIf.TabStop = False
        Me.grpNestedIf.Text = "&2. Nested If Demo"
        '
        'lbNestedIfDescription
        '
        Me.lbNestedIfDescription.Location = New System.Drawing.Point(12, 18)
        Me.lbNestedIfDescription.Name = "lbNestedIfDescription"
        Me.lbNestedIfDescription.Size = New System.Drawing.Size(163, 67)
        Me.lbNestedIfDescription.TabIndex = 0
        Me.lbNestedIfDescription.Text = "Enter a number and click Enter. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "It will test if the number is an " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    1. Numbe" &
    "r " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    2. Double " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    3. Integer"
        '
        'lbNestedIfInput
        '
        Me.lbNestedIfInput.Location = New System.Drawing.Point(12, 96)
        Me.lbNestedIfInput.Name = "lbNestedIfInput"
        Me.lbNestedIfInput.Size = New System.Drawing.Size(45, 13)
        Me.lbNestedIfInput.TabIndex = 1
        Me.lbNestedIfInput.Text = "Enter #:"
        '
        'grpForLoop
        '
        Me.grpForLoop.Controls.Add(Me.lbForLoopDemoDescription)
        Me.grpForLoop.Controls.Add(Me.lbForLoopDemoOutput)
        Me.grpForLoop.Controls.Add(Me.lbForLoopDemoInput)
        Me.grpForLoop.Controls.Add(Me.tbForLoopDemoInput)
        Me.grpForLoop.Controls.Add(Me.btnForLoopDemo)
        Me.grpForLoop.Location = New System.Drawing.Point(404, 1)
        Me.grpForLoop.Name = "grpForLoop"
        Me.grpForLoop.Size = New System.Drawing.Size(190, 195)
        Me.grpForLoop.TabIndex = 2
        Me.grpForLoop.TabStop = False
        Me.grpForLoop.Text = "&3.  For Loop"
        '
        'lbForLoopDemoDescription
        '
        Me.lbForLoopDemoDescription.Location = New System.Drawing.Point(12, 18)
        Me.lbForLoopDemoDescription.Name = "lbForLoopDemoDescription"
        Me.lbForLoopDemoDescription.Size = New System.Drawing.Size(163, 67)
        Me.lbForLoopDemoDescription.TabIndex = 0
        Me.lbForLoopDemoDescription.Text = "Enter a number and click Enter. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This will loop until the number " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "you have ente" &
    "red is reached."
        '
        'lbForLoopDemoInput
        '
        Me.lbForLoopDemoInput.Location = New System.Drawing.Point(12, 96)
        Me.lbForLoopDemoInput.Name = "lbForLoopDemoInput"
        Me.lbForLoopDemoInput.Size = New System.Drawing.Size(45, 13)
        Me.lbForLoopDemoInput.TabIndex = 1
        Me.lbForLoopDemoInput.Text = "Enter #:"
        '
        'grpForLoopBreak
        '
        Me.grpForLoopBreak.Controls.Add(Me.lbForLoopDemoBreakDescription)
        Me.grpForLoopBreak.Controls.Add(Me.lbForLoopBreakDemoOutput)
        Me.grpForLoopBreak.Controls.Add(Me.lbForLoopBreakDemoInput)
        Me.grpForLoopBreak.Controls.Add(Me.tbForLoopBreakDemoInput)
        Me.grpForLoopBreak.Controls.Add(Me.btnForLoopBreakDemo)
        Me.grpForLoopBreak.Location = New System.Drawing.Point(600, 1)
        Me.grpForLoopBreak.Name = "grpForLoopBreak"
        Me.grpForLoopBreak.Size = New System.Drawing.Size(190, 195)
        Me.grpForLoopBreak.TabIndex = 3
        Me.grpForLoopBreak.TabStop = False
        Me.grpForLoopBreak.Text = "&4. For Loop Elegant Break"
        '
        'lbForLoopDemoBreakDescription
        '
        Me.lbForLoopDemoBreakDescription.Location = New System.Drawing.Point(12, 18)
        Me.lbForLoopDemoBreakDescription.Name = "lbForLoopDemoBreakDescription"
        Me.lbForLoopDemoBreakDescription.Size = New System.Drawing.Size(163, 67)
        Me.lbForLoopDemoBreakDescription.TabIndex = 0
        Me.lbForLoopDemoBreakDescription.Text = "Enter a number and click Enter. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This will loop until the 20 or will " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "break ear" &
    "ly depending on the " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "number entered."
        '
        'lbForLoopBreakDemoInput
        '
        Me.lbForLoopBreakDemoInput.Location = New System.Drawing.Point(12, 96)
        Me.lbForLoopBreakDemoInput.Name = "lbForLoopBreakDemoInput"
        Me.lbForLoopBreakDemoInput.Size = New System.Drawing.Size(45, 13)
        Me.lbForLoopBreakDemoInput.TabIndex = 1
        Me.lbForLoopBreakDemoInput.Text = "Enter #:"
        '
        'grpWhileLoop
        '
        Me.grpWhileLoop.Controls.Add(Me.lbWhileLoopDemoInputDescription)
        Me.grpWhileLoop.Controls.Add(Me.lbWhileLoopDemoOutput)
        Me.grpWhileLoop.Controls.Add(Me.lbWhileLoopDemoInput)
        Me.grpWhileLoop.Controls.Add(Me.tbWhileLoopDemoInput)
        Me.grpWhileLoop.Controls.Add(Me.btnWhileLoopDemo)
        Me.grpWhileLoop.Location = New System.Drawing.Point(12, 196)
        Me.grpWhileLoop.Name = "grpWhileLoop"
        Me.grpWhileLoop.Size = New System.Drawing.Size(190, 195)
        Me.grpWhileLoop.TabIndex = 4
        Me.grpWhileLoop.TabStop = False
        Me.grpWhileLoop.Text = "&5. While Loop"
        '
        'lbWhileLoopDemoInputDescription
        '
        Me.lbWhileLoopDemoInputDescription.Location = New System.Drawing.Point(12, 18)
        Me.lbWhileLoopDemoInputDescription.Name = "lbWhileLoopDemoInputDescription"
        Me.lbWhileLoopDemoInputDescription.Size = New System.Drawing.Size(163, 67)
        Me.lbWhileLoopDemoInputDescription.TabIndex = 0
        Me.lbWhileLoopDemoInputDescription.Text = "Enter a number and click Enter. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This will loop until the number " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "you have ente" &
    "red is reached."
        '
        'lbWhileLoopDemoInput
        '
        Me.lbWhileLoopDemoInput.Location = New System.Drawing.Point(12, 96)
        Me.lbWhileLoopDemoInput.Name = "lbWhileLoopDemoInput"
        Me.lbWhileLoopDemoInput.Size = New System.Drawing.Size(45, 13)
        Me.lbWhileLoopDemoInput.TabIndex = 1
        Me.lbWhileLoopDemoInput.Text = "Enter #:"
        '
        'grpWhileLoopBreak
        '
        Me.grpWhileLoopBreak.Controls.Add(Me.lbWhileLoopDemoBreakDescription)
        Me.grpWhileLoopBreak.Controls.Add(Me.lbWhileLoopBreakDemoOutput)
        Me.grpWhileLoopBreak.Controls.Add(Me.lbWhileLoopBreakDemoInput)
        Me.grpWhileLoopBreak.Controls.Add(Me.tbWhileLoopBreakDemoInput)
        Me.grpWhileLoopBreak.Controls.Add(Me.btnWhileLoopBreakDemo)
        Me.grpWhileLoopBreak.Location = New System.Drawing.Point(208, 197)
        Me.grpWhileLoopBreak.Name = "grpWhileLoopBreak"
        Me.grpWhileLoopBreak.Size = New System.Drawing.Size(190, 195)
        Me.grpWhileLoopBreak.TabIndex = 5
        Me.grpWhileLoopBreak.TabStop = False
        Me.grpWhileLoopBreak.Text = "&6. While Loop Elegant Break"
        '
        'lbWhileLoopDemoBreakDescription
        '
        Me.lbWhileLoopDemoBreakDescription.Location = New System.Drawing.Point(12, 18)
        Me.lbWhileLoopDemoBreakDescription.Name = "lbWhileLoopDemoBreakDescription"
        Me.lbWhileLoopDemoBreakDescription.Size = New System.Drawing.Size(163, 67)
        Me.lbWhileLoopDemoBreakDescription.TabIndex = 0
        Me.lbWhileLoopDemoBreakDescription.Text = "Enter a number and click Enter. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This will loop until the 15 or will " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "break ear" &
    "ly depending on the " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "number entered."
        '
        'lbWhileLoopBreakDemoInput
        '
        Me.lbWhileLoopBreakDemoInput.Location = New System.Drawing.Point(12, 96)
        Me.lbWhileLoopBreakDemoInput.Name = "lbWhileLoopBreakDemoInput"
        Me.lbWhileLoopBreakDemoInput.Size = New System.Drawing.Size(45, 13)
        Me.lbWhileLoopBreakDemoInput.TabIndex = 1
        Me.lbWhileLoopBreakDemoInput.Text = "Enter #:"
        '
        'grpDoWhileLoop
        '
        Me.grpDoWhileLoop.Controls.Add(Me.lbDoWhileLoopDemoDescription)
        Me.grpDoWhileLoop.Controls.Add(Me.lbDoWhileLoopDemoOutput)
        Me.grpDoWhileLoop.Controls.Add(Me.lbDoWhileLoopDemoInput)
        Me.grpDoWhileLoop.Controls.Add(Me.tbDoWhileLoopDemoInput)
        Me.grpDoWhileLoop.Controls.Add(Me.btnDoWhileLoopDemo)
        Me.grpDoWhileLoop.Location = New System.Drawing.Point(404, 197)
        Me.grpDoWhileLoop.Name = "grpDoWhileLoop"
        Me.grpDoWhileLoop.Size = New System.Drawing.Size(190, 195)
        Me.grpDoWhileLoop.TabIndex = 6
        Me.grpDoWhileLoop.TabStop = False
        Me.grpDoWhileLoop.Text = "&7. Do While Loop"
        '
        'lbDoWhileLoopDemoDescription
        '
        Me.lbDoWhileLoopDemoDescription.Location = New System.Drawing.Point(12, 18)
        Me.lbDoWhileLoopDemoDescription.Name = "lbDoWhileLoopDemoDescription"
        Me.lbDoWhileLoopDemoDescription.Size = New System.Drawing.Size(163, 67)
        Me.lbDoWhileLoopDemoDescription.TabIndex = 0
        Me.lbDoWhileLoopDemoDescription.Text = "Enter a number and click Enter. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This will loop until the number " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "you have ente" &
    "red is reached."
        '
        'lbDoWhileLoopDemoInput
        '
        Me.lbDoWhileLoopDemoInput.Location = New System.Drawing.Point(12, 96)
        Me.lbDoWhileLoopDemoInput.Name = "lbDoWhileLoopDemoInput"
        Me.lbDoWhileLoopDemoInput.Size = New System.Drawing.Size(45, 13)
        Me.lbDoWhileLoopDemoInput.TabIndex = 1
        Me.lbDoWhileLoopDemoInput.Text = "Enter #:"
        '
        'grpDoWhileLoopBreak
        '
        Me.grpDoWhileLoopBreak.Controls.Add(Me.lbDoWhileLoopDemoBreakDescription)
        Me.grpDoWhileLoopBreak.Controls.Add(Me.lbDoWhileLoopBreakDemoOutput)
        Me.grpDoWhileLoopBreak.Controls.Add(Me.lbDoWhileLoopBreakDemoInput)
        Me.grpDoWhileLoopBreak.Controls.Add(Me.tbDoWhileLoopBreakDemoInput)
        Me.grpDoWhileLoopBreak.Controls.Add(Me.btnDoWhileLoopBreakDemo)
        Me.grpDoWhileLoopBreak.Location = New System.Drawing.Point(600, 196)
        Me.grpDoWhileLoopBreak.Name = "grpDoWhileLoopBreak"
        Me.grpDoWhileLoopBreak.Size = New System.Drawing.Size(190, 195)
        Me.grpDoWhileLoopBreak.TabIndex = 7
        Me.grpDoWhileLoopBreak.TabStop = False
        Me.grpDoWhileLoopBreak.Text = "&8. Do While Loop Elegant Break"
        '
        'lbDoWhileLoopDemoBreakDescription
        '
        Me.lbDoWhileLoopDemoBreakDescription.Location = New System.Drawing.Point(12, 18)
        Me.lbDoWhileLoopDemoBreakDescription.Name = "lbDoWhileLoopDemoBreakDescription"
        Me.lbDoWhileLoopDemoBreakDescription.Size = New System.Drawing.Size(163, 67)
        Me.lbDoWhileLoopDemoBreakDescription.TabIndex = 0
        Me.lbDoWhileLoopDemoBreakDescription.Text = "Enter a number and click Enter. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This will loop until the 18 or will " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "break ear" &
    "ly depending on the " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "number entered."
        '
        'lbDoWhileLoopBreakDemoInput
        '
        Me.lbDoWhileLoopBreakDemoInput.Location = New System.Drawing.Point(12, 96)
        Me.lbDoWhileLoopBreakDemoInput.Name = "lbDoWhileLoopBreakDemoInput"
        Me.lbDoWhileLoopBreakDemoInput.Size = New System.Drawing.Size(45, 13)
        Me.lbDoWhileLoopBreakDemoInput.TabIndex = 1
        Me.lbDoWhileLoopBreakDemoInput.Text = "Enter #:"
        '
        'grpCreateArray
        '
        Me.grpCreateArray.Controls.Add(Me.lbCreateArrayDescription)
        Me.grpCreateArray.Controls.Add(Me.lbCreateArrayOutput)
        Me.grpCreateArray.Controls.Add(Me.lbCreateArrayInput)
        Me.grpCreateArray.Controls.Add(Me.tbCreateArrayInput)
        Me.grpCreateArray.Controls.Add(Me.btnCreateArrayDemo)
        Me.grpCreateArray.Location = New System.Drawing.Point(12, 391)
        Me.grpCreateArray.Name = "grpCreateArray"
        Me.grpCreateArray.Size = New System.Drawing.Size(190, 222)
        Me.grpCreateArray.TabIndex = 8
        Me.grpCreateArray.TabStop = False
        Me.grpCreateArray.Text = "&9. Create Array"
        '
        'lbCreateArrayDescription
        '
        Me.lbCreateArrayDescription.Location = New System.Drawing.Point(12, 17)
        Me.lbCreateArrayDescription.Name = "lbCreateArrayDescription"
        Me.lbCreateArrayDescription.Size = New System.Drawing.Size(163, 78)
        Me.lbCreateArrayDescription.TabIndex = 0
        Me.lbCreateArrayDescription.Text = "Enter a number and click Enter. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This will create an array of the " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "number of el" &
    "ements specified. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Then each element of the array" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "will be filled by looping th" &
    "e array " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "and countingby 2s."
        '
        'lbCreateArrayInput
        '
        Me.lbCreateArrayInput.Location = New System.Drawing.Point(13, 123)
        Me.lbCreateArrayInput.Name = "lbCreateArrayInput"
        Me.lbCreateArrayInput.Size = New System.Drawing.Size(45, 13)
        Me.lbCreateArrayInput.TabIndex = 1
        Me.lbCreateArrayInput.Text = "Enter #:"
        '
        'grpMethodDemo
        '
        Me.grpMethodDemo.Controls.Add(Me.lbMethodDemoDesciption)
        Me.grpMethodDemo.Controls.Add(Me.lbMethodOutput)
        Me.grpMethodDemo.Controls.Add(Me.lbMethodInput)
        Me.grpMethodDemo.Controls.Add(Me.tbMethodInput)
        Me.grpMethodDemo.Controls.Add(Me.btnMethodDemo)
        Me.grpMethodDemo.Location = New System.Drawing.Point(404, 391)
        Me.grpMethodDemo.Name = "grpMethodDemo"
        Me.grpMethodDemo.Size = New System.Drawing.Size(190, 222)
        Me.grpMethodDemo.TabIndex = 10
        Me.grpMethodDemo.TabStop = False
        Me.grpMethodDemo.Text = "11. Method/&Function"
        '
        'lbMethodDemoDesciption
        '
        Me.lbMethodDemoDesciption.Location = New System.Drawing.Point(12, 18)
        Me.lbMethodDemoDesciption.Name = "lbMethodDemoDesciption"
        Me.lbMethodDemoDesciption.Size = New System.Drawing.Size(163, 106)
        Me.lbMethodDemoDesciption.TabIndex = 0
        Me.lbMethodDemoDesciption.Text = resources.GetString("lbMethodDemoDesciption.Text")
        '
        'lbMethodOutput
        '
        Me.lbMethodOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbMethodOutput.Location = New System.Drawing.Point(16, 146)
        Me.lbMethodOutput.Name = "lbMethodOutput"
        Me.lbMethodOutput.Size = New System.Drawing.Size(160, 46)
        Me.lbMethodOutput.TabIndex = 3
        '
        'lbMethodInput
        '
        Me.lbMethodInput.Location = New System.Drawing.Point(13, 124)
        Me.lbMethodInput.Name = "lbMethodInput"
        Me.lbMethodInput.Size = New System.Drawing.Size(45, 13)
        Me.lbMethodInput.TabIndex = 1
        Me.lbMethodInput.Text = "Enter #:"
        '
        'tbMethodInput
        '
        Me.tbMethodInput.Location = New System.Drawing.Point(76, 124)
        Me.tbMethodInput.Name = "tbMethodInput"
        Me.tbMethodInput.Size = New System.Drawing.Size(100, 20)
        Me.tbMethodInput.TabIndex = 2
        Me.tbMethodInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnMethodDemo
        '
        Me.btnMethodDemo.Location = New System.Drawing.Point(101, 195)
        Me.btnMethodDemo.Name = "btnMethodDemo"
        Me.btnMethodDemo.Size = New System.Drawing.Size(75, 23)
        Me.btnMethodDemo.TabIndex = 4
        Me.btnMethodDemo.Text = "&Enter"
        Me.btnMethodDemo.UseVisualStyleBackColor = True
        '
        'grpReset
        '
        Me.grpReset.Controls.Add(Me.lblReset)
        Me.grpReset.Controls.Add(Me.btnReset)
        Me.grpReset.Location = New System.Drawing.Point(600, 390)
        Me.grpReset.Name = "grpReset"
        Me.grpReset.Size = New System.Drawing.Size(190, 222)
        Me.grpReset.TabIndex = 11
        Me.grpReset.TabStop = False
        Me.grpReset.Text = "12. Method/&Void Function"
        '
        'lblReset
        '
        Me.lblReset.Location = New System.Drawing.Point(12, 17)
        Me.lblReset.Name = "lblReset"
        Me.lblReset.Size = New System.Drawing.Size(163, 76)
        Me.lblReset.TabIndex = 0
        Me.lblReset.Text = "Click Reset and the entire form" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "is reset in a function that return" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "void. In oth" &
    "erwords, it does not" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " return anything"
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(55, 122)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 1
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(715, 766)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'grpMethodAdd
        '
        Me.grpMethodAdd.Controls.Add(Me.lbNumberTwo)
        Me.grpMethodAdd.Controls.Add(Me.tbNumberTwo)
        Me.grpMethodAdd.Controls.Add(Me.lbAddFunctionDescription)
        Me.grpMethodAdd.Controls.Add(Me.lbAddDemoOutput)
        Me.grpMethodAdd.Controls.Add(Me.lbNumberOne)
        Me.grpMethodAdd.Controls.Add(Me.tbNumberOne)
        Me.grpMethodAdd.Controls.Add(Me.btnAddDemo)
        Me.grpMethodAdd.Location = New System.Drawing.Point(208, 391)
        Me.grpMethodAdd.Name = "grpMethodAdd"
        Me.grpMethodAdd.Size = New System.Drawing.Size(190, 222)
        Me.grpMethodAdd.TabIndex = 9
        Me.grpMethodAdd.TabStop = False
        Me.grpMethodAdd.Text = "10. Method/Function &Add"
        '
        'lbNumberTwo
        '
        Me.lbNumberTwo.Location = New System.Drawing.Point(13, 114)
        Me.lbNumberTwo.Name = "lbNumberTwo"
        Me.lbNumberTwo.Size = New System.Drawing.Size(57, 13)
        Me.lbNumberTwo.TabIndex = 3
        Me.lbNumberTwo.Text = "Enter #2:"
        '
        'tbNumberTwo
        '
        Me.tbNumberTwo.Location = New System.Drawing.Point(75, 114)
        Me.tbNumberTwo.Name = "tbNumberTwo"
        Me.tbNumberTwo.Size = New System.Drawing.Size(100, 20)
        Me.tbNumberTwo.TabIndex = 4
        Me.tbNumberTwo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbAddFunctionDescription
        '
        Me.lbAddFunctionDescription.Location = New System.Drawing.Point(12, 18)
        Me.lbAddFunctionDescription.Name = "lbAddFunctionDescription"
        Me.lbAddFunctionDescription.Size = New System.Drawing.Size(163, 74)
        Me.lbAddFunctionDescription.TabIndex = 0
        Me.lbAddFunctionDescription.Text = "Enter a number in each box and click Enter. This will add the two numbers togethe" &
    "r. This has no validation, so you must enter two numbers."
        '
        'lbAddDemoOutput
        '
        Me.lbAddDemoOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbAddDemoOutput.Location = New System.Drawing.Point(16, 146)
        Me.lbAddDemoOutput.Name = "lbAddDemoOutput"
        Me.lbAddDemoOutput.Size = New System.Drawing.Size(160, 46)
        Me.lbAddDemoOutput.TabIndex = 5
        '
        'lbNumberOne
        '
        Me.lbNumberOne.Location = New System.Drawing.Point(13, 92)
        Me.lbNumberOne.Name = "lbNumberOne"
        Me.lbNumberOne.Size = New System.Drawing.Size(56, 13)
        Me.lbNumberOne.TabIndex = 1
        Me.lbNumberOne.Text = "Enter #1:"
        '
        'tbNumberOne
        '
        Me.tbNumberOne.Location = New System.Drawing.Point(75, 92)
        Me.tbNumberOne.Name = "tbNumberOne"
        Me.tbNumberOne.Size = New System.Drawing.Size(100, 20)
        Me.tbNumberOne.TabIndex = 2
        Me.tbNumberOne.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnAddDemo
        '
        Me.btnAddDemo.Location = New System.Drawing.Point(101, 195)
        Me.btnAddDemo.Name = "btnAddDemo"
        Me.btnAddDemo.Size = New System.Drawing.Size(75, 23)
        Me.btnAddDemo.TabIndex = 6
        Me.btnAddDemo.Text = "&Enter"
        Me.btnAddDemo.UseVisualStyleBackColor = True
        '
        'grpSelectCase
        '
        Me.grpSelectCase.Controls.Add(Me.lblSelectCaseDescription)
        Me.grpSelectCase.Controls.Add(Me.lbSelectCaseOutput)
        Me.grpSelectCase.Controls.Add(Me.lbSelectCase)
        Me.grpSelectCase.Controls.Add(Me.tbSelectCase)
        Me.grpSelectCase.Controls.Add(Me.btnSelectCase)
        Me.grpSelectCase.Location = New System.Drawing.Point(12, 614)
        Me.grpSelectCase.Name = "grpSelectCase"
        Me.grpSelectCase.Size = New System.Drawing.Size(190, 175)
        Me.grpSelectCase.TabIndex = 12
        Me.grpSelectCase.TabStop = False
        Me.grpSelectCase.Text = "13. Select Case"
        '
        'lblSelectCaseDescription
        '
        Me.lblSelectCaseDescription.Location = New System.Drawing.Point(12, 18)
        Me.lblSelectCaseDescription.Name = "lblSelectCaseDescription"
        Me.lblSelectCaseDescription.Size = New System.Drawing.Size(163, 53)
        Me.lblSelectCaseDescription.TabIndex = 0
        Me.lblSelectCaseDescription.Text = "Enter a grade letter (A,B,C,D,F)  and click Enter. A comment will be displayed ba" &
    "sed on the letter entered. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lbSelectCaseOutput
        '
        Me.lbSelectCaseOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbSelectCaseOutput.Location = New System.Drawing.Point(16, 101)
        Me.lbSelectCaseOutput.Name = "lbSelectCaseOutput"
        Me.lbSelectCaseOutput.Size = New System.Drawing.Size(160, 42)
        Me.lbSelectCaseOutput.TabIndex = 3
        '
        'lbSelectCase
        '
        Me.lbSelectCase.Location = New System.Drawing.Point(13, 78)
        Me.lbSelectCase.Name = "lbSelectCase"
        Me.lbSelectCase.Size = New System.Drawing.Size(45, 13)
        Me.lbSelectCase.TabIndex = 1
        Me.lbSelectCase.Text = "Enter #:"
        '
        'tbSelectCase
        '
        Me.tbSelectCase.Location = New System.Drawing.Point(76, 78)
        Me.tbSelectCase.Name = "tbSelectCase"
        Me.tbSelectCase.Size = New System.Drawing.Size(100, 20)
        Me.tbSelectCase.TabIndex = 2
        Me.tbSelectCase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnSelectCase
        '
        Me.btnSelectCase.Location = New System.Drawing.Point(101, 146)
        Me.btnSelectCase.Name = "btnSelectCase"
        Me.btnSelectCase.Size = New System.Drawing.Size(75, 23)
        Me.btnSelectCase.TabIndex = 4
        Me.btnSelectCase.Text = "&Enter"
        Me.btnSelectCase.UseVisualStyleBackColor = True
        '
        'frmDemoIfLoopArray
        '
        Me.AcceptButton = Me.btnIfDemo
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(794, 791)
        Me.Controls.Add(Me.grpSelectCase)
        Me.Controls.Add(Me.grpMethodAdd)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.grpReset)
        Me.Controls.Add(Me.grpMethodDemo)
        Me.Controls.Add(Me.grpCreateArray)
        Me.Controls.Add(Me.grpDoWhileLoopBreak)
        Me.Controls.Add(Me.grpDoWhileLoop)
        Me.Controls.Add(Me.grpWhileLoopBreak)
        Me.Controls.Add(Me.grpWhileLoop)
        Me.Controls.Add(Me.grpForLoopBreak)
        Me.Controls.Add(Me.grpForLoop)
        Me.Controls.Add(Me.grpNestedIf)
        Me.Controls.Add(Me.grpIf)
        Me.Name = "frmDemoIfLoopArray"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VB Demo If Loop Array"
        Me.grpIf.ResumeLayout(False)
        Me.grpIf.PerformLayout()
        Me.grpNestedIf.ResumeLayout(False)
        Me.grpNestedIf.PerformLayout()
        Me.grpForLoop.ResumeLayout(False)
        Me.grpForLoop.PerformLayout()
        Me.grpForLoopBreak.ResumeLayout(False)
        Me.grpForLoopBreak.PerformLayout()
        Me.grpWhileLoop.ResumeLayout(False)
        Me.grpWhileLoop.PerformLayout()
        Me.grpWhileLoopBreak.ResumeLayout(False)
        Me.grpWhileLoopBreak.PerformLayout()
        Me.grpDoWhileLoop.ResumeLayout(False)
        Me.grpDoWhileLoop.PerformLayout()
        Me.grpDoWhileLoopBreak.ResumeLayout(False)
        Me.grpDoWhileLoopBreak.PerformLayout()
        Me.grpCreateArray.ResumeLayout(False)
        Me.grpCreateArray.PerformLayout()
        Me.grpMethodDemo.ResumeLayout(False)
        Me.grpMethodDemo.PerformLayout()
        Me.grpReset.ResumeLayout(False)
        Me.grpMethodAdd.ResumeLayout(False)
        Me.grpMethodAdd.PerformLayout()
        Me.grpSelectCase.ResumeLayout(False)
        Me.grpSelectCase.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpIf As GroupBox
    Friend WithEvents lbIfDescription As Label
    Friend WithEvents lbIfOutput As Label
    Friend WithEvents lbIfInput As Label
    Friend WithEvents tbIfInput As TextBox
    Friend WithEvents btnIfDemo As Button
    Friend WithEvents DemoTip As ToolTip
    Friend WithEvents grpNestedIf As GroupBox
    Friend WithEvents lbNestedIfDescription As Label
    Friend WithEvents lbNestedIfOutput As Label
    Friend WithEvents lbNestedIfInput As Label
    Friend WithEvents tbNestedIfInput As TextBox
    Friend WithEvents btnNestedIfDemo As Button
    Friend WithEvents grpForLoop As GroupBox
    Friend WithEvents lbForLoopDemoDescription As Label
    Friend WithEvents lbForLoopDemoOutput As Label
    Friend WithEvents lbForLoopDemoInput As Label
    Friend WithEvents tbForLoopDemoInput As TextBox
    Friend WithEvents btnForLoopDemo As Button
    Friend WithEvents grpForLoopBreak As GroupBox
    Friend WithEvents lbForLoopDemoBreakDescription As Label
    Friend WithEvents lbForLoopBreakDemoOutput As Label
    Friend WithEvents lbForLoopBreakDemoInput As Label
    Friend WithEvents tbForLoopBreakDemoInput As TextBox
    Friend WithEvents btnForLoopBreakDemo As Button
    Friend WithEvents grpWhileLoop As GroupBox
    Friend WithEvents lbWhileLoopDemoInputDescription As Label
    Friend WithEvents lbWhileLoopDemoOutput As Label
    Friend WithEvents lbWhileLoopDemoInput As Label
    Friend WithEvents tbWhileLoopDemoInput As TextBox
    Friend WithEvents btnWhileLoopDemo As Button
    Friend WithEvents grpWhileLoopBreak As GroupBox
    Friend WithEvents lbWhileLoopDemoBreakDescription As Label
    Friend WithEvents lbWhileLoopBreakDemoOutput As Label
    Friend WithEvents lbWhileLoopBreakDemoInput As Label
    Friend WithEvents tbWhileLoopBreakDemoInput As TextBox
    Friend WithEvents btnWhileLoopBreakDemo As Button
    Friend WithEvents grpDoWhileLoop As GroupBox
    Friend WithEvents lbDoWhileLoopDemoDescription As Label
    Friend WithEvents lbDoWhileLoopDemoOutput As Label
    Friend WithEvents lbDoWhileLoopDemoInput As Label
    Friend WithEvents tbDoWhileLoopDemoInput As TextBox
    Friend WithEvents btnDoWhileLoopDemo As Button
    Friend WithEvents grpDoWhileLoopBreak As GroupBox
    Friend WithEvents lbDoWhileLoopDemoBreakDescription As Label
    Friend WithEvents lbDoWhileLoopBreakDemoOutput As Label
    Friend WithEvents lbDoWhileLoopBreakDemoInput As Label
    Friend WithEvents tbDoWhileLoopBreakDemoInput As TextBox
    Friend WithEvents btnDoWhileLoopBreakDemo As Button
    Friend WithEvents grpCreateArray As GroupBox
    Friend WithEvents lbCreateArrayDescription As Label
    Friend WithEvents lbCreateArrayOutput As Label
    Friend WithEvents lbCreateArrayInput As Label
    Friend WithEvents tbCreateArrayInput As TextBox
    Friend WithEvents btnCreateArrayDemo As Button
    Friend WithEvents grpMethodDemo As GroupBox
    Friend WithEvents lbMethodDemoDesciption As Label
    Friend WithEvents lbMethodOutput As Label
    Friend WithEvents lbMethodInput As Label
    Friend WithEvents tbMethodInput As TextBox
    Friend WithEvents btnMethodDemo As Button
    Friend WithEvents grpReset As GroupBox
    Friend WithEvents lblReset As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents grpMethodAdd As GroupBox
    Friend WithEvents lbAddFunctionDescription As Label
    Friend WithEvents lbAddDemoOutput As Label
    Friend WithEvents lbNumberOne As Label
    Friend WithEvents tbNumberOne As TextBox
    Friend WithEvents btnAddDemo As Button
    Friend WithEvents lbNumberTwo As Label
    Friend WithEvents tbNumberTwo As TextBox
    Friend WithEvents grpSelectCase As GroupBox
    Friend WithEvents lblSelectCaseDescription As Label
    Friend WithEvents lbSelectCaseOutput As Label
    Friend WithEvents lbSelectCase As Label
    Friend WithEvents tbSelectCase As TextBox
    Friend WithEvents btnSelectCase As Button
End Class
