using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Elemendid
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Teisipaev : ContentPage
    {
        public Teisipaev()
        {
            Button Tbl_btn = new Button { Text = "Table Page" };
            StackLayout st = new StackLayout();
            st.Children.Add(Tbl_btn);
            Content = st;
            Tbl_btn.Clicked += Tbl_btn_Clicked;
            
        }
        private async void Tbl_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Kolmapaev());
        }
    }
}