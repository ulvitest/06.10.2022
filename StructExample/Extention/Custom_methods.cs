using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace StructExample.Extention
{
    internal static class Custom_methods
    {
        public static int WordFinder(this string sentence,string name)
        {

            return Regex.Matches(sentence, name).Count;
        }


    }
}
