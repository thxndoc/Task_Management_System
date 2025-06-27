using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TaskManagementSystem.Models;
using TaskManagementSystem.Services;

namespace TaskManagementSystem.Controllers
{
    public class CommentsController : Controller
    {
        private readonly ICommentService _service;
        public CommentsController(ICommentService service) { _service = service; }

        public async Task<IActionResult> Index(int taskId) => View(await _service.GetAllByTaskIdAsync(taskId));
    }
}
