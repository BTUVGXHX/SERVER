//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class embeddedVolunteer
    {
        public int embeddedVolunteersCode { get; set; }
        public int volunteerCode { get; set; }
        public System.DateTime volunteeringDate { get; set; }
        public int wardCode { get; set; }
        public int roleCode { get; set; }
        public System.TimeSpan beginningTime { get; set; }
        public System.TimeSpan endTime { get; set; }
    
        public virtual role role { get; set; }
        public virtual Volunteer Volunteer { get; set; }
        public virtual ward ward { get; set; }
    }
}
