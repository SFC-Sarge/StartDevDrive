//***********************************************************************
// Assembly         : StartDevDrive
// Author           : Danny C. McNaught
// Created          : 01-19-2020
//
// Last Modified By : Danny C. McNaught
// Last Modified On : Sunday, June 20, 2021 10:03:03 PM
// ***********************************************************************
// <copyright file="FileLogger.cs" company="Computer Question">
//     Computer Question 2021
// </copyright>
// Change Request # :
// Version Number   :
// File Name        : FileLogger.cs
// <summary></summary>
// ***********************************************************************
using Microsoft.Extensions.Logging;
using System;
using System.IO;
namespace StartDevDrive
{
    /// <summary>Class FileLogger</summary>
    /// <remarks>
    /// <para><b>History:</b></para>
    /// <list type="table">
    /// <item>
    /// <description><b>Code Changed by:</b><para>Danny C. McNaught</para><para><para><a href="mailto:danny.mcnaught@dannymcnaught.com">danny.mcnaught@dannymcnaught.com</a></para></para></description>
    /// </item>
    /// <item>
    /// <description><b>Code changed on Visual Studio Host Machine:</b><para>DESKTOP-ACLFE3O</para></description>
    /// </item>
    /// <item>
    /// <description><b>Code Change Date and Time:</b><para>Sunday, June 20, 2021 10:54 PM</para><b>Code Changes:</b><para>Created XML Comment</para></description>
    /// </item>
    /// </list>
    /// </remarks>
    internal sealed class FileLogger : ILogger, IDisposable
    {
        /// <summary>The category</summary>
        /// <remarks>
        /// <para><b>History:</b></para>
        /// <list type="table">
        /// <item>
        /// <description><b>Code Changed by:</b><para>Danny C. McNaught</para><para><para><a href="mailto:danny.mcnaught@dannymcnaught.com">danny.mcnaught@dannymcnaught.com</a></para></para></description>
        /// </item>
        /// <item>
        /// <description><b>Code changed on Visual Studio Host Machine:</b><para>DESKTOP-ACLFE3O</para></description>
        /// </item>
        /// <item>
        /// <description><b>Code Change Date and Time:</b><para>Sunday, June 20, 2021 10:54 PM</para><b>Code Changes:</b><para>Created XML Comment</para></description>
        /// </item>
        /// </list>
        /// </remarks>
        private readonly string _category;
        /// <summary>The writer</summary>
        /// <remarks>
        /// <para><b>History:</b></para>
        /// <list type="table">
        /// <item>
        /// <description><b>Code Changed by:</b><para>Danny C. McNaught</para><para><para><a href="mailto:danny.mcnaught@dannymcnaught.com">danny.mcnaught@dannymcnaught.com</a></para></para></description>
        /// </item>
        /// <item>
        /// <description><b>Code changed on Visual Studio Host Machine:</b><para>DESKTOP-ACLFE3O</para></description>
        /// </item>
        /// <item>
        /// <description><b>Code Change Date and Time:</b><para>Sunday, June 20, 2021 10:54 PM</para><b>Code Changes:</b><para>Created XML Comment</para></description>
        /// </item>
        /// </list>
        /// </remarks>
        private volatile StreamWriter _writer;

        /// <summary>Initializes a new instance of the <see cref="FileLogger" /> class.</summary>
        /// <param name="category">The category.</param>
        /// <param name="writer">The writer.</param>
        /// <remarks>
        /// <para><b>History:</b></para>
        /// <list type="table">
        /// <item>
        /// <description><b>Code Changed by:</b><para>Danny C. McNaught</para><para><para><a href="mailto:danny.mcnaught@dannymcnaught.com">danny.mcnaught@dannymcnaught.com</a></para></para></description>
        /// </item>
        /// <item>
        /// <description><b>Code changed on Visual Studio Host Machine:</b><para>DESKTOP-ACLFE3O</para></description>
        /// </item>
        /// <item>
        /// <description><b>Code Change Date and Time:</b><para>Sunday, June 20, 2021 10:54 PM</para><b>Code Changes:</b><para>Created XML Comment</para></description>
        /// </item>
        /// </list>
        /// </remarks>
        public FileLogger(string category, StreamWriter writer)
        {
            _category = category;
            _writer = writer;
        }

