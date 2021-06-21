//***********************************************************************
// Assembly         : StartDevDrive
// Author           : Danny C. McNaught
// Created          : 02-02-2020
//
// Last Modified By : Danny C. McNaught
// Last Modified On : Sunday, June 20, 2021 10:03:03 PM
// ***********************************************************************
// <copyright file="QueryUserNotificationState.cs" company="Computer Question">
//     Computer Question 2021
// </copyright>
// Change Request # :
// Version Number   :
// File Name        : QueryUserNotificationState.cs
// <summary></summary>
// ***********************************************************************
using System.Runtime.InteropServices;

namespace StartDevDrive
{
    /// <summary>Class QueryUserNotificationState</summary>
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
    static class QueryUserNotificationState
    {
        /// <summary>[ERROR: invalid expression FieldName.Words.TheAndAllAsSentence]</summary>
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
        public enum UserNotificationState
        {
            /// <summary>A screen saver is displayed, the machine is locked,
            /// or a nonactive Fast User Switching session is in progress.</summary>
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
            NotPresent = 1,

            /// <summary>A full-screen application is running or Presentation Settings are applied.
            /// Presentation Settings allow a user to put their machine into a state fit
            /// for an uninterrupted presentation, such as a set of PowerPoint slides, with a single click.</summary>
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
            Busy = 2,

            /// <summary>A full-screen (exclusive mode) Direct3D application is running.</summary>
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
            RunningDirect3dFullScreen = 3,

            /// <summary>The user has activated Windows presentation settings to block notifications and pop-up messages.</summary>
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
            PresentationMode = 4,

            /// <summary>None of the other states are found, notifications can be freely sent.</summary>
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
            AcceptsNotifications = 5,

            /// <summary>Introduced in Windows 7. The current user is in "quiet time", which is the first hour after
            /// a new user logs into his or her account for the first time. During this time, most notifications
            /// should not be sent or shown. This lets a user become accustomed to a new computer system
            /// without those distractions.
            /// Quiet time also occurs for each user after an operating system upgrade or clean installation.</summary>
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
            QuietTime = 6
        };

        /// <summary>Shes the state of the query user notification.</summary>
        /// <param name="userNotificationState">State of the user notification.</param>
        /// <returns>System.Int32.</returns>
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
        /// <para>Date: Sunday, February 2, 2020</para><para>Time: 15:32 PM</para></devName>
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
        [DllImport("shell32.dll")]
        static extern int SHQueryUserNotificationState(out UserNotificationState userNotificationState);

        /// <summary>States this instance.</summary>
        /// <returns>UserNotificationState.</returns>
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
        /// <para>Date: Sunday, February 2, 2020</para><para>Time: 15:32 PM</para></devName>
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
        public static UserNotificationState State()
        {
            _ = SHQueryUserNotificationState(out UserNotificationState state);
            return state;
        }
    }
}
