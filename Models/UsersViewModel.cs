using System.Collections.Generic;
public class UsersViewModel
{
    public List<User> Users { get; set; }

    public UsersViewModel()
    {
        Users = new List<User>(); 
    }
}
