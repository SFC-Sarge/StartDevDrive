//***********************************************************************
// Assembly         : StartDevDrive
// Author UserID    : sfcsarge
// Author Full Name : Danny C. McNaught
// Author Phone     : 1-919-239-3306
// Created          : 01-18-2020
//
// Created By       : Danny C. McNaught
// Developer Email  : sfcsarge@outlook.com
// Last Modified By : Danny C. McNaught
// Last Modified On : 02-01-2020
// Change Request # :
// Version Number   :
// Description      :
// File Name        : Program.cs
// Copyright        : (c) Computer Question. All rights reserved.
// <summary></summary>
// ***********************************************************************
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
//using System.Windows.Forms;

namespace StartDevDrive
{
    /// <summary>
    ///    Class Program
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
    /// 		<para>Time: 17:01 PM</para>
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
    class Program
    {
        /// <summary>
        /// Gets or sets the factory.
        /// </summary>
        /// <value>The factory.</value>
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
        /// 		<para>Time: 17:01 PM</para>
        /// 	</devName>
        ///  			<devCompany>Computer Question</devCompany>
        ///  			<devPhone>1-919-239-3306</devPhone>
        ///  				<devEmail>
        /// 		<a href="mailto:sfcsarge@outlook.com">mailto:sfcsarge@outlook.com</a>
        /// 	</devEmail>
        ///  			<devMachine>SURFACE-PRO-LTE</devMachine>
        ///  			<description>Created XML Comment</description>
        ///  		</item>
        ///  		<item>
        ///  				<devName>
        /// 		Developer: Danny C. McNaught
        /// 		<para>Date: Saturday, February 1, 2020</para>
        /// 		<para>Time: 17:01 PM</para>
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
        public static ILoggerFactory Factory { get; set; }
        /// <summary>
        /// Gets or sets the logger.
        /// </summary>
        /// <value>The logger.</value>
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
        /// 		<para>Time: 17:01 PM</para>
        /// 	</devName>
        ///  			<devCompany>Computer Question</devCompany>
        ///  			<devPhone>1-919-239-3306</devPhone>
        ///  				<devEmail>
        /// 		<a href="mailto:sfcsarge@outlook.com">mailto:sfcsarge@outlook.com</a>
        /// 	</devEmail>
        ///  			<devMachine>SURFACE-PRO-LTE</devMachine>
        ///  			<description>Created XML Comment</description>
        ///  		</item>
        ///  		<item>
        ///  				<devName>
        /// 		Developer: Danny C. McNaught
        /// 		<para>Date: Saturday, February 1, 2020</para>
        /// 		<para>Time: 17:01 PM</para>
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
        public static ILogger Logger { get; set; }
        /// <summary>
        /// Gets or sets the d drive counter.
        /// </summary>
        /// <value>The d drive counter.</value>
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
        /// 		<para>Time: 17:01 PM</para>
        /// 	</devName>
        ///  			<devCompany>Computer Question</devCompany>
        ///  			<devPhone>1-919-239-3306</devPhone>
        ///  				<devEmail>
        /// 		<a href="mailto:sfcsarge@outlook.com">mailto:sfcsarge@outlook.com</a>
        /// 	</devEmail>
        ///  			<devMachine>SURFACE-PRO-LTE</devMachine>
        ///  			<description>Created XML Comment</description>
        ///  		</item>
        ///  		<item>
        ///  				<devName>
        /// 		Developer: Danny C. McNaught
        /// 		<para>Date: Saturday, February 1, 2020</para>
        /// 		<para>Time: 17:01 PM</para>
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
        public static int DDriveCounter { get; set; }
        public static bool IconsRefreshed { get; set; } = false;
        /// <summary>
        /// Gets or sets the e drive counter.
        /// </summary>
        /// <value>The e drive counter.</value>
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
        /// 		<para>Time: 17:01 PM</para>
        /// 	</devName>
        ///  			<devCompany>Computer Question</devCompany>
        ///  			<devPhone>1-919-239-3306</devPhone>
        ///  				<devEmail>
        /// 		<a href="mailto:sfcsarge@outlook.com">mailto:sfcsarge@outlook.com</a>
        /// 	</devEmail>
        ///  			<devMachine>SURFACE-PRO-LTE</devMachine>
        ///  			<description>Created XML Comment</description>
        ///  		</item>
        ///  		<item>
        ///  				<devName>
        /// 		Developer: Danny C. McNaught
        /// 		<para>Date: Saturday, February 1, 2020</para>
        /// 		<para>Time: 17:01 PM</para>
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
        public static int EDriveCounter { get; set; }
        public static string AppLocation { get; set; } = AppContext.BaseDirectory;
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
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
        /// 		<para>Time: 17:01 PM</para>
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
        static async Task Main(string[] args)
        {
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(fileName: $@"{AppLocation}\StartDevDrive.exe"); // Assembly.GetExecutingAssembly().Location);
            string version = $"Application version: {fvi.FileVersion}";
            DDriveCounter = 0;
            EDriveCounter = 0;
            if (args.Length == 0)
            {
                args = new string[2];
                args.SetValue("1000", 0);
                args.SetValue($@"{Properties.Resources.AppLogLocation}", 1);
            }
            Process[] processes = Process.GetProcessesByName("StartDevDrive");
            if (processes.Select(p => p.Id.ToString()).ToArray().Length > 1)
            {
                Environment.Exit(0);
            }
            if (!Directory.Exists(args[1]))
            {
                Directory.CreateDirectory(args[1]);
            }
            else
            {
                DirectoryInfo directory = new(args[1]);
                directory.EnumerateFiles().ToList().ForEach(f => f.Delete());
            }
            Factory = new LoggerFactory().AddFile("StartDevDrive", args[1]);
            Logger = Factory.CreateLogger("Mount Development Drive");
            Logger.LogInformation(message: $@"Start Dev Drive Begins.");
            Logger.LogInformation(message: $@"StartDevDrive.exe version: {version}.");
            Logger.LogInformation(message: $@"Checking for {Properties.Resources.MountFileName} file in {AppLocation} drive!");
            if (!File.Exists($"{AppLocation}{Properties.Resources.MountFileName}"))
            {
                do
                {
                    DDriveCounter++;
                    Logger.LogWarning(message: $@"File {AppLocation}{Properties.Resources.MountFileName} not found.");
                    Logger.LogWarning(message: $@"File {AppLocation}{Properties.Resources.MountFileName} not found. Thread Sleep for: {args[0]}");
                    Logger.LogWarning(message: $@"File {AppLocation}{Properties.Resources.MountFileName} not found loop counter: {DDriveCounter}.");
                    await CreateDevelopmentTxtFileAsync(Properties.Resources.VhdxDriveLocation, Properties.Resources.VhdxFileName, $"{AppLocation}{Properties.Resources.MountFileName}", Properties.Resources.VhdxAssignedDriveLetter);
                    Thread.Sleep(Convert.ToInt32(args[0]));
                } while (!File.Exists($@"{AppLocation}{Properties.Resources.MountFileName}"));
            }
            Logger.LogInformation(message: $@"File {AppLocation}{Properties.Resources.MountFileName} found loop completed with total count: {DDriveCounter}.");
            Logger.LogInformation(message: $@"File {AppLocation}{Properties.Resources.MountFileName} found. StartDevDrive Continues.");
            Logger.LogInformation(message: $@"Checking for Development.vhdx File in {Properties.Resources.VhdxDriveLocation} drive!");
            if (!File.Exists($@"{Properties.Resources.VhdxDriveLocation}\Development.vhdx"))
            {
                do
                {
                    DDriveCounter++;
                    Logger.LogWarning(message: $@"File {Properties.Resources.VhdxDriveLocation}\Development.vhdx not found.");
                    Logger.LogWarning(message: $@"File {Properties.Resources.VhdxDriveLocation}\Development.vhdx not found. Thread Sleep for: {args[0]}");
                    Logger.LogWarning(message: $@"File {Properties.Resources.VhdxDriveLocation}\Development.vhdx not found loop counter: {DDriveCounter}.");
                    Thread.Sleep(Convert.ToInt32(args[0]));
                } while (!File.Exists($@"{Properties.Resources.VhdxDriveLocation}\Development.vhdx"));
            }
            Logger.LogInformation(message: $@"File {Properties.Resources.VhdxDriveLocation}\Development.vhdx found loop completed with total count: {DDriveCounter}.");
            Logger.LogInformation(message: $@"File {Properties.Resources.VhdxDriveLocation}\Development.vhdx found. StartDevDrive Continues.");
            if (!Directory.Exists($@"{Properties.Resources.VhdxAssignedDriveLetter}\Program Files (x86)\Microsoft Visual Studio\2019\Enterprise\Common7\IDE"))
            {
                do
                {
                    EDriveCounter++;
                    Logger.LogInformation(message: $@"Directory {Properties.Resources.VhdxAssignedDriveLetter}\Program Files (x86)\Microsoft Visual Studio\2019\Enterprise\Common7\IDE not found loop counter: {EDriveCounter}.");
                    if (!Directory.Exists($@"{Properties.Resources.VhdxAssignedDriveLetter}\Program Files (x86)\Microsoft Visual Studio\2019\Enterprise\Common7\IDE"))
                    {
                        Logger.LogWarning(message: $@"{Properties.Resources.VhdxAssignedDriveLetter}\Program Files (x86)\Microsoft Visual Studio\2019\Enterprise\Common7\IDE\devenv.exe does not exist.");
                        await MountDriveTasksAsync();
                    }
                    else
                    {
                        continue;
                    }
                } while (!Directory.Exists($@"{Properties.Resources.VhdxAssignedDriveLetter}\Program Files (x86)\Microsoft Visual Studio\2019\Enterprise\Common7\IDE"));
            }
            Logger.LogWarning(message: $@"{Properties.Resources.VhdxAssignedDriveLetter}\Program Files (x86)\Microsoft Visual Studio\2019\Enterprise\Common7\IDE\devenv.exe exist.");
            Logger.LogInformation(message: $@"Directory {Properties.Resources.VhdxAssignedDriveLetter}\Program Files (x86)\Microsoft Visual Studio\2019\Enterprise\Common7\IDE found loop completed with total count: {EDriveCounter}.");
            Logger.LogInformation(message: $@"Directory {Properties.Resources.VhdxAssignedDriveLetter}\Program Files (x86)\Microsoft Visual Studio\2019\Enterprise\Common7\IDE found. StartDevDrive Continues.");
            Logger.LogInformation(message: $@"Ready to Refresh Desktop Icons. First Pass. Thread Sleep for: {Convert.ToInt32(args[0]) * 10}");
            int timeout = Convert.ToInt32(args[0]) * 10;
            int passCount = 0;
            do
            {
                Thread.Sleep(timeout);
                Logger.LogInformation(message: $@"Ready to Refresh Desktop Icons. Pass {passCount}. Thread Sleep for: {timeout}");
                timeout++;
                passCount++;
                await RefreshIconCacheTasksAsync();
            } while (!IconsRefreshed);
            Logger.LogInformation(message: $@"Start Dev Drive Ends. StartDevDrive.exe version: {version}.");
            Environment.Exit(0);
        }

