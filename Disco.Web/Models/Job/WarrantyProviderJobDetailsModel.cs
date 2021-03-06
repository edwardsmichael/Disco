﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Disco.Web.Models.Job
{
    public class WarrantyProviderJobDetailsModel
    {
        public Type ViewType { get; set; }
        public object ViewModel { get; set; }

        public Exception JobDetailsException { get; set; }
        public bool JobDetailsSupported { get; set; }
        public string JobDetailsNotSupportedMessage { get; set; }
    }
}