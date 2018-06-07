using Adorn.Application.SystemManage;
using Adorn.Domain.Entity.SystemManage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Adorn.Web
{
    public class UserProvider
    {
        /// <summary>
        /// 获取当前登录的用户信息
        /// </summary>
        /// <returns></returns>
        public static UserEntity GetCurrentUser()
        {
            var userApp = new UserApp();
            var userEntity = userApp.GetForm(HttpContext.Current.User.Identity.Name);
            return userEntity;
        }
    }
}
