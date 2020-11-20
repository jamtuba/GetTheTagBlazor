using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetTheTagBlazor.Client.Helpers
{
    public interface IConfigService
    {
        string GetUrl(string head, string part);
    }
}
