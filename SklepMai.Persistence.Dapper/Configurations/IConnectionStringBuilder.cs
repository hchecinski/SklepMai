using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SklepMai.Persistence.Dapper.Configurations
{
    public interface IConnectionStringBuilder
    {
        string GetConnectionString { get; }
    }
}