using Adorn.Code;
using Adorn.Domain.Entity.SystemManage;
using Adorn.Domain.IRepository.SystemManage;
using Adorn.Repository.SystemManage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Adorn.Application.SystemManage
{
    public class ModuleApp
    {
        private IModuleRepository service = new ModuleRepository();

        public List<ModuleEntity> GetList()
        {
            var expression = ExtLinq.True<ModuleEntity>();
            if (!HttpContext.Current.Request.Headers["Referer"].ToString().Contains("SystemManage/Module/Index"))
                expression = expression.And(_ => _.F_EnabledMark == true);
            return service.IQueryable(expression).OrderBy(t => t.F_SortCode).ToList();
        }
        public ModuleEntity GetForm(string keyValue)
        {
            return service.FindEntity(keyValue);
        }
        public void DeleteForm(string keyValue)
        {
            if (service.IQueryable().Count(t => t.F_ParentId.Equals(keyValue)) > 0)
            {
                throw new Exception("删除失败！操作的对象包含了下级数据。");
            }
            else
            {
                service.Delete(t => t.F_Id == keyValue);
            }
        }
        public void SubmitForm(ModuleEntity moduleEntity, string keyValue)
        {
            if (!string.IsNullOrEmpty(keyValue))
            {
                moduleEntity.Modify(keyValue);
                service.Update(moduleEntity);
            }
            else
            {
                moduleEntity.Create();
                service.Insert(moduleEntity);
            }
        }
    }
}
