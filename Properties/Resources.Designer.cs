﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace steamBackup.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("steamBackup.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Absolute path needed, not relative.
        /// </summary>
        internal static string AbsolutePathExceptionText {
            get {
                return ResourceManager.GetString("AbsolutePathExceptionText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {\rtf1\ansi Click to \b select \b0 all games for backup.  The selection can be modified in the check box list. }.
        /// </summary>
        internal static string BackupAllButtonTooltip {
            get {
                return ResourceManager.GetString("BackupAllButtonTooltip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {\rtf1\ansi Cancels the backup procedure and navigates back to the main menu. }.
        /// </summary>
        internal static string BackupCancelButtonTooltip {
            get {
                return ResourceManager.GetString("BackupCancelButtonTooltip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {\rtf1\ansi Customize your selection of games to backup.  \b NOTE: \b0 Older games that utilize Valve&apos;s Source Engine share resources between each other, However Valve has patched this out. Make sure you have the latest version of these old steam games, this tool will not be able to backup or restore them otherwise. }.
        /// </summary>
        internal static string BackupCheckListTooltip {
            get {
                return ResourceManager.GetString("BackupCheckListTooltip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Backup Directory.
        /// </summary>
        internal static string BackupDir {
            get {
                return ResourceManager.GetString("BackupDir", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {\rtf1\ansi Click to \b deselect \b0 all games for backup.  The selection can be modified in the check box list. }.
        /// </summary>
        internal static string BackupNoneButtonTooltip {
            get {
                return ResourceManager.GetString("BackupNoneButtonTooltip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {\rtf1\ansi Starts the backup procedure with the above parameters }.
        /// </summary>
        internal static string BackupStartButtonTooltip {
            get {
                return ResourceManager.GetString("BackupStartButtonTooltip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please exit Steam before backing up. To continue, exit Steam and then click the &apos;Backup&apos; button again. Do Not start Steam until the backup process is finished..
        /// </summary>
        internal static string BackupSteamRunningText {
            get {
                return ResourceManager.GetString("BackupSteamRunningText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Do you want to cancel immediately? This could corrupt the games that are currently being worked on.
        ///Click &apos;Yes&apos; to stop immediately, or &apos;No&apos; to cancel once the current jobs have been finished..
        /// </summary>
        internal static string CancelQueryText {
            get {
                return ResourceManager.GetString("CancelQueryText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cancel immediately?.
        /// </summary>
        internal static string CancelQueryTitle {
            get {
                return ResourceManager.GetString("CancelQueryTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ______________________________________
        ///
        ///+ Added
        ///- Removed
        ///^ Updated
        ///* Bugfix.
        /// </summary>
        internal static string ChangeListLegend {
            get {
                return ResourceManager.GetString("ChangeListLegend", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Compression Level:
        ///.
        /// </summary>
        internal static string CompressionLevelText {
            get {
                return ResourceManager.GetString("CompressionLevelText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {\rtf1\ansi This will change how small the backup files are. Higher compression levels will use more ram and take longer but will result in far better compression. }.
        /// </summary>
        internal static string CompressionTooltip {
            get {
                return ResourceManager.GetString("CompressionTooltip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {\rtf1\ansi Hover your mouse over the controls to get further information. }.
        /// </summary>
        internal static string ControlsDefaultTooltip {
            get {
                return ResourceManager.GetString("ControlsDefaultTooltip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {\rtf1\ansi This will delete \b EVERYTHING \b0 in the &apos;Backup Directory&apos;. Make sure that there are no valuable files in there! }.
        /// </summary>
        internal static string DelBackupCheckBoxTooltip {
            get {
                return ResourceManager.GetString("DelBackupCheckBoxTooltip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Listed below are the errors for a backup or restore.
        ///
        ///Please try running the backup process again making sure that there are no programs accessing the files being backed up (e.g. Steam).
        ///
        ///To check the integrity of this backup: navigate to the backup location -&gt; Select all files in the &apos;common&apos; folder -&gt; right click -&gt; 7zip -&gt; Test archive. You should do the same for &apos;Source Games.7z&apos; also.
        ///.
        /// </summary>
        internal static string ErrorListHeader {
            get {
                return ResourceManager.GetString("ErrorListHeader", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Time: {0}, ETA: {1}.
        /// </summary>
        internal static string EtaFormatStr {
            get {
                return ResourceManager.GetString("EtaFormatStr", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Finding Files....
        /// </summary>
        internal static string FindingFilesText {
            get {
                return ResourceManager.GetString("FindingFilesText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Finished Job....
        /// </summary>
        internal static string FinishedJobText {
            get {
                return ResourceManager.GetString("FinishedJobText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Jobs finished with {0} of {1} completed!
        ///
        ///Steam Backup Tool finished without finding any errors..
        /// </summary>
        internal static string FinishedText {
            get {
                return ResourceManager.GetString("FinishedText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Finished Successfully.
        /// </summary>
        internal static string FinishedTitle {
            get {
                return ResourceManager.GetString("FinishedTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to WARNING!
        ///
        ///Jobs finished with {0} of {1} completed!
        ///
        ///However, Steam Backup Tool has encountered error, It is recommended that you look at the &apos;Error Log.txt&apos; file in the backup directory for a full list of errors..
        /// </summary>
        internal static string FinishedWithErrorsText {
            get {
                return ResourceManager.GetString("FinishedWithErrorsText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Errors Found.
        /// </summary>
        internal static string FinishedWithErrorsTitle {
            get {
                return ResourceManager.GetString("FinishedWithErrorsTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Instance {0}:- Finished.
        /// </summary>
        internal static string InstanceFinishedText {
            get {
                return ResourceManager.GetString("InstanceFinishedText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Instance {0}:- .
        /// </summary>
        internal static string InstanceNumText {
            get {
                return ResourceManager.GetString("InstanceNumText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Instance {0}:- ({1}) {2}.
        /// </summary>
        internal static string InstanceProcessing {
            get {
                return ResourceManager.GetString("InstanceProcessing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Choose the number of instances to run.
        ///Recommended: One instance for every two CPU cores..
        /// </summary>
        internal static string InstancesCountTooltip {
            get {
                return ResourceManager.GetString("InstancesCountTooltip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid path.
        /// </summary>
        internal static string InvalidPathExceptionText {
            get {
                return ResourceManager.GetString("InvalidPathExceptionText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The job was canceled by the user, there is a potential for file corruption..
        /// </summary>
        internal static string JobCanceledUser {
            get {
                return ResourceManager.GetString("JobCanceledUser", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        ///Job Details:
        ///{0}.
        /// </summary>
        internal static string JobErrorDetails {
            get {
                return ResourceManager.GetString("JobErrorDetails", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        ///Error Message:
        ///{0}.
        /// </summary>
        internal static string JobErrorMsg {
            get {
                return ResourceManager.GetString("JobErrorMsg", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        ///Stack Trace:
        ///{0}.
        /// </summary>
        internal static string JobErrorStack {
            get {
                return ResourceManager.GetString("JobErrorStack", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        /////////////////////// Error Time: {0} \\\\\\\\\\\\\\\\\\\\
        ///.
        /// </summary>
        internal static string JobErrorTime {
            get {
                return ResourceManager.GetString("JobErrorTime", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Hide Job List.
        /// </summary>
        internal static string JobListHideText {
            get {
                return ResourceManager.GetString("JobListHideText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Show Job List.
        /// </summary>
        internal static string JobListShowText {
            get {
                return ResourceManager.GetString("JobListShowText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Job Thread {0}.
        /// </summary>
        internal static string JobThreadText {
            get {
                return ResourceManager.GetString("JobThreadText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {\rtf1\ansi This will use multi threaded compression and reduce concurrent compression instances to 1.  The compressed archives have similar sizes compared to LZMA compression. }.
        /// </summary>
        internal static string Lzma2CheckboxTooltip {
            get {
                return ResourceManager.GetString("Lzma2CheckboxTooltip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Max Ram Usage: {0:g}MB.
        /// </summary>
        internal static string MaxRamUsageText {
            get {
                return ResourceManager.GetString("MaxRamUsageText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No Jobs Remaining....
        /// </summary>
        internal static string NoJobsText {
            get {
                return ResourceManager.GetString("NoJobsText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; is not a valid Steam Backup folder.
        /// </summary>
        internal static string NotValidSteamBackupDirectory {
            get {
                return ResourceManager.GetString("NotValidSteamBackupDirectory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; is not a valid Steam installation directory.
        /// </summary>
        internal static string NotValidSteamDirectory {
            get {
                return ResourceManager.GetString("NotValidSteamDirectory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Pause.
        /// </summary>
        internal static string PauseText {
            get {
                return ResourceManager.GetString("PauseText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The percent of finished work must be between 0 and 100..
        /// </summary>
        internal static string PercentRangeError {
            get {
                return ResourceManager.GetString("PercentRangeError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Started: {0}.
        /// </summary>
        internal static string ProcessingStarted {
            get {
                return ResourceManager.GetString("ProcessingStarted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Jobs started: {0} of {1}
        ///Jobs skipped: {2} of {3}
        ///Jobs total: {4} of {5}.
        /// </summary>
        internal static string ProgressFormatStr {
            get {
                return ResourceManager.GetString("ProgressFormatStr", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {\rtf1\ansi Click to \b select \b0 all games in the list. The selection can be modified in the check box list. }.
        /// </summary>
        internal static string RestoreAllButtonTooltip {
            get {
                return ResourceManager.GetString("RestoreAllButtonTooltip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {\rtf1\ansi Cancels the restore procedure and navigates back to the main menu. }.
        /// </summary>
        internal static string RestoreCancelButtonTooltip {
            get {
                return ResourceManager.GetString("RestoreCancelButtonTooltip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {\rtf1\ansi Customise your selection of games to restore.  \b NOTE: \b0 Older games that utilize Valve&apos;s Source Engine share resources between each other, However Valve has patched this out. Make sure you have the latest version of these old steam games, this tool will not be able to backup or restore them otherwise. }.
        /// </summary>
        internal static string RestoreCheckListTooltip {
            get {
                return ResourceManager.GetString("RestoreCheckListTooltip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {\rtf1\ansi Click to \b deselect \b0 all games in the list. The selection can be modified in the check box list. }.
        /// </summary>
        internal static string RestoreNoneButtonTooltip {
            get {
                return ResourceManager.GetString("RestoreNoneButtonTooltip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {\rtf1\ansi Allows for some games to be restored to a alternative library.  }.
        /// </summary>
        internal static string RestoreRefreshListLabelTooltip {
            get {
                return ResourceManager.GetString("RestoreRefreshListLabelTooltip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {\rtf1\ansi Starts the restore procedure with the above parameters. \b This will overwrite any currently installed Steam games with the back up files. \b0 }.
        /// </summary>
        internal static string RestoreStartButtonTooltip {
            get {
                return ResourceManager.GetString("RestoreStartButtonTooltip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please exit Steam before restoring. To continue, exit Steam and then click the &apos;Start Restore&apos; button again. Do Not start Steam until the restore process is finished..
        /// </summary>
        internal static string RestoreSteamRunningText {
            get {
                return ResourceManager.GetString("RestoreSteamRunningText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {\rtf1\ansi This will change how many threads are used. Doesn&apos;t use much ram and can only utilizes one core per instance. }.
        /// </summary>
        internal static string RestoreThreadsTooltip {
            get {
                return ResourceManager.GetString("RestoreThreadsTooltip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Resume.
        /// </summary>
        internal static string ResumeText {
            get {
                return ResourceManager.GetString("ResumeText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Speed: {0:###0} KB/s, {1}.
        /// </summary>
        internal static string SpeedKBFormatStr {
            get {
                return ResourceManager.GetString("SpeedKBFormatStr", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Speed: {0:###0} MB/s, {1}.
        /// </summary>
        internal static string SpeedMBFormatStr {
            get {
                return ResourceManager.GetString("SpeedMBFormatStr", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sorry, But I could not find where steam has been installed.
        ///
        ///Please browse for it manually..
        /// </summary>
        internal static string SteamFolderNotFound {
            get {
                return ResourceManager.GetString("SteamFolderNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Steam Install Directory.
        /// </summary>
        internal static string SteamInstallDir {
            get {
                return ResourceManager.GetString("SteamInstallDir", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Steam Is Running.
        /// </summary>
        internal static string SteamRunningTitle {
            get {
                return ResourceManager.GetString("SteamRunningTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Number Of Instances:
        ///.
        /// </summary>
        internal static string ThreadLblInstancesText {
            get {
                return ResourceManager.GetString("ThreadLblInstancesText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Number Of Threads:
        ///.
        /// </summary>
        internal static string ThreadLblThreadsText {
            get {
                return ResourceManager.GetString("ThreadLblThreadsText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Choose the number of Threads to run.
        ///Recommended: One Thread for every CPU core..
        /// </summary>
        internal static string ThreadsCountTooltip {
            get {
                return ResourceManager.GetString("ThreadsCountTooltip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {\rtf1\ansi This will change how many threads are used. It is recommended that you set the slider to \b &apos;core_count&apos; \b0 for best performance.  Dramatically increases ram usage when also using high compression rates.  }.
        /// </summary>
        internal static string ThreadsLzma2Tooltip {
            get {
                return ResourceManager.GetString("ThreadsLzma2Tooltip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {\rtf1\ansi This will change how many instances of 7zip are used, each instance creates two threads. It is recommended that you set the slider to \b &apos;core_count/2&apos; \b0 for best performance.  Dramatically increases ram usage when also using high compression rates. }.
        /// </summary>
        internal static string ThreadsLzmaTooltip {
            get {
                return ResourceManager.GetString("ThreadsLzmaTooltip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ERROR: There was a problem parsing the JSON file..
        /// </summary>
        internal static string ToolUpdateBadJson {
            get {
                return ResourceManager.GetString("ToolUpdateBadJson", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ERROR: There was a problem retrieving update information..
        /// </summary>
        internal static string ToolUpdateDownloadFail {
            get {
                return ResourceManager.GetString("ToolUpdateDownloadFail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Steam Backup Tool is currently up to date..
        /// </summary>
        internal static string ToolUpdateNoNewVersion {
            get {
                return ResourceManager.GetString("ToolUpdateNoNewVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {\rtf1\ansi Click to select all games that have been changed since the last backup, \b Excluding \b0 games that have not been backed up yet.  The selection can be modified in the check box list. }.
        /// </summary>
        internal static string UpdateBackupButtonTooltip {
            get {
                return ResourceManager.GetString("UpdateBackupButtonTooltip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {\rtf1\ansi Click to select all games that have been changed since the last backup, \b Including \b0 games that have not been backed up yet. The selection can be modified in the check box list. }.
        /// </summary>
        internal static string UpdateLibButtonTooltip {
            get {
                return ResourceManager.GetString("UpdateLibButtonTooltip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Version: {0}.
        /// </summary>
        internal static string VersionStr {
            get {
                return ResourceManager.GetString("VersionStr", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Waiting....
        /// </summary>
        internal static string WaitingText {
            get {
                return ResourceManager.GetString("WaitingText", resourceCulture);
            }
        }
    }
}
