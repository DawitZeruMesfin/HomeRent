using HomeRent.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace HomeRent.Views
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