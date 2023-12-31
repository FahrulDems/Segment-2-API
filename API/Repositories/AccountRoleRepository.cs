﻿using API.Contracts;
using API.Data;
using API.Models;

namespace API.Repositories;

public class AccountRoleRepository : GeneralRepository<AccountRole>, IAccountRoleRepository
{
    public AccountRoleRepository(BookingDbContext context) : base(context) { }
    public IEnumerable<AccountRole> GetAccountRolesByAccountGuid(Guid guid)
    {
        return _context.Set<AccountRole>().Where(ar => ar.AccountGuid == guid);
    }
}



















/*public class AccountRoleRepository : IAccountRoleRepository
{
    private readonly BookingDbContext _context;
    public AccountRoleRepository (BookingDbContext context)
    {
        _context = context;
    }

    public ICollection<AccountRole> GetAll()
    {
        return _context.Set<AccountRole>().ToList();
    }

    public AccountRole GetByGuid(Guid guid)
    {
        return _context.Set<AccountRole>().Find(guid);
    }

    public AccountRole Create(AccountRole accountRole)
    {
        try
        {
            _context.Set<AccountRole>().Add(accountRole);
            _context.SaveChanges();

            return accountRole;
        }
        catch
        {
            return new AccountRole();
        }
    }

    public bool Update(AccountRole accountRole)
    {
        try
        {
            _context.Set<AccountRole>().Add(accountRole);
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
            var accountRole = GetByGuid(guid);
            if (accountRole is null)
            {
                return false;
            }

            _context.Set<AccountRole>().Remove(accountRole);
            _context.SaveChanges();

            return true;
        }
        catch 
        {
            return false;
        }
    }

}*/
