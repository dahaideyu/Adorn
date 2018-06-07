using Adorn.Data;
using Adorn.Domain.Entity.SystemManage;
using System.Collections.Generic;

namespace Adorn.Domain.IRepository.SystemManage
{
    public interface IItemsDetailRepository : IRepositoryBase<ItemsDetailEntity>
    {
        List<ItemsDetailEntity> GetItemList(string enCode);
    }
}
