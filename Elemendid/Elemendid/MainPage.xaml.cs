using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Elemendid
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            Button Tbl_btn = new Button { Text = "Esmaspäev" };
            StackLayout st = new StackLayout();
            st.Children.Add(Tbl_btn);
            Tbl_btn.Clicked += Tbl_btn_Clicked;
            Button Tbl_btn1 = new Button { Text = "Teisipäev" };
            Tbl_btn1.Clicked += Tbl_btn_Clicked1;
            Button Tbl_btn2 = new Button { Text = "Kolmapäev" };
            Tbl_btn2.Clicked += Tbl_btn_Clicked2;
            st.Children.Add(Tbl_btn1);
            st.Children.Add(Tbl_btn2);
            Content = st;
        }

        private async void Tbl_btn_Clicked2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Kolmapaev());
        }

        private async void Tbl_btn_Clicked1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Teisipaev());
        }

        private async void Tbl_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Esmaspaev());
        }
    }
}
