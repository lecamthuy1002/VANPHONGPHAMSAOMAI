//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class MAT_HANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MAT_HANG()
        {
            this.DONDATHANG_MATHANG = new HashSet<DONDATHANG_MATHANG>();
            this.HOADON_MATHANG = new HashSet<HOADON_MATHANG>();
        }
    
        public string MAMH { get; set; }
        public string TENMH { get; set; }
        public long GIABAN { get; set; }
        public string DVT { get; set; }
        public string MALOAI { get; set; }
        public string MOTA { get; set; }
        public bool VOHIEUHOA { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DONDATHANG_MATHANG> DONDATHANG_MATHANG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOADON_MATHANG> HOADON_MATHANG { get; set; }
        public virtual LOAI_MAT_HANG LOAI_MAT_HANG { get; set; }
    }
}
