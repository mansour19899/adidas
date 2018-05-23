using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace Adidas.Models.DomainModels
{


    public  class RelationShip
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Relational { get; set; }
        public string Tell { get; set; }
        public string Address { get; set; }
        public bool Moaref { get; set; }
        public bool Moarefff { get; set; }
        public  int Person_FK { get; set; }

        
    }
}
