﻿using System.Globalization;

namespace Model
{
    public class CpuLoad : PerformanceMetric
    {
        public CpuLoad(int executionId, double load, DateTime date)
        {
            ExecutionId = executionId;
            Load = load;
            Date = date;
        }

        public override string ToString()
        {
            return $"{Date.ToString(new CultureInfo("da-DK"))}: {Load}%";
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(ExecutionId, Load, Date);
        }

        public override bool Equals(object obj)
        {
            if (obj is not CpuLoad other)
            {
                return false;
            }
            return GetHashCode() == other.GetHashCode();
        }
    }
}