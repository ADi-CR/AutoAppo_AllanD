using Acr.UserDialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using AutoAppo_AllanD.ViewModels;

namespace AutoAppo_AllanD.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppoLoginPage : ContentPage
    {
        //se debe "anclar" el viewmodel correspondiente a la vista 

        UserViewModel viewModel;

        public AppoLoginPage()
        {
            InitializeComponent();

            this.BindingContext = viewModel = new UserViewModel();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            //LOGIN
            bool R = false;

            if (TxtEmail.Text != null && !string.IsNullOrEmpty(TxtEmail.Text.Trim()) &&
                TxtPassword.Text != null && !string.IsNullOrEmpty(TxtPassword.Text.Trim()))
            {
                //si hay datos en el usuario y contraseña se puede continuar 
                try
                {
                    UserDialogs.Instance.ShowLoading("Cheking User Access...");
                    await Task.Delay(2000);

                    string email = TxtEmail.Text.Trim();
                    string password = TxtPassword.Text.Trim();

                    R = await viewModel.UserAccessValidation(email, password);




                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    UserDialogs.Instance.HideLoading();
                }
            }
            else
            {
                await DisplayAlert("Validation Error", "User Email and Password are required!", "OK");
                return;
            }

            //TODO: en caso que R sea true, entonces cargamos un usuario global igual que en progra 5
            if (R)
            {
                await DisplayAlert("Validation OK", "Access Granted!!", "OK");
                return;
            }
            else
            {
                await DisplayAlert("Validation Failed", "Access Denied!!", "OK");
                return;
            }

        }

        private void BtnSignUp_Clicked(object sender, EventArgs e)
        {
            //REGISTRO DE NUEVO USUARIO


        }
    }
}