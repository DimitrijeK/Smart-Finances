using Smart_Finances.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Smart_Finances.Views
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