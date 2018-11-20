using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace task_for_jun_fullstack_dev.Models
{
  public class CIntersections
  {
    public List<CIntersection> Intersections { get; set; }

    public CIntersections(string first, string second)
    {
      Intersections = new List<CIntersection>();

      int[] firstNums = first.Split(';').Select(n => Convert.ToInt32(n)).ToArray();
      int[] secondNums = second.Split(';').Select(n => Convert.ToInt32(n)).ToArray();

      var intersectItems = firstNums.Intersect(secondNums);

      foreach (int item in intersectItems)
        Intersections.Add(new CIntersection(item));
    }
  }
}