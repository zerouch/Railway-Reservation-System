﻿Public Class MainForm
    Private Sub MainForm_Load(sender As Object, e As EventArgs) handles MyBase.Load
        DatePicker.MinDate = Date.Now
        DatePicker.MaxDate = Date.Now.AddYears(1)
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) handles SearchButton.Click
        If ValidateFields() Then
            Return
        End If
        Dim origin As String = FromComboBox.SelectedItem
        Dim destination As String = ToComboBox.SelectedItem
        Dim dateOfTravel As Date = DatePicker.Value
        Dim classOfTravel As String = ClassComboBox.SelectedItem
        Dim numberOfPassengers As Integer = PassengerCount.Value
    End Sub

    Private Function ValidateFields() As Boolean
        If String.IsNullOrEmpty(FromComboBox.SelectedItem) Or String.IsNullOrEmpty(ToComboBox.SelectedItem) Or String.IsNullOrEmpty(ClassComboBox.SelectedItem) Then
            MessageBox.Show("Please fill up all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return True
        ElseIf FromComboBox.SelectedItem = ToComboBox.SelectedItem Then
            MessageBox.Show("Origin and destination cannot be the same", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) handles Guna2ControlBox1.Click
        WelcomeForm.Show()
    End Sub
End Class