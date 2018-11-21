using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using task_for_jun_fullstack_dev.Models;

namespace task_for_jun_fullstack_dev.Controllers
{
  public class HomeController : Controller
  {
    public ActionResult Index()
    {
      return View();
    }
    
    public ActionResult GetNums(int start, int end)
    {
      CNums nums = new CNums(start, end);
      return Json(nums);
    }

    public ActionResult GetRundomNums(int min, int max, int n)
    {
      Random random = new Random();

      double[] randomNums = new double[n];

      for (int i = 0; i < randomNums.Length; i++)
        randomNums[i] = random.Next(min, max);

      double k = randomNums.Sum() / 1;

      for (int i = 0; i < randomNums.Length; i++)
        randomNums[i] /= k;

      return Json(randomNums);
    }

    public ActionResult MissedLetter(string alphabet, string letters)
    {
      CAlphabet cAlphabet = new CAlphabet(alphabet);
      return Json(cAlphabet.MissingLetter(letters));
    }

    public ActionResult Intersection(string first, string second)
    {
      CIntersections intersections = new CIntersections(first, second);
      return Json(intersections.Intersections);
    }
  }
}