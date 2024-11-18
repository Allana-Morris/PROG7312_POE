using PROG7312_POE.Class.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG7312_POE.Class
{
    public class EnumManager
    {
        //-------------------------------------------------------------------------------------
        /// <summary>
        /// Converts a List of Enum Descriptions to the Enum Values
        /// </summary>
        public List<RequestCategory> ConvertDescriptionsToCategories(List<string> descriptions)
        {
            var categories = new List<RequestCategory>();

            foreach (var description in descriptions)
            {
                // Use reflection to find the enum value that matches the description
                var category = Enum.GetValues(typeof(RequestCategory))
                                   .Cast<RequestCategory>()
                                   .FirstOrDefault(c => GetEnumDescription(c) == description);

                if (category != RequestCategory.None) // Only add valid categories
                {
                    categories.Add(category);
                }
            }

            return categories;
        }

        //-------------------------------------------------------------------------------------
        /// <summary>
        /// Helper method to get the description of an enum value
        /// </summary>
        public string GetEnumDescription(Enum value)
        {
            var field = value.GetType().GetField(value.ToString());
            var attribute = (DescriptionAttribute)Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute));
            return attribute?.Description ?? value.ToString();
        }
    }
}
