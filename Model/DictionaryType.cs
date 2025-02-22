﻿using System;

namespace Model
{
    /// <summary>
    /// 类别表
    /// </summary>
    public class DictionaryType
    {
        /// <summary>
        /// 自增主键ID
        /// </summary>
        public string ID { get; set; }
        /// <summary>
        /// 项目上级
        /// </summary>
        public string PARENTID { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string FULLNAME { get; set; }
        /// <summary>
        /// 是否为树形
        /// </summary>
        public int ISTREE { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public string DESCRIPTION { get; set; }
        /// <summary>
        /// 删除标记 0：未删除 1： 已删除
        /// </summary>
        public int ISDELETE { get; set; }
        /// <summary>
        /// 编码
        /// </summary>
        public string ENCODE { get; set; }
        /// <summary>
        /// 排列码
        /// </summary>
        public int SORTCODE { get; set; }
        /// <summary>
        /// 拼音
        /// </summary>
        public string SIMPLESPELLING { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CREATORTIME { get; set; }
        /// <summary>
        /// 创建人员ID
        /// </summary>
        public string CREATORUSERID { get; set; }
        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime LASTMODIFYTIME { get; set; }
        /// <summary>
        /// 修改人员ID
        /// </summary>
        public string LASTMODIFYUSERID { get; set; }
        /// <summary>
        /// 删除时间
        /// </summary>
        public DateTime DELETETIME { get; set; }
        /// <summary>
        /// 删除人ID
        /// </summary>
        public string DELETEUSERID { get; set; }
    }
}
