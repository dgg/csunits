// Copyright (c) 2011 Anders Gustafsson, Cureos AB.
// All rights reserved. This software and the accompanying materials
// are made available under the terms of the Eclipse Public License v1.0
// which accompanies this distribution, and is available at
// http://www.eclipse.org/legal/epl-v10.html

namespace Cureos.Measures.Extensions
{
    internal static class Unit<Q, U> where U : struct, IUnit<Q> where Q : struct, IQuantity
    {
        internal static Unit Value
        {
            get { return default(U).EnumeratedValue; }
        }
    }
}