using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Stack.API.Controllers.Common;
using Stack.DTOs.Models;
using Stack.Entities.Models;
using Stack.ServiceLayer;

namespace Stack.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdministratorController : BaseResultHandlerController<AdministratorService>
    {
        public AdministratorController(AdministratorService _service) : base(_service)
        {

        }

        //[HttpGet("getAdministrator")]
        //public async Task<IActionResult> getAdminByid(int adminId)
        //{
        //    return await GetResponseHandler(async () => await service.GetAdminByID(adminId));
        //}
        //[HttpPut("EditAdministrator")]
        //public async Task<IActionResult> EditAdminById(AdministratorDTO admin)
        //{
        //    return await EditItemResponseHandler(async () => await service.EditAdminById(admin));
        //}

    }
}
