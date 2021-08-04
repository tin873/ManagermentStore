using System;

namespace ManagermentStore.Core
{
    public interface IBaseService<Entity>
    {
        /// <summary>
        /// thêm mới 1 bản ghi
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public ServiceResult Add(Entity entity);
        /// <summary>
        /// sửa thông tin bản ghi
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public ServiceResult Update(Entity entity, Guid Id);
        /// <summary>
        /// xóa bỏ 1 bản ghi
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public ServiceResult Delete(Guid Id);
        /// <summary>
        /// lấy ra danh sách tất cả bản ghi
        /// </summary>
        /// <returns></returns>
        public ServiceResult GetAll();
        /// <summary>
        /// lấy bản ghi theo mã
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public ServiceResult GetById(Guid Id);
    }
}
