using System.Collections.Generic;
using System.Threading.Tasks;
using TaskManagementSystem.Models;

namespace TaskManagementSystem.Services
{
    public interface IProjectService
    {
        Task<IEnumerable<Project>> GetAllAsync();
        Task<Project> GetByIdAsync(int id);
        Task CreateAsync(Project project);
        Task UpdateAsync(Project project);
        Task DeleteAsync(int id);
    }
}

