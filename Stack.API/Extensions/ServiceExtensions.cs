
using Microsoft.Extensions.DependencyInjection;
using Stack.DTOs.Models;
using Stack.ServiceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stack.API.Extensions
{
    public static class ServiceExtensions
    {
        public static void AddBusinessServices(this IServiceCollection caller)
        {
            caller.AddScoped<UsersService>();
            caller.AddScoped<ServiceService>();
            caller.AddScoped<SmsService>();
            caller.AddScoped<AdministratorService>();
            caller.AddScoped<BarberService>();
            caller.AddScoped<FeedbackService>();
            caller.AddScoped<BarberService>();
            caller.AddScoped<CustomerService>();
            caller.AddScoped<QuestionFeedbackService>();
            caller.AddScoped<QueueService>();
            caller.AddScoped<OrdersService>();
            caller.AddScoped<DailyReportService>();
            caller.AddScoped<PromoCodeService>();
        }

    }
}
