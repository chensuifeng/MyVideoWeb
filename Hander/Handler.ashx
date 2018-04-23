<%@ WebHandler Language="C#" Class="Handler" %>
using System;
using System.Web;
using System.Linq;
using System.Collections.Generic;
using AqyVideoApi;
using HandleString;
public class Handler : IHttpHandler {

    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";
        //context.Response.Write("Hello World");
        string returndata = string.Empty;
        switch (context.Request.HttpMethod.ToLower())
        {
            case "get":

                break;
            case "post":
                //returndata = AqyVideoApi.VideoMain.GetVideo(2);
                returndata = VideoMain.TestGetVideo();
                break;
            default:
                returndata = "请求方法只能为get或post";
                break;
        }
        //returndata = new HandleStringCom().GetString(HandTypeEnum.gzip, returndata);
        context.Response.Write(returndata);
    }

    public bool IsReusable {
        get {
            return false;


            ////3002592531
            //丁娟
            //中医药
        }
    }

}