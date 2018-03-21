using System.Web.Mvc;
using ISTQBFoundationTrainer.Helpers;
using ISTQBFoundationTrainer.Models;

namespace ISTQBFoundationTrainer.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var question = SqlHelper.ReadRandomQuestion();

            return View(new TrainingDataModel
            {
                Question = question,
                Language = Language.Russian,
                TrainingStrategy = TrainingStrategy.Sequentially
            });
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}