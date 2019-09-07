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
    public partial class BMIPage : ContentPage
    {
        public BMIPage()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Clicked(object sender, EventArgs e)
        {
            double weight = Double.Parse(EntWeight.Text);
            double height = Double.Parse(EntHeight.Text);
            double bmi = Convert.ToInt32(weight / Math.Pow(height, 2));
            if (bmi >= 25)
            {
                LabBMI.Text = bmi.ToString();
                LabResult.Text = "Overweight";
                //LabResult = new Label { Text = "Overweight", TextColor = Color.Red };
                LabInfo.Text = "You have a higher than normal body weight. Try to exercise more.";
            }
            else if (bmi > 18.5)
            {
                LabBMI.Text = bmi.ToString();
                LabResult.Text = "Normal";
                //LabResult = new Label { Text = "Normal", TextColor = Color.Green };
                LabInfo.Text = "You have a normal body weight. Good job!";
            }
            else
            {
                LabBMI.Text = bmi.ToString();
                LabResult.Text = "Underweight";
                //LabResult = new Label { Text = "Underweight", TextColor = Color.Yellow };
                LabInfo.Text = "You have a lower than normal body weight. You can eat a bit more.";
            }
        }
    }
}