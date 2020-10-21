using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Elemendid_App
{
    public partial class MainPage : ContentPage
    {
        Button[] btns = new Button[3];
        String[] btn_Text = new String[] {"Table Page", "Web Page", "ListView Page" };
        StackLayout st;
        public MainPage()
        {
            st = new StackLayout();
            for (int i = 0; i < 3; i++)
            {
                btns[i] = new Button { Text = btn_Text[i] };
                st.Children.Add(btns[i]);
                btns[i].Clicked += Btn_Clicked;
            }           
            Content = st;

            //Button Tbl_btn = new Button { Text = "Table Page" };
            //Button Web_btn = new Button { Text = "Web Page" };
            //Button List_btn = new Button { Text = "ListView Page" };
            //st.Children.Add(Tbl_btn);
            //st.Children.Add(Web_btn);
            //st.Children.Add(List_btn);
            //Tbl_btn.Clicked += new EventHandler(Btn_Clicked);4
            //Web_btn.Clicked += new EventHandler(Btn_Clicked);4
            //List_btn.Clicked += new EventHandler(Btn_Clicked);4
            //Tbl_btn.Clicked += Tbl_btn_Clicked;3
            //Content = st;
            
        }

        private async void Btn_Clicked(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            switch (btn.Text) // I want to get the name of the control 
            {
                case "Table Page":
                    await Navigation.PushAsync(new Table_Page());
                    break;
                case "Web Page":
                    await Navigation.PushAsync(new Web_Page());
                    break;
                case "ListView Page":
                    await Navigation.PushAsync(new List_Page());
                    break;
            }
        }

        /*private async void Tbl_btn_Clicked(object sender, EventArgs e)3
        {
            await Navigation.PushAsync(new Table_Page());
        }*/

    }
}
