Imports System.IO
Public Class frmPatientInformation
    Dim fileExtension As String = ".png"

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmPatientInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not CheckPermission(Me.Name.ToString) = True Then
            MessageBox.Show("Sorry, you are not allowed to access this form.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.BeginInvoke(New MethodInvoker(AddressOf Close))
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtAddress.Text = ""
        txtAge.Text = ""
        txtContactNo.Text = ""
        txtOccupation.Text = ""
        txtParentNames.Text = ""
        txtPatientID.Text = ""
        txtPatientName.Text = ""
        txtReference.Text = ""
        txtAllergyStatic.Text = ""
        dtpDateOfEnroll.Value = Now
        cmbGender.Text = ""
        btnSave.Text = "SAVE"
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtPatientName.Text = "" Or cmbGender.Text = "" Or txtContactNo.Text = "" Then
            ErrorProvider1.SetError(txtPatientName, "Mandatory field.")
            ErrorProvider1.SetError(cmbGender, "Mandatory field.")
            ErrorProvider1.SetError(txtContactNo, "Mandatory field.")
        Else
            ErrorProvider1.Clear()
            If btnSave.Text = "SAVE" Then
                ExecuteSQLQuery(" INSERT INTO  PatientInformation (PatientName, ParentNames, Age, Gender, Address, Occupation, Reference, DateOfEnroll, ContactNo, AllergyStatic) VALUES " &
                " ('" + str_repl(txtPatientName.Text) + "', '" + str_repl(txtParentNames.Text) + "', '" + str_repl(txtAge.Text) + "', '" + str_repl(cmbGender.Text) + "',  " &
                " '" + str_repl(txtAddress.Text) + "', '" + str_repl(txtOccupation.Text) + "', '" + str_repl(txtReference.Text) + "', '" & Format(dtpDateOfEnroll.Value, "MM/dd/yyyy") & "', '" + str_repl(txtContactNo.Text) + "', '" + str_repl(txtAllergyStatic.Text) + "') ")

                ExecuteSQLQuery("SELECT  Patient_ID FROM     PatientInformation  ORDER BY Patient_ID DESC")
                ExecuteSQLQuery("SELECT  Patient_ID FROM     PatientInformation  ORDER BY Patient_ID DESC")
                If sqlDT.Rows.Count > 0 Then
                    Dim PATIENT_ID As Double = sqlDT.Rows(0)("Patient_ID")
                    ' Tiếp tục xử lý dữ liệu ở đây
                End If

            ElseIf btnSave.Text = "UPDATE" Then
                ExecuteSQLQuery(" UPDATE   PatientInformation SET PatientName='" + str_repl(txtPatientName.Text) + "', ParentNames='" + str_repl(txtParentNames.Text) + "', Age='" + str_repl(txtAge.Text) + "', Gender='" + str_repl(cmbGender.Text) + "',Address='" + str_repl(txtAddress.Text) + "', " &
                                " Occupation='" + str_repl(txtOccupation.Text) + "', Reference='" + str_repl(txtReference.Text) + "', DateOfEnroll='" & Format(dtpDateOfEnroll.Value, "MM/dd/yyyy") & "', ContactNo='" + str_repl(txtContactNo.Text) + "', AllergyStatic='" + str_repl(txtAllergyStatic.Text) + "', " &
                                " WHERE  Patient_ID=" & txtPatientID.Text & "  ")

            End If
            btnSave.Text = "SAVE"
            btnReset.PerformClick()
            MsgBox("Record has been saved successfully.", MsgBoxStyle.Information, "Information")
        End If
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class