//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace mvchandson_mailapplication15_2
{
    using System;
    using System.Collections.Generic;
    
    public partial class maildetail
    {
        public int mailid { get; set; }
        public int userid { get; set; }
        public string mailfrom { get; set; }
        public string subject { get; set; }
        public System.DateTime recievedate { get; set; }
        public string message { get; set; }
    
        public virtual login login { get; set; }
    }
}
