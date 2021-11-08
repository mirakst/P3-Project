﻿using DashboardBackend.Database.Models;

namespace DashboardBackend.Database
{
    /// <summary>
    /// Contains utilities to handle all interaction with the state database.
    /// </summary>
    public interface IDatabaseHandler
    {
        /// <summary>
        /// Retrieves all entries in the AFSTEMNING table of the state database added after the specified DateTime.
        /// </summary>
        /// <param name="minDate">A date constraint for the returned objects</param>
        /// <returns>A list of all Validations no older than the specified DateTime</returns>
        List<AfstemningEntry> QueryAfstemninger(DateTime minDate);

        /// <summary>
        /// Retrieves all entries in the EXECUTIONS table of the state database added after the specified DateTime.
        /// </summary>
        /// <param name="minDate">A date constraint for the returned objects</param>
        /// <returns>A list of Executions no older than the specified DateTime</returns>
        List<ExecutionEntry> QueryExecutions(DateTime minDate);

        /// <summary>
        /// Retrieves all entries in the LOGGING table of the state database added after the specified DateTime, matching the supplied ExecutionId.
        /// </summary>
        /// <param name="ExecutionId">An Execution ID constraint for the returned objects</param>
        /// <param name="minDate">A date constraint for the returned objects</param>
        /// <returns>A list of Executions no older than the specified DateTime</returns>
        List<LoggingEntry> QueryLogMessages(int ExecutionId, DateTime minDate);

        /// <summary>
        /// Retrieves all entries in the MANAGERS table of the state database .
        /// </summary>
        /// <returns>A list of Managers</returns>
        List<ManagerEntry> QueryManagers();

        /// <summary>
        /// Retrieves all entries in the HEALTH_REPORT table of the state database where REPORT_TYPE ends on 'INIT'.
        /// </summary>
        /// <returns>A Health Report, complete with system info on CPU, Network and RAM.</returns>
        List<HealthReportEntry> QueryHealthReport();

        /// <summary>
        /// Retrieves all entries in the HEALTH_REPORT table of the state database added after the specified DateTime, where REPORT_TYPE is 'CPU' and REPORT_KEY is 'LOAD'.
        /// </summary>
        /// <param name="minDate">A date constraint for the returned objects</param>
        /// <returns>A list of CPU load entries no older than the specified DateTime</returns>
        List<HealthReportEntry> QueryCpuReadings(DateTime minDate);

        /// <summary>
        /// Retrieves all entries in the HEALTH_REPORT table of the state database added after the specified DateTime, where REPORT_TYPE is 'NETWORK'.
        /// </summary>
        /// <param name="minDate">A date constraint for the returned objects</param>
        /// <returns>A list of Network entries no older than the specified DateTime</returns>
        List<HealthReportEntry> QueryNetworkReadings(DateTime minDate);

        /// <summary>
        /// Retrieves all entries in the HEALTH_REPORT table of the state database added after the specified DateTime, where REPORT_TYPE is 'MEMORY' and REPORT_KEY is 'AVAILABLE'.
        /// </summary>
        /// <param name="minDate">A date constraint for the returned objects</param>
        /// <returns>A list of RAM available entries no older than the specified DateTime</returns>
        List<HealthReportEntry> QueryRamReadings(DateTime minDate);
    }
}