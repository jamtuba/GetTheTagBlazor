using GetTheTagBlazor.Shared.ModelsDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetTheTagBlazor.Client.Helpers
{
    public interface IHttpService
    {
        Task<TagDTO> Get<T>(string url);
    }
}
