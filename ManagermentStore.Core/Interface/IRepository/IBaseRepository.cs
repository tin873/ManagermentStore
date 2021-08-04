using System;
using System.Collections.Generic;

namespace ManagermentStore.Core
{
    public interface IBaseRepository<Entity> where Entity : class
    {
        /// <summary>
        /// thêm mới 1 bản ghi
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>thông tin bản ghi vừa thêm mới</returns>
        public int Add(Entity entity);
        /// <summary>
        /// sửa thông tin bản ghi
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>thông tin đã được sửa</returns>
        public int Update(Entity entity);
        /// <summary>
        /// xóa bỏ 1 bản ghi
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>thông tin bản ghi đã xóa</returns>
        public int Delete(Guid Id);
        /// <summary>
        /// lấy ra danh sách tất cả bản ghi
        /// </summary>
        /// <returns>danh sách bản ghi</returns>
        public IEnumerable<Entity> GetAll();
        /// <summary>
        /// lấy bản ghi theo mã
        /// </summary>
        /// <param name="Id"></param>
        /// <returns>bản ghi tìm thấy</returns>
        public Entity GetById(Guid Id);
    }
}
