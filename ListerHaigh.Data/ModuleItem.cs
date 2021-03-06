//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ListerHaigh.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class ModuleItem
    {
        public ModuleItem()
        {
            this.Permissions = new HashSet<Permission>();
            this.SecurityActions = new HashSet<SecurityAction>();
        }
    
        public int Id { get; set; }
        public int DashboardSectionId { get; set; }
        public int ModuleId { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Url { get; set; }
        public int SortOrder { get; set; }
        public Nullable<bool> isVisible { get; set; }
    
        public virtual DashboardSection DashboardSection { get; set; }
        public virtual Module Module { get; set; }
        public virtual ICollection<Permission> Permissions { get; set; }
        public virtual ICollection<SecurityAction> SecurityActions { get; set; }
    }
}
