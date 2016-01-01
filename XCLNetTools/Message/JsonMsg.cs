﻿using System;

/// <summary>
/// json消息信息
/// </summary>
[Serializable]
public class JsonMsg
{
    /// <summary>
    /// 构造函数，初始化head和body
    /// </summary>
    public JsonMsg()
    {
        this.Head = new JsonMsgHead();
        this.Body = new JsonMsgBody();
    }

    /// <summary>
    /// head
    /// </summary>
    public JsonMsgHead Head { get; set; }

    /// <summary>
    /// body
    /// </summary>
    public JsonMsgBody Body { get; set; }
}

/// <summary>
/// json消息头信息
/// </summary>
[Serializable]
public class JsonMsgHead
{
    /// <summary>
    /// 提示标题
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// 消息提示时间
    /// </summary>
    public DateTime? Date { get; set; }

    /// <summary>
    /// 消息提示内容
    /// </summary>
    public string Message { get; set; }

    /// <summary>
    /// 消息详细信息
    /// </summary>
    public string MessageMore { get; set; }

    /// <summary>
    /// 消息发生页地址
    /// </summary>
    public string Url { get; set; }

    /// <summary>
    /// 消息页来源地址(reffer)
    /// </summary>
    public string FromUrl { get; set; }

    /// <summary>
    /// 是否成功与失败的标识
    /// </summary>
    public bool IsSuccess { get; set; }

    /// <summary>
    /// 是否需要刷新
    /// </summary>
    public bool IsRefresh { get; set; }

    /// <summary>
    /// 备注信息
    /// </summary>
    public string Remark { get; set; }

    /// <summary>
    /// 是否需要跳转
    /// </summary>
    public bool IsRedirect { get; set; }

    /// <summary>
    /// 要跳转的url
    /// </summary>
    public string RedirectURL { get; set; }

    /// <summary>
    /// 当前请求是否为ajax请求
    /// </summary>
    public bool IsAjax
    {
        get
        {
            return XCLNetTools.StringHander.Common.IsAjax();
        }
    }

    /// <summary>
    /// 错误码
    /// </summary>
    public string ErrorCode { get; set; }
}

/// <summary>
/// json消息正文信息
/// </summary>
[Serializable]
public class JsonMsgBody
{
    /// <summary>
    /// 主数据
    /// </summary>
    public object Data { get; set; }

    /// <summary>
    /// 扩展数据
    /// </summary>
    public object ExtendData { get; set; }
}