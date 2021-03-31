using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using DotNet5Practices.Services;
using Microsoft.AspNetCore.Mvc;

namespace DotNet5Practices.Components
{
    public class MyComponent:ViewComponent
    {
        private IUser _userServices;

        public MyComponent(IUser userServices)
        {
            _userServices = userServices;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("~/Pages/Shared/_MyComponent.cshtml",_userServices.GetAll());
        }
    }
}
