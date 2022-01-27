using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Tarea1_1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async private void btnSuma_Clicked(object sender, EventArgs e)
        {
            //Hacemos la operacion y mandamos el resultado

            int num1 = Convert.ToInt32(n1.Text);
            int num2 = Convert.ToInt32(n2.Text);
            int suma = num1 + num2;
            string totalsuma = suma.ToString();

            //Aqui envio parametros
             await Navigation.PushAsync(new PageMain(totalsuma));
        }

        async private void btnResta_Clicked(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(n1.Text);
            int num2 = Convert.ToInt32(n2.Text);
            int resta = num1 - num2;
            string totalresta = resta.ToString();
            await Navigation.PushAsync(new PageMain(totalresta));
        }
             async private void btnDivision_Clicked(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(n1.Text);
            int num2 = Convert.ToInt32(n2.Text);
            float div = num1 / num2;
            string totaldiv = div.ToString();

            await Navigation.PushAsync(new PageMain(totaldiv));
        }
        async private void btnMultiplicacion_Clicked(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(n1.Text);
            int num2 = Convert.ToInt32(n2.Text);
            int multi = num1 * num2;
            string totalmulti = multi.ToString();

            await Navigation.PushAsync(new PageMain(totalmulti));
        }


    }
}
