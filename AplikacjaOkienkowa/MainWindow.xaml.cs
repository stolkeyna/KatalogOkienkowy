using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace AplikacjaOkienkowa
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //stwórz listę kilku produktów
            List<Product> products = new List<Product>
            {
                new Product("Mleko", 2.50, "Nabiał", 5, 0),
                new Product("Yogurt", 10.00, "Nabiał", 5, 0),
                new Product("Chleb", 1.00, "Pieczywo", 2, 0),
                new Product("Herbata", 4.50, "Napoje", 10, 0),
                new Product("Sok", 6.00, "Napoje", 3, 0),
                new Product("Chipsy", 7.50, "Przekąski", 10, 1),
                new Product("Czekolada", 12.50, "Słodycze", 5, 1)
            };

            EtykietaLiczbaProduktow.Text = $"Liczba produktów: {products.Count}";
            EtykietaWartoscMagazynu.Text = $"Wartosc magazynu: {Product.ObliczWartoscMagazynu(products):C}";

            TextBlock dopisek = new TextBlock();
            dopisek.Text = "To zostało dodane bezpośrednie w kodzie C#";
            dopisek.FontSize = 12;
            GlownyPanel.Children.Add(dopisek);
        }
    }
}