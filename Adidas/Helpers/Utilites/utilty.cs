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

    public static string ConvertNumbersToPersian(this string str)
    {
        return str.Replace("0", "۰").Replace("1", "۱").Replace("2", "۲").Replace("3", "۳").Replace("4", "۴").Replace("5", "۵").Replace("6", "۶").Replace("7", "۷").Replace("8", "۸").Replace("9", "۹");
    }

    public static string ConvertNumbersToEnglish(this string str)
    {
        return str.Replace("۰", "0").Replace("۱", "1").Replace("۲", "2").Replace("۳", "3").Replace("۴", "4").Replace("۵", "5").Replace("۶", "6").Replace("۷", "7").Replace("۸", "8").Replace("۹", "9");
    }

}
