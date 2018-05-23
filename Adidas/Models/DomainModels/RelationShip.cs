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
        public int Id { get; set; }
        public string Name { get; set; }
        public string Relational { get; set; }
        public string Tell { get; set; }
        public string Address { get; set; }
        public Nullable<int> Person_FK { get; set; }

        public virtual Person Person { get; set; }
    }
}
