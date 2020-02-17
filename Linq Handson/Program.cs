using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqhandson
{
    class Program
    {
        static void Main(string[] args)
        {
            List <int> nums= new List<int>() {1,2,3,5 };
            List<int> nums2 = new List<int>() { 2, 3, 5, 6 };
            int res = nums.Except(nums2).Union(nums2.Except(nums)).Sum();
            Console.WriteLine(res);
            List<string> names = new List<string>() { "agobu", "jobu", "vobu" };
            string log = names.Where(s => s.Contains("a")).OrderBy(s => s.Length).First();
            Console.WriteLine(log);
            int res2 = nums2.Intersect(nums2).Sum();
            Console.WriteLine(res2);
            int l = 1, h = 2;
            int res3 = nums2.Skip(l).Take(h - 1).Count();
            Console.WriteLine(res3);
        }
    }
}
