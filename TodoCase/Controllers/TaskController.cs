using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoCase.Core.ViewModel;
using TodoCase.DataAccess.Services.IServices;

namespace TodoCase.Controllers
{
    public class TaskController : Controller
    {
        private readonly ITaskService _taskService;
        public TaskController(ITaskService taskService)
        {
            _taskService = taskService;
        }
        public IActionResult Index()
        {
            var model = _taskService.GetAll();
            return View(model);
        }
        public IActionResult Insert(TaskViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _taskService.Insert(model);
                    return Json(new { success = true, message = "Ekleme işlemi tamamlandı.", data = model });
                }
                catch (Exception ex )
                {

                    return Json(new { success = false, message = ex.Message });
                }
            }
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Update(TaskViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _taskService.Update(model);
                    return Json(new { success = true, message = "Ekleme işlemi tamamlandı.", data = model });
                }
                catch (Exception ex)
                {

                    return Json(new { success = false, message = ex.Message });
                }
            }
            return RedirectToAction(nameof(Index));

        }
    }
}
