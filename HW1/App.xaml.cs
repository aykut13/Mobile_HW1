using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace HW1
{
    public partial class App : Application
    {
        public App()
        {
            

            MainPage = new MainPage();
       
        }
    }
}
