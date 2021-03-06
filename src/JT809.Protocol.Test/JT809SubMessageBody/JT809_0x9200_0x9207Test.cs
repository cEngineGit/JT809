﻿using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using JT809.Protocol;
using JT809.Protocol.JT809Extensions;
using JT809.Protocol.JT809MessageBody;
using JT809.Protocol.JT809Exceptions;
using JT809.Protocol.JT809SubMessageBody;
using JT809.Protocol.JT809Enums;

namespace JT809.Protocol.Test.JT809SubMessageBody
{
    public class JT809_0x9200_0x9207Test
    {
        [Fact]
        public void Test1()
        {
            JT809_0x9200_0x9207 jT809_0X9200_0X9207 = new JT809_0x9200_0x9207
            {
                 Result=  JT809_0x9207_Result.申请成功
            };
            var hex = JT809Serializer.Serialize(jT809_0X9200_0X9207).ToHexString();
            Assert.Equal("00", hex);
        }

        [Fact]
        public void Test2()
        {
            var bytes = "00".ToHexBytes();
            JT809_0x9200_0x9207 jT809_0X9200_0X9207 = JT809Serializer.Deserialize<JT809_0x9200_0x9207>(bytes);
            Assert.Equal(JT809_0x9207_Result.申请成功, jT809_0X9200_0X9207.Result);
        }

    }
}
