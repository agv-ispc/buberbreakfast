using Microsoft.AspNetCore.Mvc;

namespace BuberBreakfast.Controllers;

public class ErrorsController : Controller
{
		[Route("/error")]
    public IActionResult Error()
    {
        return Problem();
    }
}