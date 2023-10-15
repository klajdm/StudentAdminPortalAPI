using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace StudentAdminPortalAPI.Repositories
{
    public interface IImageRepository
    {
        Task<string> Upload(IFormFile file, string fileName);
    }
}
