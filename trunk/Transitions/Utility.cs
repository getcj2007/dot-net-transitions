﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace Transitions
{
	/// <summary>
	/// A class holding static utility functions.
	/// </summary>
	internal class Utility
	{
        /// <summary>
        /// Returns the value of the property passed in.
        /// </summary>
        public static object getValue(object target, string strPropertyName)
        {
            Type targetType = target.GetType();
            PropertyInfo propertyInfo = targetType.GetProperty(strPropertyName);
            if (propertyInfo == null)
            {
                throw new Exception("Object: " + target.ToString() + " does not have the property: " + strPropertyName);
            }
            return propertyInfo.GetValue(target, null);
        }

        /// <summary>
        /// Sets the value of the property passed in.
        /// </summary>
        public static void setValue(object target, string strPropertyName, object value)
        {
            Type targetType = target.GetType();
            PropertyInfo propertyInfo = targetType.GetProperty(strPropertyName);
            if (propertyInfo == null)
            {
                throw new Exception("Object: " + target.ToString() + " does not have the property: " + strPropertyName);
            }
            propertyInfo.SetValue(target, value, null);
        }

		/// <summary>
		/// Returns a value between d1 and d2 for the percentage passed in.
		/// </summary>
		public static double interpolate(double d1, double d2, double dPercentage)
		{
			double dDifference = d2 - d1;
			double dDistance = dDifference * dPercentage;
			double dResult = d1 + dDistance;
			return dResult;
		}

        /// <summary>
        /// Returns a value betweeen i1 and i2 for the percentage passed in.
        /// </summary>
        public static int interpolate(int i1, int i2, double dPercentage)
        {
            return (int)interpolate((double)i1, (double)i2, dPercentage);
        }
    
        /// <summary>
        /// Returns a value betweeen f1 and f2 for the percentage passed in.
        /// </summary>
        public static float interpolate(float f1, float f2, double dPercentage)
        {
            return (float)interpolate((double)f1, (double)f2, dPercentage);
        }
    }
}