using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace task_for_jun_fullstack_dev.Models
{
  public class CNums
  {
    public List<CNum> Nums { get; set; }

    public CNums(int start, int end)
    {
      Nums = new List<CNum>();

      for (; start <= end; start++)
        Nums.Add(new CNum(start));
    }
  }
}