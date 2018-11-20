using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace task_for_jun_fullstack_dev.Models
{
  public class CAlphabet
  {
    public string Alphabet { get; set; }
    public string Letters { get; set; }

    public CAlphabet(string alphabet_)
    {
      Alphabet = alphabet_;
    }

    public string MissingLetter(string letters)
    {
      string result = "Пропущенная буква: ";

      int i = 0;

      for (int j = 0; j < Alphabet.Length; j++)
      {
        if (Alphabet[j] == letters[0])
          i = j;
      }

      for (; i < Alphabet.Length; i++)
      {
        for (int j = 0; j < letters.Length; j++)
        {
          if (letters[j] == Alphabet[i])
          {
            i++;
            continue;
          }
          else
          {
            result += Alphabet[i].ToString();
            return result;
          }
        }
      }

      return result;
    }
  }
}