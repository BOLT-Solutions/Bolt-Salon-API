using Microsoft.AspNetCore.Mvc;
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
    public class QueueController : BaseResultHandlerController<QueueService>
    {
        public QueueController(QueueService _service) : base(_service)
        {

        }

        [HttpGet("GetBarberQueue/{barberId}")]
        public async Task<IActionResult> GetBarberQueue(int barberId)
        {
            return await GetResponseHandler(async () => await service.GetBarberQueueByBarberId(barberId));
        }

        [HttpPost("ReassignOrder")]
        public async Task<IActionResult> ReassignOrder (string orderId, string newQueueId)
        {
            return await AddItemResponseHandler(async () => await service.ReassignOrderToDifferentQueue(orderId, newQueueId));
        }

        [HttpGet("SetQueueWaitingTimes")]
        public async Task<IActionResult> SetQueueWaitingTimes()
        {
            return await GetResponseHandler(async () => await service.SetQueueWaitingTimes());
        }
        [HttpPost("AddOrderToQueue")]
        public async Task<IActionResult> AddOrderToQueue(OrderToAddDTO order)
        {
            return await AddItemResponseHandler(async () => await service.AddOrderToQueue(order));
        }
    }
}
