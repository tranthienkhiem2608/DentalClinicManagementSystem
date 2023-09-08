Public Class AppointmentInformation
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtAppointmentNo.Text = ""
        txtDoctorID.Text = ""
        dtpAppointmentDate.Value = Now
        txtAppointmentTime.Text = System.DateTime.Now.ToString("hh:mm tt")
        dtpNextAppointment.Value = Now
        cmbStatic.Text = ""
        txtRoom.Text = ""
        txtPatientID.Text = ""
        btnSave.Text = "SAVE"
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtDoctorID.Text = "" Or txtRoom.Text = "" Then
            ErrorProvider1.SetError(txtDoctorID, "Mandatory field.")
            ErrorProvider1.SetError(txtRoom, "Mandatory field.")
        Else
            ErrorProvider1.Clear()
            If btnSave.Text = "SAVE" Then
                ExecuteSQLQuery(" INSERT INTO Appointment  (Static, DOCTOR_ID, Patient_ID, Room_ID) VALUES " &
                                " ('" + str_repl(cmbStatic.Text) + "', '" + str_repl(txtDoctorID.Text) + "', '" + str_repl(txtPatientID.Text) + "', '" + str_repl(txtRoom.Text) + "') ")
                btnReset.PerformClick()
                MsgBox("Record has been saved successfully.", MsgBoxStyle.Information, "Information")
            ElseIf btnSave.Text = "UPDATE" Then
                ExecuteSQLQuery(" UPDATE Appointment SET  Static='" + str_repl(cmbStatic.Text) + "', DOCTOR_ID='" + str_repl(txtDoctorID.Text) + "', Patient_ID='" + str_repl(txtDoctorID.Text) + "', Room_ID='" + str_repl(txtRoom.Text) + "', " &
                                 "' WHERE    (AppointmentNo = " & txtAppointmentNo.Text & ")  ")
                btnReset.PerformClick()
                MsgBox("Record has been updated successfully.", MsgBoxStyle.Information, "Information")
            End If

            If chkNextAppointment.Checked = True Then
                Try
                    ExecuteSQLQuery("UPDATE Treatment SET NextAppointmentDate='" & Format(dtpNextAppointment.Value, "MM/dd/yyyy") & "' WHERE   (VID = " & num_fltr(txtAppointmentNo.Text) & ") ")
                Catch ex As Exception

                End Try
            Else
                ExecuteSQLQuery("UPDATE Treatment SET NextAppointmentDate='' WHERE   (VID = " & num_fltr(txtAppointmentNo.Text) & ") ")
            End If
            MsgBox("The data has been changed.", MsgBoxStyle.Information, "Information")
        End If
    End Sub

    Private Sub frmAppointmentInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not CheckPermission(Me.Name.ToString) = True Then
            MessageBox.Show("Sorry, you are not allowed to access this form.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.BeginInvoke(New MethodInvoker(AddressOf Close))
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub dtpAppointmentDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpAppointmentDate.ValueChanged

    End Sub

    Private Sub Label8_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class