using Microsoft.AspNetCore.Mvc;
using RaishasBooks.DataAccess.Repository.IRepository;
using RaishasBooks.Models;

namespace RaishasBookStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Upsert(int? id)
        {
            Category category = new Category();
            if (id == null)
            {
                //this is for create
                return View(category);
            }
            category = _unitOfWork.Category.Get(id.GetValueOrDefault());
            if (category == null)
            {
                return NotFound();
            }
            return View(category); 
        }

        // Use HTTP POST to define the post-action method.
        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Upsert(Category category)
        {
            if (ModelState.IsValid)  // Checks all validations in the model (eg: Name Required) to increase security.
            {
                if (category.Id == 0)
                {
                    _unitOfWork.Category.Add(category);
                }

                else
                {
                    _unitOfWork.Category.Update(category);
                }

                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));  //To see all the categories
                return RedirectToAction(nameof(Index));  
            }

            return View(category);
        }

        // API calls here
        #region API CALLS
        [HttpGet]
        public IActionResult GetAll()
        {

            var allObj = _unitOfWork.Category.GetAll();
            return Json(new { data = allObj });



        }
        [HttpDelete]

        public IActionResult Delete(int id)
        {
            var objFromDb = _unitOfWork.Category.Get(id);
            if (objFromDb == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }
            _unitOfWork.Category.Remove(objFromDb);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Delete successful" });

        }
        #endregion
    }
}
