//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebRapPhim.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Film
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Film()
        {
            this.SuatChieu = new HashSet<SuatChieu>();
            this.TheLoai = new HashSet<TheLoai>();
        }
    
        public int ID { get; set; }
        public string ten { get; set; }
        public Nullable<int> thoi_luong { get; set; }
        public string gioi_han_tuoi { get; set; }
        public Nullable<System.DateTime> ngay_cong_chieu { get; set; }
        public string ngon_ngu { get; set; }
        public string dao_dien { get; set; }
        public string dien_vien { get; set; }
        public string quoc_gia { get; set; }
        public string tom_tat { get; set; }
        public Nullable<bool> trang_thai { get; set; }
        public Nullable<int> loai_phim { get; set; }
        public Nullable<int> nha_cung_cap { get; set; }
        public string poster_link { get; set; }
        public string trailer { get; set; }
    
        public virtual NhaCungCap NhaCungCap { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SuatChieu> SuatChieu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TheLoai> TheLoai { get; set; }
    }
}
