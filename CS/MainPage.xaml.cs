using System.Windows;
using System.Windows.Controls;
using DevExpress.Xpf.Charts;

namespace CheckBoxesInLegendExample {
    public partial class MainPage : UserControl {
        public MainPage() {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            foreach (Series s in xyDiagram2D.Series)
                s.Visible = true;
        }
    }
}
