//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Adidas.Models.DomainModels
{
    using System;
    using System.Collections.Generic;
    
    public partial class JobRecord
    {
        public int Id { get; set; }
        public string Company { get; set; }
        public string Title { get; set; }
        public string Duration { get; set; }
        public string Disconnection { get; set; }
        public string Address { get; set; }
        public string Tell { get; set; }
        public Nullable<int> Person_FK { get; set; }
    }
}