        /// <summary>Begins a logical operation scope.</summary>
        /// <typeparam name="TState">The type of the state to begin scope for.</typeparam>
        /// <param name="state">The identifier for the scope.</param>
        /// <returns>An <see cref="T:System.IDisposable" /> that ends the logical operation scope on dispose.</returns>
        /// <remarks><para>
        ///   <b>History:</b>
        /// </para>
        /// <list type="table">
        ///   <listheader>
        ///     <devName>Developer\Date\Time</devName>
        ///     <devCompany>Developer Company</devCompany>
        ///     <devPhone>Developer Phone</devPhone>
        ///     <devEmail>Developer Email</devEmail>
        ///     <devMachine>Developer On</devMachine>
        ///     <description>Description</description>
        ///   </listheader>
        ///   <item>
        ///     <devName>
        /// Developer: Danny C. McNaught
        /// <para>Date: Saturday, February 1, 2020</para><para>Time: 17:04 PM</para></devName>
        ///     <devCompany>Computer Question</devCompany>
        ///     <devPhone>1-919-239-3306</devPhone>
        ///     <devEmail>
        ///       <a href="mailto:sfcsarge@outlook.com">mailto:sfcsarge@outlook.com</a>
        ///     </devEmail>
        ///     <devMachine>SURFACE-PRO-LTE</devMachine>
        ///     <description>Created XML Comment</description>
        ///   </item>
        /// </list></remarks>
        /// <remarks>
        /// <para><b>History:</b></para>
        /// <list type="table">
        /// <item>
        /// <description><b>Code Changed by:</b><para>Danny C. McNaught</para><para><para><a href="mailto:danny.mcnaught@dannymcnaught.com">danny.mcnaught@dannymcnaught.com</a></para></para></description>
        /// </item>
        /// <item>
        /// <description><b>Code changed on Visual Studio Host Machine:</b><para>DESKTOP-ACLFE3O</para></description>
        /// </item>
        /// <item>
        /// <description><b>Code Change Date and Time:</b><para>Sunday, June 20, 2021 10:54 PM</para><b>Code Changes:</b><para>Created XML Comment</para></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <exception cref="System.NotImplementedException"></exception>
        /// <exception cref="NotImplementedException"></exception>
        public IDisposable BeginScope<TState>(TState state) => throw new NotImplementedException();

        /// <summary>Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.</summary>
        /// <remarks><para>
        ///   <b>History:</b>
        /// </para>
        /// <list type="table">
        ///   <listheader>
        ///     <devName>Developer\Date\Time</devName>
        ///     <devCompany>Developer Company</devCompany>
        ///     <devPhone>Developer Phone</devPhone>
        ///     <devEmail>Developer Email</devEmail>
        ///     <devMachine>Developer On</devMachine>
        ///     <description>Description</description>
        ///   </listheader>
        ///   <item>
        ///     <devName>
        /// Developer: Danny C. McNaught
        /// <para>Date: Saturday, February 1, 2020</para><para>Time: 17:04 PM</para></devName>
        ///     <devCompany>Computer Question</devCompany>
        ///     <devPhone>1-919-239-3306</devPhone>
        ///     <devEmail>
        ///       <a href="mailto:sfcsarge@outlook.com">mailto:sfcsarge@outlook.com</a>
        ///     </devEmail>
        ///     <devMachine>SURFACE-PRO-LTE</devMachine>
        ///     <description>Created XML Comment</description>
        ///   </item>
        /// </list></remarks>
        /// <remarks>
        /// <para><b>History:</b></para>
        /// <list type="table">
        /// <item>
        /// <description><b>Code Changed by:</b><para>Danny C. McNaught</para><para><para><a href="mailto:danny.mcnaught@dannymcnaught.com">danny.mcnaught@dannymcnaught.com</a></para></para></description>
        /// </item>
        /// <item>
        /// <description><b>Code changed on Visual Studio Host Machine:</b><para>DESKTOP-ACLFE3O</para></description>
        /// </item>
        /// <item>
        /// <description><b>Code Change Date and Time:</b><para>Sunday, June 20, 2021 10:54 PM</para><b>Code Changes:</b><para>Created XML Comment</para></description>
        /// </item>
        /// </list>
        /// </remarks>
        public void Dispose()
        {
            _writer = null;
        }

