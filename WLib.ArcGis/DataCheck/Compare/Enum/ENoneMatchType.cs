﻿namespace WLib.ArcGis.DataCheck.Compare
{
    /// <summary>
    /// 在数据对比时，数据查询或匹配失败情况
    /// </summary>
    public enum ENoneMatchType
    {
        /// <summary>
        /// 找不到数据库
        /// </summary>
        NoDb,
        /// <summary>
        /// 找不到数据集
        /// </summary>
        NoDataset,
        /// <summary>
        /// 找不到表格/图层
        /// </summary>
        NoTable,
        /// <summary>
        /// 找不到字段
        /// </summary>
        NoField,

        /// <summary>
        /// 数据库为空（数据库不包含任何表、图层、数据集等）
        /// </summary>
        EmptyDb,
        /// <summary>
        /// 数据集为空（数据集不包含图层）
        /// </summary>
        EmptyDataset,
        /// <summary>
        /// 表格/图层为空（表格/图层没有记录）
        /// </summary>
        EmptyTable,

        /// <summary>
        /// 没有匹配的记录
        /// </summary>
        NoneMatchRecord,
        /// <summary>
        /// 没有匹配的图斑
        /// </summary>
        NoneMatchGeometry,

        /// <summary>
        /// 匹配的值为null
        /// </summary>
        NullValue,
        /// <summary>
        /// 匹配的值为null或Empty
        /// </summary>
        NullOrEmptyValue,
        /// <summary>
        /// 匹配的值为null、Empty或空白字符
        /// </summary>
        NullorWhitespaceValue,
    }
}
