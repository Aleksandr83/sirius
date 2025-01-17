﻿// Copyright (c) 2021 Lukin Aleksandr
using alg.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClient.Services.App
{
    internal interface IAppService : IService
    {
        String GetAppId();
        String GetAppName();
        String GetAppVersion();
        String GetAuthor();
        String GetAuthorEmail();
        String GetLicenseType();
        String GetCopyright();
        String GetConfigurationDataDir();        
        bool   IsExistConfigurationDataDir();
        void   CreateConfigurationDataDir();
        String GetConfigurationFileName();
        String GetConfigurationFile();
        bool   IsExistConfigurationFile();
        void   CreateConfigurationFile();
        void   InitConfiguration();
        dynamic GetConfiguration();
    }
}
