//***********************************************************************
// Assembly         : StartDevDrive
// Author           : Danny C. McNaught
// Created          : 01-19-2020
//
// Last Modified By : Danny C. McNaught
// Last Modified On : Sunday, June 20, 2021 10:03:03 PM
// ***********************************************************************
// <copyright file="FileLoggerProvider.cs" company="Computer Question">
//     Computer Question 2021
// </copyright>
// Change Request # :
// Version Number   :
// File Name        : FileLoggerProvider.cs
// <summary></summary>
// ***********************************************************************
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using static System.FormattableString;
namespace StartDevDrive
{
    /// <summary>Class FileLoggerProvider</summary>
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
    /// <description><b>Code Change Date and Time:</b><para>Sunday, June 20, 2021 10:44 PM</para><b>Code Changes:</b><para>Created XML Comment</para></description>
    /// </item>
    /// </list>
    /// </remarks>
    public sealed class FileLoggerProvider : ILoggerProvider
    {
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
        /// <description><b>Code Change Date and Time:</b><para>Sunday, June 20, 2021 10:44 PM</para><b>Code Changes:</b><para>Created XML Comment</para></description>
        /// </item>
        /// </list>
        /// </remarks>
        private readonly StreamWriter _writer;
        /// <summary>The loggers</summary>
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
        /// <description><b>Code Change Date and Time:</b><para>Sunday, June 20, 2021 10:44 PM</para><b>Code Changes:</b><para>Created XML Comment</para></description>
        /// </item>
        /// </list>
        /// </remarks>
        private readonly List<FileLogger> _loggers = new();

        /// <summary>Initializes a new instance of the <see cref="FileLoggerProvider" /> class.</summary>
        /// <param name="name">The name.</param>
        /// <param name="logFolder">The log folder.</param>
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
        /// <description><b>Code Change Date and Time:</b><para>Sunday, June 20, 2021 10:44 PM</para><b>Code Changes:</b><para>Created XML Comment</para></description>
        /// </item>
        /// </list>
        /// </remarks>
        public FileLoggerProvider(string name = null, string logFolder = null)
            : this(File.CreateText(GetLogFileName(name, logFolder)))
        {
        }

        /// <summary>Initializes a new instance of the <see cref="FileLoggerProvider" /> class.</summary>
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
        /// <description><b>Code Change Date and Time:</b><para>Sunday, June 20, 2021 10:44 PM</para><b>Code Changes:</b><para>Created XML Comment</para></description>
        /// </item>
        /// </list>
        /// </remarks>
        public FileLoggerProvider(StreamWriter writer)
        {
            _writer = writer;
        }

        /// <summary>Gets the name of the log file.</summary>
        /// <param name="name">The name.</param>
        /// <param name="logFolder">The log folder.</param>
        /// <returns>System.String.</returns>
        /// <remarks><para>
        ///   <b>History:</b>
        /// </para>
        /// <list type="table">
        ///   <listheader>
        ///     <devName>Developer\Date\Time</devName>
        ///     <devCompany>Developer Company</devCompany>
        ///     <devPhone>Developer Phone</devPhone>
        ///     <devEmail>Developer Email</devEmail>
        ///     <devMachine>Developed On</devMachine>
        ///     <description>Description</description>
        ///   </listheader>
        ///   <item>
        ///     <devName>
        /// Developer: Danny C. McNaught
        /// <para>Date: Friday, July 26, 2019</para><para>Time: 8:27 AM</para></devName>
        ///     <devCompany>United States Postal Service</devCompany>
        ///     <devPhone>1-984-292-3437</devPhone>
        ///     <devEmail>
        ///       <a href="mailto:danny.mcnaught@uspsector.com">mailto:danny.mcnaught@uspsector.com</a>
        ///       <para>
        ///         <a href="mailto:danny.c.mcnaught@usps.gov">mailto:danny.c.mcnaught@usps.gov</a>
        ///       </para>
        ///       <para>
        ///         <a href="mailto:sfcsarge@outlook.com">mailto:sfcsarge@outlook.com</a>
        ///       </para>
        ///     </devEmail>
        ///     <devMachine>G25FZQ2</devMachine>
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
        /// <description><b>Code Change Date and Time:</b><para>Sunday, June 20, 2021 10:44 PM</para><b>Code Changes:</b><para>Created XML Comment</para></description>
        /// </item>
        /// </list>
        /// </remarks>
        private static string GetLogFileName(string name, string logFolder)
        {
            //if (!string.IsNullOrEmpty(name))
            //{
            //    name = "_" + name;
            //}

            if (string.IsNullOrEmpty(logFolder))
            {
                logFolder = Path.GetTempPath();
            }
            string applicationFullPath = $@"{AppPath()}\{AppName()}.exe";
            if (applicationFullPath.StartsWith("file:\\", StringComparison.CurrentCulture))
            {
                applicationFullPath = applicationFullPath[6..];
            }

            string VersionNumber = FileVersionInfo.GetVersionInfo(applicationFullPath).FileVersion;

            return Path.Combine(logFolder, Invariant($@"{name}_{VersionNumber}_{DateTime.Now:yyyyMdd_HHmmss}_pid{Environment.ProcessId}.log"));
        }

