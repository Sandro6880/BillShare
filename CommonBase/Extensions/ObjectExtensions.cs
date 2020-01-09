using System;
using System.Collections.Generic;
using System.Text;

namespace CommonBase.Extensions
{
    public static class ObjectExtensions
    {
        public static void CheckArgument(this string current,string name)
        {
            if(name == null)
            {
                name = current;
            }
        }
    }
}
