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
    public partial class YazOkuluCP2 : ContentPage
    {
        protected override bool OnBackButtonPressed()
        {           
            return base.OnBackButtonPressed();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
        }
        public YazOkuluCP2()
        {
            InitializeComponent();

            BoxView view1 = new BoxView
            {
                BackgroundColor = Color.Red
            };
            BoxView view2 = new BoxView
            {
                BackgroundColor = Color.Blue
            };

            //RelativeLayout layout = new RelativeLayout();

            //layout.Children.Add(view1,Constraint.Constant(50),Constraint.Constant(100), 
            //    Constraint.Constant(250),Constraint.Constant(250));

            //layout.Children.Add(view2, Constraint.Constant(50), Constraint.Constant(100), 
            //    Constraint.Constant(250), Constraint.Constant(250));

            //RelativeLayout layout = new RelativeLayout();

            //layout.Children.Add(view1, Constraint.Constant(50), Constraint.Constant(1000), Constraint.RelativeToParent(x =>
            // {
            //     return x.Width / 3;
            // }), Constraint.RelativeToParent(x =>
            // {
            //     return x.Height / 3;
            // }));

            //layout.Children.Add(view2, Constraint.RelativeToView(view1, (parent, sibling) =>
            //{
            //    return sibling.X + 20;
            //}), Constraint.RelativeToView(view1, (parent, sibling) =>
            //  {
            //      return sibling.Y + 20;
            //  }), Constraint.RelativeToView(view1, (parent, sibling) =>
            //    {
            //        return sibling.Width + 20;
            //    }), Constraint.RelativeToView(view1, (parent, sibling) =>
            //    {
            //        return sibling.Height + 20;
            //    }));
            AbsoluteLayout layout = new AbsoluteLayout();
            layout.Children.Add(view1, new Point(50, 100));
            layout.Children.Add(view2, new Rectangle(new Point(70,120),new Size(150,150)));
            layout.Children.Add(btn, new Rectangle(new Point(70, 120), new Size(150, 150)));
            Content = layout;
        }
        void btn_clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new YazOkuluCP1());
        }
    }
}