        /// <summary>
        /// Refreshes the icon cache.
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
        /// 		<para>Time: 17:01 PM</para>
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
        public static StringBuilder RefreshIconCache()
        {
            StringBuilder stringBuilder = new();
            string processCommandLine = string.Empty;
            try
            {
                string workingDirectory = @"C:\Windows\System32";
                string exefile = "ie4uinit.exe";
                ProcessStartInfo startInfo = new();
                startInfo.ArgumentList.Add("-show");
                startInfo.CreateNoWindow = true;
                startInfo.UseShellExecute = false;
                //startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.FileName = Path.Combine(workingDirectory, exefile);
                using (Process process = new())
                {
                    processCommandLine = $@"{startInfo.WorkingDirectory}\{startInfo.FileName} {startInfo.ArgumentList.ToList().FirstOrDefault()}";
                    Logger.LogInformation(message: $@"Refreshing System Icons {processCommandLine}.");
                    process.StartInfo = startInfo;
                    process.Start();
                    process.WaitForExit();
                    process.Close();
                }
                Logger.LogInformation(message: $@"Refreshed System Icons {processCommandLine}.");
                _ = stringBuilder.AppendLine("Success");
                return stringBuilder;
            }
            catch (Win32Exception ex)
            {
                Logger.LogError(message: $@"Win32Exception Message: {ex.Message} Stack Trace {ex.StackTrace}.");
                _ = stringBuilder.AppendLine("Failed");
                return stringBuilder;
            }
            catch (Exception ex)
            {
                Logger.LogError(message: $@"Exception Message: {ex.Message} Stack Trace {ex.StackTrace}.");
                _ = stringBuilder.AppendLine("Failed");
                return stringBuilder;
            }
        }

