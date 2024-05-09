using Microsoft.AspNetCore.Identity;

namespace KhumaloCraft.Web.Repositories
{
    public interface IUserRepository
    {
        Task<IEnumerable<IdentityUser>> GetAll();
    }
}
