using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace UsageDownloadRestfulSampleClient
{
    [DataContract]
    class UsageReportApiResponse
    {
        private DateTime reportMonth;

        public UsageReportApiResponse(UsageReportType type, DateTime reportMonth, string reportExtensionName, Byte[] reportFileStream)
        {
            this.Type = type;
            this.reportMonth = reportMonth;
            this.ReportExtensionName = reportExtensionName;
            this.ReportFileStream = reportFileStream;
            this.ObjectType = "Usage";
        }

        [DataMember]
        public UsageReportType Type { get; set; }

        public string ReportMonth
        {
            get
            {
                return reportMonth.ToString("yyyy-MM");
            }
        }

         [DataMember]
        public string ReportExtensionName { get; set; }

         [DataMember]
        public Byte[] ReportFileStream { get; set; }

         [DataMember]
        public string ObjectType { get; set; }
    }
}
