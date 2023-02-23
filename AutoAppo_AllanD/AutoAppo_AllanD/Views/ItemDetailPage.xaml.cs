using AutoAppo_AllanD.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace AutoAppo_AllanD.Views
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