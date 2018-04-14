using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


    public  class DropDown
    {
        public static IEnumerable<SelectListItem> GetMilitaryList()
        {
            List<SelectListItem> items = new List<SelectListItem>
            {
                new SelectListItem{Text = "دارای کارت پایان خدمت", Value = "1"},
                new SelectListItem{Text = "معافیت تحصیلی", Value = "2"},
                new SelectListItem{Text = "معافیت پزشکی", Value = "3"},
                new SelectListItem{Text = "غایب", Value = "4"},
            };
            return items;
        }
    }
