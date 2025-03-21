namespace PortfolioApp.Entities;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;

    public virtual UserProfile? Profile { get; set; }
    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
    public virtual ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
}