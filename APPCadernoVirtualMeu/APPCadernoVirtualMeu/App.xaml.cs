using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace APPCadernoVirtualMeu
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

           /** vai receber um navigationpage e o mainpage vai ser
            a pagina inicial*/
            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
