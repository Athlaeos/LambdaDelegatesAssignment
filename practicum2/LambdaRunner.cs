using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace practicum2
{
    class LambdaRunner
    {
        public static String RunAllMethods(int num1, int num2, int num3)
        {
            StringBuilder output = new StringBuilder();

            //TimesThree
            Func<int, int> timesThree = x => 3 * x;
            output.AppendFormat("TimesThree({0}) = {1}\n", num1, timesThree(num1));

            //AddNumbers
            Func<int, int, int, int> addUp = (a, b, c) => a + b + c;
            output.AppendFormat("AddNumbers({0},{1},{2}) = {3}\n", num1, num2,num3, addUp(num1,num2,num3));

            //IsEven
            Func<int, bool> isEven = x => x % 2 == 0;
            output.AppendFormat("IsEven({0}) = {1}\n", num1, isEven(num1));

            //Num2String
            Func<int, string> convert = num2string;
            output.AppendFormat("Num2String({0}) = {1}\n", num1, convert(num1));

            //InBetween
            Func<int, int, int, bool> inBetween = (x, y, z) => (x < y && y < z) || (z < y && y < x);
            output.AppendFormat("InBetween({0},{1},{2}) = {3}\n", num1, num2, num3, inBetween(num1,num2,num3));

            //ResetName
            Predicate<Person> resetName = ResetName;
            Person p = new Person() {Name = "Dirk"};
            output.AppendFormat("ResetName, daarna (Name == null) = {0}\n",resetName(p));

            return output.ToString();
        }

        private static bool ResetName(Person p){
            p.Name = null;
            if (p.Name == null){
                return true;
            } else {
                return false;
            }
        }

        private static String num2string(int x)
        {
            switch (x)
            {
                case 0:
                    return "zero"; break;
                case 1:
                    return "one"; break;
                case 2:
                    return "two"; break;
                case 3:
                    return "three"; break;
                case 4:
                    return "four"; break;
                case 5:
                    return "five"; break;
                case 6:
                    return "six"; break;
                case 7:
                    return "seven"; break;
                case 8:
                    return "eight"; break;
                case 9:
                    return "nine"; break;
                default:
                    return "undefined"; break;
            }
        }
    }
}
