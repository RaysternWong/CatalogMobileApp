using CatalogMobileApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace CatalogMobileApp.Views
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