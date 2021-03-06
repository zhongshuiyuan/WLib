﻿/*---------------------------------------------------------------- 
// auth： Windragon
// date： 2017/2/23 10:36:37
// desc： None
// mdfy:  None
//----------------------------------------------------------------*/

namespace WLib.ExtProgress
{
    /// <summary>
    /// 日志关键信息及所在路径
    /// </summary>
    public class ProLogFileInfo
    {
        /// <summary>
        /// 日志时间（字符串）
        /// </summary>
        public string TimeString { get; set; }
        /// <summary>
        /// 日志标题
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 日志文件路径
        /// </summary>
        public string Path { get; set; }


        /// <summary>
        /// 日志关键信息及所在路径
        /// </summary>
        /// <param name="timeString">日志时间（字符串）</param>
        /// <param name="title">日志标题</param>
        /// <param name="path">日志文件路径</param>
        public ProLogFileInfo(string timeString, string title, string path)
        {
            TimeString = timeString;
            Title = title;
            Path = path;
        }
        /// <summary>
        /// 输出："日志时间\t日志标题"
        /// </summary>
        /// <returns></returns>
        public override string ToString() => $"{TimeString}\t{Title}";
    }
}
