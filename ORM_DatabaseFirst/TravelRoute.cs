//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ORM_DatabaseFirst
{
    using System;
    using System.Collections.Generic;
    
    public partial class TravelRoute
    {
        public int travelRouteId { get; set; }
        public Nullable<int> ownerCompanyId { get; set; }
        public string fromId { get; set; }
        public string toId { get; set; }
        public Nullable<System.DateTime> travelDate { get; set; }
    
        public virtual Company Company { get; set; }
    }
}
