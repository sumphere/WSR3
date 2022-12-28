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
using System.Windows.Shapes;

namespace WSR3
{
    /// <summary>
    /// Логика взаимодействия для ProductListWindow.xaml
    /// </summary>
    public partial class ProductListWindow : Window
    {
        public ProductListWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            WSR3.WSR3DataSet wSR3DataSet = ((WSR3.WSR3DataSet)(this.FindResource("wSR3DataSet")));
            // Загрузить данные в таблицу Product. Можно изменить этот код как требуется.
            WSR3.WSR3DataSetTableAdapters.ProductTableAdapter wSR3DataSetProductTableAdapter = new WSR3.WSR3DataSetTableAdapters.ProductTableAdapter();
            wSR3DataSetProductTableAdapter.Fill(wSR3DataSet.Product);
            System.Windows.Data.CollectionViewSource productViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("productViewSource")));
            productViewSource.View.MoveCurrentToFirst();
        }
    }
}
