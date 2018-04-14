using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using  Adidas.Models.DomainModels;
using Adidas.Models.EntityModels;

namespace Adidas.ViewModels
{
    public class PersonInfo
    {
        public Person Person { get; set; }
        public JobRecord JobRecord1 { get; set; }
        public JobRecord JobRecord2 { get; set; }
        public JobRecord JobRecord3 { get; set; }
        public RelationShip RelationShip1 { get; set; }
        public RelationShip RelationShip2 { get; set; }
        public RelationShip RelationShip3 { get; set; }
        public  DateOfBirth Date { get; set; }
        public PersonInfo()
        {
            
        }
    }
}