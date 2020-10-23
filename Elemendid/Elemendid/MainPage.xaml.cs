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
            Button Tbl_btn = new Button { Text = "Uncharted: Drake’s Fortune" };
            StackLayout st = new StackLayout();
            Image img = new Image();
            st.Children.Add(Tbl_btn);
            Tbl_btn.Clicked += Tbl_btn_Clicked;
            Button Tbl_btn1 = new Button { Text = "Uncharted 2: Among Thieves" };
            Tbl_btn1.Clicked += Tbl_btn_Clicked1;
            Button Tbl_btn2 = new Button { Text = "Uncharted 3: Drake’s Deception" };
            Tbl_btn2.Clicked += Tbl_btn_Clicked2;
            Button Tbl_btn3 = new Button { Text = "Uncharted: Golden Abyss" };
            Tbl_btn3.Clicked += Tbl_btn3_Clicked;
            Button Tbl_btn4 = new Button { Text = "Uncharted: Fight for Fortune" };
            Tbl_btn4.Clicked += Tbl_btn4_Clicked;
            Button Tbl_btn5 = new Button { Text = "Uncharted 4: A Thief’s End" };
            Tbl_btn5.Clicked += Tbl_btn5_Clicked;
            Button Tbl_btn6 = new Button { Text = "Uncharted: The Lost Legacy" };
            Tbl_btn6.Clicked += Tbl_btn6_Clicked;
            st.Children.Add(Tbl_btn1);
            st.Children.Add(Tbl_btn2);
            st.Children.Add(Tbl_btn3);
            st.Children.Add(Tbl_btn4);
            st.Children.Add(Tbl_btn5);
            st.Children.Add(Tbl_btn6);
            Content = st;
        }

        private async void Tbl_btn6_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Uncharted5());
        }

        private async void Tbl_btn5_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Uncharted4());
        }

        private async void Tbl_btn4_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new UnchartedCards());
        }

        private async void Tbl_btn3_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Uncharted11());
        }

        private async void Tbl_btn_Clicked2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Uncharted3());
        }

        private async void Tbl_btn_Clicked1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Uncharted2());
        }

        private async void Tbl_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Uncharted1());
        }
    }
}
