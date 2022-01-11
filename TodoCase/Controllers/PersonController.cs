using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoCase.Core.ViewModel;
using TodoCase.DataAccess.Services.IServices;

namespace TodoCase.Controllers
{
    public class PersonController : Controller
    {
        private readonly IPersonService _personService;
        private readonly ITaskService _taskService;
        public PersonController(IPersonService personService, ITaskService taskService)
        {
            _personService = personService;
            _taskService = taskService;
        }
        public IActionResult Index()
        {
            var model = _personService.GetAll();
            return View(model);
        }
        public IActionResult Insert(PersonelViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _personService.Insert(model);
                    return Json(new { success = true, message = "Ekleme işlemi tamamlandı.", data = model });
                }
                catch (Exception ex)
                {

                    return Json(new { success = false, message = ex.Message });
                }
            }
            return RedirectToAction(nameof(Index));


        }
        public IActionResult Update(PersonelViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _personService.Update(model);
                    return Json(new { success = true, message = "Ekleme işlemi tamamlandı.", data = model });
                }
                catch (Exception ex)
                {

                    return Json(new { success = false, message = ex.Message });
                }
            }
            return RedirectToAction(nameof(Index));

        }

        public IActionResult PersonsTask(int personId)
        {
            var model = _taskService.GetByPersonId(personId);
            return View(model);
        }

    }
}
