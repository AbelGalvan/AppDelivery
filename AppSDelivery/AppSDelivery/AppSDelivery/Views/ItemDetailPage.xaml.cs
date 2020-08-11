using System.ComponentModel;
using Xamarin.Forms;
using AppSDelivery.ViewModels;

namespace AppSDelivery.Views
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