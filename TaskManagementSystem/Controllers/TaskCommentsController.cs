using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TaskManagementSystem.Models;
using TaskManagementSystem.Services;

namespace TaskManagementSystem.Controllers
{
    public class TaskCommentsController : Controller
    {
        private readonly ITaskCommentService _service;
        public TaskCommentsController(ITaskCommentService service) { _service = service; }

        public async Task<IActionResult> Index(int taskId) => View(await _service.GetAllByTaskIdAsync(taskId));

        public async Task<IActionResult> Details(int id)
        {
            var comment = await _service.GetByIdAsync(id);
            if (comment == null) return NotFound();
            return View(comment);
        }

        public IActionResult Create(int taskId) => View(new TaskComment { TaskId = taskId, Comment = string.Empty });

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TaskComment taskcomment)
        {
            if (!ModelState.IsValid) return View(taskcomment);
            await _service.CreateAsync(taskcomment);
            return RedirectToAction(nameof(Index), new { taskId = taskcomment.TaskId });
        }

        public async Task<IActionResult> Edit(int id)
        {
            var comment = await _service.GetByIdAsync(id);
            if (comment == null) return NotFound();
            return View(comment);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(TaskComment taskcomment)
        {
            if (!ModelState.IsValid) return View(taskcomment);
            await _service.UpdateAsync(taskcomment);
            return RedirectToAction(nameof(Index), new { taskId = taskcomment.TaskId });
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
