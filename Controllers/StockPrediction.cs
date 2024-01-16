using Microsoft.AspNetCore.Mvc;
using static Team21.MLModel;

namespace Team21.Controllers
{
    
    public class StockPrediction : Controller
    {
        [HttpGet]
        public IActionResult Predict()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Predict(ModelInput input)
        {
            var prediction = MLModel.Predict(input);
            ViewBag.Result = prediction;
            return View();
        }
    }
}
