﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Domain.Core
{
    /// <summary>
    /// 值类型
    /// </summary>
   public class ValueObject
    {
        public string Content { get; private set; }
    }
}