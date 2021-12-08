﻿// Copyright (c) 2021 Lukin Aleksandr
using alg.Services;
using alg.Types.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClient.Services.Commands
{
    interface ICommandsService : IService
    {
        void CommandRegistration(ICommand command);
        ICommand GetCommandByName(String commandName);     
        
    }
}
