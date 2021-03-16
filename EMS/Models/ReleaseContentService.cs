using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EMS.Utilities;

namespace EMS.Models
{
    public class ReleaseContentService : IContentService
    {
        public string GetHeader() => "Release Content Header";
        public string GetBody() => "Release Content Body";

    }
}
