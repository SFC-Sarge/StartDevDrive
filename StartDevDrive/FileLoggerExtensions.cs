//***********************************************************************
// Assembly         : StartDevDrive
// Author UserID    : sfcsarge
// Author Full Name : Danny C. McNaught
// Author Phone     : 1-919-239-3306
// Created          : 01-19-2020
//
// Created By       : Danny C. McNaught
// Developer Email  : sfcsarge@outlook.com
// Last Modified By : Danny C. McNaught
// Last Modified On : 01-19-2020
// Change Request # :
// Version Number   :
// Description      : 
// File Name        : FileLoggerExtensions.cs
// Copyright        : (c) Computer Question. All rights reserved.
// <summary></summary>
// ***********************************************************************
using Microsoft.Extensions.Logging;

namespace StartDevDrive
{
    /// <summary>
    ///    Class FileLoggerExtensions
    /// </summary>
    /// <remarks>
    ///  	<para><b>History:</b></para>
    ///  	<list type="table">
    ///  		<listheader>
    ///  			<devName>Developer\Date\Time</devName>
    ///  			<devCompany>Developer Company</devCompany>
    ///  			<devPhone>Developer Phone</devPhone>
    ///  			<devEmail>Developer Email</devEmail>
    ///  			<devMachine>Developer On</devMachine>
    ///  			<description>Description</description>
    ///  		</listheader>
    ///  		<item>
    ///  				<devName>
    /// 		Developer: Danny C. McNaught
    /// 		<para>Date: Saturday, February 1, 2020</para>
    /// 		<para>Time: 17:04 PM</para>
    /// 	</devName>
    ///  			<devCompany>Computer Question</devCompany>
    ///  			<devPhone>1-919-239-3306</devPhone>
    ///  				<devEmail>
    /// 		<a href="mailto:sfcsarge@outlook.com">mailto:sfcsarge@outlook.com</a>
    /// 	</devEmail>
    ///  			<devMachine>SURFACE-PRO-LTE</devMachine>
    ///  			<description>Created XML Comment</description>
    ///  		</item>
    ///  	</list>
    /// </remarks>
    public static class FileLoggerExtensions
    {
        /// <summary>
        /// Adds the file.
        /// </summary>
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
        ///  	<para><b>History:</b></para>
        ///  	<list type="table">
        ///  		<listheader>
        ///  			<devName>Developer\Date\Time</devName>
        ///  			<devCompany>Developer Company</devCompany>
        ///  			<devPhone>Developer Phone</devPhone>
        ///  			<devEmail>Developer Email</devEmail>
        ///  			<devMachine>Developer On</devMachine>
        ///  			<description>Description</description>
        ///  		</listheader>
        ///  		<item>
        ///  				<devName>
        /// 		Developer: Danny C. McNaught
        /// 		<para>Date: Saturday, February 1, 2020</para>
        /// 		<para>Time: 17:04 PM</para>
        /// 	</devName>
        ///  			<devCompany>Computer Question</devCompany>
        ///  			<devPhone>1-919-239-3306</devPhone>
        ///  				<devEmail>
        /// 		<a href="mailto:sfcsarge@outlook.com">mailto:sfcsarge@outlook.com</a>
        /// 	</devEmail>
        ///  			<devMachine>SURFACE-PRO-LTE</devMachine>
        ///  			<description>Created XML Comment</description>
        ///  		</item>
        ///  	</list>
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