        /// <summary>Applications the path.</summary>
        /// <returns>System.String.</returns>
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
        /// <description><b>Code Change Date and Time:</b><para>Sunday, June 20, 2021 10:44 PM</para><b>Code Changes:</b><para>Created XML Comment</para></description>
        /// </item>
        /// </list>
        /// </remarks>
        public static string AppPath()
        {
            return Path.GetDirectoryName(System.AppContext.BaseDirectory); //Assembly.GetExecutingAssembly().GetName().CodeBase
        }

        /// <summary>Applications the name.</summary>
        /// <returns>System.String.</returns>
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
        /// <description><b>Code Change Date and Time:</b><para>Sunday, June 20, 2021 10:44 PM</para><b>Code Changes:</b><para>Created XML Comment</para></description>
        /// </item>
        /// </list>
        /// </remarks>
        public static string AppName()
        {
            return Assembly.GetExecutingAssembly().GetName().Name;
        }

        /// <summary>Creates a new T:Microsoft.Extensions.Logging.ILogger instance.</summary>
        /// <param name="categoryName">The category name for messages produced by the logger.</param>
        /// <returns>ILogger.</returns>
        /// <remarks><para>
        ///   <b>History:</b>
        /// </para>
        /// <list type="table">
        ///   <listheader>
        ///     <devName>Developer\Date\Time</devName>
        ///     <devCompany>Developer Company</devCompany>
        ///     <devPhone>Developer Phone</devPhone>
        ///     <devEmail>Developer Email</devEmail>
        ///     <devMachine>Developed On</devMachine>
        ///     <description>Description</description>
        ///   </listheader>
        ///   <item>
        ///     <devName>
        /// Developer: Danny C. McNaught
        /// <para>Date: Friday, July 26, 2019</para><para>Time: 8:27 AM</para></devName>
        ///     <devCompany>United States Postal Service</devCompany>
        ///     <devPhone>1-984-292-3437</devPhone>
        ///     <devEmail>
        ///       <a href="mailto:danny.mcnaught@uspsector.com">mailto:danny.mcnaught@uspsector.com</a>
        ///       <para>
        ///         <a href="mailto:danny.c.mcnaught@usps.gov">mailto:danny.c.mcnaught@usps.gov</a>
        ///       </para>
        ///       <para>
        ///         <a href="mailto:sfcsarge@outlook.com">mailto:sfcsarge@outlook.com</a>
        ///       </para>
        ///     </devEmail>
        ///     <devMachine>G25FZQ2</devMachine>
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
        /// <description><b>Code Change Date and Time:</b><para>Sunday, June 20, 2021 10:44 PM</para><b>Code Changes:</b><para>Created XML Comment</para></description>
        /// </item>
        /// </list>
        /// </remarks>
        public ILogger CreateLogger(string categoryName)
        {
            var logger = new FileLogger(categoryName, _writer);
            _loggers.Add(logger);
            return logger;
        }

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
        ///     <devMachine>Developed On</devMachine>
        ///     <description>Description</description>
        ///   </listheader>
        ///   <item>
        ///     <devName>
        /// Developer: Danny C. McNaught
        /// <para>Date: Friday, July 26, 2019</para><para>Time: 8:27 AM</para></devName>
        ///     <devCompany>United States Postal Service</devCompany>
        ///     <devPhone>1-984-292-3437</devPhone>
        ///     <devEmail>
        ///       <a href="mailto:danny.mcnaught@uspsector.com">mailto:danny.mcnaught@uspsector.com</a>
        ///       <para>
        ///         <a href="mailto:danny.c.mcnaught@usps.gov">mailto:danny.c.mcnaught@usps.gov</a>
        ///       </para>
        ///       <para>
        ///         <a href="mailto:sfcsarge@outlook.com">mailto:sfcsarge@outlook.com</a>
        ///       </para>
        ///     </devEmail>
        ///     <devMachine>G25FZQ2</devMachine>
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
        /// <description><b>Code Change Date and Time:</b><para>Sunday, June 20, 2021 10:44 PM</para><b>Code Changes:</b><para>Created XML Comment</para></description>
        /// </item>
        /// </list>
        /// </remarks>
        public void Dispose()
        {
            foreach (var logger in _loggers)
            {
                logger.Dispose();
            }
            _writer.Dispose();
        }
    }
}
