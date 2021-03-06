﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Input;
using Neutronium.MVVMComponents;

namespace Neutronium.Core.Binding.GlueObject
{
    internal interface IGlueFactory
    {
        JSCommand Build(ICommand command);

        JsSimpleCommand Build(ISimpleCommand command);

        JsResultCommand Build(IResultCommand command);

        JsGenericObject Build(object from, int childrenCount);

        JSArray BuildArray(IEnumerable<IJSCSGlue> enumerable, IEnumerable source, Type basictype);
    }
}