        /// <summary>Refreshes the icon cache tasks asynchronous.</summary>
        /// <remarks>
        ///   <para>
        ///     <b>History:</b>
        ///   </para>
        ///   <list type="table">
        ///     <listheader>
        ///       <term>Developer\Date\Time</term>
        ///       <term>Developer Company</term>
        ///       <term>Developer Phone</term>
        ///       <term>Developer Email</term>
        ///       <term>Developer On</term>
        ///       <term>Description</term>
        ///     </listheader>
        ///     <item>
        ///       <description>
        /// 		Developer: Danny C. McNaught
        /// 		<para>Date: Tuesday, May 26, 2020</para><para>Time: 21:39 PM</para></description>
        ///       <description>Computer Question</description>
        ///       <description>1-919-239-3306</description>
        ///       <description>
        ///         <a href="mailto:sfcsarge@outlook.com">mailto:sfcsarge@outlook.com</a>
        ///       </description>
        ///       <description>SURFACE-PRO-LTE</description>
        ///       <description>Created XML Comment</description>
        ///     </item>
        ///   </list>
        /// </remarks>
        public static async Task RefreshIconCacheTasksAsync()
        {
            CancellationTokenSource cts = new();
            CancellationToken token = cts.Token;
            Task result = Task.Factory.StartNew(() => RefreshIconCache(), token, TaskCreationOptions.None, TaskScheduler.Default).ContinueWith((antecedent) =>
            {
                switch (antecedent.Result.ToString().ToUpper(CultureInfo.CurrentCulture))
                {
                    case var result when new List<string>() { "SUCCESS\r\n" }.Contains(value: result):
                        Logger.LogInformation(message: $@"Refresh Icon Cache Successful.");
                        IconsRefreshed = true;
                        break;
                    case var result when new List<string>() { "FAILED\r\n" }.Contains(value: result):
                        Logger.LogError(message: $@"Refresh Icon Cache Failed.");
                        IconsRefreshed = false;
                        break;
                    default:
                        Logger.LogError(message: $@"Refresh Icon Cache Failed with {antecedent.Result}.");
                        IconsRefreshed = false;
                        break;
                }
            }, token, TaskContinuationOptions.OnlyOnRanToCompletion, TaskScheduler.Default);
            await Task.WhenAll(result).ConfigureAwait(false);
        }

