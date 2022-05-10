using APPCadernoVirtualMeu.Terceiro;
using APPCadernoVirtualMeu.Segundo;
using APPCadernoVirtualMeu.Primeiro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace APPCadernoVirtualMeu
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        /** esse método é para ter a troca de telas e ter a ação do clice */
        private void Button_Clicked(object sender, EventArgs e)
        {   
            Navigation.PushAsync(new GeralPrimeiro());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GeralSegundo());
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GeralTerceiro());
        }
    }
}
