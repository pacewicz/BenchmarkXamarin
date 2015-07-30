using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

using Xamarin.Forms;

namespace BenchmarkXamarin.Sample
{
    public class App : Application
    {
        public App()
        {
            var log = new Label();

            MainPage = new ContentPage
            {
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Start,
                    Children = {
                        new Button {
                            Text = "Start benchmark",
                            Command = new Command(OnStartBenchmarkClick)
                        },
                        log
                    }
                }
            };

            BenchmarkManager manager = BenchmarkManager.Current;
            manager.Log += text => log.Text += Environment.NewLine + text;                       
            manager.Register(GetType().GetTypeInfo().Assembly);
        }

        private void OnStartBenchmarkClick(object obj)
        {
            BenchmarkManager.Current.Start();
        }
    }
}
