using System.Text;
using Newtonsoft.Json;
using ShoppingList.Models;

namespace ShoppingList;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    async void LoadData()
    {
        var client = new HttpClient();
        var response = await client.GetAsync(new Uri("" + App.SessionKey));
        var wsJson = response.Content.ReadAsStringAsync().Result;

        var UserDataObject = JsonConvert.DeserializeObject<userDataCollection>(wsJson);

        lstData.ItemSource = UserDataObject.UserDataItems;
    }

    public void OnAppearing()
    {
        if ()
        {

        }
        else
        {
            LoadData();
        }
    }

    async void MenuItem_OnClicked(object sender, EventArgs e)
    {
        var dataID = ((MenuItem)sender).CommandParameter.ToString();
        var data = JsonConvert.SerializeObject(new userData(dataID, null, App.SessionKey));

        var client = new HttpClient();
        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Delete,
            RequestUri = new Uri(""),
            Content = new StringContent(data, Encoding.UTF8, "application/json")
        };
        await client.SendAsync(request);
        LoadData();
    }

    lstData.Refreshing += delegate

    {
        LoadData();
        lstData.IsRefreshing = false;
    };

}