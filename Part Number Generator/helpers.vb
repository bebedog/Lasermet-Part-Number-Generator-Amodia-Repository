Module helpers

    Public Sub disableAllControls(form As Form)

        For Each c As Control In form.Controls
            c.Enabled = False
        Next

    End Sub

    Public Sub enableAllControls(form As Form)

        For Each c As Control In form.Controls
            c.Enabled = True
        Next

    End Sub

End Module
