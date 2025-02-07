﻿using System.Collections.Generic;

namespace ConversionEngineSimulator
{
    public class ManagerTrackingTable : IDatabaseTable
    {
        public ManagerTrackingTable()
        {
            ColumnNames = "MGR, STATUS, RUNTIME, PERFORMANCECOUNTROWSREAD, " +
                          "PERFORMANCECOUNTROWSWRITTEN, STARTTIME, ENDTIME, WEEK";
            OutputColumnNames = "@MGR, @STATUS, @RUNTIME, @PERFORMANCECOUNTROWSREAD, " +
                                "@PERFORMANCECOUNTROWSWRITTEN, @STARTTIME, @ENDTIME, @WEEK";
            TableName = "dbo.MANAGER_TRACKING";
            Entries = DbUtilities.QueryTable<ManagerTracking>(this);
        }
        public string ColumnNames { get; }

        public string OutputColumnNames { get; }

        public string TableName { get; }
        public List<ManagerTracking> Entries { get; set;  }
    }
}