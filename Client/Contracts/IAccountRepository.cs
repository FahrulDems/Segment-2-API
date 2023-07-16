using API.DTOs.Account;
using API.Utilities;
using Client.Repositories;

namespace Client.Contracts
{
    public interface IAccountRepository : IRepository<RegisterDto, string>
    { 
        Task<ResponseHandler<AccountRepository>> Register(RegisterDto entity);
        Task<ResponseHandler<string>> Login(LoginDto entity);
    }
}