        /// <summary>Checks if the given <paramref name="logLevel" /> is enabled.</summary>
        /// <param name="logLevel">level to be checked.</param>
        /// <returns><c>true</c> if enabled.</returns>
        /// <remarks><para>
        ///   <b>History:</b>
        /// </para>
        /// <list type="table">
        ///   <listheader>
        ///     <devName>Developer\Date\Time</devName>
        ///     <devCompany>Developer Company</devCompany>
        ///     <devPhone>Developer Phone</devPhone>
        ///     <devEmail>Developer Email</devEmail>
        ///     <devMachine>Developer On</devMachine>
        ///     <description>Description</description>
        ///   </listheader>
        ///   <item>
        ///     <devName>
        /// Developer: Danny C. McNaught
        /// <para>Date: Saturday, February 1, 2020</para><para>Time: 17:04 PM</para></devName>
        ///     <devCompany>Computer Question</devCompany>
        ///     <devPhone>1-919-239-3306</devPhone>
        ///     <devEmail>
        ///       <a href="mailto:sfcsarge@outlook.com">mailto:sfcsarge@outlook.com</a>
        ///     </devEmail>
        ///     <devMachine>SURFACE-PRO-LTE</devMachine>
        ///     <description>Created XML Comment</description>
        ///   </item>
        /// </list></remarks>
        /// <remarks>
        /// <para><b>History:</b></para>
        /// <list type="table">
        /// <item>
        /// <description><b>Code Changed by:</b><para>Danny C. McNaught</para><para><para><a href="mailto:danny.mcnaught@dannymcnaught.com">danny.mcnaught@dannymcnaught.com</a></para></para></description>
        /// </item>
        /// <item>
        /// <description><b>Code changed on Visual Studio Host Machine:</b><para>DESKTOP-ACLFE3O</para></description>
        /// </item>
        /// <item>
        /// <description><b>Code Change Date and Time:</b><para>Sunday, June 20, 2021 10:54 PM</para><b>Code Changes:</b><para>Created XML Comment</para></description>
        /// </item>
        /// </list>
        /// </remarks>
        public bool IsEnabled(LogLevel logLevel)
        {
            return true;
        }

        /// <summary>Writes a log entry.</summary>
        /// <typeparam name="TState">The type of the object to be written.</typeparam>
        /// <param name="logLevel">Entry will be written on this level.</param>
        /// <param name="eventId">Id of the event.</param>
        /// <param name="state">The entry to be written. Can be also an object.</param>
        /// <param name="exception">The exception related to this entry.</param>
        /// <param name="formatter">Function to create a <see cref="T:System.String" /> message of the <paramref name="state" /> and <paramref name="exception" />.</param>
        /// <remarks><para>
        ///   <b>History:</b>
        /// </para>
        /// <list type="table">
        ///   <listheader>
        ///     <devName>Developer\Date\Time</devName>
        ///     <devCompany>Developer Company</devCompany>
        ///     <devPhone>Developer Phone</devPhone>
        ///     <devEmail>Developer Email</devEmail>
        ///     <devMachine>Developer On</devMachine>
        ///     <description>Description</description>
        ///   </listheader>
        ///   <item>
        ///     <devName>
        /// Developer: Danny C. McNaught
        /// <para>Date: Saturday, February 1, 2020</para><para>Time: 17:04 PM</para></devName>
        ///     <devCompany>Computer Question</devCompany>
        ///     <devPhone>1-919-239-3306</devPhone>
        ///     <devEmail>
        ///       <a href="mailto:sfcsarge@outlook.com">mailto:sfcsarge@outlook.com</a>
        ///     </devEmail>
        ///     <devMachine>SURFACE-PRO-LTE</devMachine>
        ///     <description>Created XML Comment</description>
        ///   </item>
        /// </list></remarks>
        /// <remarks>
        /// <para><b>History:</b></para>
        /// <list type="table">
        /// <item>
        /// <description><b>Code Changed by:</b><para>Danny C. McNaught</para><para><para><a href="mailto:danny.mcnaught@dannymcnaught.com">danny.mcnaught@dannymcnaught.com</a></para></para></description>
        /// </item>
        /// <item>
        /// <description><b>Code changed on Visual Studio Host Machine:</b><para>DESKTOP-ACLFE3O</para></description>
        /// </item>
        /// <item>
        /// <description><b>Code Change Date and Time:</b><para>Sunday, June 20, 2021 10:54 PM</para><b>Code Changes:</b><para>Created XML Comment</para></description>
        /// </item>
        /// </list>
        /// </remarks>
        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            StreamWriter writer = _writer;
            if (writer == null)
            {
                return;
            }

            string message = formatter(state, exception);
            lock (writer)
            {
                writer.WriteLine("[{0:u}] <{1}> ({2}):", DateTime.Now, _category, logLevel.ToString()[0]);
                writer.WriteLine(message);

                if (exception != null)
                {
                    writer.WriteLine("Exception: " + exception);
                }

                writer.WriteLine();
                writer.Flush();
            }
        }
    }
}
