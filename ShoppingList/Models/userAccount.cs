namespace ShoppingList.Models;

public class userAccount
{
    public string username { get; set; }
    public string password { get; set; }
    public string email { get; set; }
    public string userKey { get; set; }

    public userAccount(string username, string password, string email)
    {
        this.username = username;
        this.password = password;
        this.email = email;
    }
    
    public userAccount(string username, string password)
    {
        this.username = username;
        this.password = password;
    }
    
    public userAccount(string userKey)
    {
        this.userKey = userKey;
    }
}
