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
    
    public partial class SACH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SACH()
        {
            this.PHIEUMUONs = new HashSet<PHIEUMUON>();
            this.PHIEUTRAs = new HashSet<PHIEUTRA>();
        }
    
        public string MaSach { get; set; }
        public string TenSach { get; set; }
        public string LoaiSach { get; set; }
        public string TacGia { get; set; }
        public string NhaXuatBan { get; set; }
        public Nullable<System.DateTime> NgayXuatBan { get; set; }
        public Nullable<int> SoLuong { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUMUON> PHIEUMUONs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUTRA> PHIEUTRAs { get; set; }
    }
}
