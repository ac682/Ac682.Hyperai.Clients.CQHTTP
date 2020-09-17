﻿using Hyperai.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ac682.Hyperai.Clients.CQHTTP.DataObjects
{
    public class DtoGroupMessage
    {
        /// <summary>
        /// 匿名名, null 则不匿名
        /// </summary>
        public object Anonymous { get; set; }
        /// <summary>
        /// 反正都是0
        /// </summary>
        public uint Font { get; set; }
        public long GroupId { get; set; }
        public MessageChain Message { get; set; }
        public long MessageId { get; set; }
        public DtoGroupSender Sender { get; set; }
        public long UserId { get; set; }
    }
}