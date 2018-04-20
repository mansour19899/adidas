using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Adidas.Models.EntityModels
{
    internal class JobRecordMetaData
    {
      
            public int Id { get; set; }
        [DisplayName("نام موسسه")]
        [Display(Name = "نام موسسه")]
        public string Company { get; set; }
        [DisplayName(" سمت کاری/نوع همکاری")]
        [Display(Name = "سمت کاری/نوع همکاری")]
        public string Title { get; set; }
        [DisplayName(" مدت اشتغال")]
        [Display(Name = "مدت اشتغال")]
        public string Duration { get; set; }
        [DisplayName(" علت قطع همکاری")]
        [Display(Name = "علت قطع همکاری")]
        public string Disconnection { get; set; }
        [DisplayName("آدرس")]
        [Display(Name = "آدرس")]
        public string Address { get; set; }
        [DisplayName("تلفن")]
        [Display(Name = "تلفن")]
        public string Tell { get; set; }

        public Nullable<int> Person_FK { get; set; }
        
    }
}

namespace Adidas.Models.DomainModels
{
    [MetadataType(typeof(Adidas.Models.EntityModels.JobRecordMetaData))]
    public partial class JobRecord
    {


    }
}