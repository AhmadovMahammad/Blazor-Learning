using Microsoft.EntityFrameworkCore;
using PortfolioApp.Entities;

namespace PortfolioApp.Data;

//public class UserService
//{
//    private int _nextId;

//    private readonly Dictionary<int, string> _users = new()
//    {
//        { 0, "Mahammad Ahmadov" },
//        { 1, "Lagertha" },
//        { 2, "Bjorn Ironside" }
//    };

//    public event Action? OnUserChanged;

//    public string GetUser(int id)
//    {
//        return _users[id];
//    }

//    public string GetCurrentUser()
//    {
//        return _users[_nextId];
//    }

//    public void SetCurrentUser(string name)
//    {
//        _nextId = _users.Count;
//        _users.Add(++_nextId, name);
//        OnUserChanged?.Invoke();
//    }

//    public IEnumerable<string> GetUsers()
//    {
//        return _users.Values;
//    }

//    public void AddUser(int id, string name)
//    {
//        _users.Add(id, name);
//    }

//    public void RemoveUser(int id)
//    {
//        _users.Remove(id);
//    }

//    public void UpdateUser(int id, string name)
//    {
//        _users[id] = name;
//    }

//    public bool UserExists(int id)
//    {
//        return _users.ContainsKey(id);
//    }

//    public bool UserExists(string name)
//    {
//        return _users.ContainsValue(name);
//    }

//    public int GetUserCount()
//    {
//        return _users.Count;
//    }

//    public void ClearUsers()
//    {
//        _users.Clear();
//    }
//}

public class UserService
{
    private readonly AppDbContext _context;
    public UserService(AppDbContext context)
    {
        _context = context;
    }

    public IEnumerable<User> GetUsers()
    {
        IEnumerable<User> users = _context.Users.Include(u => u.Profile);
        return users;
    }
}
