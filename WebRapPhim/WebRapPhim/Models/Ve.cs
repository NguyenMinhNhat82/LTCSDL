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
    
    public partial class Ve
    {
        public int ID { get; set; }
        public Nullable<System.DateTime> NgayBan { get; set; }
        public Nullable<int> Ghe { get; set; }
        public Nullable<int> NVID { get; set; }
        public Nullable<int> CusId { get; set; }
        public Nullable<double> Gia { get; set; }
        public Nullable<int> IDGiamGia { get; set; }
        public Nullable<int> SuatChieuID { get; set; }
        public Nullable<int> LoaVe { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Ghe Ghe1 { get; set; }
        public virtual LoaiVe LoaiVe { get; set; }
        public virtual NhanVien NhanVien { get; set; }
        public virtual SuatChieu SuatChieu { get; set; }
        public virtual SuKien SuKien { get; set; }
    }
}