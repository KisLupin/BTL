using System.Data.Linq;
using System.Data.Linq.Mapping;

[Table(Name = "Users")]
class Users{
    private string username;
    [Column(IsPrimaryKey = true, Storage = "username")]
    public string username_
    {
        get
        {
            return this.username;
        }
        set
        {
            this.username = value;
        }
    }

    private string password;
    [Column(Storage = "password")]

    public string password_
    {
        get
        {
            return this.password;
        }
        set
        {
            this.password = value;
        }
    }

    
}

