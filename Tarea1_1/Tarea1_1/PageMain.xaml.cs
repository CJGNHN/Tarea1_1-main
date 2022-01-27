using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tarea1_1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageMain : ContentPage
    {
        //Aqui recibo datos
        public PageMain(String total)
        {
            InitializeComponent();

            //Aqui concatenamos el texto de nuestro label con el valor del resultado
            lbltotal.Text = "El resultado es: " + total.ToString() ;

        }
    }
}