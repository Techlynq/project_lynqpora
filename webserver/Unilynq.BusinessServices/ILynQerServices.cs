using Unilynq.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unilynq.BusinessEntities;

namespace Unilynq.BusinessServices
{
    public interface ILynQerServices
    {
        LynQerEntity GetLynQerById(int id);
        IEnumerable<LynQerEntity> GetAllLynQers();
        int CreateLynQer(LynQerEntity lynQerEntity);
        bool UpdateLynQer(int lynQerId, LynQerEntity lynQerEntity);
        bool DeleteLynQer(int lynQerId);
        int Authenticate(string lynQName, string Rakeit);


    }
}
