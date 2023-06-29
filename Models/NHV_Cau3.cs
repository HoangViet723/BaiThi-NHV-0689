using System.ComponentModel.DataAnnotations;
namespace BaiThi_NHV.Models
{
    public class NHV_Cau3
    {
        [Key]
        [Display(Name = "Mã sinh viên")]
        public string NHVMaSV { get; set; }
        [Display(Name = "Tên sinh viên")]
        public string NHVTenSV { get; set; }
        [Display(Name = "SĐT sinh viên")]
        public int NHVSDT { get; set; }
    }
}