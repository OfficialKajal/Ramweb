using Microsoft.AspNetCore.Mvc;

namespace RamWeb.Controllers
{
    public class CurrencyConverterController : Controller
    {
        // The current exchange rate from USD to INR.
        private const decimal ExchangeRate = 74.85m;

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Convert(decimal amountInDollars)
        {
            if (amountInDollars <= 0)
            {
                TempData["Error"] = "Please enter a valid amount in dollars.";
                return RedirectToAction("Index");
            }

            decimal amountInRupees = amountInDollars * ExchangeRate;
            TempData["Result"] = $"{amountInDollars} USD = {amountInRupees} INR";

            return RedirectToAction("Index");
        }
    }
}
