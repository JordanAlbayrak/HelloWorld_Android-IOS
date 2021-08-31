using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HelloWorld_Android_IOS
{
    public partial class MainPage : ContentPage
    {
        private int count=0;
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnIncrease_Clicked(object sender, EventArgs e)
        {
            count++;
            lblValue.Text = count.ToString();
        }

        private void btnDecrease_Clicked(object sender, EventArgs e)
        {
            count--;
            lblValue.Text = count.ToString();
        }

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            display.Text = string.Format("{0}'s Counter", e.NewTextValue);
        }
    }
}
