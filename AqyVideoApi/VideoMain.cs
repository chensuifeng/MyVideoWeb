using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Web.Script.Serialization;
using System.IO;
using AqyVideoApi.CommonEntity;

namespace AqyVideoApi
{
   public class VideoMain
    {

        private const string appkey = "71c300df4a7f4e89a43d8e19e5458e6";
        public static string GetVideo(int categoryId)
        {
            string url = "http://expand.video.iqiyi.com/api/category/list.json?apiKey=" + appkey + "&categoryId" + categoryId;
            I_HttpPost post = new AqyVideoApi.I_HttpPost();
            string data = post.I_Post(url, null);

            //List<VideoEntity> listVideo = JsonToList<VideoEntity>(data);


            return data;
        }

        public static string TestGetVideo()
        {
            //string url = "https://www.ixxplayer.com/video.php?url=http://bobo.okokbo.com/20180301/WEwKQ997/index.m3u8";
            string url = "http://zabaye.com/search.php?searchword=%E8%BF%AA%E4%B8%BD%E7%83%AD%E5%B7%B4";
            I_HttpPost post = new AqyVideoApi.I_HttpPost();
            //string postdata = @"{""name"":""烈火如歌""}";
            //string postdata = @"{""video"":[{""name"":""烈火如歌"",""link"":""http://www.zabaye.com/detail/?6231.html"",""pic"":""""}]}";
            string postdata = @"{""searchword"":""%E8%BF%AA%E4%B8%BD%E7%83%AD%E5%B7%B4""}";
            //byte[] bytedate = Encoding.UTF8.GetBytes(postdata);
            //byte[] bytedate = Convert.FromBase64String(postdata);
            //MemoryStream ms = new MemoryStream(bytedate);
            //Dictionary<object, string> diction = new Dictionary<object, string>();
            //diction.Add("Accept-Encoding", "gzip, deflate");
            //diction.Add("Content-Type", "application/x-www-form-urlencoded");
            string data = post.I_Post(url, "");
            return data;
        }

        public static List<T> JsonToList<T>(string jsonString)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<T> list = serializer.Deserialize<List<T>>(jsonString);
            return list;
        }

        //public static T Deserialize<T>(string json)
        //{
        //    T obj = Activator.CreateInstance<T>();
        //    using (MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(json)))
        //    {
        //        DataContractJsonSerializer serializer = new DataContractJsonSerializer(obj.GetType());
        //        return (T)serializer.ReadObject(ms);
        //    }
        //}

    }
}
