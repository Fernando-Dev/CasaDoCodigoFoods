using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace CasaDoCodigoFoods
{
    public class GarconsListPage : ContentPage
    {
        public GarconsListPage()
        {
           Content = GetGarcons();
        }
        private ListView GetGarcons()
        {
            var garcons = new ListView();
            garcons.ItemsSource = new string[]
            {
                "Fernando","Nascimento","Antonio","Pedro"
            };
            return garcons;
        }
    }
}