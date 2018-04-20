using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Adidas.Models.EntityModels
{
    internal class RelationShipMetaData
    {
        public int Id { get; set; }
        [DisplayName("نام و نام خانوادگی")]
        [Display(Name = "نام و نام خانوادگی")]
        public string Name { get; set; }
        [DisplayName("نسبت ")]
        [Display(Name = "نسبت ")]
        public string Relational { get; set; }
        [DisplayName("تلفن ")]
        [Display(Name = "تلفن ")]
        public string Tell { get; set; }
        [DisplayName("آدرس ")]
        [Display(Name = "آدرس ")]
        public string Address { get; set; }
     
        public Nullable<int> Person_FK { get; set; }
    }
}
namespace Adidas.Models.DomainModels
{
    [MetadataType(typeof(Adidas.Models.EntityModels.RelationShipMetaData))]
    public partial class RelationShip
    {


    }
}