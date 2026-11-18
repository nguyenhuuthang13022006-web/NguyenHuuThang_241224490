namespace NguyenHuuThang_241224490.Models.Models.Models.Models
{
    public class Sach
    {
        public int MaSach { get; set; }
        public int MaTl { get; set; }
        public string TenSach { get; set; } = null!;   
        public decimal? Gia { get; set; }
        public string? Anh { get; set; }
        public virtual TheLoai MaTlNavigation { get; set; } = null!;
    }
}
