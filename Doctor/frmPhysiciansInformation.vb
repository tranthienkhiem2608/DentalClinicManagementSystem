Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip

Public Class frmPhysiciansInformation
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtAddress.Text = ""
        txtContactNumber.Text = ""
        txtDoctorID.Text = ""
        txtDoctorName.Text = ""
        txtQualification.Text = ""
        txtSpeciality.Text = ""
        btnSave.Text = "SAVE"
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtDoctorName.Text = "" Or txtSpeciality.Text = "" Or txtQualification.Text = "" Or txtContactNumber.Text = "" Then
            ErrorProvider1.SetError(txtDoctorName, "Mandatory field.")
            ErrorProvider1.SetError(txtSpeciality, "Mandatory field.")
            ErrorProvider1.SetError(txtQualification, "Mandatory field.")
            ErrorProvider1.SetError(txtContactNumber, "Mandatory field.")
        Else
            ErrorProvider1.Clear()
            If btnSave.Text = "SAVE" Then
                ExecuteSQLQuery(" INSERT INTO PhysiciansInformation  (DoctorName, Speciality, Qualification, Address, ContactNumber) VALUES " &
                                " ('" + str_repl(txtDoctorName.Text) + "', '" + str_repl(txtSpeciality.Text) + "', '" + str_repl(txtQualification.Text) + "', '" + str_repl(txtAddress.Text) + "', '" + str_repl(txtContactNumber.Text) + "') ")
                btnReset.PerformClick()
                MsgBox("Record has been saved successfully.", MsgBoxStyle.Information, "Information")
            ElseIf btnSave.Text = "UPDATE" Then
                ExecuteSQLQuery(" UPDATE PhysiciansInformation SET  DoctorName='" + str_repl(txtDoctorName.Text) + "', Speciality='" + str_repl(txtSpeciality.Text) + "', Qualification='" + str_repl(txtQualification.Text) + "', Address='" + str_repl(txtAddress.Text) + "', " &
                                "  ContactNumber='" + str_repl(txtContactNumber.Text) + "' WHERE    (DOCTOR_ID = " & txtDoctorID.Text & ")  ")
                btnReset.PerformClick()
                MsgBox("Record has been updated successfully.", MsgBoxStyle.Information, "Information")
            End If
        End If
    End Sub

    Private Sub frmPhysiciansInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not CheckPermission(Me.Name.ToString) = True Then
            MessageBox.Show("Sorry, you are not allowed to access this form.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.BeginInvoke(New MethodInvoker(AddressOf Close))
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtAddress_TextChanged(sender As Object, e As EventArgs) Handles txtAddress.TextChanged

    End Sub
End Class