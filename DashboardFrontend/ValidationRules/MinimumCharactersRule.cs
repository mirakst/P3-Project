﻿using System.Globalization;
using System.Windows.Controls;

namespace DashboardFrontend.ValidationRules
{
    /// <summary>
    /// Validation rule checking whether the input contains less than the allow number of characters
    /// </summary>
    public class MinimumCharactersRule : ValidationRule
    {
        public int MinimumCharacters {  get; set; }

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string inputStr = value.ToString();

            if (inputStr.Length == MinimumCharacters) return new ValidationResult(false, "Input cannot be empty!");

            return new ValidationResult(true, null);
        }
    }
}
