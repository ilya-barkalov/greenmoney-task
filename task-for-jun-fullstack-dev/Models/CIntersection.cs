using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace task_for_jun_fullstack_dev.Models
{
  public class CIntersection
  {
    public int Intersection { get; set; }
    public int Square { get; set; }

    public CIntersection(int intersection_)
    {
      Intersection = intersection_;
      Square = Intersection * Intersection;
    }
  }
}