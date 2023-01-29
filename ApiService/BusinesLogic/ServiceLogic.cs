using ApiService.ModelView;
using System.Security.Cryptography;
using System.Text;

namespace ApiService.BusinesLogic
{
    public class ServiceLogic : IServiceLogic
    {
        public string GetTriangleCategory(double side_a, double side_b, double side_c)
        {
            List<double> list = new List<double> { side_a, side_b, side_c }.OrderByDescending(x => x).ToList();
            double biggest = list[0];
            double medium = list[1];
            double smallest = list[2];

            if (biggest == medium)
            {
                if (biggest == smallest)
                    return "Equilateral triangle";
                else
                    return "Isosceles triangle";
            }
            else
            {

                if (Math.Pow(biggest, 2) == (Math.Pow(medium, 2) + Math.Pow(smallest, 2)))
                {
                    return "Right triangle";
                }
                else if (medium == smallest)
                {
                    return "Isosceles triangle";
                }
                else
                {
                    return "Any triangle";
                }

            }


        }

        public int GetFibonacci(int max)
        {
            int after0 = 0;
            int after = 0;
            int current = 0;

            for (int i = 0; i < max; i++)
            {
                if (i == 0)
                {
                    current = 0;
                }
                else if (i == 1)
                {
                    current = 1;
                    after = current;
                }
                else
                {
                    current = after + after0;
                    after0 = after;
                    after = current;
                }
            }
            return current;
        }

        public string ReverseWord(string word)
        {
            string result_word = "";
            for (int i = word.Length - 1; i >= 0; i--)
            {
                string sub_str = word.Substring(i, 1);
                result_word = $"{result_word}{sub_str}";
            }

            return result_word;
        }


        public HashModel HshMd5(string word)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.ASCII.GetBytes(word);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                return new HashModel { Algorithm = "MD5", Value = Convert.ToHexString(hashBytes).ToLower() };
            }

        }


    }
}
