﻿using System;

namespace DSG.IKAM.SHARED.Utilities
{
    public static class EnumExtensions
    {

        public static T ToEnum<T>(this string value) where T : struct, IConvertible
        {
            if (!typeof(T).IsEnum)
                throw new ArgumentException("T must be an enumerated type");

            return (T)Enum.Parse(typeof(T), value, true);
        }
        public static T ToEnum<T>(this int value) where T : struct, IConvertible
        {
            if (!typeof(T).IsEnum)
                throw new ArgumentException("T must be an enumerated type");

            var name = Enum.GetName(typeof(T), value);
            return name.ToEnum<T>();
        }
        public static string ToString<T>(this T value) where T : struct, IConvertible
        {
            if (!typeof(T).IsEnum)
                throw new ArgumentException("T must be an enumerated type");

            return Enum.GetName(value.GetType(), value);
        }

    }
}
