using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace Adidas.Models.DomainModels
{


    public  class Person
    {
        [Key]
        public int Id { get; set; }
        public string LastName { get; set; }
        public string Name { get; set; }
        public string Father { get; set; }
        public Nullable<System.DateTime> BirthDay { get; set; }
        public Nullable<byte> MilitaryService { get; set; }
        public bool Marriage { get; set; }
        public Nullable<byte> Children { get; set; }
        public string NationalCode { get; set; }
        public string Address { get; set; }
        public string Tell { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public Nullable<byte> Degree { get; set; }
        public string Institute { get; set; }
        public string Field { get; set; }
        public Nullable<byte> EnglishKnowledge { get; set; }
        public bool Excel { get; set; }
        public bool Word { get; set; }
        public bool Outlook { get; set; }
        public bool PowerPoint { get; set; }
        public bool Accounting { get; set; }
        public string OtherSoftwer { get; set; }
        public string Skills { get; set; }
        public string SalaryExpection { get; set; }
        public bool JobStatus { get; set; }
        public Nullable<byte> DaysNumber { get; set; }
        public bool WorkingGuranty { get; set; }
        public string Duration { get; set; }
        public bool GurantyPayment { get; set; }
        public bool Gender { get; set; }
        public byte[] image { get; set; }
        public Nullable<System.DateTime> RegPerson { get; set; }

        

    }
}
