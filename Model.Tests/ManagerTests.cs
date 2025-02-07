﻿using System;
using System.Collections.Generic;
using Xunit;

namespace Model.Tests
{
    public class ManagerTests
    {
        [Fact]
        public void Equal_DiffrentManagerWithSameParametersIdExecutionIdAndName_ReturnsTrue()
        {
            var expected = new Manager()
            {
                Name = "managerOne",
                ContextId = 1
            };

            var actual = new Manager()
            {
                Name = "managerOne",
                ContextId = 1
            };

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Equal_DiffrentManagerWithSameParametersIdExecutionIdAndNameStartTime_ReturnsTrue()
        {
            var expected = new Manager()
            {
                Name = "managerOne",
                ContextId= 1,
                StartTime = DateTime.Parse("01-01-2020 12:00:00")
            };

            var actual = new Manager()
            {
                Name = "managerOne",
                ContextId= 1,
                StartTime = DateTime.Parse("01-01-2020 12:00:00")
            };

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AddReadings_AddsRamAndCpuReadingsToAManager_ReturnsNumberOfReadings()
        {
            var expected = 3;

            var manager = new Manager();
            var ramReadings = new List<RamLoad>()
            {
                new RamLoad(0, 0.1, 100, DateTime.Parse("01-01-2020 12:00:00")),
                new RamLoad(0, 0.2, 100, DateTime.Parse("01-01-2020 13:00:00")),
                new RamLoad(0, 0.3, 100, DateTime.Parse("01-01-2020 14:00:00"))
            };
            var cpuReadings = new List<CpuLoad>()
            {
                new CpuLoad(0, 0.1, DateTime.Parse("01-01-2020 12:00:00")),
                new CpuLoad(0, 0.2, DateTime.Parse("01-01-2020 13:00:00")),
                new CpuLoad(0, 0.3, DateTime.Parse("01-01-2020 14:00:00"))
            };
            manager.AddReadings(cpuReadings, ramReadings);

            var cpuCount = manager.CpuReadings.Count;
            var ramCount = manager.RamReadings.Count;

            Assert.True(expected == cpuCount && expected == ramCount);
        }

        [Fact]
        public void Equal_DiffrentManagerWithSameParametersIdExecutionIdAndNameStartTimeEndTime_ReturnsTrue()
        {
            var expected = new Manager()
            {
                Name = "managerOne",
                ContextId = 1,
                StartTime = DateTime.Parse("01-01-2020 12:00:00"),
                EndTime = DateTime.Parse("01-01-2020 13:00:00"),
            };

            var actual = new Manager()
            {
                Name = "managerOne",
                ContextId = 1,
                StartTime = DateTime.Parse("01-01-2020 12:00:00"),
                EndTime = DateTime.Parse("01-01-2020 13:00:00"),
            };

            Assert.Equal(expected, actual);
        }
    }
}