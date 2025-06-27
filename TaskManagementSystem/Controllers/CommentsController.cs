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

        public async Task<IActionResult> Details(int id)
        {
            var comment = await _service.GetByIdAsync(id);
            if (comment == null) return NotFound();
            return View(comment);
        }

        public IActionResult Create(int taskId) => View(new Comment { TaskId = taskId });

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Comment comment)
        {
            if (!ModelState.IsValid) return View(comment);
            await _service.CreateAsync(comment);
            return RedirectToAction(nameof(Index), new { taskId = comment.TaskId });
        }

        public async Task<IActionResult> Edit(int id)
        {
            var comment = await _service.GetByIdAsync(id);
            if (comment == null) return NotFound();
            return View(comment);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Comment comment)
        {
            if (!ModelState.IsValid) return View(comment);
            await _service.UpdateAsync(comment);
            return RedirectToAction(nameof(Index), new { taskId = comment.TaskId });
        }

        public async Task<IActionResult> Delete(int id)
        {
            var comment = await _service.GetByIdAsync(id);
            if (comment == null) return NotFound();
            return View(comment);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var comment = await _service.GetByIdAsync(id);
            if (comment != null)
                await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index), new { taskId = comment?.TaskId });
        }
    }
}
