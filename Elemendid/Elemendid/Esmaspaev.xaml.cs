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
    public partial class Esmaspaev : ContentPage
    {
        public Esmaspaev()
        {
            /*Button Tbl_btn = new Button { Text = "Teisipäev" };
            StackLayout st = new StackLayout();
            st.Children.Add(Tbl_btn);
            Tbl_btn.Clicked += Tbl_btn_Clicked;

            Button Tbl_btn2 = new Button { Text = "Kolmapäev" };
            Tbl_btn2.Clicked += Tbl_btn2_Clicked;
            st.Children.Add(Tbl_btn2);

            Button tagasi_btn = new Button { Text = "Tagasi" };
            tagasi_btn.HorizontalOptions = LayoutOptions.StartAndExpand;
            tagasi_btn.VerticalOptions = LayoutOptions.End;
            tagasi_btn.Clicked += Tagasi_btn_Clicked;
            st.Children.Add(tagasi_btn);
            Content = st;*/
        }

        /*private async void Tagasi_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        private async void Tbl_btn2_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Kolmapaev());
        }

        private async void Tbl_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Teisipaev());
        }*/

    }
}