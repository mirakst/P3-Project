﻿using System;

namespace ConversionEngineSimulator
{
    public class Execution : ITimestampedDatabaseEntry, IComparable<Execution>
    {
        public int EXECUTION_ID { get; set; }
        public string EXECUTION_UUID {  get; set; }
        public DateTime CREATED { get; set;  }

        public override string ToString()
        {
            return $"{"[Execution]",-15} {CREATED}: {EXECUTION_ID} {EXECUTION_UUID}";
        }
        public int CompareTo(Execution execution)
        {
            return DateTime.Compare(CREATED, execution.CREATED);
        }
    }
}
