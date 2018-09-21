using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URLEncoder__Creating_URL_
{
    class Program
    {
        static void Main(string[] args)
        {
            string projectname;
            string activityname;

            Console.WriteLine("Enter the project name for the URL: ");
            projectname = Console.ReadLine();
            Console.WriteLine();

            while (projectname == null)
            {
                Console.WriteLine("Nothing was written, try again: ");
                projectname = Console.ReadLine();
            }

            Console.WriteLine("Enter the activity name next:");
            activityname = Console.ReadLine();
            Console.WriteLine();

            while (activityname == null)
            {
                Console.WriteLine("Nothing was written, try again: ");
                activityname = Console.ReadLine();
            }

            //ReplaceChar n = new ReplaceChar();
           // projectname = n.ReplaceChar(projectname);

            Replace(projectname);
            Replace(activityname);

            Console.WriteLine("The new URL is: https://companyserver.com/content/{0}/files/{1}/{1}Report.pdf", projectname, activityname);

        }
    
    }

    public class ReplaceChar
    {
        public static string Replace(string s)
        {
            s = s.Trim();
            s = s.Replace(" ", "%20");
            s = s.Replace(";", "%3B");
            s = s.Replace("/", "%2F");
            s = s.Replace("?", "%3F");
            s = s.Replace(":", "%3A");
            s = s.Replace("@", "%40");
            s = s.Replace("&", "%26");
            s = s.Replace("=", "%3D");
            s = s.Replace("+", "%2B");
            s = s.Replace("{", "%24");
            s = s.Replace("}", "%24");
            s = s.Replace("|", "%24");
            //s = s.Replace("\", "");
            s = s.Replace("^", "%5E");
            s = s.Replace("[", "%5B");
            s = s.Replace("]", "%5D");
            s = s.Replace("`", "%60");
            s = s.Replace("$", "%24");
            return s;
        }
    }
}
