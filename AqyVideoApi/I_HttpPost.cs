using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Net.Http;

namespace AqyVideoApi
{
    public class I_HttpPost
    {
        /// <summary>
        /// 发送post请求
        /// </summary>
        /// <param name="url">地址</param>
        /// <param name="data">post数据</param>
        /// <param name="headers">页面头</param>
        /// <returns></returns>
        public string I_Post(string url,string data,IDictionary<object,string> headers =null)
        {
            string str = string.Empty;
            WebRequest request = HttpWebRequest.Create(url);
            request.Method = "get";
            //request.Headers["Accept-Encoding"] = "gzip,deflate";
            //request.AutomaticDecompression = DecompressionMethods.GZip;
            byte[] bytedata = null;
            if (!string.IsNullOrWhiteSpace(data))
            {
                 bytedata = Encoding.UTF8.GetBytes(data);
                if (bytedata != null)
                {
                    request.ContentLength = bytedata.Length;
                    request.ContentType = "application/x-www-form-urlencoded;charset=utf-8";
                }
            }

            if (headers != null)
            {
                foreach (var item in headers)
                {
                    if (item.Key is HttpRequestHeader)
                    {
                        request.Headers[(HttpRequestHeader)item.Key] = item.Value;
                    }
                    else
                    {
                        request.Headers[item.Key.ToString()] = item.Value;
                    }
                }
            }

            HttpWebResponse response = null;
            try
            {
                ////data不为空 即为post的时候 必须要先执行request.GetRequestStream
                if (bytedata != null)
                {
                    using (Stream rs = request.GetRequestStream())
                    {
                        rs.Write(bytedata, 0, bytedata.Length);
                        rs.Close();
                    }
                }
                //
                response = (HttpWebResponse)request.GetResponse();
                Stream returndata = response.GetResponseStream();


                StreamReader read = new StreamReader(returndata);
                str = read.ReadToEnd();

                read.Close();
                returndata.Close();
                response.Close();
            }
            catch (Exception ex)
            {
                throw ex;

            }

            return str;
        }
    }
}
