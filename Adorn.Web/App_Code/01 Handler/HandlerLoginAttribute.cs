﻿using Microsoft.AspNetCore.Authorization;
using Adorn.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Adorn.Web
{
    public class HandlerLoginAttribute: AuthorizeAttribute
    {
       
        public HandlerLoginAttribute(bool ignore = true)
        {
            if (OperatorProvider.Provider.GetCurrent() == null)
            {
                WebHelper.WriteCookie("AuthCookie", "");
                HttpContext.Current.Response.Redirect("/Login/Index");
            }
        }
    }
}
