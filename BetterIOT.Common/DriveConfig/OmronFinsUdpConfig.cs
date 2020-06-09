﻿using BetterIOT.Common.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace BetterIOT.Common.DriveConfig
{
    public class OmronFinsUdpConfig : NetworkDeviceConfigBase
    {
        /// <summary>
        /// PLC IP地址
        /// </summary>
        public string IP { get; set; }
        /// <summary>
        /// 端口
        /// </summary>
        public int Port { get; set; }
        /// <summary>
        /// 上位机节点地址
        /// </summary>
        public byte SA1 { get; set; }
        /// <summary>
        /// 上位机单元号地址
        /// </summary>
        public byte SA2 { get; set; }
        /// <summary>
        /// HslCommunication.Core.DataFormat
        /// </summary>
        public int ByteTransformDataFormat { get; set; }
    }
}
