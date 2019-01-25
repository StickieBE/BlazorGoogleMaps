﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SharedComponents
{
    public abstract class JsObjectRef : IDisposable
    {
        protected Guid _guid = Guid.NewGuid();

        public abstract void Dispose();
    }
}