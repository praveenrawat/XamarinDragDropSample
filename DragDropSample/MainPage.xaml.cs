using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DragDropSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void DragGestureRecognizer_DragStarting(System.Object sender, Xamarin.Forms.DragStartingEventArgs e)
        {
            //write your code
        }

        

        void DropGestureRecognizer_DragOver(System.Object sender, Xamarin.Forms.DragEventArgs e)
        {
            var txt = e.Data?.Text;
            var frame = (sender as Element)?.Parent as Frame;

            frame.Content = new Label { Text = txt };
        }
    }
}
