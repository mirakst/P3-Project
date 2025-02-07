﻿namespace DashboardBackend.Parsers
{
    /// <summary>
    /// Contains method signatures to transform raw data from the state database into the models used by the Dashboard system.
    /// </summary>
    /// <typeparam name="TInput">A model class auto-generated by Entity Framework Core for the state database.</typeparam>
    /// <typeparam name="TOutput">A model class created for the Dashboard system.</typeparam>
    public interface IDataParser<TInput, TOutput>
        where TInput : class
        where TOutput : class
    {
        /// <summary>
        /// Converts the specified raw data into an object that can be used by the Dashboard system.
        /// </summary>
        /// <param name="data">The list of raw data from the state database to be parsed.</param>
        TOutput Parse(List<TInput> data);
    }
}
