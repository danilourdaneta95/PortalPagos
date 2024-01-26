using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;

namespace Mobile.App.Helpers
{
    public static class ValidationHelper
    {

        public static bool IsText(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return false;
            }
            return Regex.IsMatch(text, @"^[a-zA-Z0-9_ ]*$", RegexOptions.IgnoreCase);
        }

        public static bool IsEmail(string emailaddress)
        {
            if (string.IsNullOrEmpty(emailaddress))
            {
                return false;
            }
            return Regex.IsMatch(emailaddress, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9]{2,10}?)\Z", RegexOptions.IgnoreCase);
        }

        public static bool IsNullOrEmpty(string s1)
        {
            return String.IsNullOrWhiteSpace(s1);
        }

        public static bool IsNumeric(string s1)
        {
            return Int32.TryParse(s1, out int test);
        }

        public static bool IsDecimal(string s1)
        {
            return float.TryParse(s1, out float test);
        }

        public static bool IsNullOrEmptyObject(object obj)
        {
            try
            {
                return String.IsNullOrWhiteSpace((string)obj);
            }
            catch (Exception)
            {
                try
                {
                    int var = (int)obj;
                    return String.IsNullOrWhiteSpace(var.ToString());
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public static bool ValidationObject<T>(T obj)
        {
            var emptyProperties = obj.GetType().GetProperties()
                .Select(prop => new { Prop = prop, Val = prop.GetValue(obj, null) })
                .Where(val => IsNullOrEmptyObject(val.Val))
                .Select(val => val.Prop.Name)
                .ToList();

            if (emptyProperties.Count == 1)
            {

                if (emptyProperties[0] == "RUC")
                {
                    return false;
                }
                if (emptyProperties[0] == "FullName")
                {
                    return false;
                }
                return true;
            }
            if (emptyProperties.Count == 2)
            {
                if (emptyProperties[0] == "RUC")
                {
                    if (emptyProperties[1] == "Phone")
                    {
                        return false;
                    }
                    if (emptyProperties[1] == "Cellphone")
                    {
                        return false;
                    }
                    return true;
                }
                if (emptyProperties[0] == "FullName")
                {
                    if (emptyProperties[1] == "Phone")
                    {
                        return false;
                    }
                    if (emptyProperties[1] == "Cellphone")
                    {
                        return false;
                    }
                    return true;
                }
                return true;
            }
            else
            {
                return emptyProperties.Count > 0;
            }

        }

        public static bool IsRuc(string RUC)
        {
            try
            {
                if (RUC.Length == 11)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch
            {
                return false;
            }
        }

        public static bool IsDNI(string DNI)
        {
            try
            {
                if (string.IsNullOrEmpty(DNI)) return false;

                if (DNI.Length == 8)
                {
                    if (!IsNumeric(DNI))
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                else
                {
                    return false;
                }

            }
            catch
            {
                return false;
            }
        }
    }
}
