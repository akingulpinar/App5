using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App5
{
    class Page1:TabbedPage
    {
        public Page1()
        {
            Children.Add(new Page3());
            Children.Add(new Page4());
            Children.Add(new Page5());
        }
    }
}
