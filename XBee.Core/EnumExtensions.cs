﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace XBee
{
    internal static class EnumExtensions
    {
        public static IEnumerable<T> GetFlagValues<T>(this T enumValue) where T : struct
        {
            return Enum.GetValues(typeof(T))
                .Cast<object>()
                .Where(o => (Convert.ToInt32(o) & Convert.ToInt32(enumValue)) != 0)
                .Cast<T>();
        }
    }
}