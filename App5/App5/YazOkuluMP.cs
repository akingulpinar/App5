using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App5
{
    class YazOkuluMP : TabbedPage
    {
        public YazOkuluMP()
        {
            Children.Add(new YazOkuluCP1());
            Children.Add(new YazOkuluCP2());
        }
    }
}