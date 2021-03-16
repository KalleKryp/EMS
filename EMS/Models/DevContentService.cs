using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EMS.Utilities;


namespace EMS.Models
{
    public class DevContentService : IContentService
    {
        public string GetHeader() => "Dev Content Header";
        public string GetBody() => "Dev Content Body";

    }
}
