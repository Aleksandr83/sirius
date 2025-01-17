﻿// Copyright (c) 2021 Lukin Aleksandr
using alg.Types.Generic;
using alg.Types.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alg.Data.Repositories
{
    public abstract class GenericRepository<T> : 
        IRepository where T : class 
    {
        public GenericRepository()
        {           
        }

        protected abstract String GetConnectionString();
        protected abstract String GetSpNameForGetAll();

        protected virtual RepositoryContext<T> GetContext(String connectionString)
        {
            return (string.IsNullOrEmpty(connectionString))? 
                new RepositoryContext<T>() : new RepositoryContext<T>(connectionString);
        }

        public virtual bool IsTestConnection()
        {
            try
            {
                using (var context = GetContext(GetConnectionString()))
                {
                    context.Database.Connection.Open();                   
                    context.Database.Connection.Close();
                    return true;
                }
            }
            catch (Exception) { }
            return false;
        }

        public virtual IList<T> GetAll()
        {
            dynamic   requestResult = null;
            IList<T>  result = new List<T>();
            using (var context = GetContext(GetConnectionString()))
            {
                try
                {
                    requestResult = context.Database?
                            .SqlQuery<T>(GetSpNameForGetAll())?
                            .ToList();
                }
                catch (Exception) { }   // temp
            }          
            foreach (var item in requestResult ?? List.Empty<T>())
               result?.Add((T)item);            
            return result;
        }
    }
}
