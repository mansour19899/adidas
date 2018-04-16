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
                new SelectListItem{Text = "مرد", Value = "1"},
                new SelectListItem{Text = "زن", Value = "0"}
            };
            return items;
        }

        public static IEnumerable<SelectListItem> GetMarrigeList()
        {
            List<SelectListItem> items = new List<SelectListItem>
            {
                new SelectListItem{Text = "مجرد", Value = "1"},
                new SelectListItem{Text = "متاهل", Value = "0"}
            };
            return items;
        }
}
