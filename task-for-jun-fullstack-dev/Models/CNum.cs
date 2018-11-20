using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace task_for_jun_fullstack_dev.Models
{
  public class CNum
  {
    public int Increment { get; set; }
    public string Value { get; set; }

    public CNum(int i)
    {
      Increment = i;
      Value = setValue(i);
    }

    private string setValue(int i)
    {
      string result = i.ToString();

      if (i % 3 == 0)
        result = "Green";

      if (i % 5 == 0)
        result = "Money";

      if (i % 3 == 0 && i % 5 == 0)
        result = "GreenMoney";

      return result;
    }
  }
}