using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Mungojerrie
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            Bob bob = new Bob();
            bob.Name = "ITS YA BOI SKINNY WIENER";
            this.T1.Text = bob.Name;

            Bob bob2 = new Bob();
            bob2.Name = "BANANA!!!!";
            this.C1.Content = bob2.Name;

            // mainpage here  

        }
    }

    public class Bob
    {
        private String _name;
        public Bob()
        {
            
        }

        public String Name { get; set; }

        
    }
}
