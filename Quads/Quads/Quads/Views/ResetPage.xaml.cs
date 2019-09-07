using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Quads.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ResetPage : ContentPage
    {
        public ResetPage()
        {
            InitializeComponent();
        }

        private async void BtnReset_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}