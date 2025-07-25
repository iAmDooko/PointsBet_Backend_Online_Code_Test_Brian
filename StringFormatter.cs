﻿using System.Text;
using System.Linq;

namespace PointsBet_Backend_Online_Code_Test
{

    /*
    Improve a block of code as you see fit in C#.
    You may make any improvements you see fit, for example:
      - Cleaning up code
      - Removing redundancy
      - Refactoring / simplifying
      - Fixing typos
      - Any other light-weight optimisation
    */
    public class StringFormatter
    {
        private const string Separator = ",";
        private const string Quote = "\"";
        
        private const string StringFormat = "{0}{1}{0}";
        
        public static string ToCommaSeparatedListSimpleStrings(string[] items)
        {
            // refactored to use join as this handles array items > 1 correctly for simple arrays
            return items == null || items?.Length == 0 ? string.Empty : string.Join(Separator, items);
        }
        
        public static string ToCommaSepatatedListComplexStrings(string[] items)
        {
            // refactor for more complex arrays with quote marks
            if (items == null || items?.Length == 0)
            {
                return string.Empty;
            }
            
            StringBuilder qry = new StringBuilder();
            
            for (int i = 0; i < items.Length; i++)
            {
                qry.Append(string.Format(StringFormat, Quote, items[i]));

                if (i < items.Length - 1)
                {
                    qry.Append(Separator);
                }
            }

            return qry.ToString();
        }
        
        public static string ToCommaSepatatedListComplexStringsLinq(string[] items)
        {
            // refactor above method to use Linq
            if (items == null || items?.Length == 0)
            {
                return string.Empty;
            }
            
            return string.Join(Separator, items.Select(item => $"{Quote}{item}{Quote}"));
        }
    }
}
