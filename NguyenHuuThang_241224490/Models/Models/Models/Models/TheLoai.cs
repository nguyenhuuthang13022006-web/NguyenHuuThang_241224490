namespace NguyenHuuThang_241224490.Models.Models.Models.Models
{
    public class TheLoai
    {
        public int MaTl { get; set; }
        public string TenTl { get; set; } = null!;
        public virtual ICollection<Sach> Saches { get; set; } = new List<Sach>();
    }
}
