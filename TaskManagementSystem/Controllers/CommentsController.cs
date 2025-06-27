using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OmnitakTaskCommandCenter.Models;
using OmnitakTaskCommandCenter.Services;

namespace TaskManagementSystem.Controllers
{
    public class CommentsController : Controller
    {
        private readonly ICommentService _service;
        public CommentsController(ICommentService service) { _service = service; }
    }
}
