using System.Windows.Controls;
using System.Collections.ObjectModel;

namespace AgDataGrid_GroupRowTemplate {
    public partial class MainPage : UserControl {
        ObservableCollection<Product> ds = new ObservableCollection<Product>();

        public MainPage() {
            InitializeComponent();

            ds.Add(new Product() {
                CompanyName = "Island Trading",
                Quantity = 10,
                UnitPrice = 19
            });
            ds.Add(new Product() {
                CompanyName = "Island Trading",
                Quantity = 18,
                UnitPrice = 22.4
            });
            ds.Add(new Product() {
                CompanyName = "Island Trading",
                Quantity = 7,
                UnitPrice = 12
            });
            ds.Add(new Product() {
                CompanyName = "Rancho grande",
                Quantity = 2,
                UnitPrice = 263.5
            });
            ds.Add(new Product() {
                CompanyName = "Rancho grande",
                Quantity = 12,
                UnitPrice = 81
            });

            grid.DataSource = ds;
        }
    }
    public class Product {
        public string CompanyName { get; set; }
        public double UnitPrice { get; set; }
        public int Quantity { get; set; }
    }
}
