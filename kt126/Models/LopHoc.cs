using System.ComponentModel.DataAnnotations;

namespace kt126.Models;
public class LopHoc 
{
    [Key]
    [Display (Name = "Mã Lớp")]
    public string MaLop {get; set;}

     [Display (Name = "Tên Lớp")]
    public string TenLop {get;set;}

}