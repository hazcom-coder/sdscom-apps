using System;

namespace SDSComApps.Models
{
    /// <remarks/>
    public class ErrorViewModel
    {
        /// <remarks/>
        public string RequestId { get; set; }

        /// <remarks/>
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}