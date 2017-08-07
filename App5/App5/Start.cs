using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App5
{
    class Start:MasterDetailPage
    {
        public Start()
        { 
            Detail = new Page1();
            Master = new Page2();
        }
    }
}
