using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;

namespace HandleString
{
    public class HandGzip : IHandleString
    {
        /// <summary>
        /// 获取字符串
        /// </summary>
        /// <param name="gzipstr"></param>
        /// <returns></returns>
        public string GetString(string gzipstr)
        {
            string str = string.Empty;

            if (!string.IsNullOrWhiteSpace(gzipstr) && gzipstr.Length > 0)
            {
                //byte[] data = Convert.FromBase64String(gzipstr);
                //MemoryStream ms = new MemoryStream(data);
                //GZipStream gzipstream = new GZipStream(ms, CompressionMode.Decompress);
                //byte[] block = new byte[1024];
                //MemoryStream outbuff = new MemoryStream();
                //while (true)
                //{
                //    int byteread = gzipstream.Read(block, 0, block.Length);
                //    if (byteread < 0)
                //    {
                //        break;
                //    }
                //    else
                //    {
                //        outbuff.Write(block, 0, byteread);
                //    }
                //}

                //str = Encoding.UTF8.GetString(Decompress(gzipstr));

                byte[] byteArr = new byte[gzipstr.Length];
                int num = 0;
                foreach (char item in gzipstr.ToCharArray())
                {
                    byteArr[num++] = (byte)item;
                }
                //StringBuilder sb = new StringBuilder();
                MemoryStream ms = new MemoryStream(byteArr);
                GZipStream gzipstream = new GZipStream(ms, CompressionMode.Decompress);

                //byteArr = new byte[byteArr.Length];

                //int rByte = gzipstream.Read(byteArr, 0, byteArr.Length);

                //for (int i = 0; i < rByte; i++)
                //{
                //    sb.Append((char)byteArr[i]);
                //}

                StreamReader sr = new StreamReader(gzipstream, Encoding.UTF8);
                str = sr.ReadToEnd();
                gzipstream.Close();
                ms.Close();

                //str = sb.ToString();
            }

            return str;
        }


        /// <summary>
        /// Gzip解压缩
        /// </summary>
        /// <param name="zipdata"></param>
        /// <returns></returns>
        public static byte[] Decompress(string gzipstr)
        {

            byte[] zipdata = Convert.FromBase64String(gzipstr);
            MemoryStream ms = new MemoryStream(zipdata);
            GZipStream gzipstream = new GZipStream(ms, CompressionMode.Decompress);
            MemoryStream outbuff = new MemoryStream();
            byte[] block = new byte[1024];
            while (true)
            {
                int byteread = gzipstream.Read(block, 0, block.Length);
                if (byteread < 0)
                {
                    break;
                }
                else
                {
                    outbuff.Write(block, 0, byteread);
                }
            }
            return outbuff.ToArray();

        }

        /// <summary>
        /// Gzip压缩
        /// </summary>
        /// <param name="gzipstr"></param>
        /// <returns></returns>
        public string Compress(string str)
        {
            string gzip = string.Empty;
            if (!string.IsNullOrWhiteSpace(str) && str.Length > 0)
            {
                byte[] data = Encoding.UTF8.GetBytes(str);
                MemoryStream ms = new MemoryStream();
                GZipStream gzipstream = new GZipStream(ms, CompressionMode.Compress, true);
                gzipstream.Write(data, 0, data.Length);
                gzipstream.Close();

                str = Convert.ToBase64String(ms.ToArray());
            }

            return gzip;
        }



    }
}
