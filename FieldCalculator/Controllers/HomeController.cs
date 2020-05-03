using FieldCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace FieldCalculator.Controllers
{
    public class HomeController : Controller
    {
        //    
        // GET: /Home/    
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(FieldCalculatorViewModel model, string command)
        {
                model.SplitInputData(model.InputData);
                if (command.Contains("kwadrat"))
                {
                    model.Figure1(model.a);
                    model.choosedFigure = "Pole powierzchni wybranej figury kwadratu wynosi:";
                }
                else if (command.Contains("prostokąt"))
                {
                    model.Figure1(model.a, model.b);
                    model.choosedFigure = "Pole powierzchni wybranej figury prostokątu wynosi:";
                }
                else if (command.Contains("równoległobok"))
                {
                    model.Figure1(model.a, model.b);
                    model.choosedFigure = "Pole powierzchni wybranej figury równoległoboku wynosi:";
                }
                else if (command.Contains("trapez"))
                {
                    model.Figure1(model.a, model.b, model.c);
                    model.choosedFigure = "Pole powierzchni wybranej figury trapezu wynosi:";
                }
                else if (command.Contains("koła"))
                {
                    model.Figure2(model.a);
                    model.choosedFigure = "Pole powierzchni wybranej figury koła wynosi:";
                }
                else if (command.Contains("trójkąt"))
                {
                    model.Figure2(model.a, model.b);
                    model.choosedFigure = "Pole powierzchni wybranej figury trójkąta wynosi:";
                }
                else if (command.Contains("romb"))
                {
                    model.Figure3(model.a, model.b);
                    model.choosedFigure = "Pole powierzchni wybranej figury rombu wynosi:";
                }
                return View(model);
        }
    }
}
