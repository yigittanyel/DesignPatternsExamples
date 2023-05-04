using DesignPatternsExamples.Repository_UOW.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatternsExamples.Repository_UOW.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TodoItemsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public TodoItemsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet("{id}")]
        public ActionResult<TodoItem> GetById(int id)
        {
            var todoItem = _unitOfWork.GetRepository<TodoItem>().GetById(id);

            if (todoItem == null)
            {
                return NotFound();
            }

            return todoItem;
        }

        [HttpPost]
        public ActionResult<TodoItem> Create(TodoItem todoItem)
        {
            _unitOfWork.GetRepository<TodoItem>().Add(todoItem);
            _unitOfWork.SaveChanges();

            return CreatedAtAction(nameof(GetById), new { id = todoItem.Id }, todoItem);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, TodoItem todoItem)
        {
            if (id != todoItem.Id)
            {
                return BadRequest();
            }

            _unitOfWork.GetRepository<TodoItem>().Update(todoItem);
            _unitOfWork.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var todoItem = _unitOfWork.GetRepository<TodoItem>().GetById(id);

            if (todoItem == null)
            {
                return NotFound();
            }

            _unitOfWork.GetRepository<TodoItem>().Remove(todoItem);
            _unitOfWork.SaveChanges();

            return NoContent();
        }
    }

}
