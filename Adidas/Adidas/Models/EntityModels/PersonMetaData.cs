using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Adidas.Models.EntityModels
{
    internal class PersonMetaData
    {
        public int Id { get; set; }
        [DisplayName(" نام خانوادگی")]
        [Display(Name = " نام خانوادگی")]
        public string LastName { get; set; }
        [DisplayName("نام ")]
        [Display(Name = "نام ")]
        public string Name { get; set; }
        [DisplayName(" نام پدر ")]
        [Display(Name = "نام پدر ")]
        public string Father { get; set; }
        [DisplayName("تاریخ تولد ")]
        [Display(Name = "تاریخ تولد ")]
        public Nullable<System.DateTime> BirthDay { get; set; }
        [DisplayName("وضعیت نظام وظیفه ")]
        [Display(Name = "وضعیت نظام وظیفه ")]
        public Nullable<byte> MilitaryService { get; set; }
        [DisplayName("وضعیت تاهل ")]
        [Display(Name = "وضعیت تاهل ")]
        public Nullable<bool> Marriage { get; set; }
        [DisplayName("تعداد فرزندان ")]
        [Display(Name = "تعداد فرزندان ")]
        public Nullable<byte> Children { get; set; }
        [DisplayName("کدملی ")]
        [Display(Name = "کدملی ")]
        public string NationalCode { get; set; }
        [DisplayName("آدرس ")]
        [Display(Name = "آدرس ")]
        public string Address { get; set; }
        [DisplayName("تلفن ")]
        [Display(Name = "تلفن ")]
        public string Tell { get; set; }
        [DisplayName("موبایل ")]
        [Display(Name = "موبایل ")]
        public string Mobile { get; set; }
        [DisplayName("ایمیل ")]
        [Display(Name = "ایمیل ")]
        public string Email { get; set; }
        [DisplayName("آخرین مدرک تحصیلی ")]
        [Display(Name = "آخرین مدرک تحصیلی ")]
        public Nullable<byte> Degree { get; set; }
        [DisplayName("نام موسسه ")]
        [Display(Name = "نام موسسه ")]
        public string Institute { get; set; }
        [DisplayName("رشته تحصیلی ")]
        [Display(Name = "رشته تحصیلی ")]
        public string Field { get; set; }
        [DisplayName("آشنایی با زبان خارجه ")]
        [Display(Name = "آشنایی با زبان خارجه ")]
        public Nullable<byte> EnglishKnowledge { get; set; }
        [DisplayName("Excel ")]
        [Display(Name = "Excel ")]
        public Nullable<bool> Excel { get; set; }
        [DisplayName("Word ")]
        [Display(Name = "Word ")]
        public Nullable<bool> Word { get; set; }
        [DisplayName("Outlook ")]
        [Display(Name = "Outlook ")]
        public Nullable<bool> Outlook { get; set; }
        [DisplayName("PowerPoint ")]
        [Display(Name = "PowerPoint ")]
        public Nullable<bool> PowerPoint { get; set; }
        [DisplayName("حسابداری ")]
        [Display(Name = "حسابداری ")]
        public Nullable<bool> Accounting { get; set; }
        [DisplayName("غیره . ذکر نرم افزار ")]
        [Display(Name = "غیره . ذکر نرم افزار ")]
        public string OtherSoftwer { get; set; }
        [DisplayName("دوره های کامپیوتری ")]
        [Display(Name = "دوره های کامپیوتری ")]
        public string Skills { get; set; }
        [DisplayName("میزان حقوق درخواستی ")]
        [Display(Name = "میزان حقوق درخواستی ")]
        public string SalaryExpection { get; set; }
        [DisplayName("متقاضی کار ")]
        [Display(Name = "متقاضی کار ")]
        public Nullable<bool> JobStatus { get; set; }
        [DisplayName("چند روز در هفته ")]
        [Display(Name = "چند روز در هفته ")]
        public Nullable<byte> DaysNumber { get; set; }
        [DisplayName("آیا تعهد کاری 3 سال کار را می دهید؟ ")]
        [Display(Name = "آیا تعهد 3 سال کار را می دهید؟ ")]
        public Nullable<bool> WorkingGuranty { get; set; }
        [DisplayName("مدت تعهد کاری ")]
        [Display(Name = "مدت تعهد کاری ")]
        public string Duration { get; set; }
        [DisplayName("آیا در صورت همکاری مشکلی برای پرداخت ضمانت دارید؟ ")]
        [Display(Name = "آیا در صورت همکاری مشکلی برای پرداخت ضمانت دارید؟ ")]
        public Nullable<bool> GurantyPayment { get; set; }
        [DisplayName("جنسیت ")]
        [Display(Name = "جنسیت ")]
        public Nullable<bool> Gender { get; set; }
        public byte[] image { get; set; }
    }
}
namespace Adidas.Models.DomainModels
{
    [MetadataType(typeof(Adidas.Models.EntityModels.PersonMetaData))]
    public partial class Person
    {
        //[Required(AllowEmptyStrings = false, ErrorMessage = "رمز عبور خود را تکرار کنید")]
        //[DisplayName("تکرار رمز عبور")]
        //[Display(Name = "تکرار رمز عبور")]
        //[DataType(DataType.Password)]
        //[Compare("Password", ErrorMessage = "تکرار پسورد یکسان نیست")]
        //public string ConfirmPassword { get; set; }

    }
}