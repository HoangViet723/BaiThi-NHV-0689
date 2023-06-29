using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Models.NHV_Cau3;

namespace BaiThi_NHV.Models
{
    public class NHV_Lop
    {
        [Key]
        [Display(Name = "Mã lớp")]
        public string NHVMaLop { get; set; }
        [Display(Name = "Tên lớp")]
        public string NHVTenLop { get; set; }
        
        [Display(Name = "Tên sinh viên")]
        [ForeignKey]
        public string NHVTenSV { get; set; }
        public NHV_Cau3? NHV_Cau3 { get; set; }
    }
}