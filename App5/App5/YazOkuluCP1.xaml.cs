using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App5
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class YazOkuluCP1 : ContentPage
    {
        public YazOkuluCP1()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new YazOkuluCP2());
        }
    }
}