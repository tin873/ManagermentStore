using System;

namespace ManagermentStore.Core
{
    public class BaseService<Entity> : IBaseService<Entity> where Entity : class
    {
        private readonly IBaseRepository<Entity> _baseRepository;
        private ServiceResult _serviceResult;
        public BaseService(IBaseRepository<Entity> baseRepository)
        {
            _baseRepository = baseRepository;
            _serviceResult = new ServiceResult();
        }
        public ServiceResult Delete(Guid Id)
        {
            if (CheckIsExits(Id))
            {
                var result = _baseRepository.Delete(Id);
                if (result > 0)
                {
                    _serviceResult.IsSuccess = true;
                    _serviceResult.Data = result;
                    _serviceResult.DevMsg = "Xóa thành công.";
                    _serviceResult.ResultCode = ResultCode.Success;
                    return _serviceResult;
                }
                else
                {
                    _serviceResult.IsSuccess = false;
                    _serviceResult.Data = result;
                    _serviceResult.DevMsg = "Thêm mới thất bại.";
                    _serviceResult.ResultCode = ResultCode.NotValid;
                    return _serviceResult;
                }
            }
            else
            {
                _serviceResult.IsSuccess = false;
                _serviceResult.Data = null;
                _serviceResult.DevMsg = "Không tìm thấy bản ghi.";
                _serviceResult.ResultCode = ResultCode.NotFound;
                return _serviceResult;
            }
        }
        public ServiceResult Add(Entity entity)
        {
            var result = _baseRepository.Add(entity);
            if (result > 0)
            {
                _serviceResult.IsSuccess = true;
                _serviceResult.Data = result;
                _serviceResult.DevMsg = "Thêm mới thành công.";
                _serviceResult.ResultCode = ResultCode.Success;
                return _serviceResult;
            }
            else
            {
                _serviceResult.IsSuccess = false;
                _serviceResult.Data = result;
                _serviceResult.DevMsg = "Thêm mới thất bại.";
                _serviceResult.ResultCode = ResultCode.NotValid;
                return _serviceResult;
            }
        }

        public ServiceResult GetAll()
        {
            var result = _baseRepository.GetAll();
            if (result != null)
            {
                _serviceResult.IsSuccess = true;
                _serviceResult.Data = result;
                _serviceResult.DevMsg = "Lấy thành công.";
                _serviceResult.ResultCode = ResultCode.Success;
                return _serviceResult;
            }
            else
            {
                _serviceResult.IsSuccess = false;
                _serviceResult.Data = null;
                _serviceResult.DevMsg = "Không tìm thấy kết quả.";
                _serviceResult.ResultCode = ResultCode.NotFound;
                return _serviceResult;
            }
        }

        public ServiceResult GetById(Guid Id)
        {
            var result = _baseRepository.GetById(Id);
            if (result != null)
            {
                _serviceResult.IsSuccess = true;
                _serviceResult.Data = result;
                _serviceResult.DevMsg = "Lấy thành công.";
                _serviceResult.ResultCode = ResultCode.Success;
                return _serviceResult;
            }
            else
            {
                _serviceResult.IsSuccess = false;
                _serviceResult.Data = null;
                _serviceResult.DevMsg = "Không tìm thấy kết quả.";
                _serviceResult.ResultCode = ResultCode.NotFound;
                return _serviceResult;
            }
        }

        public ServiceResult Update(Entity entity, Guid Id)
        {

            if(CheckIsExits(Id))
            {
                var result = _baseRepository.Update(entity);
                if (result > 0)
                {
                    _serviceResult.IsSuccess = true;
                    _serviceResult.Data = result;
                    _serviceResult.DevMsg = "Sửa thành công.";
                    _serviceResult.ResultCode = ResultCode.Success;
                    return _serviceResult;
                }
                else
                {
                    _serviceResult.IsSuccess = false;
                    _serviceResult.Data = result;
                    _serviceResult.DevMsg = "Sửa thất bại.";
                    _serviceResult.ResultCode = ResultCode.NotValid;
                    return _serviceResult;
                }
            }  
            else
            {
                _serviceResult.IsSuccess = false;
                _serviceResult.Data = null;
                _serviceResult.DevMsg = "Không tìm thấy bản ghi.";
                _serviceResult.ResultCode = ResultCode.NotFound;
                return _serviceResult;
            }    
        }
        public bool CheckIsExits(Guid Id)
        {
            if (_baseRepository.GetById(Id) != null)
                return true;
            else
                return false;
        }
    }
}
