﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.tbxName = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.tbxAddress = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.tbxCnum = New System.Windows.Forms.TextBox()
        Me.lblCnum = New System.Windows.Forms.Label()
        Me.tbxTemp = New System.Windows.Forms.TextBox()
        Me.lblTemp = New System.Windows.Forms.Label()
        Me.gbxGender = New System.Windows.Forms.GroupBox()
        Me.radFemale = New System.Windows.Forms.RadioButton()
        Me.radMale = New System.Windows.Forms.RadioButton()
        Me.gbxVacc = New System.Windows.Forms.GroupBox()
        Me.rad2booster = New System.Windows.Forms.RadioButton()
        Me.radNotyet = New System.Windows.Forms.RadioButton()
        Me.rad2dose = New System.Windows.Forms.RadioButton()
        Me.radBooster = New System.Windows.Forms.RadioButton()
        Me.rad1dose = New System.Windows.Forms.RadioButton()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.cbxFever = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbxSorethroat = New System.Windows.Forms.CheckBox()
        Me.cbxColds = New System.Windows.Forms.CheckBox()
        Me.cbxBreathComp = New System.Windows.Forms.CheckBox()
        Me.cbxCoughs = New System.Windows.Forms.CheckBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.cbxIdont = New System.Windows.Forms.CheckBox()
        Me.gbxGender.SuspendLayout()
        Me.gbxVacc.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbxName
        '
        Me.tbxName.Location = New System.Drawing.Point(139, 42)
        Me.tbxName.Name = "tbxName"
        Me.tbxName.Size = New System.Drawing.Size(183, 27)
        Me.tbxName.TabIndex = 0
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(12, 45)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(52, 20)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Name:"
        '
        'tbxAddress
        '
        Me.tbxAddress.Location = New System.Drawing.Point(139, 86)
        Me.tbxAddress.Name = "tbxAddress"
        Me.tbxAddress.Size = New System.Drawing.Size(183, 27)
        Me.tbxAddress.TabIndex = 0
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(12, 89)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(65, 20)
        Me.lblAddress.TabIndex = 1
        Me.lblAddress.Text = "Address:"
        '
        'tbxCnum
        '
        Me.tbxCnum.Location = New System.Drawing.Point(139, 136)
        Me.tbxCnum.Name = "tbxCnum"
        Me.tbxCnum.Size = New System.Drawing.Size(183, 27)
        Me.tbxCnum.TabIndex = 0
        '
        'lblCnum
        '
        Me.lblCnum.AutoSize = True
        Me.lblCnum.Location = New System.Drawing.Point(12, 139)
        Me.lblCnum.Name = "lblCnum"
        Me.lblCnum.Size = New System.Drawing.Size(121, 20)
        Me.lblCnum.TabIndex = 1
        Me.lblCnum.Text = "Contact Number:"
        '
        'tbxTemp
        '
        Me.tbxTemp.Location = New System.Drawing.Point(139, 184)
        Me.tbxTemp.Name = "tbxTemp"
        Me.tbxTemp.Size = New System.Drawing.Size(183, 27)
        Me.tbxTemp.TabIndex = 0
        '
        'lblTemp
        '
        Me.lblTemp.AutoSize = True
        Me.lblTemp.Location = New System.Drawing.Point(12, 187)
        Me.lblTemp.Name = "lblTemp"
        Me.lblTemp.Size = New System.Drawing.Size(96, 20)
        Me.lblTemp.TabIndex = 1
        Me.lblTemp.Text = "Temperature:"
        '
        'gbxGender
        '
        Me.gbxGender.Controls.Add(Me.radFemale)
        Me.gbxGender.Controls.Add(Me.radMale)
        Me.gbxGender.Location = New System.Drawing.Point(27, 240)
        Me.gbxGender.Name = "gbxGender"
        Me.gbxGender.Size = New System.Drawing.Size(294, 72)
        Me.gbxGender.TabIndex = 2
        Me.gbxGender.TabStop = False
        Me.gbxGender.Text = "Gender:"
        '
        'radFemale
        '
        Me.radFemale.AutoSize = True
        Me.radFemale.Location = New System.Drawing.Point(192, 26)
        Me.radFemale.Name = "radFemale"
        Me.radFemale.Size = New System.Drawing.Size(78, 24)
        Me.radFemale.TabIndex = 0
        Me.radFemale.TabStop = True
        Me.radFemale.Text = "Female"
        Me.radFemale.UseVisualStyleBackColor = True
        '
        'radMale
        '
        Me.radMale.AutoSize = True
        Me.radMale.Location = New System.Drawing.Point(87, 26)
        Me.radMale.Name = "radMale"
        Me.radMale.Size = New System.Drawing.Size(63, 24)
        Me.radMale.TabIndex = 0
        Me.radMale.TabStop = True
        Me.radMale.Text = "Male"
        Me.radMale.UseVisualStyleBackColor = True
        '
        'gbxVacc
        '
        Me.gbxVacc.Controls.Add(Me.rad2booster)
        Me.gbxVacc.Controls.Add(Me.radNotyet)
        Me.gbxVacc.Controls.Add(Me.rad2dose)
        Me.gbxVacc.Controls.Add(Me.radBooster)
        Me.gbxVacc.Controls.Add(Me.rad1dose)
        Me.gbxVacc.Location = New System.Drawing.Point(31, 335)
        Me.gbxVacc.Name = "gbxVacc"
        Me.gbxVacc.Size = New System.Drawing.Size(289, 118)
        Me.gbxVacc.TabIndex = 3
        Me.gbxVacc.TabStop = False
        Me.gbxVacc.Text = "Vaccination:"
        '
        'rad2booster
        '
        Me.rad2booster.AutoSize = True
        Me.rad2booster.Location = New System.Drawing.Point(145, 53)
        Me.rad2booster.Name = "rad2booster"
        Me.rad2booster.Size = New System.Drawing.Size(110, 24)
        Me.rad2booster.TabIndex = 0
        Me.rad2booster.TabStop = True
        Me.rad2booster.Text = "2nd Booster"
        Me.rad2booster.UseVisualStyleBackColor = True
        '
        'radNotyet
        '
        Me.radNotyet.AutoSize = True
        Me.radNotyet.Location = New System.Drawing.Point(67, 83)
        Me.radNotyet.Name = "radNotyet"
        Me.radNotyet.Size = New System.Drawing.Size(79, 24)
        Me.radNotyet.TabIndex = 0
        Me.radNotyet.TabStop = True
        Me.radNotyet.Text = "Not yet"
        Me.radNotyet.UseVisualStyleBackColor = True
        '
        'rad2dose
        '
        Me.rad2dose.AutoSize = True
        Me.rad2dose.Location = New System.Drawing.Point(3, 53)
        Me.rad2dose.Name = "rad2dose"
        Me.rad2dose.Size = New System.Drawing.Size(93, 24)
        Me.rad2dose.TabIndex = 0
        Me.rad2dose.TabStop = True
        Me.rad2dose.Text = "2nd Dose"
        Me.rad2dose.UseVisualStyleBackColor = True
        '
        'radBooster
        '
        Me.radBooster.AutoSize = True
        Me.radBooster.Location = New System.Drawing.Point(145, 23)
        Me.radBooster.Name = "radBooster"
        Me.radBooster.Size = New System.Drawing.Size(81, 24)
        Me.radBooster.TabIndex = 0
        Me.radBooster.TabStop = True
        Me.radBooster.Text = "Booster"
        Me.radBooster.UseVisualStyleBackColor = True
        '
        'rad1dose
        '
        Me.rad1dose.AutoSize = True
        Me.rad1dose.Location = New System.Drawing.Point(3, 23)
        Me.rad1dose.Name = "rad1dose"
        Me.rad1dose.Size = New System.Drawing.Size(87, 24)
        Me.rad1dose.TabIndex = 0
        Me.rad1dose.TabStop = True
        Me.rad1dose.Text = "1st Dose"
        Me.rad1dose.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(114, 679)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(94, 29)
        Me.btnSubmit.TabIndex = 4
        Me.btnSubmit.Text = "SUBMIT"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'cbxFever
        '
        Me.cbxFever.AutoSize = True
        Me.cbxFever.Location = New System.Drawing.Point(16, 26)
        Me.cbxFever.Name = "cbxFever"
        Me.cbxFever.Size = New System.Drawing.Size(66, 24)
        Me.cbxFever.TabIndex = 5
        Me.cbxFever.Text = "Fever"
        Me.cbxFever.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbxCoughs)
        Me.GroupBox1.Controls.Add(Me.cbxBreathComp)
        Me.GroupBox1.Controls.Add(Me.cbxColds)
        Me.GroupBox1.Controls.Add(Me.cbxSorethroat)
        Me.GroupBox1.Controls.Add(Me.cbxFever)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 467)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(294, 120)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Do you have any of these?"
        '
        'cbxSorethroat
        '
        Me.cbxSorethroat.AutoSize = True
        Me.cbxSorethroat.Location = New System.Drawing.Point(168, 26)
        Me.cbxSorethroat.Name = "cbxSorethroat"
        Me.cbxSorethroat.Size = New System.Drawing.Size(108, 24)
        Me.cbxSorethroat.TabIndex = 5
        Me.cbxSorethroat.Text = "Sore Throat"
        Me.cbxSorethroat.UseVisualStyleBackColor = True
        '
        'cbxColds
        '
        Me.cbxColds.AutoSize = True
        Me.cbxColds.Location = New System.Drawing.Point(168, 56)
        Me.cbxColds.Name = "cbxColds"
        Me.cbxColds.Size = New System.Drawing.Size(68, 24)
        Me.cbxColds.TabIndex = 5
        Me.cbxColds.Text = "Colds"
        Me.cbxColds.UseVisualStyleBackColor = True
        '
        'cbxBreathComp
        '
        Me.cbxBreathComp.AutoSize = True
        Me.cbxBreathComp.Location = New System.Drawing.Point(16, 86)
        Me.cbxBreathComp.Name = "cbxBreathComp"
        Me.cbxBreathComp.Size = New System.Drawing.Size(194, 24)
        Me.cbxBreathComp.TabIndex = 5
        Me.cbxBreathComp.Text = "Breathing Complications"
        Me.cbxBreathComp.UseVisualStyleBackColor = True
        '
        'cbxCoughs
        '
        Me.cbxCoughs.AutoSize = True
        Me.cbxCoughs.Location = New System.Drawing.Point(16, 56)
        Me.cbxCoughs.Name = "cbxCoughs"
        Me.cbxCoughs.Size = New System.Drawing.Size(80, 24)
        Me.cbxCoughs.TabIndex = 5
        Me.cbxCoughs.Text = "Coughs"
        Me.cbxCoughs.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(74, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(183, 20)
        Me.lblTitle.TabIndex = 7
        Me.lblTitle.Text = "CONTACT TRACING FORM"
        '
        'cbxIdont
        '
        Me.cbxIdont.AutoSize = True
        Me.cbxIdont.Location = New System.Drawing.Point(43, 593)
        Me.cbxIdont.Name = "cbxIdont"
        Me.cbxIdont.Size = New System.Drawing.Size(192, 24)
        Me.cbxIdont.TabIndex = 8
        Me.cbxIdont.Text = "I don't have any of these"
        Me.cbxIdont.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(347, 720)
        Me.Controls.Add(Me.cbxIdont)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.gbxVacc)
        Me.Controls.Add(Me.gbxGender)
        Me.Controls.Add(Me.lblTemp)
        Me.Controls.Add(Me.lblCnum)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.tbxTemp)
        Me.Controls.Add(Me.tbxCnum)
        Me.Controls.Add(Me.tbxAddress)
        Me.Controls.Add(Me.tbxName)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.gbxGender.ResumeLayout(False)
        Me.gbxGender.PerformLayout()
        Me.gbxVacc.ResumeLayout(False)
        Me.gbxVacc.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbxName As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents tbxAddress As TextBox
    Friend WithEvents lblAddress As Label
    Friend WithEvents tbxCnum As TextBox
    Friend WithEvents lblCnum As Label
    Friend WithEvents tbxTemp As TextBox
    Friend WithEvents lblTemp As Label
    Friend WithEvents gbxGender As GroupBox
    Friend WithEvents radFemale As RadioButton
    Friend WithEvents radMale As RadioButton
    Friend WithEvents gbxVacc As GroupBox
    Friend WithEvents rad2booster As RadioButton
    Friend WithEvents radNotyet As RadioButton
    Friend WithEvents rad2dose As RadioButton
    Friend WithEvents radBooster As RadioButton
    Friend WithEvents rad1dose As RadioButton
    Friend WithEvents btnSubmit As Button
    Friend WithEvents cbxFever As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbxCoughs As CheckBox
    Friend WithEvents cbxBreathComp As CheckBox
    Friend WithEvents cbxColds As CheckBox
    Friend WithEvents cbxSorethroat As CheckBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents cbxIdont As CheckBox
End Class
