using DataModel.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using System.Transactions;
using BusinessEntities;
using DataModels.Models;

namespace BusinessServices
{
    public class LynQerServices : ILynQerServices
    {
        private readonly UnitOfWork _unitOfWork;

        public LynQerServices()
        {
            _unitOfWork = new UnitOfWork();
        }

        public LynQerEntity GetLynQerById(int id)
        {
            var lynQer = _unitOfWork.LynQerRepository.GetByID(id);
            if (lynQer != null)
            {
                Mapper.CreateMap<LynQer, LynQerEntity>();
                var lynQerModel = Mapper.Map<LynQer, LynQerEntity>(lynQer);
                return lynQerModel;
            }
            return null;
        }
        public IEnumerable<LynQerEntity> GetAllLynQers()
        {
            var lynQers = _unitOfWork.LynQerRepository.GetAll().ToList();
            if (lynQers.Any())
            {
                Mapper.CreateMap<LynQer, LynQerEntity>();
                var lynQersModel = Mapper.Map<List<LynQer>, List<LynQerEntity>>(lynQers);
                return lynQersModel;
            }
            return null;
        }
        public int CreateLynQer(LynQerEntity lynQerEntity)
        {
            //Registration change later
            using (var scope = new TransactionScope())
            {
                var lynQer = new LynQer
                {
                    LynQName = lynQerEntity.LynQName
                };
                _unitOfWork.LynQerRepository.Insert(lynQer);
                _unitOfWork.Save();
                scope.Complete();
                return lynQer.Id;
            }
        }
        public bool UpdateLynQer(int lynQerId, LynQerEntity lynQerEntity)
        {
            var success = false;
            if (lynQerEntity != null)
            {
                using (var scope = new TransactionScope())
                {
                    var lynQer = _unitOfWork.LynQerRepository.GetByID(lynQerId);
                    if (lynQer != null)
                    {
                        lynQer.LynQName = lynQerEntity.LynQName;
                        _unitOfWork.LynQerRepository.Update(lynQer);
                        _unitOfWork.Save();
                        scope.Complete();
                        success = true;
                    }
                }
            }
            return success;
        }
        public bool DeleteLynQer(int lynQerId)
        {
            var success = false;
            if (lynQerId > 0)
            {
                using (var scope = new TransactionScope())
                {
                    var lynQer = _unitOfWork.LynQerRepository.GetByID(lynQerId);
                    if (lynQer != null)
                    {

                        _unitOfWork.LynQerRepository.Delete(lynQer);
                        _unitOfWork.Save();
                        scope.Complete();
                        success = true;
                    }
                }
            }
            return success;
        }
    }
}
