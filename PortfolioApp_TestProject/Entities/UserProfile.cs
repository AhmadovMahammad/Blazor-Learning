namespace PortfolioApp.Entities;

public class UserProfile
{
    public int Id { get; set; }
    public string Bio { get; set; } = string.Empty;

    public int UserId { get; set; }
    public virtual User User { get; set; } = null!;
}

////2. User and Orders(One-to-Many Relationship)
//public class Order
//{
//    public int Id { get; set; }
//    public string ProductName { get; set; } = string.Empty;
//    public decimal Price { get; set; }

//    public int UserId { get; set; }
//    public User User { get; set; } = null!;
//}

////3. Many-to-Many: Users and Roles
//public class Role
//{
//    public int Id { get; set; }
//    public string Name { get; set; } = string.Empty;

//    public ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
//}

//public class UserRole
//{
//    public int UserId { get; set; }
//    public User User { get; set; } = null!;

//    public int RoleId { get; set; }
//    public Role Role { get; set; } = null!;
//}