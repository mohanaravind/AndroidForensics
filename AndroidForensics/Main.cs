using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Diagnostics;
using AndroidForensics.Code;
using System.Threading;
using System.Resources;
using System.IO;
using System.Reflection;
using AndroidForensics.Properties;

namespace AndroidForensics
{
    public partial class frmMain : Form
    {
        #region Fields

        //Declarations
        private Thread thAndroidADB;
        private Thread thWorker;

        private frmSettings _frmSettings;

        #endregion


        #region Constructor

        public frmMain()
        {
            InitializeComponent();

            //Initialize the required wire ups
            Initialize();            
        }

        #endregion


        #region Delegates

        private delegate void DeviceInfoCallBack(DeviceInfo deviceInfo);

        private delegate void ExtractionInfoCallBack(Worker.ExtractionMessage message);

        #endregion


        #region Event Handlers

        /// <summary>
        /// Gets triggered when the device connects or disconnects
        /// </summary>
        /// <param name="deviceInfo"></param>
        void frmMain_DeviceInfo(DeviceInfo deviceInfo)
        {
            try
            {
                //Set the call back for thread-safe execution
                DeviceInfoCallBack dlgAllocateCallback = new DeviceInfoCallBack(UpdateDeviceInfo);
                this.Invoke(dlgAllocateCallback, new object[] { deviceInfo });
            }
            catch (Exception ex)
            {
                
                throw;
            }

        }

        /// <summary>
        /// Gets triggered when an extraction happens
        /// </summary>
        /// <param name="message"></param>
        void frmMain_Extracted(Worker.ExtractionMessage message)
        {
            try
            {
                //Set the call back for thread-safe execution
                ExtractionInfoCallBack dlgExtractoinInfoCallBack = new ExtractionInfoCallBack(UpdateExtractionInfo);
                this.Invoke(dlgExtractoinInfoCallBack, new object[] { message });
            }
            catch (Exception ex)
            {

                throw;
            }
        }


        /// <summary>
        /// Gets triggered when the user clicks on extract button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExtract_Click(object sender, EventArgs e)
        {
            btnExtract.Enabled = false;
            txtExtractionInfo.Clear();

            //Create the thread
            thWorker = new Thread(new ThreadStart(Worker.GetInstance(_frmSettings).StartExtraction));

            //Start the thread
            thWorker.Start();
        }


        /// <summary>
        /// Gets triggered when the form gets loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Load(object sender, EventArgs e)
        {
            //Create the thread
            thAndroidADB = new Thread(new ThreadStart(AndroidADB.GetInstance().Start));

            //Start the thread
            thAndroidADB.Start();
            
        }

        /// <summary>
        /// Gets triggerd when the user clicks on the close dialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            thAndroidADB.Abort();
            thWorker.Abort();
            
            this.Close();
        }


        /// <summary>
        /// Gets triggered when user clicks on Settings button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lnkSettings_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _frmSettings.ShowDialog(this);
        }

        #endregion


        #region Private Methods

        private void Initialize()
        {
            //Set the event handlers
            AndroidADB.GetInstance().Connected += new AndroidADB.ConnectionHandler(frmMain_DeviceInfo);
            AndroidADB.GetInstance().Disconnected += new AndroidADB.ConnectionHandler(frmMain_DeviceInfo);

            //Create the settings form
           _frmSettings = new frmSettings();

            Worker.GetInstance(_frmSettings).Extracted += new Worker.ExtractionHandler(frmMain_Extracted);
        }




        /// <summary>
        /// Updates the device informations
        /// </summary>
        /// <param name="deviceInfo"></param>
        private void UpdateDeviceInfo(DeviceInfo deviceInfo)
        {
            //Update the device information to UI
            lblDeviceStatus.Text = deviceInfo.Status.ToString();
            lblSerialNumber.Text = deviceInfo.DeviceID;


            //Set the device info image
            if (deviceInfo.Status == DeviceInfo.DeviceStatus.Connected)
            {
                picDeviceStatus.Image = Resources.Connected;
                btnExtract.Enabled = true;
            }
            else
            {
                picDeviceStatus.Image = Resources.Disconnected;
                btnExtract.Enabled = false;
            }

        }

        /// <summary>
        /// Updates the extraction information to UI
        /// </summary>
        /// <param name="message"></param>
        private void UpdateExtractionInfo(Worker.ExtractionMessage message)
        {
            if(message.ToString().Trim().Length > 0)
                txtExtractionInfo.AppendText(message.ToString());
            

            //If all the extraction is completed
            if (message.IsExtractionCompleted)
                btnExtract.Enabled = true;

        }


    


        #endregion

        
    }
}
