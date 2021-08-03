using System;
using System.ComponentModel;
using System.Configuration;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace UsageDownloadRestfulSampleClient
{
    internal class UsageDownloadHelper
    {
        private readonly string downloadUsageByMonthUrlTemplate;
        private readonly string getUsageListUrlTemplate;
        private readonly string downloadPaginatedUsageByMonthUrlTemplate;

        public UsageDownloadHelper()
        {
            downloadUsageByMonthUrlTemplate = string.Format(@"{0}?month={{1}}&type={{2}}&fmt={{3}}", ConfigurationManager.AppSettings["UsageReportAPIUrl"]);
            downloadPaginatedUsageByMonthUrlTemplate = string.Format(@"{0}?month={{1}}&fmt={{2}}&pageindex={{3}}", ConfigurationManager.AppSettings["PaginatedUsageReportAPIUrl"]);
            getUsageListUrlTemplate = ConfigurationManager.AppSettings["UsageReportListAPIUrl"];
        }


        public string GetEnrollmentUsageByMonth(DateTime month, UsageReportType type, string enrollmentNumber, string jwt, string format, bool throwWebException= false)
        {
            string url = string.Format(downloadUsageByMonthUrlTemplate, enrollmentNumber, month, type, format);
            string response = GetResponse(url, jwt, throwWebException);
            return response;
        }

        public async Task<string> GetEnrollmentPaginatedUsageByMonth(DateTime month, string enrollmentNumber, string jwt, string format,int Pageindex, bool throwWebException = false)
        {
            string url = string.Format(downloadPaginatedUsageByMonthUrlTemplate, enrollmentNumber, month, format,Pageindex);
            string response = await GetPaginatedResponse(url, jwt, throwWebException);
            return response;
        }

        public string GetEnrollmentUsageList(string enrollmentNumber, string jwt, bool throwWebException = false)
        {
            string url = string.Format(getUsageListUrlTemplate, enrollmentNumber);
            string response = GetResponse(url, jwt, throwWebException);
            return response;
        }

        public string GetResponse(string url, string jwt, bool throwException)
        {
            WebRequest request = WebRequest.Create(url);
            if (!string.IsNullOrEmpty(jwt))
            {
                AddHeaders(request, jwt);
            }
            HttpWebResponse response = null;
            try
            {
             
                response = (HttpWebResponse)request.GetResponse();
            }
            catch (WebException ex)
            {
                if (throwException)
                {
                    throw;
                }

                response = (HttpWebResponse)ex.Response;
            }

            using (StreamReader reader = new StreamReader(response.GetResponseStream()))
            {
                var contentType = response.Headers["Content-Type"];

                string s = (int)response.StatusCode + "\t" + response.StatusDescription + "\r\n"
                    + response.Headers + "\r\n"
                    + reader.ReadToEnd();

               
                return s;
            }
        }


        public async Task<string> GetPaginatedResponse(string url, string jwt, bool throwException)
        {
            WebRequest request = WebRequest.Create(url);
            if (!string.IsNullOrEmpty(jwt))
            {
                AddHeaders(request, jwt);
            }
            HttpWebResponse response = null;
            try
            {

                response = (HttpWebResponse) await request.GetResponseAsync();
            }
            catch (WebException ex)
            {
                if (throwException)
                {
                    throw;
                }

                response = (HttpWebResponse)ex.Response;
            }

            using (StreamReader reader = new StreamReader(response.GetResponseStream()))
            {
                var contentType = response.Headers["Content-Type"];

                string s = (int)response.StatusCode + "\t" + response.StatusDescription + "\r\n"
                    + response.Headers + "\r\n"
                    +  reader.ReadToEndAsync().GetAwaiter().GetResult();


                return s;
            }
        }

        public string GetEnrollmentUsageByMonthStream(DateTime month, UsageReportType type, string enrollmentNumber, string jwt, string format, bool loadAll = false, bool throwWebException = false)
        {
            string url = string.Format(downloadUsageByMonthUrlTemplate, enrollmentNumber, month, type, format);
            string response = GetResponseStream(url, jwt, loadAll, throwWebException);
            return response;
        }

        public string GetEnrollmentPaginatedUsageByMonthStream(DateTime month, string enrollmentNumber, string jwt, string format,int pageindex, bool loadAll = false, bool throwWebException = false)
        {
            string url = string.Format(downloadPaginatedUsageByMonthUrlTemplate, enrollmentNumber, month,format, pageindex);
            string response = GetResponseStream(url, jwt, loadAll, throwWebException);
            return response;
        }


        public string GetResponseStream(string url, string jwt, bool loadAll, bool throwException)
        {
            WebRequest request = WebRequest.Create(url);

            //keep request openning for 5 minutes. the socket will close either file is downloaded or socket opening for longer than 5 minutes
            request.Timeout = 1000 * 60 * 5;
            if (!string.IsNullOrEmpty(jwt))
            {
                AddHeaders(request, jwt);
            }
            string ret = string.Empty;
            try
            {
                HttpWebResponse response = null;
                try
                {
                    response = (HttpWebResponse)request.GetResponse();
                }
                catch (WebException ex)
                {
                    if (throwException)
                    {
                        throw;
                    }

                    response = (HttpWebResponse)ex.Response;
                }

                if (!Directory.Exists("c:/temp"))
                {
                    Directory.CreateDirectory("c:/temp");
                }

                var localfile = "c:/temp/output-" + Guid.NewGuid() + ".txt";

                using (FileStream writeStream = new FileStream(localfile, FileMode.Create, FileAccess.Write))
                {
                    // write to the stream
                    ReadWriteStream(response.GetResponseStream(), writeStream);


                    using (StreamReader sr = new StreamReader(localfile))
                    {
                        StringBuilder sb = new StringBuilder();
                        char[] c = null;
                        int i = 0;

                        //by default, we load 10 batches.
                        while (sr.Peek() >= 0 && i < 10)
                        {
                            c = new char[1024];
                            sr.Read(c, 0, c.Length);
                            sb.Append(c);
                            if (!loadAll)
                            {
                                i++;
                            }
                        }
                        string s = (int)response.StatusCode + "\t" + response.StatusDescription + "\r\n"
                                   + response.Headers + "\r\n";
                        ret = string.Concat(s, sb.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                ret = ex.Message;
            }
            return ret;
        }


        public void ReadWriteStream(Stream readStream, Stream writeStream)
        {
            int Length = 4096;
            Byte[] buffer = new Byte[Length];
            int bytesRead = readStream.Read(buffer, 0, Length);
            // write the required bytes
            while (bytesRead > 0)
            {
                writeStream.Write(buffer, 0, bytesRead);
                bytesRead = readStream.Read(buffer, 0, Length);
                writeStream.Flush();
            }
            readStream.Close();
            writeStream.Close();
        }

        public void AddHeaders(WebRequest request, string jwt)
        {
            string bearerTokenHeader = BearerToken.FromJwt(jwt).BearerTokenHeader;
            request.Headers.Add("authorization", bearerTokenHeader);
            request.Headers.Add("api-version", "1.0");
        }
    }

    internal class BearerToken
    {
        private BearerToken() { }

        public static BearerToken Parse(string tokenHeader)
        {
            if (!tokenHeader.StartsWith("bearer", StringComparison.InvariantCultureIgnoreCase) || tokenHeader.Length < 8) //meaning the string after "bearer " is empty
            {
                throw new InvalidOperationException("not a valid bearer token");
            }

            return new BearerToken() { Token = tokenHeader.Substring(7), BearerTokenHeader = tokenHeader };//"bearer "
        }

        public static BearerToken FromJwt(string jwt)
        {
            string bearerToken = string.Concat("bearer ", jwt);
            return Parse(bearerToken);
        }

        public string Token
        {
            get;
            private set;
        }

        public string BearerTokenHeader
        {
            get;
            private set;
        }

    }
}
