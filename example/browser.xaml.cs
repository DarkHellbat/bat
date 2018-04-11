using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace example
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class browser : ContentPage
	{
		public browser ()
		{
			InitializeComponent ();
		}

        private void Button_Click(object sender, EventArgs e)
        {
            //var txt = new HtmlWebViewSource();
            //txt.Html = "<h1>Если вы видите это сообщение, значит создатель xamarin'a - косячник</h1>";
            //webView.Source = txt;
            // this.Navigation.PopAsync();
            webView.Source = new UrlWebViewSource { Url = urlEntry.Text };
        }
	}
}