using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PPTaxe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Champ
        private Calcule _calcule = new Calcule();

        #endregion

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAddition_Click(object sender, RoutedEventArgs e)
        {
            txtReponse.Clear();

            txtReponse.Text += _calcule.Addition2TextBox(txtNombre1.Text, txtNombre2.Text).ToString();
        }

        private void btnTaxe_Click(object sender, RoutedEventArgs e)
        {
            txtTPS.Clear();
            txtTVQ.Clear();

            txtTPS.Text += _calcule.CalculerTPS(txtMontant.Text).ToString();
            txtTVQ.Text += _calcule.CalculerTVQ(txtMontant.Text).ToString();
        }
    }
}
