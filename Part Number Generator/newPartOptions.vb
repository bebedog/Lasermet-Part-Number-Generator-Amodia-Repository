'================================================================================
'FILE        : newPartOptions.vb
'AUTHORS     : Jayson O. Amodia, Elyn Abby Toledo, Kathryn Marie P. Sigaya
'DESCRIPTION : This file shows the processes and design menu of the Inventory Request Options menu of the Part Number Generator.
'COPYRIGHT   : 12 July 2023
'REVISION HISTORY
'Date: 			By: 		Description:
'2023/07/12     Sigaya      Documentation
'================================================================================

'================================================================================
'CLASS       : newPartOptions
'DESCRIPTION : Class that stores variables, functions, and other classes for the "Inventory Request Options" window processes
'================================================================================
Public Class newPartOptions

    '================================================================================
    'SUBROUTINE   : btnSingleRequest_Click
    'DESCRIPTION  : Shows the "Single Master List Request" menu after you click the "Single Part Request" option.
    'ARGUMENTS    : sender - Object
    '               e      - EventArgs
    '================================================================================
    Private Sub btnSingleRequest_Click(sender As Object, e As EventArgs) Handles btnSingleRequest.Click
        LasermetPNG.Show()
        Me.Close()
    End Sub

    '================================================================================
    'SUBROUTINE   : btnBack_Click
    'DESCRIPTION  : Shows the dashboard based on the user if the "Go Back to Dashboard" option is clicked. 
    'ARGUMENTS    : sender - Object
    '               e      - EventArgs
    '================================================================================
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Select Case login.account_type
            Case "App Admin"
                Me.Close()
                AppAdminDashboard.Show()

            Case "Inventory Admin"
                Me.Close()
                InventoryAdminDashboard.Show()

            Case "Dept. Manager"
                Me.Close()
                AppAdminDashboard.Show()

            Case "General User"
                Me.Close()
                GeneralUserDashboard.Show()

        End Select
    End Sub

    '================================================================================
    'SUBROUTINE   : btnBatchRequest_Click
    'DESCRIPTION  : Shows the "Batch Part Request" menu after user clicks the "Batch Request" option.
    'ARGUMENTS    : sender - Object
    '               e      - EventArgs
    '================================================================================
    Private Sub btnBatchRequest_Click(sender As Object, e As EventArgs) Handles btnBatchRequest.Click
        Me.Close()
        BatchPartRequest.Show()
    End Sub

    '================================================================================
    'SUBROUTINE   : newPartOptions_Load
    'DESCRIPTION  : Loads the menu for "Inventory Request Options".
    'ARGUMENTS    : sender - Object
    '               e      - EventArgs
    '================================================================================
    Private Sub newPartOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class