var user = new User();
user.FirstName = Console.ReadLine();
user.LastName = Console.ReadLine();
user.UserName = Console.ReadLine();
user.Password = Convert.ToInt32(Console.ReadLine());

var user1 = new User();
user1.FirstName = Console.ReadLine();
user1.LastName = Console.ReadLine();
user1.UserName = Console.ReadLine();
user1.Password = Convert.ToInt32(Console.ReadLine());

var user2 = new User();
user2.FirstName = Console.ReadLine();
user2.LastName = Console.ReadLine();
user2.UserName = Console.ReadLine();
user2.Password = Convert.ToInt32(Console.ReadLine());

var user3 = new User();
user3.FirstName = Console.ReadLine();
user3.LastName = Console.ReadLine();
user3.UserName = Console.ReadLine();
user3.Password = Convert.ToInt32(Console.ReadLine());

var user4 = new User();
user4.FirstName = Console.ReadLine();
user4.LastName = Console.ReadLine();
user4.UserName = Console.ReadLine();
user4.Password = Convert.ToInt32(Console.ReadLine());

List<User> users = new List<User>();
users.Add(user);
users.Add(user1);
users.Add(user2);
users.Add(user3);
users.Add(user4);

class User
{
    public string FirstName;
    public string LastName;
    public string UserName;
    public int Password;

    public string GetInfo()
    {
        
    }
}