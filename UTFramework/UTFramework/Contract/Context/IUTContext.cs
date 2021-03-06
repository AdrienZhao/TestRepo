﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace MD.API.MVCUTFramework
{
    public interface IUTContext : IDisposable
    {
        /// <summary>
        /// 用于初始化
        /// </summary>
        void Initialize();

        IValueProvider valueProvider { get; set; }

        IUTFakeContext FakeContext { get; }

        IHttpFakeRequest Request { get; }

        IEntityInitializer EntityInitializer { get; }

        IEntityVerifier EntityVerifier { get; }
    }
}
