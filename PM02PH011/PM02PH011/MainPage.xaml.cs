using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PM02PH011
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnAgregar_Clicked(object sender, EventArgs e)
        {
            var num1 = Convert.ToDecimal(txtnum1.Text);
            var num2 = Convert.ToDecimal(txtnum2.Text);

            await Navigation.PushAsync(new SecondPage(Convert.ToDecimal(num1 + num2)));

            //wait DisplayAlert("Suma", Convert.ToString(num1 + num2), "OK");
        }
    }
}
