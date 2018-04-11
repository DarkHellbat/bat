using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace example
{
    class StartPage1 :ContentPage
    {
        public StartPage1()
        {
            Label header = new Label() { Text = "Greetings" };
            this.Content = header;
        }
    }
}
