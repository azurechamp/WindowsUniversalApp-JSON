using App3.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text;
using Windows.UI.Popups;

namespace App3.ViewModels
{
    public class MainPageViewModel
    {
        //Observable Collection
        public ObservableCollection<LatestNew> obs_main { get; set; }

        public MainPageViewModel() 
        {

            obs_main = new ObservableCollection<LatestNew>();
            getJson();
        }

        public async void getJson() 
        {
            try
            {
                var client = new HttpClient();
                var response = await client.GetAsync("http://hello987.azurewebsites.net/news.html");
                var result = await response.Content.ReadAsStringAsync();
                var rootObject = JsonConvert.DeserializeObject<RootObject>(result);
                foreach (LatestNew latnew in rootObject.LatestNews)
                {
                    obs_main.Add(latnew);
                }
            }catch(Exception exc)
            {
               //TODO Code HERE
               
            }
        }
    }
}
