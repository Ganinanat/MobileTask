using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace Mobile_Task
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            int n = Convert.ToInt32(n.Text);
            int[] num = new int[n];
            int b = 0;

            int half = n / 2;
            n -= 1;

            for (int i = 0; i <= half; i++)
            {
                b = num[i];
                num[i] = num[n];
                num[n] = b;

                n--;
                if (num[n] == num[i])
                { break; }

            }
            for (int i = 0; i < a.Length; i++)
            {
                result.Text = (a[i])ToString();
            }
        
        }
        catch (Exception exc) { }


    } 
