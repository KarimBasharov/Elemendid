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
    public partial class Uncharted1 : ContentPage
    {
        Button btn;
        public Uncharted1()
        {
            StackLayout st = new StackLayout();
            Button tagasi_btn = new Button { Text = "Главная страница" };
            tagasi_btn.HorizontalOptions = LayoutOptions.StartAndExpand;
            tagasi_btn.VerticalOptions = LayoutOptions.EndAndExpand;
            tagasi_btn.Clicked += Tagasi_btn_Clicked;
            //btn.Text = "Щпа";
            //btn.Clicked += Btn_Clicked;
            //st.Children.Add(btn);
            st.Children.Add(tagasi_btn);
            Content = st;

        }
        private async void Tagasi_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}