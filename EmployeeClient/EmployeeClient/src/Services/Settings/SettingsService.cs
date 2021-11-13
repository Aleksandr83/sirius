﻿// Copyright (c) 2021 Lukin Aleksandr
using EmployeeClient.Helpers;
using EmployeeClient.Services.App;
using EmployeeClient.Types.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClient.Services.Settings
{
    internal class SettingsService:ISettingsService
    {
        public string GetStringValue
            (String section, String parameterName, String defaultValue)
        {
            String result;
            var configuration = GetConfiguration();
            result = configuration
                .GetSection(string.Format("{0}:{1}", section, parameterName))
                .Value;
            if (String.IsNullOrEmpty(result)) result = defaultValue;
            return result;
        }

        public void SetStringValue
            (String section, String parameterName,String value = "")
        {            
            var configuration = GetConfiguration();
            configuration
                .GetSection(string.Format("{0}:{1}",section, parameterName))
                .Value = value;
        }

        public bool GetBoolValue
            (String section, String parameterName, bool defaultValue = false)
        {
            bool result = defaultValue;           
            var configuration = GetConfiguration();
            var s = configuration
                .GetSection(string.Format("{0}:{1}", section, parameterName))
                .Value;
            bool.TryParse(s, out result);
            return result;
        }
        public void SetBoolValue
            (String section, String parameterName, bool value = false)
        {
            var configuration = GetConfiguration();
            configuration
                .GetSection(string.Format("{0}:{1}", section, parameterName))
                .Value = value.ToString()?.Normalize();
        }
        
        private IConfiguration GetConfiguration()
        {
            return (IConfiguration)(ServicesManager
                .GetService<IAppService>() as IAppService)?
                .GetConfiguration();
        }

        public void Save()
        {           
            GetConfiguration().Save();
        }
    }
}