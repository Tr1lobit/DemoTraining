//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Demo_Afonichev.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Event
    {
        public int EventId { get; set; }
        public string Name { get; set; }
        public System.DateTime Date { get; set; }
        public int Days { get; set; }
        public Nullable<int> CityId { get; set; }
        public int DirectionId { get; set; }
        public Nullable<int> WinnerId { get; set; }
        public string Logo { get; set; }
    
        public virtual City City { get; set; }
        public virtual Direction Direction { get; set; }
        public virtual Member Member { get; set; }
    }
}
