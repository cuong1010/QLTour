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
    
    public partial class Tour
    {
        public Tour()
        {
            this.GiaTours = new HashSet<GiaTour>();
            this.CTTours = new HashSet<CTTour>();
            this.DoanKhaches = new HashSet<DoanKhach>();
        }
    
        public int Id { get; set; }
        public string TenGoi { get; set; }
        public string DacDiem { get; set; }
        public int LoaiDLId { get; set; }
    
        public virtual LoaiDL LoaiDL { get; set; }
        public virtual ICollection<GiaTour> GiaTours { get; set; }
        public virtual ICollection<CTTour> CTTours { get; set; }
        public virtual ICollection<DoanKhach> DoanKhaches { get; set; }
    }
}
