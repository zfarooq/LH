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
    
    public partial class SecurityAction
    {
        public SecurityAction()
        {
            this.Permissions = new HashSet<Permission>();
        }
    
        public int Id { get; set; }
        public string ActionName { get; set; }
        public Nullable<int> ModuleItemId { get; set; }
    
        public virtual ModuleItem ModuleItem { get; set; }
        public virtual ICollection<Permission> Permissions { get; set; }
    }
}
