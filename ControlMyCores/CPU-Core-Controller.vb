Imports System.Diagnostics
Imports System.Threading
Public Class Form1

    Dim corecount As Integer
    Dim counter1 As Integer
    Dim counter2 As Integer
    Dim sc As Integer
    Dim ferror As Boolean


    Private Sub Button1_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        corecount = 0

        'Sider Counter
        fss.Maximum = System.Environment.ProcessorCount.ToString - 1
        '------------------


        'Checkbox SingleCore List
        'For Each proc In Process.GetProcesses
        '    If Not scpl.Items.Contains(proc.ProcessName) Then
        '        scpl.Items.Add(proc.ProcessName)
        '    End If

        '    On Error Resume Next
        'Next
        '------------------


        'Corecounter multicore checked list
        While corecount <= System.Environment.ProcessorCount.ToString - 1
            corecount = corecount + 1
            cs.Items.Add(corecount - 1)
        End While

        '------------------



    End Sub

    Private Sub ForceSingleSlider_ValueChanged(sender As Object, e As EventArgs) Handles fss.ValueChanged
        singlecoreval.Text = "Core Selected: " & fss.Value
    End Sub
    Private Sub ProcessChanger_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles ProcessChanger.DoWork

        ProcessChanger.ReportProgress(1, "Starting...")
        'Thread.Sleep(15)
        For Each proc In Process.GetProcesses
            Try
                proc.ProcessorAffinity = New IntPtr(1)
                ProcessChanger.ReportProgress(2, "Applying Changes")
                'Thread.Sleep(15)
            Catch ex As Exception

            End Try

        Next

    End Sub

    Private Sub ProcessChanger_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles ProcessChanger.ProgressChanged
        ReportLbl.Text = DirectCast(e.UserState, String)
    End Sub

    Private Sub ProcessChanger_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles ProcessChanger.RunWorkerCompleted
        ReportLbl.Text = "Done"
        Me.Enabled = True
    End Sub

    Private Sub ProcessChanger2_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles ProcessChanger2.DoWork
        ProcessChanger2.ReportProgress(1, "Starting...")
        'Thread.Sleep(15)
        For Each proc In Process.GetProcesses
            Try
                proc.ProcessorAffinity = New IntPtr(sc)
                ProcessChanger2.ReportProgress(2, "Applying Changes")
                'Thread.Sleep(15)
            Catch ex As Exception

            End Try

        Next

    End Sub


    Private Sub ProcessChanger2_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles ProcessChanger2.ProgressChanged
        ReportLbl.Text = DirectCast(e.UserState, String)
    End Sub

    Private Sub ProcessChanger2_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles ProcessChanger2.RunWorkerCompleted
        ReportLbl.Text = "Done"
        Me.Enabled = True
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        sc = 2 ^ fss.Value
        Me.Enabled = False
        Try
            If fss.Value = 0 Then
                ProcessChanger.RunWorkerAsync()

            Else
                ProcessChanger2.RunWorkerAsync()
            End If
        Catch ex As Exception

        End Try





    End Sub

    Private Sub ProcessChanger3_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles ProcessChanger3.DoWork
        ProcessChanger3.ReportProgress(1, "Restore Starting")
        Try
            'Thread.Sleep(15)
        Catch ex As Exception

        End Try

        Dim cores As Integer
        Dim n As Integer
        cores = System.Environment.ProcessorCount.ToString
        n = 2 ^ cores - 1
        For Each proc In Process.GetProcesses
            Try
                proc.ProcessorAffinity = New IntPtr(n)
                ProcessChanger3.ReportProgress(2, "Restoring...")
                'Thread.Sleep(15)
            Catch ex As Exception

            End Try
        Next
    End Sub


    Private Sub ProcessChanger3_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles ProcessChanger3.ProgressChanged
        ReportLbl.Text = DirectCast(e.UserState, String)
    End Sub

    Private Sub ProcessChanger3_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles ProcessChanger3.RunWorkerCompleted
        ReportLbl.Text = "Restore Finished."
        Me.Enabled = 1
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            ProcessChanger3.RunWorkerAsync()
            Me.Enabled = False
        Catch ex As Exception

        End Try

    End Sub

    Private Sub rfpl1_Click(sender As Object, e As EventArgs) Handles rfpl1.Click
        scpl.Items.Clear()
        For Each proc In Process.GetProcesses
            Try
                If Not scpl.Items.Contains(proc.ProcessName) Then
                    scpl.Items.Add(proc.ProcessName)
                End If
            Catch ex As Exception

            End Try
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles rfspcl.Click
        pclist.Items.Clear()
        For Each proc In Process.GetProcesses
            Try
                If Not pclist.Items.Contains(proc.ProcessName) Then
                    pclist.Items.Add(proc.ProcessName)
                End If
            Catch ex As Exception

            End Try
        Next
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles fcp2.Click
        Try
            CoreBox2.Text = "Select Cores to Use - Warming Up"
            Me.Enabled = False
            MCBW.RunWorkerAsync()
        Catch ex As Exception

        End Try

    End Sub



    Private Sub MCBW_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles MCBW.DoWork
        Dim total As Integer
        total = 0
        MCBW.ReportProgress(1, "Select Cores to Use - Configuring")
        'Thread.Sleep(15)
        For Each item In cs.CheckedItems
            Try
                total = (2 ^ item.ToString) + total
                MCBW.ReportProgress(2, "Select Cores to Use - Calculating")
                'Thread.Sleep(15)
            Catch ex As Exception

            End Try
        Next

        For Each item In pclist.CheckedItems
            For Each proc In Process.GetProcesses
                Try
                    If proc.ToString.Contains(item) Then
                        proc.ProcessorAffinity = New IntPtr(total)
                        MCBW.ReportProgress(3, "Select Cores to Use - Applying changes")
                        'Thread.Sleep(15)
                    End If
                Catch ex As Exception
                    ferror = True
                End Try

            Next
        Next
    End Sub

    Private Sub MCBW_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles MCBW.ProgressChanged
        CoreBox2.Text = DirectCast(e.UserState, String)
    End Sub

    Private Sub MCBW_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles MCBW.RunWorkerCompleted
        If ferror = False Then
            CoreBox2.Text = "Select Cores to Use - Done"
            Me.Enabled = True
        Else
            CoreBox2.Text = "Select Cores to Use - Access Denied/Error"
            Me.Enabled = True
            ferror = False
        End If

    End Sub

    Private Sub ReportLbl_TextChanged(sender As Object, e As EventArgs) Handles ReportLbl.TextChanged
        If ReportLbl.Text.Contains("Done") Then
            Me.Enabled = True
        End If
    End Sub
End Class
