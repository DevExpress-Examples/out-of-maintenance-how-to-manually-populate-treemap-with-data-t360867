using System;
using System.Windows.Forms;
using DevExpress.XtraTreeMap;

namespace ItemStorageSample {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e) {
            ConfigureTreeMapDataAdapter();
            ConfigureTreeMapColorizer();
        }

        #region #ItemStorage
        void ConfigureTreeMapDataAdapter() {
            TreeMapItemStorage storage = new TreeMapItemStorage();
            treeMap.DataAdapter = storage;

            TreeMapItem americasGroup = new TreeMapItem { Label = "Americas" };
            americasGroup.Children.Add(new TreeMapItem { Label = "United States", Value = 17.968 });
            americasGroup.Children.Add(new TreeMapItem { Label = "Brazil", Value = 1.8 });
            americasGroup.Children.Add(new TreeMapItem { Label = "Canada", Value = 1.573 });
            storage.Items.Add(americasGroup);

            TreeMapItem europeGroup = new TreeMapItem { Label = "Europe" };
            europeGroup.Children.Add(new TreeMapItem { Label = "Germany", Value = 3.371 });
            europeGroup.Children.Add(new TreeMapItem { Label = "United Kingdom", Value = 2.865 });
            europeGroup.Children.Add(new TreeMapItem { Label = "France", Value = 2.423 });
            europeGroup.Children.Add(new TreeMapItem { Label = "Italy", Value = 1.819 });
            storage.Items.Add(europeGroup);

            TreeMapItem asiaGroup = new TreeMapItem { Label = "Asia" };
            asiaGroup.Children.Add(new TreeMapItem { Label = "China", Value = 11.385 });
            asiaGroup.Children.Add(new TreeMapItem { Label = "Japan", Value = 4.116 });
            asiaGroup.Children.Add(new TreeMapItem { Label = "India", Value = 2.183 });
            storage.Items.Add(asiaGroup);
        }
        #endregion #ItemStorage

        #region #PaletteColorizer
        void ConfigureTreeMapColorizer() {
            treeMap.Colorizer = new TreeMapPaletteColorizer {
                ColorizeGroups = true,
                Palette = Palette.Office2016Palette
            };
        }
        #endregion #PaletteColorizer
    }
}
