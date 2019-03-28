using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
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
using Newtonsoft.Json;

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
            Api_Handler api = new Api_Handler();
            api.data();
            // mainpage here  

        }

        private void checker(object sender, RoutedEventArgs e)
        {

        }

        private void unchecker(object sender, RoutedEventArgs e)
        {

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

    public class Api_Handler
    {
        public String url = "https://opentdb.com/api.php?amount=10&category=20&difficulty=easy&type=multiple";
        HttpClient client = new HttpClient();

        

        public Api_Handler()
        {

        }

        

        public async void data()
        {
            string response = await client.GetStringAsync(url);
            var data = JsonConvert.DeserializeObject<List<JSONResponse>>(response);
            foreach (JSONResponse q in data) {
                Console.Write(q.result);
            }


            
        }

    }

    public class JSONResponse
    {
        public int response_code { get; set; }
        public List<Results> result { get; set; }
    }

    public class Results
    {
        public String category { get; set; }
        public String type { get; set; }
        public String difficulty { get; set; }
        public String question { get; set; }
        public String correct_answer { get; set; }
        public WrongAnswer incorrect_answers { get; set; }
    }

    public class WrongAnswer
    {
        public String zero { get; set; }
        public String one { get; set; }
        public String two { get; set; }
    }


}
