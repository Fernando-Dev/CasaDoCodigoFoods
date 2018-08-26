using Xamarin.Forms;

namespace CasaDoCodigoFoods.Pages.Garcons
{
    internal class GarconsPages : TabbedPage
    {
        public GarconsPages()
        {
            Children.Add(new GarconsListPage()
            {
                Title = "Listagem",
                Icon = "icone_list.png"
            });
            Children.Add(new GarconsNewPage()
            {
                Title = "Inserir Novo",
                Icon = "icone_new.png"
            });
        }
    }

    
}