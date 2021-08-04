using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManagermentStore.Core
{
    [Table("Employee")]
    public class Employee
    {
        /// <summary>
        /// id nhân viên
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid EmployeeId { get; set; }
        /// <summary>
        /// mã nhân viên
        /// </summary>
        [Required]
        [MaxLength(20)]
        public string EmployeeCode { get; set; }
        /// <summary>
        /// ho tên
        /// </summary>
        public string Fullname { get; set; }
        /// <summary>
        /// địa chỉ
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// số điện thoại
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// khóa ngoại với bảng cửa hàng
        /// </summary>
        public Guid StoreId { get; set; }
        public virtual Store Store { get; set; }
    }
}
