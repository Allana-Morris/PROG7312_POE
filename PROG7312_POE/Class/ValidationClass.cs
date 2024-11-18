using PROG7312_POE.Class.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace PROG7312_POE.Class
{
    internal class ValidationClass
    {
        public ValidationClass() { }

        //-------------------------------------------------------------------------------------
        /// <summary>
        /// Function that return whether or not the input is null or empty
        /// </summary>
        public bool isString(string userinput)
        {
            if (string.IsNullOrEmpty(userinput)) return false;
            return true;
        }

        /// <summary>
        /// check if
        ///a) Dates are not past
        ///b) if the To date is after the From date <summary>
        /// 
        /// <param name="FromDate"></param>
        /// <param name="ToDate"></param>
        /// <returns></returns>
        /// </summary>
        public bool isValidDates(DateTime FromDate, DateTime ToDate)
        {
            bool pastDate = true;
            bool LargerToDate = true;
            bool ValidDates = true;

            if (FromDate < DateTime.Now || ToDate < DateTime.Now)
            {
                pastDate = false;
            }

            if (ToDate < FromDate)
            {
                LargerToDate = false;
            }

            if (!pastDate || !LargerToDate)
            {
                ValidDates = false;
            }
            return ValidDates;
        }

        //-------------------------------------------------------------------------------------
        /// <summary>
        /// Function that checks that all the selected categories are valid and exist in RequestCategory
        /// </summary>
        public bool allCategoriesValid(List<string> usercategories)
        {
            int count = 0;
            foreach (string category in usercategories)
            {
                foreach (var cat in Enum.GetValues(typeof(RequestCategory)).Cast<RequestCategory>())
                {
                    var description = GetEnumDescription(cat);
                    if (category == description)
                    {
                        count++;
                    }
                }
            }

            if (count != usercategories.Count)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //-------------------------------------------------------------------------------------
        /// <summary>
        /// Gets Enum Decription using the value
        /// </summary>
        private string GetEnumDescription(Enum value)
        {
            var field = value.GetType().GetField(value.ToString());
            var attribute = (DescriptionAttribute)Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute));
            return attribute == null ? value.ToString() : attribute.Description;
        }
    }
}
//-----------------------------------...ooo000 END OF FILE 000ooo...-----------------------------------//