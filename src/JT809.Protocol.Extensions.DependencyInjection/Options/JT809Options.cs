﻿using JT809.Protocol.JT809Configs;
using System;
using System.Collections.Generic;
using System.Text;

namespace JT809.Protocol.Extensions.DependencyInjection.Options
{
    public class JT809Options
    {
        public JT809EncryptOptions EncryptOptions { get; set; }
        public JT809HeaderOptions  HeaderOptions { get; set; }
        /// <summary>
        /// 版本号:
        /// 默认 1.0.0
        /// </summary>
        public string Version { get; set; }
        /// <summary>
        /// 设置跳过校验码
        /// 场景：测试的时候，可能需要收到改数据，所以测试的时候有用
        /// </summary>
        public bool SkipCRCCode { get; set; }
    }
}
