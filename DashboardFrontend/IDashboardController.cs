﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashboardBackend;
using DashboardBackend.Settings;
using Model;

namespace DashboardFrontend
{
    public delegate void ConversionCreated(Conversion conversion);

    public interface IDashboardController
    {
        event ConversionCreated OnConversionCreated;

        IDatabaseHandler DatabaseHandler { get; set; }
        IUserSettings UserSettings { get; set; }
        Conversion? Conversion { get; set; }
        bool IsRunning { get; }

        void SetupNewConversion();
        void ChangeMonitoringState();
        void StartMonitoring();
        void StopMonitoring();
        void TryUpdateLog();
    }
}
