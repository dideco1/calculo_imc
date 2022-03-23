using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace app_IMC
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            // Convertendo o texto inserido no entry para double 

            double peso = Convert.ToDouble(peso_valor.Text);
            double altura = Convert.ToDouble(altura_valor.Text);
            double IMC = peso/(altura*altura);

            // Definindo em qual parte do IMC o usuário se encaixa

            if (IMC < 18.5)
            {
                DisplayAlert("Resultado", "Abaixo do peso, IMC:  " + Convert.ToString(IMC), "Ok");
            }
            else if (IMC >= 18.5 && IMC < 24.9)
            {
                DisplayAlert("Resultado", "Peso normal, IMC:  " + Convert.ToString(IMC), "Ok");
            }
            else if (IMC >= 25 && IMC < 29.9)
            {
                DisplayAlert("Resultado", "Sobrepeso, IMC:  " + Convert.ToString(IMC), "Ok");
            }
            else if (IMC >= 30 && IMC < 34.9)
            {
                DisplayAlert("Resultado", "Obesidade grau I, IMC:  " + Convert.ToString(IMC), "Ok");
            }
            else if (IMC >= 35 && IMC < 39.9)
            {
                DisplayAlert("Resultado", "Obesidade grau II, IMC:  " + Convert.ToString(IMC), "Ok");
            }
            else
            {
                DisplayAlert("Resultado", "Obesidade grau III ou mórbida, IMC:  " + Convert.ToString(IMC), "Ok");
            }

        }
    }
}
