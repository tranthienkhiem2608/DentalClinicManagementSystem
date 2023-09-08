<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AppointmentInformation
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtPatientID = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtpNextAppointment = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chkNextAppointment = New System.Windows.Forms.CheckBox()
        Me.cmbStatic = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtRoom = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtDoctorID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnDoctorList = New System.Windows.Forms.Button()
        Me.btnCurrentTime = New System.Windows.Forms.Button()
        Me.txtAppointmentTime = New System.Windows.Forms.TextBox()
        Me.dtpAppointmentDate = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAppointmentNo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(425, 62)
        Me.Panel1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(55, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(267, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Appointment Information"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.DentalClinicManagementSystem.My.Resources.Resources.doctor_headers
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Location = New System.Drawing.Point(20, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 39)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtPatientID)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.dtpNextAppointment)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.chkNextAppointment)
        Me.GroupBox1.Controls.Add(Me.cmbStatic)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtRoom)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.txtDoctorID)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.btnDoctorList)
        Me.GroupBox1.Controls.Add(Me.btnCurrentTime)
        Me.GroupBox1.Controls.Add(Me.txtAppointmentTime)
        Me.GroupBox1.Controls.Add(Me.dtpAppointmentDate)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtAppointmentNo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(20, 89)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(389, 247)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Appointment Information"
        '
        'txtPatientID
        '
        Me.txtPatientID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPatientID.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatientID.Location = New System.Drawing.Point(6, 200)
        Me.txtPatientID.Name = "txtPatientID"
        Me.txtPatientID.ReadOnly = True
        Me.txtPatientID.Size = New System.Drawing.Size(130, 22)
        Me.txtPatientID.TabIndex = 71
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(6, 183)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 14)
        Me.Label8.TabIndex = 70
        Me.Label8.Text = "Patient ID"
        '
        'dtpNextAppointment
        '
        Me.dtpNextAppointment.CustomFormat = "dd-MMM-yyyy"
        Me.dtpNextAppointment.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpNextAppointment.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNextAppointment.Location = New System.Drawing.Point(236, 219)
        Me.dtpNextAppointment.Name = "dtpNextAppointment"
        Me.dtpNextAppointment.Size = New System.Drawing.Size(142, 22)
        Me.dtpNextAppointment.TabIndex = 59
        '
        'GroupBox3
        '
        Me.GroupBox3.Location = New System.Drawing.Point(230, 244)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(155, 105)
        Me.GroupBox3.TabIndex = 69
        Me.GroupBox3.TabStop = False
        '
        'chkNextAppointment
        '
        Me.chkNextAppointment.AutoSize = True
        Me.chkNextAppointment.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkNextAppointment.Location = New System.Drawing.Point(237, 200)
        Me.chkNextAppointment.Name = "chkNextAppointment"
        Me.chkNextAppointment.Size = New System.Drawing.Size(128, 17)
        Me.chkNextAppointment.TabIndex = 0
        Me.chkNextAppointment.Text = "Next Appointment"
        Me.chkNextAppointment.UseVisualStyleBackColor = True
        '
        'cmbStatic
        '
        Me.cmbStatic.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStatic.FormattingEnabled = True
        Me.cmbStatic.Items.AddRange(New Object() {"Re-examination", "", "New appointment"})
        Me.cmbStatic.Location = New System.Drawing.Point(236, 151)
        Me.cmbStatic.Name = "cmbStatic"
        Me.cmbStatic.Size = New System.Drawing.Size(123, 22)
        Me.cmbStatic.TabIndex = 67
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(236, 134)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 68
        Me.Label7.Text = "Static"
        '
        'txtRoom
        '
        Me.txtRoom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRoom.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRoom.Location = New System.Drawing.Point(236, 103)
        Me.txtRoom.Name = "txtRoom"
        Me.txtRoom.ReadOnly = True
        Me.txtRoom.Size = New System.Drawing.Size(88, 22)
        Me.txtRoom.TabIndex = 66
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(236, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 14)
        Me.Label6.TabIndex = 65
        Me.Label6.Text = "Room"
        '
        'Button1
        '
        Me.Button1.Image = Global.DentalClinicManagementSystem.My.Resources.Resources.Table
        Me.Button1.Location = New System.Drawing.Point(330, 103)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(29, 24)
        Me.Button1.TabIndex = 64
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtDoctorID
        '
        Me.txtDoctorID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDoctorID.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDoctorID.Location = New System.Drawing.Point(236, 50)
        Me.txtDoctorID.Name = "txtDoctorID"
        Me.txtDoctorID.ReadOnly = True
        Me.txtDoctorID.Size = New System.Drawing.Size(88, 22)
        Me.txtDoctorID.TabIndex = 63
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(236, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 14)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "Doctor ID"
        '
        'btnDoctorList
        '
        Me.btnDoctorList.Image = Global.DentalClinicManagementSystem.My.Resources.Resources.Table
        Me.btnDoctorList.Location = New System.Drawing.Point(330, 50)
        Me.btnDoctorList.Name = "btnDoctorList"
        Me.btnDoctorList.Size = New System.Drawing.Size(29, 24)
        Me.btnDoctorList.TabIndex = 61
        Me.btnDoctorList.UseVisualStyleBackColor = True
        '
        'btnCurrentTime
        '
        Me.btnCurrentTime.BackColor = System.Drawing.Color.White
        Me.btnCurrentTime.FlatAppearance.BorderSize = 0
        Me.btnCurrentTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCurrentTime.Image = Global.DentalClinicManagementSystem.My.Resources.Resources.Clock
        Me.btnCurrentTime.Location = New System.Drawing.Point(106, 151)
        Me.btnCurrentTime.Name = "btnCurrentTime"
        Me.btnCurrentTime.Size = New System.Drawing.Size(28, 20)
        Me.btnCurrentTime.TabIndex = 59
        Me.btnCurrentTime.UseVisualStyleBackColor = False
        '
        'txtAppointmentTime
        '
        Me.txtAppointmentTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAppointmentTime.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAppointmentTime.Location = New System.Drawing.Point(6, 150)
        Me.txtAppointmentTime.Name = "txtAppointmentTime"
        Me.txtAppointmentTime.Size = New System.Drawing.Size(130, 22)
        Me.txtAppointmentTime.TabIndex = 60
        '
        'dtpAppointmentDate
        '
        Me.dtpAppointmentDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpAppointmentDate.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpAppointmentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpAppointmentDate.Location = New System.Drawing.Point(6, 99)
        Me.dtpAppointmentDate.Name = "dtpAppointmentDate"
        Me.dtpAppointmentDate.Size = New System.Drawing.Size(130, 22)
        Me.dtpAppointmentDate.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(6, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Appointment Time"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(6, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Appointment Date"
        '
        'txtAppointmentNo
        '
        Me.txtAppointmentNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAppointmentNo.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAppointmentNo.Location = New System.Drawing.Point(6, 50)
        Me.txtAppointmentNo.Name = "txtAppointmentNo"
        Me.txtAppointmentNo.ReadOnly = True
        Me.txtAppointmentNo.Size = New System.Drawing.Size(130, 22)
        Me.txtAppointmentNo.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(6, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 14)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Appointment ID"
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Image = Global.DentalClinicManagementSystem.My.Resources.Resources._Exit
        Me.btnClose.Location = New System.Drawing.Point(271, 362)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(119, 33)
        Me.btnClose.TabIndex = 28
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Image = Global.DentalClinicManagementSystem.My.Resources.Resources.Redo
        Me.btnReset.Location = New System.Drawing.Point(148, 362)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(119, 33)
        Me.btnReset.TabIndex = 27
        Me.btnReset.Text = "RESET"
        Me.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = Global.DentalClinicManagementSystem.My.Resources.Resources.Save
        Me.btnSave.Location = New System.Drawing.Point(24, 362)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(119, 33)
        Me.btnSave.TabIndex = 26
        Me.btnSave.Text = "SAVE"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(-71, 349)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(555, 54)
        Me.GroupBox2.TabIndex = 29
        Me.GroupBox2.TabStop = False

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtAppointmentNo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpAppointmentDate As DateTimePicker
    Friend WithEvents btnCurrentTime As Button
    Friend WithEvents txtAppointmentTime As TextBox
    Friend WithEvents btnDoctorList As Button
    Friend WithEvents txtDoctorID As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtRoom As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents cmbStatic As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dtpNextAppointment As DateTimePicker
    Friend WithEvents chkNextAppointment As CheckBox
    Friend WithEvents btnClose As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents txtPatientID As TextBox
    Friend WithEvents Label8 As Label
End Class
