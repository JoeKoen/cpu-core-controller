Public Class Form1

    Dim corecount As Integer

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

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sc As Integer
        sc = 2 ^ fss.Value

        If fss.Value = 0 Then
            For Each proc In Process.GetProcesses
                proc.ProcessorAffinity = New IntPtr(1)

                On Error Resume Next
            Next
        Else
            For Each proc In Process.GetProcesses
                proc.ProcessorAffinity = New IntPtr(sc)

                On Error Resume Next
            Next
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim cores As Integer
        Dim n As Integer
        cores = System.Environment.ProcessorCount.ToString
        n = 2 ^ cores - 1
        For Each proc In Process.GetProcesses
            proc.ProcessorAffinity = New IntPtr(n)

            On Error Resume Next
        Next

    End Sub

    Private Sub rfpl1_Click(sender As Object, e As EventArgs) Handles rfpl1.Click
        scpl.Items.Clear()
        For Each proc In Process.GetProcesses
            If Not scpl.Items.Contains(proc.ProcessName) Then
                scpl.Items.Add(proc.ProcessName)
            End If

            On Error Resume Next
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles rfspcl.Click
        pclist.Items.Clear()
        For Each proc In Process.GetProcesses
            If Not pclist.Items.Contains(proc.ProcessName) Then
                pclist.Items.Add(proc.ProcessName)
            End If

            On Error Resume Next
        Next
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles fcp2.Click
        Dim total As Integer
        total = 0

        For Each item In cs.CheckedItems
            total = (2 ^ item.ToString) + total
        Next

        For Each item In pclist.CheckedItems
            For Each proc In Process.GetProcesses
                If proc.ToString.Contains(item) Then
                    proc.ProcessorAffinity = New IntPtr(total)
                End If
                On Error Resume Next
            Next
            On Error Resume Next
        Next

    End Sub
End Class
