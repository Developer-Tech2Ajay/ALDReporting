﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Globalization;
using System.Linq;

namespace Entities
{
    public static partial class Extensions
    {
        /// <summary>
        ///     A DateTime extension method that converts this object to a short date time string.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>The given data converted to a string.</returns>
        public static string ToDateTimeMMDDYYYYString(this DateTime @this)
        {
            return @this.ToString("MM-dd-yyyy hh:mm tt");
        }


        /// <summary>
        ///     A DateTime extension method that converts this object to a short date time string.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="culture">The culture.</param>
        /// <returns>The given data converted to a string.</returns>
        public static string ToShortDateTimeString(this DateTime @this, string culture)
        {
            return @this.ToString("g", new CultureInfo(culture));
        }

        /// <summary>
        ///     A DateTime extension method that converts this object to a short date time string.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="culture">The culture.</param>
        /// <returns>The given data converted to a string.</returns>
        public static string ToShortDateTimeString(this DateTime @this, CultureInfo culture)
        {
            return @this.ToString("g", culture);
        }


    }
}
