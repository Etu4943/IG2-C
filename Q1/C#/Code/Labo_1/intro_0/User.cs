namespace intro_0;

public class User
{
    private string login;
    private string password;
    private DateTime joinDate;
    private int postCount;
    

    public User(string login, string password, DateTime joinDate)
    {
        this.login = login;
        this.password = password;
        this.joinDate = joinDate;
        this.postCount = 0;
    }

    public User(string login, string password):this(login,password,DateTime.Today) {}
}