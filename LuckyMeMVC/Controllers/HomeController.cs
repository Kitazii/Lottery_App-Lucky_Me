using LuckyMeMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LuckyMeMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        //this action returns the empty form
        [HttpGet]
        public ActionResult CheckNumbers()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CheckNumbers(LotteryNumber model)
        {
            //This list var will hold the value of the weekly lottery draw (six int values)
            List<int> weeklyDraw = new List<int>() { 23, 27, 34, 39, 40, 3 };

            //the counter will hold how many of the user's nums matches the weekly lottery draw
            int counter = 0;

            //looping from the weekly lottery draw to count how many numbers match
            //if theres a single match, we increment the counter by one
            foreach (int lotter_num in weeklyDraw)
            {
                if (lotter_num == model.Number_1)
                {
                    counter++;
                }
                else if (lotter_num == model.Number_2)
                {
                    counter++;
                }
                else if (lotter_num == model.Number_3)
                {
                    counter++;
                }
                else if (lotter_num == model.Number_4)
                {
                    counter++;
                }
                else if (lotter_num == model.Number_5)
                {
                    counter++;
                }
                else if (lotter_num == model.Number_6)
                {
                    counter++;
                }
            } //end of foreach

            //checking if the user has 6 matching nnumber then he wins the jackpot else...
            if (counter == 6)
            {
                ViewBag.Winning = "Congratulations! You won 10 Million";
            }
            else
            {
                ViewBag.Losing = "Sorry maybe you have better luck next time!";
            }

            return View();
        }//end of CheckNumbers Method
    }//end of HomeController class
}//end of namespace