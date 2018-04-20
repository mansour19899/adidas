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
                new SelectListItem{Text = "---------------------------", Value = "0"},
                new SelectListItem{Text = "دارای کارت پایان خدمت", Value = "1"},
                new SelectListItem{Text = "معافیت تحصیلی", Value = "2"},
                new SelectListItem{Text = "معافیت پزشکی", Value = "3"},
                new SelectListItem{Text = "غایب", Value = "4"},
            };
            return items;
        }

        public static IEnumerable<SelectListItem> GetDegreeList()
        {
            List<SelectListItem> items = new List<SelectListItem>
            {
                new SelectListItem{Text = "دیپلم", Value = "1"},
                new SelectListItem{Text = "کاردانی", Value = "2"},
                new SelectListItem{Text = "کارشناسی", Value = "3"},
                new SelectListItem{Text = "کارشناسی ارشد", Value = "4"},
                new SelectListItem{Text = "در حین تحصیل", Value = "5"}
              };
            return items;
        }

        public static IEnumerable<SelectListItem> GetKnowledgeList()
        {
            List<SelectListItem> items = new List<SelectListItem>
            {
                new SelectListItem{Text = "ابتدایی", Value = "1"},
                new SelectListItem{Text = "متوسط", Value = "2"},
                new SelectListItem{Text = "خوب", Value = "3"}
              
            };
            return items;
        }

        public static IEnumerable<SelectListItem> GetGenderList()
        {
            List<SelectListItem> items = new List<SelectListItem>
            {
                new SelectListItem{Text = "مرد", Value = "True"},
                new SelectListItem{Text = "زن", Value = "False"}
            };
            return items;
        }

        public static IEnumerable<SelectListItem> GetMarrigeList()
        {
            List<SelectListItem> items = new List<SelectListItem>
            {
                new SelectListItem{Text = "مجرد", Value = "True"},
                new SelectListItem{Text = "متاهل", Value = "False"}
            };
            return items;
        }

    public static IEnumerable<SelectListItem> GetJobStatusList()
    {
        List<SelectListItem> items = new List<SelectListItem>
            {
                new SelectListItem{Text = "تمام وقت", Value = "True"},
                new SelectListItem{Text = "نیمه وقت", Value = "False"}
            };
        return items;
    }

    public static IEnumerable<SelectListItem> GetYesOrNoList()
    {
        List<SelectListItem> items = new List<SelectListItem>
            {
                new SelectListItem{Text = "بله", Value = "True"},
                new SelectListItem{Text = "خیر", Value = "False"}
            };
        return items;
    }

    public static IEnumerable<SelectListItem> GetDaysList()
    {
        List<SelectListItem> items = new List<SelectListItem>
            {
              new SelectListItem{Text = "------------------------", Value = "0"},
                new SelectListItem{Text = " 1 روز", Value = "1"},
                new SelectListItem{Text = "2 روز", Value = "2"},
                new SelectListItem{Text = "3 روز", Value = "3"},
                new SelectListItem{Text = " 4 روز", Value = "4"},
                new SelectListItem{Text = "5 روز  ", Value = "5"},
                  new SelectListItem{Text = "6 روز  ", Value = "6"}
              };
        return items;
    }


}
