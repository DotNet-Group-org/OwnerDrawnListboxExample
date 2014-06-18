Public Class Form1

    Dim heightOffset As Integer

    Private Sub lbStates_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles lbStates.DrawItem
        ' Draw the background of the ListBox control for each item.
        e.DrawBackground()

        Dim stateInfo As classStateInfo
        Dim foreBrush As New SolidBrush(e.ForeColor)

        stateInfo = lbStates.Items(e.Index)

        ' Draw the current item text based on the current Font and the custom brush settings.
        If radioOwnerName.Checked Then
            e.Graphics.DrawString(stateInfo.stateName, e.Font, foreBrush, _
                                  New RectangleF(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height))
        Else  ' either radioOwnerNameFlag or radioOwnerNameFlagSeal is checked
            Dim destRect As Rectangle
            Dim srcRect As Rectangle
            Dim ratio As Double
            Dim newHeight As Integer
            Dim newWidth As Integer
            Dim newFont As Font

            newFont = New Font(e.Font.FontFamily, e.Font.Size * 2, FontStyle.Bold, e.Font.Unit)

            srcRect = New Rectangle(0, 0, stateInfo.stateFlag.Width, stateInfo.stateFlag.Height)
            ratio = stateInfo.stateFlag.Width / stateInfo.stateFlag.Height

            newHeight = e.Bounds.Height - 50
            newWidth = newHeight * ratio
            destRect = New Rectangle(e.Bounds.X + 10, e.Bounds.Y + 40, newWidth, newHeight)

            e.Graphics.DrawString(stateInfo.stateName, newFont, foreBrush, e.Bounds.X + 5, e.Bounds.Y + 5)
            e.Graphics.DrawImage(stateInfo.stateFlag, destRect, srcRect, System.Drawing.GraphicsUnit.Pixel)

            If radioOwnerNameFlagSeal.Checked Then
                srcRect = New Rectangle(0, 0, stateInfo.stateSeal.Width, stateInfo.stateSeal.Height)
                ratio = stateInfo.stateSeal.Width / stateInfo.stateSeal.Height

                newWidth = newHeight * ratio
                destRect = New Rectangle((e.Bounds.Width - newWidth) - 10, e.Bounds.Y + 40, newWidth, newHeight)
                e.Graphics.DrawImage(stateInfo.stateSeal, destRect, srcRect, System.Drawing.GraphicsUnit.Pixel)
            End If

            newFont.Dispose()
        End If

        ' If the ListBox has focus, draw a focus rectangle around the selected item.
        e.DrawFocusRectangle()

        foreBrush.Dispose()
    End Sub

    Private Sub lbStates_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbStates.SelectedIndexChanged
        ' pgStates.SelectedObject = lbStates.SelectedItem
        Dim stateInfo As classStateInfo

        stateInfo = lbStates.SelectedItem
        PictureBox1.Image = stateInfo.stateFlag
        PictureBox2.Image = stateInfo.stateSeal
    End Sub

    Private Sub mnuFileOpen_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuFileOpen.Click
        Dim openFileDialog1 As New OpenFileDialog()

        openFileDialog1.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
        openFileDialog1.Filter = "xml files (*.xml)|*.xml|txt files (*.txt)|*.txt|All files (*.*)|*.*"
        openFileDialog1.FilterIndex = 1
        openFileDialog1.RestoreDirectory = True
        openFileDialog1.CheckFileExists = True
        openFileDialog1.CheckPathExists = True

        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            LoadStateInfo(openFileDialog1.FileName)
        End If
    End Sub

    Private Sub mnuFileExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileExit.Click
        End
    End Sub

    Private Sub LoadStateInfo(ByVal filename As String)
        If IO.File.Exists(filename) Then
            Try
                Dim dirPath As String
                Dim doc As New Xml.XmlDocument
                Dim states As Xml.XmlNodeList
                Dim info As classStateInfo
                Dim sName As String
                Dim sAbbr As String
                Dim sBird As String
                Dim sTree As String
                Dim sFlower As String
                Dim sRegion As String
                Dim sFlag As String
                Dim sSeal As String

                doc.Load(filename)

                dirPath = IO.Path.GetDirectoryName(filename)

                If doc.HasChildNodes Then
                    lbStates.Items.Clear()

                    states = doc.SelectNodes("//states/state")
                    For Each state As Xml.XmlElement In states
                        sName = state.GetAttribute("stateName")
                        sAbbr = state.GetAttribute("stateAbbr")
                        sBird = state.GetAttribute("bird")
                        sTree = state.GetAttribute("tree")
                        sFlower = state.GetAttribute("flower")
                        sRegion = state.GetAttribute("region")
                        sFlag = state.GetAttribute("imageFlag")
                        sSeal = state.GetAttribute("imageSeal")

                        info = New classStateInfo(sName, sAbbr, sBird, sTree, sFlower, sRegion)

                        sFlag = IO.Path.Combine(dirPath, sFlag)
                        If IO.File.Exists(sFlag) Then
                            info.stateFlag = New Bitmap(sFlag)
                        End If

                        sSeal = IO.Path.Combine(dirPath, sSeal)
                        If IO.File.Exists(sSeal) Then
                            info.stateSeal = New Bitmap(sSeal)
                        End If

                        lbStates.Items.Add(info)
                    Next

                    If lbStates.Items.Count > 0 Then
                        lbStates.Enabled = True
                    End If
                End If
            Catch ex As Exception
                MessageBox.Show("Error loading xml data from the specified file.")
            End Try
        End If
    End Sub

    Private Sub radioStandard_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles radioStandard.Click
        lbStates.ItemHeight = 13
        lbStates.DrawMode = DrawMode.Normal
        lbStates.Height = Me.ClientRectangle.Height - heightOffset
        lbStates.Refresh()
    End Sub

    Private Sub radioOwnerName_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles radioOwnerName.Click
        lbStates.ItemHeight = 13
        lbStates.DrawMode = DrawMode.OwnerDrawFixed
        lbStates.Height = Me.ClientRectangle.Height - heightOffset
        lbStates.Refresh()
    End Sub

    Private Sub radioOwnerNameFlag_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles radioOwnerNameFlag.Click
        lbStates.ItemHeight = 100
        lbStates.DrawMode = DrawMode.OwnerDrawFixed
        lbStates.Height = Me.ClientRectangle.Height - heightOffset
        lbStates.Refresh()
    End Sub

    Private Sub radioOwnerNameFlagSeal_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles radioOwnerNameFlagSeal.Click
        lbStates.ItemHeight = 100
        lbStates.DrawMode = DrawMode.OwnerDrawFixed
        lbStates.Height = Me.ClientRectangle.Height - heightOffset
        lbStates.Refresh()
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        heightOffset = Me.ClientRectangle.Height - lbStates.Height
    End Sub
End Class
