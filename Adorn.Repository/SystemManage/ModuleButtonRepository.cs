using Adorn.Data;
using Adorn.Domain.Entity.SystemManage;
using Adorn.Domain.IRepository.SystemManage;
using Adorn.Repository.SystemManage;
using System.Collections.Generic;

namespace Adorn.Repository.SystemManage
{
    public class ModuleButtonRepository : RepositoryBase<ModuleButtonEntity>, IModuleButtonRepository
    {
        public void SubmitCloneButton(List<ModuleButtonEntity> entitys)
        {
            using (var db = new RepositoryBase().BeginTrans())
            {
                foreach (var item in entitys)
                {
                    db.Insert(item);
                }
                db.Commit();
            }
        }
    }
}
