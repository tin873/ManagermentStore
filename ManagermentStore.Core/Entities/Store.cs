using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManagermentStore.Core
{
    [Table("Store")]
    public class Store
    {
        public Store()
        {
            Employees = new HashSet<Employee>();
        }
        /// <summary>
        /// khóa chính
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid StoreId { get; set; }
        /// <summary>
        /// mã cửa hàng
        /// </summary>
        [Required]
        [MaxLength(20)]
        public string StoreCode { get; set; }
        /// <summary>
        /// tên cửa hàng
        /// </summary>
        [Required]
        [MaxLength(255)]
        public string StoreName { get; set; }
        /// <summary>
        /// địa chỉ
        /// </summary>
        [Required]
        [MaxLength(255)]
        public string Address { get; set; }
        /// <summary>
        /// số điện thoại
        /// </summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// trạng thái cửa hàng (0- đang hoạt động. 1- đóng cửa)
        /// </summary>
        public bool? Status { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
