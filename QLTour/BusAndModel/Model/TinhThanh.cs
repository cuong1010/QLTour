//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BusAndModel.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class TinhThanh
    {
        public TinhThanh()
        {
            this.DiaDiems = new HashSet<DiaDiem>();
        }
    
        public int Id { get; set; }
        public string MaTinh { get; set; }
        public string TenTinh { get; set; }
    
        public virtual ICollection<DiaDiem> DiaDiems { get; set; }
    }
}