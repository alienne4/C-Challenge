namespace CSharpChallenge;

public abstract class Application
{
    private string name;
    private int MaxUsers = 0;
    private List<User> usersList = new List<User>();

    public Application(string name, int dim, List<User> app)
    {
        this.name = name;
        MaxUsers = dim;
        List<User> usersList = app;
    }

    public string GetName()
    {
        return name;
    }

    public int GetNumberOfUsers()
    {
        return MaxUsers;
    }

    public override string ToString()
    {
        return name + " " + MaxUsers;
    }

    public void AddUser(string name, string pass, string mail)
    {
        MaxUsers++;
        User a = new User(username: name, password: pass, email: mail);
        usersList.Add(a);
    }

    public void RemoveUser(string name)
    {
        User n = new User(username: name, password: "0000", email: "s.com");
        usersList.Remove(n);
    }
}