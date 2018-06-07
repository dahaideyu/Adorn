using Adorn.Data;
using Adorn.Domain.Entity.SystemManage;
using System.Collections.Generic;

namespace Adorn.Domain.IRepository.SystemManage
{
    public interface IModuleButtonRepository : IRepositoryBase<ModuleButtonEntity>
    {
        void SubmitCloneButton(List<ModuleButtonEntity> entitys);
    }
}
