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
    
    public partial class PropertyHistory
    {
        public int HistoryId { get; set; }
        public Nullable<int> ComparableRecordId { get; set; }
        public Nullable<int> PropertyId { get; set; }
        public Nullable<int> JobId { get; set; }
        public Nullable<int> HistoryType { get; set; }
    
        public virtual ComparableRecord ComparableRecord { get; set; }
        public virtual Job Job { get; set; }
        public virtual Property Property { get; set; }
        public virtual Property Property1 { get; set; }
    }
}