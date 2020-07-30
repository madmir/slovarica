using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XFApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Counter : ContentPage
    {
        public Counter()
        {
            InitializeComponent();
            number.Text = "0";
            stepper.Value = 0;
        }

        void OnStepperValueChanged(object sender, ValueChangedEventArgs e)
        {
            number.Text = string.Format("{0}", stepper.Value);
        }

        private void OnResetClicked(object sender, EventArgs e)
        {
            number.Text = "0";
            stepper.Value = 0;
        }
    }
}