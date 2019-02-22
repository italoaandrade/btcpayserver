﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BTCPayServer.Configuration.External
{
    public interface IAccessKeyService
    {
        SparkConnectionString ConnectionString { get; }
    }
    public class ExternalSpark : ExternalService, IAccessKeyService
    {
        public SparkConnectionString ConnectionString { get; }

        public ExternalSpark(SparkConnectionString connectionString)
        {
            if (connectionString == null)
                throw new ArgumentNullException(nameof(connectionString));
            ConnectionString = connectionString;
        }
    }
}
