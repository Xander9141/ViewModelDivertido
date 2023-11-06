using Microsoft.AspNetCore.Mvc;
namespace ViewModelDivertido.Controllers;
public class PrincipalController : Controller
{

    [HttpGet]
    [Route("")]
    public IActionResult Index()
    {
        var stringModel = new stringModel
        {
            Message = "Hola, esta es una cadena de mensaje."
        };

        return View(stringModel);
    }
}


public class NumbersController : Controller
{
    public IActionResult Index()
    {
        var numbersViewModel = new NumbersViewModel
        {
            Numbers = new int[] { 1, 2, 3, 4, 5 }
        };

        return View(numbersViewModel);
    }
}


public class UsersController : Controller
{
    public IActionResult Index()
    {
        var usersViewModel = new UsersViewModel
        {
            Users = new List<User>
            {
                new User { FirstName = "John", LastName = "Doe" },
                new User { FirstName = "Jane", LastName = "Smith" },
                new User { FirstName = "Michael", LastName = "White" },
                new User { FirstName = "Jesus", LastName = "Fenix" },
                new User { FirstName = "Josh", LastName = "Parker" }
                
            }
        };

        return View(usersViewModel);
    }
}


public class UserController : Controller
{
    public IActionResult Index()
    {
        var userViewModel = new UserViewModel
        {
            User = new User { FirstName = "Moose", LastName = "Phillips" }
        };

        return View(userViewModel);
    }
}
