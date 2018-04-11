using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace example
{
	public partial class MainPage : ContentPage
	{
        public const string HEADER = "Xamarin";
        
        public static double staticVar = 20;
        public MainPage()
		{
			InitializeComponent();
		}
        public interface IMarkupExtension
        {
            object ProvideValue(IServiceProvider serviceProvider);
        }
        private void Button_Click (object sender, EventArgs e)
        {
            // Application.Current.MainPage.Navigation.PushAsync(new example.browser()); 
            this.Navigation.PushAsync(new browser());
        }
	}
}
