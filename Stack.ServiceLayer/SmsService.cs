﻿
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Stack.Core;
using Stack.Core.Managers;
using Stack.DTOs;
using Stack.DTOs.Enums;
using Stack.DTOs.Models;
using Stack.Entities.Models;
using Stack.ServiceLayer;

namespace Stack.ServiceLayer
{
    public class SmsService
    {
        private readonly UnitOfWork unitOfWork;
        private readonly IConfiguration config;

        public SmsService(UnitOfWork unitOfWork,IConfiguration config)
        {
            this.unitOfWork = unitOfWork;
            this.config = config;
        }
        public async Task<ApiResponse<String>> GetSMS()
        {
            ApiResponse<string> result = new ApiResponse<string>();

            try
            {
                var smsResult = await unitOfWork.SMSManager.GetAsync();

                List<SMS> smsList = smsResult.ToList();

                if (smsList.Count == 0)
                {
                    SMS newSMS = new SMS();

                    newSMS.Body = "Default";


                    var res = await unitOfWork.SMSManager.CreateAsync(newSMS);

                    await unitOfWork.SaveChangesAsync();

                    if (res != null)
                    {
                        result.Data = newSMS.Body;
                        result.Succeeded = true;
                        return result;
                    }
                    else
                    {
                        result.Succeeded = false;
                        result.Errors.Add("Failed to save initial SMS !");
                        return result;
                    }

                }    
                else
                {
                    result.Succeeded = true;
                    result.Data = smsList[0].Body;
                    return result;
                }
            }
            catch (Exception ex)
            {
                result.Succeeded = false;
                result.Errors.Add(ex.Message);
                return result;
            }

        }
        public async Task<ApiResponse<bool>> EditSMS(SmsDTO model)
        {
            ApiResponse<bool> result = new ApiResponse<bool>();
            try
            {

                var smsResult = await unitOfWork.SMSManager.GetAsync();

                List<SMS> smsList = smsResult.ToList();

                SMS smsToUpdate = smsList[0];

                smsToUpdate.Body = model.Body;

                var res = await unitOfWork.SMSManager.UpdateAsync(smsToUpdate);

                await unitOfWork.SaveChangesAsync();

                if (res == true)
                {
                    result.Data = true;
                    result.Succeeded = true;
                    return result;
                }
                else
                {
                    result.Succeeded = false;
                    result.Errors.Add("Failed to edit SMS !");
                    return result;
                }
            }
            catch (Exception ex)
            {
                result.Succeeded = false;
                result.Errors.Add(ex.Message);
                return result;
            }
        }
    }
}


