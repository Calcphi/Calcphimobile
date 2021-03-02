using CalcphiMobile.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace CalcphiMobile.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}