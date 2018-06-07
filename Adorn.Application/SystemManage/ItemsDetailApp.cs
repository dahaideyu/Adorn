﻿using Adorn.Code;
using Adorn.Domain.Entity.SystemManage;
using Adorn.Domain.IRepository.SystemManage;
using Adorn.Repository.SystemManage;
using System.Collections.Generic;
using System.Linq;

namespace Adorn.Application.SystemManage
{
    public class ItemsDetailApp
    {
        private IItemsDetailRepository service = new ItemsDetailRepository();
        private IItemsRepository itemsService = new ItemsRepository();

        public List<ItemsDetailEntity> GetList(string itemId = "", string keyword = "")
        {
            var expression = ExtLinq.True<ItemsDetailEntity>();
            if (!string.IsNullOrEmpty(itemId))
            {
                expression = expression.And(t => t.F_ItemId == itemId);
            }
            if (!string.IsNullOrEmpty(keyword))
            {
                expression = expression.And(t => t.F_ItemName.Contains(keyword));
                expression = expression.Or(t => t.F_ItemCode.Contains(keyword));
            }
            return service.IQueryable(expression).OrderBy(t => t.F_SortCode).ToList();
        }

        public List<ItemsDetailEntity> GetListEnCode(string enCode)
        {
            var expression = ExtLinq.True<ItemsDetailEntity>();
            var parentEntity = itemsService.FindEntity(_ => _.F_EnCode == enCode);
            if (parentEntity != null)
            {
                return GetList(parentEntity.F_Id);
            }
            else
                return null;
        }

        public List<ItemsDetailEntity> GetItemList(string enCode)
        {
            return service.GetItemList(enCode);
        }
        public ItemsDetailEntity GetForm(string keyValue)
        {
            return service.FindEntity(keyValue);
        }
        public void DeleteForm(string keyValue)
        {
            service.Delete(t => t.F_Id == keyValue);
        }
        public void SubmitForm(ItemsDetailEntity itemsDetailEntity, string keyValue)
        {
            if (!string.IsNullOrEmpty(keyValue))
            {
                itemsDetailEntity.Modify(keyValue);
                service.Update(itemsDetailEntity);
            }
            else
            {
                itemsDetailEntity.Create();
                service.Insert(itemsDetailEntity);
            }
        }
    }
}
