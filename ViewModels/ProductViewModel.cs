using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using MvvmHelpers;

namespace WSR3.ViewModels
{
    public class ProductViewModel : BaseViewModel
    {
        private Product product;
        public Product Product { get => product; }
        private Color backgroundColor;
        public SolidColorBrush BackgroundColor { get => new SolidColorBrush(backgroundColor); }
        public ProductViewModel(Product product) : base() {
            this.product = product;
            SetProperty(ref backgroundColor, product.ProductQuantityInStock > 0 ? Color.FromRgb(118, 227, 131) : Color.FromRgb(180, 180, 180));
            
        }
    }
}
