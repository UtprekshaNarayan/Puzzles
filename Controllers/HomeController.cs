using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Game.Models;
namespace Game.Controllers
{
    public class HomeController : Controller
    {
        // int a, b;
        public ActionResult Index()
        {
            return View();
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

        //Level 1
        public ActionResult Find_Gcd(FormCollection c)
        {
            //int A = int.Parse(Request.Form["a"]);
            //int B = int.Parse(Request.Form["b"]);
            int user_ans = int.Parse(Request.Form["UserAnswer"]);
            GCD ob = new GCD(5, 9, user_ans);
            int result = ob.FindGcd(5, 9);
            if (result == user_ans)
                //ViewBag.Message = "Excellent";
                return RedirectToAction("Count_Steps");
            else
                ViewBag.Message = "Oops ! Wrong Answer, try again ";
            return View(ob);
        }
        public ActionResult Solve_Puzzle()
        {
            GCD ob = new GCD { FirstName = 5, SecondName = 9, UserAnswer = 0 };
            //int result = ob.FindGcd(a,b);
            //ViewBag.Message = "Your contact page.";

            return View(ob);

        }

        //Level 2
        public ActionResult Count_Steps()
        {
            CountNumberOfJumps ob_CountNumberOfJumps = new CountNumberOfJumps { Steps = 5 };
            return View(ob_CountNumberOfJumps);
        }
        public ActionResult Calculate_Steps(FormCollection count_steps)
        {
            int user_ans = int.Parse(Request.Form["UserAns_Steps"]);
            CountNumberOfJumps obOfFindNumberOfJumps = new CountNumberOfJumps(5, user_ans);
            int result = obOfFindNumberOfJumps.FindNumberOfJumps(5);
            if (result == user_ans)
            {

                return RedirectToAction("Lost_Number");
            }
            else
            {
                ViewBag.Message = "Oops ! Wrong Answer, try again ";
            }
            // obOfFindNumberOfJumps = (obOfFindNumberOfJumps)user_ans;
            return View(obOfFindNumberOfJumps);
        }


        //Level3
        public ActionResult CalculateLostNumber(FormCollection c)
        {
            int firstNo = int.Parse(Request.Form["firstNo"]);
            int secondNo = int.Parse(Request.Form["secondNo"]);
            LostNumber obOfFindNumberOfJumps = new LostNumber { FirstNoOfSequence = 0, SecondNoOfSequence = 0, ThirdNumberOfSequence = 1, FourthNumberOfSequence = 100 };
            //FirstNoOfSequence = 0, SecondNoOfSequence = 0, ThirdNumberOfSequence = 1, FourthNumberOfSequence =100
            //String[] result = new String[2];
            List<int> result = new List<int>(2);

            result = obOfFindNumberOfJumps.FindLostNumbers(1, 100);
            if (result[0] == firstNo && result[1] == secondNo)
            {

                return RedirectToAction("PossiblPath");
            }
            else
            {
                ViewBag.Message = "Oops ! Wrong Answer, try again ";
            }
            //Console.WriteLine(int.Parse(result[0])+" "+ int.Parse(result[1]));
            obOfFindNumberOfJumps.FirstNoOfSequence = firstNo;
            obOfFindNumberOfJumps.SecondNoOfSequence = secondNo;
            return View(obOfFindNumberOfJumps);
        }
        public ActionResult Lost_Number()
        {
            //I have to provide first no and fourth no
            LostNumber obLostNumber = new LostNumber { FirstNoOfSequence = 0, SecondNoOfSequence = 0, ThirdNumberOfSequence = 1, FourthNumberOfSequence = 100 };

            return View(obLostNumber);
        }

        //Level 4
        public ActionResult PossiblPath()
        {
            AllPossiblePaths obOfAllPossiblePaths = new AllPossiblePaths { Length = 3, Breath = 3, TotalPossiblePaths = 0 };
            return View(obOfAllPossiblePaths);
        }
        public ActionResult Find_AllPossibePaths(FormCollection c)
        {
            int Userans = int.Parse(Request.Form["userAns"]);
            //int breath = int.Parse(Request.Form["Breath"]);
            AllPossiblePaths obOfAllPossiblePaths = new AllPossiblePaths { Length = 3, Breath = 3, TotalPossiblePaths = Userans };
            //obOfAllPossiblePaths.Length = 3;
            //obOfAllPossiblePaths.Breath = 3;
            obOfAllPossiblePaths.TotalPossiblePaths = Userans;
            int totalPossiblePaths = obOfAllPossiblePaths.CountAllPossiblePaths(obOfAllPossiblePaths);
            if (totalPossiblePaths == Userans)
            {

                return RedirectToAction("Congratulations");
            }
            else
            {
                ViewBag.Message = "Oops ! Wrong Answer, try again ";
            }

            return View(obOfAllPossiblePaths);
        }
        //Final Action for Puzzle
        public ActionResult Congratulations()
        {
            ViewBag.Message = "You solved all problems. You are a GENIUS !!";
            return View();
        }
    }
}