        /// <summary>
        /// Mounts the drive tasks asynchronous.
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
        /// 		<para>Time: 17:01 PM</para>
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
        public static async Task MountDriveTasksAsync()
        {
            CancellationTokenSource cts = new();
            CancellationToken token = cts.Token;
            Task result = Task.Factory.StartNew(() => MountDrive(true), token, TaskCreationOptions.None, TaskScheduler.Default).ContinueWith((antecedent) =>
            {
                switch (antecedent.Result.ToString().ToUpper(CultureInfo.CurrentCulture))
                {
                    case var result when new List<string>() { "SUCCESS\r\n" }.Contains(value: result):
                        Logger.LogInformation(message: $@"Mounting Development Drive Successful.");
                        break;
                    case var result when new List<string>() { "FAILED\r\n" }.Contains(value: result):
                        Logger.LogError(message: $@"Mounting Development Drive Failed.");
                        break;
                    default:
                        Logger.LogError(message: $@"Mounting Development Drive Failed with {antecedent.Result}.");
                        break;
                }
            }, token, TaskContinuationOptions.OnlyOnRanToCompletion, TaskScheduler.Default);
            await Task.WhenAll(result).ConfigureAwait(false);
        }

        /// <summary>
        /// Mounts the drive.
        /// </summary>
        /// <param name="defaultValue">if set to <c>true</c> [default value].</param>
        /// <returns>StringBuilder.</returns>
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
        /// 		<para>Time: 17:01 PM</para>
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
        public static StringBuilder MountDrive(bool defaultValue = false)
        {
            StringBuilder stringBuilder = new();
            Logger.LogInformation(message: $@"Called MountDrive({defaultValue}).");
            try
            {
                ProcessStartInfo startInfo = new();
                startInfo.ArgumentList.Add("/s");
                startInfo.ArgumentList.Add(@$"{AppLocation}\{Properties.Resources.MountFileName}");
                startInfo.CreateNoWindow = true;
                startInfo.UseShellExecute = false;
                //startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.FileName = Path.Combine(@"C:\Windows\System32", "diskpart.exe");
                using (Process process = new())
                {
                    process.StartInfo = startInfo;
                    process.Start();
                    process.WaitForExit();
                    process.Close();
                }
                Logger.LogInformation(message: $@"MountDrive({defaultValue}) result: true.");
                _ = stringBuilder.AppendLine("Success");
                return stringBuilder;
            }
            catch (Win32Exception ex)
            {
                Logger.LogError(message: $@"Win32Exception Message: {ex.Message} Stack Trace {ex.StackTrace}.");
                _ = stringBuilder.AppendLine("Failed");
                return stringBuilder;
            }
            catch (Exception ex)
            {
                Logger.LogError(message: $@"Exception Message: {ex.Message} Stack Trace {ex.StackTrace}.");
                _ = stringBuilder.AppendLine("Failed");
                return stringBuilder;
            }
        }
        
