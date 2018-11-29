using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "RESTServiceImpl" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select RESTServiceImpl.svc or RESTServiceImpl.svc.cs at the Solution Explorer and start debugging.
    public class RESTServiceImpl : IRESTServiceImpl
    {   /*
        public void DoWork()
        {
        }
        public string XMLData(string id)
        {
            return "You requested product " + id;
        }
        public string JSONData(string id)
        {
            return "You requested product " + id;
        }*/
        public int Fibonacci(int n)
        {
            if (n <= 1)
                return n;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
        public string reverse(String sentence)
        {
            sentence += " ";

            string retval = string.Empty;
            int pos = 0;
            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] == ' ')
                {
                    string tmp = sentence.Substring(pos, i - pos);
                    retval += new string(tmp.Reverse().ToArray()) + " ";
                    pos = i + 1;
                }
            }

            return retval.Trim();
        }


        public String getToken()
        {
            return "https://join.readify.net/Status/1c3d1467-9a0f-49c2-bfc6-e30e99e827ef";
        }

        public String TriangleType(int a, int b, int c)
        {

            String result = "Error";

            if (a <= 0 || b <= 0 || c <= 0) return "Error"; // added test
            if (a == b && b == c) return "EQUILATERAL";
            if (a >= b + c || c >= b + a || b >= a + c) return "Error";
            if (b == c || a == b || c == a) return "ISOSCELES";

            return result;
        }
    }
}
