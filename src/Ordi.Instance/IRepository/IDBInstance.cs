﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;

namespace Ordi
{
    /// <summary>
    /// DB访问实例
    /// </summary>
    internal interface IDBInstance : IExecute, IExecuteScalar, IQuery
    {
    }
}
