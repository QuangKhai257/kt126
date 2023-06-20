using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace kt126.Models;
public class SinhVien 
{
    [Key]
    [Display (Name = "Mã Sinh Viên ")]
    public string MaSinhVien {get;set;}

    [Display (Name = "Họ Tên")]
    public string HoTen {get; set;}

    [Display (Name = "Mã Lớp ")]
    public string Malop {get; set;}
    [ForeignKey ("Malop")]
    public LopHoc? LopHoc {get;set;}
}