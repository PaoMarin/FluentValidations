using FluentValidation.Results;
using FluentValidationsMCV.Models;
using Microsoft.AspNetCore.Mvc;

namespace FluentValidationsMCV.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind] Login user)
        {
            LoginValidation validator = new LoginValidation();

            ValidationResult result = validator.Validate(user);

            if (!result.IsValid)

            {
                foreach (ValidationFailure failer in result.Errors)

                {
                    ModelState.AddModelError(failer.PropertyName, failer.ErrorMessage);
                }
            }

            else
            {
                //Acciones que queramos ejecutar (crear el usuario)
            }

            return View(user);
        }

    }
}