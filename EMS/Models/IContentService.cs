﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMS.Models
{
    public interface IContentService
    {
        string GetHeader();

        string GetBody();
    }
}
