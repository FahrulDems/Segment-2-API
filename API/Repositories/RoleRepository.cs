﻿using API.Contracts;
using API.Data;
using API.Models;

namespace API.Repositories;
public class RoleRepository : GeneralRepository<Role> , IRoleRepository
{
    public RoleRepository(BookingDbContext context) : base(context) { }
    public Role? GetByName(string name)
    {
        return _context.Set<Role>().FirstOrDefault(role => role.Name == name);
    }
}




















/*public class RoleRepository : IRoleRepository
{
    private readonly BookingDbContext _context;
    public RoleRepository (BookingDbContext context)
    {
        _context = context;
    }

    public ICollection<Role> GetAll()
    {
        return _context.Set<Role>().ToList();
    }

    public Role GetByGuid (Guid guid)
    {
        return _context.Set<Role>().Find(guid);
    }

    public Role Create(Role role)
    {
        _context.Set<Role>().Add(role);
        _context.SaveChanges();

        return role;
    }

    public bool Update(Role role)
    {
        try
        {
            _context.Set<Role>().Update(role);
            _context.SaveChanges();

            return true;
        }
        catch 
        {
            return false;
        }
    }

    public bool Delete(Guid guid)
    {
        try
        {
            var role = GetByGuid(guid);
            if (role is null)
            {
                return false;
            }

            _context.Set<Role>().Remove(role);
            _context.SaveChanges();

            return true;
        }
        catch
        {
            return false;
        }       
    }
}
*/