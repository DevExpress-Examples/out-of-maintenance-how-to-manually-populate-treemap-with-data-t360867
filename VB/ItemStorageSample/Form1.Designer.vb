Namespace ItemStorageSample
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim treeMapPaletteColorizer1 As New DevExpress.XtraTreeMap.TreeMapPaletteColorizer()
            Me.treeMap = New DevExpress.XtraTreeMap.TreeMapControl()
            Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
            DirectCast(Me.treeMap, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' treeMap
            ' 
            Me.treeMap.BorderOptions.Color = System.Drawing.Color.FromArgb((CInt((CByte(50)))), (CInt((CByte(0)))), (CInt((CByte(0)))), (CInt((CByte(0)))))
            Me.treeMap.BorderOptions.Visible = False
            treeMapPaletteColorizer1.ColorizeGroups = True
            treeMapPaletteColorizer1.Palette = DevExpress.XtraTreeMap.Palette.Office2016Palette
            Me.treeMap.Colorizer = treeMapPaletteColorizer1
            Me.treeMap.Dock = System.Windows.Forms.DockStyle.Fill
            Me.treeMap.Location = New System.Drawing.Point(0, 0)
            Me.treeMap.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat
            Me.treeMap.Name = "treeMap"
            Me.treeMap.Size = New System.Drawing.Size(624, 321)
            Me.treeMap.TabIndex = 0
            ' 
            ' defaultLookAndFeel1
            ' 
            Me.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(624, 321)
            Me.Controls.Add(Me.treeMap)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.treeMap, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private treeMap As DevExpress.XtraTreeMap.TreeMapControl
        Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    End Class
End Namespace

