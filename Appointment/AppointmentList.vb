Public Class AppointmentList
    Private Sub frmListOfAppointment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not CheckPermission(Me.Name.ToString) = True Then
            MessageBox.Show("Sorry, you are not allowed to access this form.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.BeginInvoke(New MethodInvoker(AddressOf Close))
        End If
        LoadAppointmentData()
    End Sub
    Private Sub LoadAppointmentData()
        sqlSTR = "SELECT        AppointmentNo, VisitingDate, VisitingTime, NextAppointment, NextAppointmentDate, Static, DOCTOR_ID, Patient_ID, Room_ID FROM         Appointment"
        FillDataGrid(sqlSTR, DataGridView1)
        ExecuteSQLQuery(sqlSTR)
        If sqlDT.Rows.Count > 0 Then
            lblCount.Text = sqlDT.Rows.Count.ToString & " Record Found."
        Else
            lblCount.Text = "No Record Found."
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadAppointmentData()
    End Sub

    Private Sub txtCriteria_TextChanged(sender As Object, e As EventArgs) Handles txtCriteria.TextChanged
        If cmbParameter.Text = "" Then
            ErrorProvider1.SetError(cmbParameter, "Mandatory field.")
            LoadAppointmentData()
        ElseIf txtCriteria.Text = "" Then
            ErrorProvider1.Clear()
            ErrorProvider2.SetError(txtCriteria, "Mandatory field.")
            LoadAppointmentData()
        Else
            ErrorProvider1.Clear()
            ErrorProvider2.Clear()
            sqlSTR = "  SELECT        AppointmentNo, VisitingDate, VisitingTime, NextAppointment, NextAppointmentDate, Static, " &
                     " DOCTOR_ID, Patient_ID, Room_ID  FROM            Appointment " &
                     " WHERE   (" + cmbParameter.Text + " LIKE '%" + txtCriteria.Text + "%') "
            FillDataGrid(sqlSTR, DataGridView1)
            ExecuteSQLQuery(sqlSTR)
            If sqlDT.Rows.Count > 0 Then
                lblCount.Text = sqlDT.Rows.Count.ToString & " Record Found."
            Else
                lblCount.Text = "No Record Found."
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.ColumnIndex = 0 Then
            If MsgBox("Are you sure you want to edit this record?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Confirm..") = MsgBoxResult.Yes Then
                With AppointmentInformation
                    .MdiParent = frmMDIParent
                    .Show()
                    ExecuteSQLQuery("SELECT * FROM Appointment WHERE  AppointmentNo =" & DataGridView1.CurrentRow.Cells(2).Value & " ")
                    If sqlDT.Rows.Count > 0 Then
                        .txtDoctorID.Text = sqlDT.Rows(0)("DOCTOR_ID")
                        .dtpAppointmentDate.Value = sqlDT.Rows(0)("VisitingDate")
                        .txtAppointmentTime.Text = sqlDT.Rows(0)("VisitingTime")
                        .dtpNextAppointment.Value = sqlDT.Rows(0)("NextAppointment")
                        .cmbStatic.Text = sqlDT.Rows(0)("Static")
                        .txtRoom.Text = sqlDT.Rows(0)("Room_ID")
                        .txtPatientID.Text = sqlDT.Rows(0)("Patient_ID")
                        .btnSave.Text = "UPDATE"
                    End If
                End With
            End If
        ElseIf e.ColumnIndex = 1 Then
            If MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Confirm..") = MsgBoxResult.Yes Then
                ExecuteSQLQuery("DELETE FROM PatientInformation WHERE  Patient_ID =" & DataGridView1.CurrentRow.Cells(2).Value & " ")
                LoadAppointmentData()
                MsgBox("Record deleted successfully.", MsgBoxStyle.Information, "Information")
            End If
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class