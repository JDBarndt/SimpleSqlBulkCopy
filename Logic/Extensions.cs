﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

public static class Extensions
{
    public static bool IsNonStringEnumerable(this PropertyInfo pi)
    {
        return pi != null && pi.PropertyType.IsNonStringEnumerable();
    }

    public static bool IsNonStringEnumerable(this object instance)
    {
        return instance != null && instance.GetType().IsNonStringEnumerable();
    }

    public static bool IsNonStringEnumerable(this Type type)
    {
        if (type == null || type == typeof(string))
            return false;
        return typeof(IEnumerable).IsAssignableFrom(type);
    }
}