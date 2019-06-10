using FluentValidation.Results;
using FluentValidationsMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace FluentValidationsMCV.Controllers
{
    public class ProductosController : Controller
    {

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind] productos producto)
        {
            ValidadorProductos validator = new ValidadorProductos();

            ValidationResult result = validator.Validate(producto);

            if (!result.IsValid)

            {
                foreach (ValidationFailure failer in result.Errors)

                {
                    ModelState.AddModelError(failer.PropertyName, failer.ErrorMessage);
                }
            }

            else
            {  
              //Accion de crear el producto  
            }

            return View(producto);


        }

    }

}