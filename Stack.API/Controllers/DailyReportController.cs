﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Stack.API.Controllers.Common;
using Stack.DTOs.Models;
using Stack.ServiceLayer;

namespace Stack.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DailyReportController : BaseResultHandlerController<DailyReportService>
    {
        public DailyReportController(DailyReportService _service) : base(_service)
        {

        }

        [HttpPost("SaveDailyReport")]

        public async Task<IActionResult> SaveDailyReport(DailyReportDTO dailyReport)
        {
            return await AddItemResponseHandler(async () => await service.SaveDailyReport(dailyReport));
        }

        [HttpGet("GetTotalNumberCustomerForToday")]

        public async Task<IActionResult> GetTotalNumberCustomerForToday( )
        {
            return await GetResponseHandler(async () => await service.GetTotalNumberCustomerForToday( ));
        }
        [HttpGet("GetTotalServiceCostForToday")]

        public async Task<IActionResult> GetTotalServiceCostForToday( )
        {
            return await GetResponseHandler(async () => await service.GetTotalServiceCostForToday( ));
        }
        [HttpGet("GetAverageOfWaitingTimeForToday")]

        public async Task<IActionResult> GetAverageOfWaitingTimeForToday( )
        {
            return await GetResponseHandler(async () => await service.GetAverageOfWaitingTimeForToday(  ));
        }
        [HttpGet("GetNumberOfSignedInBarbersForToday")]

        public async Task<IActionResult> GetNumberOfSignedInBarbersForToday()
        {
            return await GetResponseHandler(async () => await service.GetNumberOfSignedInBarbersForToday( ));
        }
        [HttpGet("GetTotalAmountOfCostPerDay")]

        public async Task<IActionResult> GetTotalAmountOfCostPerDay()
        {
            return await GetResponseHandler(async () => await service.GetTotalAmountOfCostPerDay());
        }

        [HttpGet("GetTotalServiceCostByPeriod/{filter}")]

        public async Task<IActionResult> GetTotalServiceCost(string filter)
        {
            return await GetResponseHandler(async () => await service.GetTotalServiceCost(filter));
        }
        [HttpGet("GetTotalNumberCustomerByPeriod/{filter}")]

        public async Task<IActionResult> GetTotalNumberCustomer(string filter)
        {
            return await GetResponseHandler(async () => await service.GetTotalNumberCustomer(filter));
        }
        [HttpGet("GetAverageOfWaitingTimeByPeriod/{filter}")]

        public async Task<IActionResult> GetAverageOfWaitingTime(string filter)
        {
            return await GetResponseHandler(async () => await service.GetAverageOfWaitingTime(filter));
        }
        [HttpGet("GetNumberOfSignedInBarbersByPeriod/{filter}")]

        public async Task<IActionResult> GetNumberOfSignedInBarbers(string filter)
        {
            return await GetResponseHandler(async () => await service.GetNumberOfSignedInBarbers(filter));
        }
    }
}
