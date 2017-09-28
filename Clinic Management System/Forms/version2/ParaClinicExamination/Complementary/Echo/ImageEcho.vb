Imports System.Drawing.Drawing2D

Public Class ImageEcho
    Dim DA_Img As New DSEchoTableAdapters.tblechoImageTableAdapter

    Dim cropX As Integer
    Dim cropY As Integer
    Dim cropWidth As Integer
    Dim cropHeight As Integer

    Dim oCropX As Integer
    Dim oCropY As Integer
    Dim cropBitmap As Bitmap

    Public cropPen As Pen
    Public cropPenSize As Integer = 1 '2
    Public cropDashStyle As Drawing2D.DashStyle = Drawing2D.DashStyle.Solid
    Public cropPenColor As Color = Color.Yellow
    Dim FResultEcho As FormResultEcho
    Sub New(ByVal FResultEcho As FormResultEcho)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.FResultEcho = FResultEcho
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub BtnOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOpen.Click
        Dim openDlg As New System.Windows.Forms.OpenFileDialog
        openDlg.Filter = "JPEG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|Bitmap Files (*.bmp)|*.bmp"
        If openDlg.ShowDialog() = Windows.Forms.DialogResult.Cancel Then
            Exit Sub
        End If
        If Not openDlg.FileName Is Nothing Then
            PicPreview.Image = System.Drawing.Bitmap.FromFile(openDlg.FileName)
            PicCropping.Image = System.Drawing.Bitmap.FromFile(openDlg.FileName)
        End If
    End Sub

    Private Sub PicCropping_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PicCropping.MouseDown
        Try

            If e.Button = Windows.Forms.MouseButtons.Left Then

                cropX = e.X
                cropY = e.Y

                cropPen = New Pen(cropPenColor, cropPenSize)
                cropPen.DashStyle = DashStyle.DashDotDot
                Cursor = Cursors.Cross

            End If
            PicCropping.Refresh()
        Catch exc As Exception
        End Try
    End Sub

    Private Sub PicCropping_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PicCropping.MouseMove
        Try

            If PicCropping.Image Is Nothing Then Exit Sub

            If e.Button = Windows.Forms.MouseButtons.Left Then

                PicCropping.Refresh()
                cropWidth = e.X - cropX
                cropHeight = e.Y - cropY
                PicCropping.CreateGraphics.DrawRectangle(cropPen, cropX, cropY, cropWidth, cropHeight)
            End If
            ' GC.Collect()

        Catch exc As Exception

            If Err.Number = 5 Then Exit Sub
        End Try
    End Sub

    Private Sub PicCropping_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PicCropping.MouseUp
        Try
            Cursor = Cursors.Default
            Try

                If cropWidth < 1 Then
                    Exit Sub
                End If

                Dim rect As Rectangle = New Rectangle(cropX, cropY, cropWidth, cropHeight)
                Dim bit As Bitmap = New Bitmap(PicCropping.Image, PicCropping.Width, PicCropping.Height)

                cropBitmap = New Bitmap(cropWidth, cropHeight)
                Dim g As Graphics = Graphics.FromImage(cropBitmap)
                g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
                g.PixelOffsetMode = Drawing2D.PixelOffsetMode.HighQuality
                g.CompositingQuality = Drawing2D.CompositingQuality.HighQuality
                g.DrawImage(bit, 0, 0, rect, GraphicsUnit.Pixel)
                PicPreview.Image = cropBitmap

            Catch exc As Exception
            End Try
        Catch exc As Exception
        End Try
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Close()
    End Sub

    Private Sub BtnClean_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClean.Click
        CleanImage()
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If PicPreview.Image Is Nothing Then
            MessageBox.Show("Please select image in preview", "Echo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            If MessageBox.Show("Do you want to save image result of echo?", "Echo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If DA_Img.InsertNewImage(LblRequesID.Text, ImageToByArray(PicPreview.Image)) = 1 Then
                    MessageBox.Show("Save image successfully", "Echo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.FResultEcho.RefreshImage(LblRequesID.Text)
                    CleanImage()
                End If
            End If
        End If
    End Sub
    Sub CleanImage()
        PicCropping.Image = Nothing
        cropBitmap = Nothing
        PicPreview.Image = Nothing
    End Sub
End Class