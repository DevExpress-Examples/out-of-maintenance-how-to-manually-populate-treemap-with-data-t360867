Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraTreeMap

Namespace ItemStorageSample
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub


        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            ConfigureTreeMapDataAdapter()
            ConfigureTreeMapColorizer()
        End Sub

        #Region "#ItemStorage"
        Private Sub ConfigureTreeMapDataAdapter()
            Dim storage As New TreeMapItemStorage()
            treeMap.DataAdapter = storage

            Dim americasGroup As TreeMapItem = New TreeMapItem With {.Label = "Americas"}
            americasGroup.Children.Add(New TreeMapItem With {.Label = "United States", .Value = 17.968})
            americasGroup.Children.Add(New TreeMapItem With {.Label = "Brazil", .Value = 1.8})
            americasGroup.Children.Add(New TreeMapItem With {.Label = "Canada", .Value = 1.573})
            storage.Items.Add(americasGroup)

            Dim europeGroup As TreeMapItem = New TreeMapItem With {.Label = "Europe"}
            europeGroup.Children.Add(New TreeMapItem With {.Label = "Germany", .Value = 3.371})
            europeGroup.Children.Add(New TreeMapItem With {.Label = "United Kingdom", .Value = 2.865})
            europeGroup.Children.Add(New TreeMapItem With {.Label = "France", .Value = 2.423})
            europeGroup.Children.Add(New TreeMapItem With {.Label = "Italy", .Value = 1.819})
            storage.Items.Add(europeGroup)

            Dim asiaGroup As TreeMapItem = New TreeMapItem With {.Label = "Asia"}
            asiaGroup.Children.Add(New TreeMapItem With {.Label = "China", .Value = 11.385})
            asiaGroup.Children.Add(New TreeMapItem With {.Label = "Japan", .Value = 4.116})
            asiaGroup.Children.Add(New TreeMapItem With {.Label = "India", .Value = 2.183})
            storage.Items.Add(asiaGroup)
        End Sub
        #End Region ' #ItemStorage

        #Region "#PaletteColorizer"
        Private Sub ConfigureTreeMapColorizer()
            treeMap.Colorizer = New TreeMapPaletteColorizer With {.ColorizeGroups = True, .Palette = Palette.Office2016Palette}
        End Sub
        #End Region ' #PaletteColorizer
    End Class
End Namespace
