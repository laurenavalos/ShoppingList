namespace ShoppingList.Models;

public class userDataCollection
{
    public userData[] UserDataItems { get; set; }
}

public class userData
{
    public string dataID { get; set; }
    public string dataValue { get; set; }
    public string userKey { get; set; }

    public userData(string dataID, string dataValue, string userKey)
    {
        this.dataID = dataID;
        this.dataValue = dataValue;
        this.userKey = userKey;
    }
}