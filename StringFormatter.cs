using System.Text;

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
        
        public static string ToCommaSeparatedList(string[] items)
        {
            // refactored to use join as this handles array items > 1 correctly
            return items == null || items?.Length == 0 ? string.Empty : string.Join(Separator, items);
        }
    }
}
