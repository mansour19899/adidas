using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace Adidas.Models.DomainModels
{


    public  class JobRecord
    {
        public int Id { get; set; }
        public string Company { get; set; }
        public string Title { get; set; }
        public string Duration { get; set; }
        public string Disconnection { get; set; }
        public string Address { get; set; }
        public string Tell { get; set; }
        public Nullable<int> Person_FK { get; set; }

        public virtual Person Person { get; set; }
    }
}
