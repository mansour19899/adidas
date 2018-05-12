using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;



    public static  class utilty
    {

    public static string ToLowerFirst(this string str)
    {
        return str.Substring(0, 1).ToLower() + str.Substring(1);
    }


}