        public static async Task CreateDevelopmentTxtFileAsync(string vhdxDriveLocation, string vhdxFileName, string fileFullName, string vhdxDriveLetter)
        {
            string[] lines = { $"select vdisk file=\"{vhdxDriveLocation}{vhdxFileName}\"", "attach vdisk", $"assign letter={vhdxDriveLetter.First()}", "exit" };
            CancellationTokenSource cts = new();
            CancellationToken token = cts.Token;
            Task result = Task.Factory.StartNew(() => File.WriteAllLinesAsync(fileFullName, lines), token, TaskCreationOptions.None, TaskScheduler.Default).ContinueWith((antecedent) =>
            {
                switch (antecedent.Result.ToString().ToUpper(CultureInfo.CurrentCulture))
                {
                    case var result when new List<string>() { "SUCCESS\r\n" }.Contains(value: result):
                        Logger.LogInformation(message: $@"Mounting Development Drive Successful.");
                        break;
                    case var result when new List<string>() { "FAILED\r\n" }.Contains(value: result):
                        Logger.LogError(message: $@"Mounting Development Drive Failed.");
                        break;
                    default:
                        Logger.LogError(message: $@"Mounting Development Drive Failed with {antecedent.Result}.");
                        break;
                }
            }, token, TaskContinuationOptions.OnlyOnRanToCompletion, TaskScheduler.Default);
            await Task.WhenAll(result).ConfigureAwait(false);

        }

    }
}
