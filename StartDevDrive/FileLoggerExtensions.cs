//***********************************************************************
// Assembly         : StartDevDrive
// Author           : Danny C. McNaught
// Created          : 01-19-2020
//
// Last Modified By : Danny C. McNaught
// Last Modified On : Sunday, June 20, 2021 10:03:03 PM
// ***********************************************************************
// <copyright file="FileLoggerExtensions.cs" company="Computer Question">
//     Computer Question 2021
// </copyright>
// Change Request # :
// Version Number   :
// File Name        : FileLoggerExtensions.cs
// <summary></summary>
// ***********************************************************************
using Microsoft.Extensions.Logging;

namespace StartDevDrive
{
    /// <summary>Class FileLoggerExtensions</summary>
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
    public static class FileLoggerExtensions
    {
        /// <summary>Adds the file.</summary>
        /// <param name="factory">The factory.</param>
        /// <param name="name">The name.</param>
        /// <param name="logFolder">The log folder.</param>
        /// <returns>ILoggerFactory.</returns>
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
        /// <para>Date: Friday, July 26, 2019</para><para>Time: 7:27 AM</para></devName>
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
        /// <description><b>Code Change Date and Time:</b><para>Sunday, June 20, 2021 10:54 PM</para><b>Code Changes:</b><para>Created XML Comment</para></description>
        /// </item>
        /// </list>
        /// </remarks>
        public static ILoggerFactory AddFile(this ILoggerFactory factory, string name, string logFolder)
        {
            if (factory == null || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(logFolder))
            {
                return null;
            }

            factory.AddProvider(new FileLoggerProvider(name, logFolder));
            return factory;
        }
    }
}
