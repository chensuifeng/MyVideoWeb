using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AqyVideoApi.CommonEntity
{
    public class VideoEntity
    {
        public int tvId { get; set; } /*视频ID    废弃(qipuId代替)*/
        public int qipuId { get; set; }  /*视频的奇谱ID*/
        public string tvName { get; set; } //视频名称
        public int videoStatus { get; set; } //视频状态	0：无效，1：有效
        public DateTime beginTime { get; set; }    //视频开始时间
        public DateTime endTime{ get; set; }  //视频结束时间
        public int timeLength{ get; set; }   //视频播放时长
        public int albumId { get; set; } //专辑ID 废弃(albumQipuId代替)
        public int albumQipuId { get; set; } //专辑对应的奇谱Id
        public int playOrder { get; set; } //视频播放顺序
        public int tvYear { get; set; } //发行年份
        public string keyWord { get; set; } //视频关键词
        public string subTitle { get; set; } //视频副标题
        public string domainName { get; set; }//视频所属最终页发布的域名
        public DateTime updateTime { get; set; } //视频最后一次更新时间
        public DateTime issueTime { get; set; } //视频首次发布时间
        public int tvUniqId { get; set; }//视频vid
        public string videoImage { get; set; }//视频图片地址
        public string videoUrl { get; set; } //视频url
        public string desc { get; set; } //描述
        public string Html5PlayUrl { get; set; }// Html5播放页地址
        public int categoryId { get; set; }// 频道ID
        public string Swf { get; set; } //分享播放器地址
        public string androidApp { get; set; } //安卓app调起字段   根据合作方生成对应的调起地址
        public string iosApp { get; set; }  //苹果app调起字段 根据合作方生成对应的调起地址
        public int contentType { get; set; } //视频的内容类型 各频道不太相同详情参看常见问题汇总20.专辑的内容类型
        public string commonSwf { get; set; }   //通用swf
        public bool is3D { get; set; }   //是否为3d视频	1:是; 0:不是
        public int isPurchase { get; set; }  //是否需要付费观看	0:免费; 1、2:付费
        public int payMark { get; set; } //付费角标	0：无角标 1：vip角标 2：付费点播角标 3：点播券角标
        public bool memberDownloadableOnly { get; set; } // 是否仅会员可下载	1：是 0：否 注：该字段需在可下载（播控平台可下载）的前提下才有效（即需要先判断播控中某个平台下可下载，再判断该字段才有意义）
        public bool is1080p { get; set; } //是否支持1080p	1:支持; 0:不支持
        public bool isDolby { get; set; } //是否支持杜比	1:支持; 0:不支持
        public string panorama { get; set; }   //全景字段 全景视频的属性
        public int videoType { get; set; } //视频类型1:普通视频 2:360度全景视频 3:180度全景视频4:广角视频
        public int viewAngleX { get; set; }  //视角X坐标
        public int viewAngleY { get; set; }  //视角Y坐标
        public int zoomRate { get; set; }   //放大倍数
        public int renderingType { get; set; }  // 渲染类型:(普通视频无此字段)0:球面渲染 1:棱锥渲染
        public int playControls { get; set; }    //播放控制 控制各个平台权限
        public int platformId { get; set; }//播放平台Id, 详见常见问题汇总21)播放平台定义
        public bool downloadAllowed { get; set; } //该平台是否允许下载1:允许,0:不允许
        public bool cooperationAllowed { get; set; } // 该平台是否允许站外合作1:允许,0:不允许
        public int availableStatus { get; set; } //在线状态1:在线2:版权原因下线3:其他原因下线
        public string subsites { get; set; }    //地方站信息
        public int id { get; set; } //地方站ID， 数字
        public string name { get; set; }    //地方站名称， 字符串
        public int level { get; set; }   //地方站等级，数字 1 常规； 2中级； 3 高级；

    }
}
