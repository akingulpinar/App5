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
	public partial class Page3 : ContentPage
	{
		public Page3 ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Login());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Register());
        }
    }
}