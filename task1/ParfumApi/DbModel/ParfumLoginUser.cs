//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ParfumApi.DbModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class ParfumLoginUser
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Password { get; set; }
        public Nullable<bool> IsAdmin { get; set; }
        public Nullable<bool> IsEmployee { get; set; }
        public Nullable<bool> IsUser { get; set; }
        public Nullable<bool> IsActive { get; set; }
    }
}
