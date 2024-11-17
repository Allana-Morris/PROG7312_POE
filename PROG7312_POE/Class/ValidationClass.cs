﻿using PROG7312_POE.Class.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROG7312_POE.Class
{
    internal class ValidationClass
    {
        public ValidationClass() { }

        public bool isString(string userinput)
        {
            if (string.IsNullOrEmpty(userinput)) return false;
            return true;
        }

        ///check if
        ///a) Dates are not past
        ///b) if the To date is after the From date
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

        private string GetEnumDescription(Enum value)
        {
            var field = value.GetType().GetField(value.ToString());
            var attribute = (DescriptionAttribute)Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute));
            return attribute == null ? value.ToString() : attribute.Description;
        }



    }
}
