﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using SevenZip;
using System.Threading;

namespace steamBackup
{
    public enum JobType
    {
        UNSET = -1,
        BACKUP,
        RESTORE
    }

    public enum JobStatus
    {
        UNSET = -1,
        SKIPED,
        WAITING,
        WORKING,
        PAUSED,
        FINISHED,
        CANCELED,
        ERROR
    }

    public abstract class Job
    {        
        protected JobType type = JobType.UNSET;
        public JobType getJobType() { return type; }
        
        public string appId;
        public string name;


        protected string dirSteam;
        abstract public void setSteamDir(string dir);
        public string getSteamDir() { return dirSteam; }

        protected string dirBackup;
        abstract public void setBackupDir(string dir);
        public string getBackupDir() { return dirBackup; }

        public JobStatus status;

        public string acfDir;

        abstract public void start(ProgressBar pgsBar);

        protected ProgressBar progressBar;
        private string curFileStr;
        public string getCurFileStr() { return curFileStr; }

        protected void working(object sender, ProgressEventArgs e)
        {
            progressBar.Value = e.PercentDone;
        }

        protected void started(object sender, FileNameEventArgs e)
        {
            curFileStr = e.FileName;

            if (status == JobStatus.CANCELED)
                e.Cancel = true;

            while (status == JobStatus.PAUSED)
            {
                Thread.Sleep(250);
            }
        }

        protected void started(object sender, FileInfoEventArgs e)
        {
            string[] splitStr = e.FileInfo.FileName.Split('\\');
            curFileStr = splitStr[splitStr.Length - 1];

            if (status == JobStatus.CANCELED)
                e.Cancel = true;

            while (status == JobStatus.PAUSED)
            {
                Thread.Sleep(250);
            }
        }

        protected void finished(object sender, EventArgs e)
        {
            if (status == JobStatus.WORKING)
                status = JobStatus.FINISHED;
        }

        public string toString()
        {
            return "appId = " + appId + Environment.NewLine +
                "name = " + name + Environment.NewLine +
                "dirSteam = " + dirSteam + Environment.NewLine +
                "dirBackup = " + dirBackup + Environment.NewLine +
                "status = " + status + Environment.NewLine +
                "acfDir = " + acfDir;
        }
    }
}
