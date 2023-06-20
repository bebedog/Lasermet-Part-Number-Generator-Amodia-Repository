Public Class RequestForMoreInfoOrDeny
    Dim mondayID As String
    Dim part_no As String
    Dim dwg_no As String
    Dim description As String
    Dim specs As String
    Dim category As String
    Dim subcategory As String
    Dim group_name As String
    Dim revenueCC As String
    Dim issuesCC As String
    Dim requestID As String
    Dim requester As String
    Dim _partlocation As String
    Dim _warehouse As String
    Dim supplier As String
    Dim mpn As String
    Dim srn As String

    Public Sub getRequestInfo(monday_id As String, partNo As String, dwg_num As String, partDescription As String, partSpecs As String, partCategory As String, partSubcat As String, partGroup As String, revCC As String, issCC As String, request_id As String, partRequester As String, warehouse As String, partlocation As String, partsupplier As String, partmpn As String, partsrn As String)
        mondayID = monday_id
        part_no = partNo
        dwg_no = dwg_num
        description = partDescription
        specs = partSpecs
        category = partCategory
        subcategory = partSubcat
        group_name = partGroup
        revenueCC = revCC
        issuesCC = issCC
        requestID = request_id
        requester = partRequester
        _partlocation = partlocation
        _warehouse = warehouse
        supplier = partsupplier
        mpn = partmpn
        srn = partsrn
    End Sub



    Private Async Sub sendComment()
        ToolStripStatusLabel1.Text = "Updating request on Monday"
        Dim updateStatus As String() = Await updateStatusOnMonday(mondayID, "Needs additional information", part_no, dwg_no, description, specs, category, subcategory, group_name, revenueCC, issuesCC, _partlocation, _warehouse, tbRequestDetails.Text, ToolStripStatusLabel1,,, supplier, mpn, srn)


        If updateStatus(0) = "success" Then
            MessageBox.Show("Update successfully sent to Monday", ":)", MessageBoxButtons.OK, MessageBoxIcon.Information)
            If DialogResult.OK Then
                SearchDB.populateApprovalDGV()
                Me.Close()
                SearchDB.Show()
            End If
        End If

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        disableAllControls(Me)

        If btnUpdate.Text = "Deny" Then
            SearchDB.denyPart(part_no, requestID, requester, mondayID, dwg_no, description, specs, category, subcategory, group_name, revenueCC, issuesCC, _partlocation, _warehouse, supplier, mpn, srn, tbRequestDetails.Text, Me, ToolStripStatusLabel1)
        Else
            sendComment()
        End If


    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        SearchDB.dgvSearchResults.Columns.Clear()
        SearchDB.resultsTable.Columns.Clear()
        SearchDB.resultsTable.Clear()
        SearchDB.populateApprovalDGV()
        Me.Close()
        SearchDB.Show()
    End Sub
End Class