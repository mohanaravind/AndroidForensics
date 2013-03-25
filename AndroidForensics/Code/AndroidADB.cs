using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace AndroidForensics.Code
{
    class AndroidADB
    {

        #region Private Fields

        private Int32 POLL_TIME = 3000;

        private static AndroidADB androidADB;


        #endregion

        #region Delegates

        public delegate void ConnectionHandler(DeviceInfo deviceInfo);

        #endregion
        
        #region Events

        /// <summary>
        /// Event which marks the recognition of an Android device through ADB
        /// </summary>
        public event ConnectionHandler Connected;

        /// <summary>
        /// Event which marks that there are no Android device which is connected through ADB
        /// </summary>
        public event ConnectionHandler Disconnected;

        #endregion

        #region Public Methods

        /// <summary>
        /// Private constructor
        /// </summary>
        private AndroidADB()
        {

        }

        /// <summary>
        /// Returns the instance of AndroidADB
        /// </summary>
        /// <returns></returns>
        public static AndroidADB GetInstance()
        {
            //If the instance is yet to be created
            if (androidADB == null)
                androidADB = new AndroidADB();

            return androidADB;
        }
        
        /// <summary>
        /// Starts the communication with Android bridge
        /// </summary>
        public void Start()
        {
            //Declrations
            DeviceInfo deviceInfo;
            DeviceInfo.DeviceStatus status = DeviceInfo.DeviceStatus.Disconnected;
           
            while (true)
            {
                //Get the device info
                deviceInfo = GetDeviceInfo();
                
                //Check whether the status has been modified
                if (status != deviceInfo.Status)
                {
                    //Trigger the respective event
                    if (deviceInfo.Status == DeviceInfo.DeviceStatus.Connected)
                        Connected(deviceInfo);
                    else
                        Disconnected(deviceInfo);
                }

                //Retain the status for comparision
                status = deviceInfo.Status;

                //Sleep 
                Thread.Sleep(POLL_TIME);
            }

        }


        #endregion

        #region Private Methods

        /// <summary>
        /// Gets the status of the device
        /// </summary>
        /// <returns></returns>
        private DeviceInfo GetDeviceInfo()
        {
            //Declrations
            DeviceInfo deviceInfo = new DeviceInfo();
            String output = String.Empty;
            String[] splitted;

            output = ADBUtility.SendMessage("devices");

            if (output != String.Empty)
            {
                splitted = output.Split(new String[] {"List of devices attached"}, StringSplitOptions.RemoveEmptyEntries);

                if (splitted.Length > 0)
                {
                    //Check whether there is a device which is connected
                    if (splitted[splitted.Length - 1].Contains("device"))
                    {
                        splitted = splitted[splitted.Length - 1].Split(new String[] { "device" }, StringSplitOptions.RemoveEmptyEntries);

                        //Set the device ID
                        deviceInfo.DeviceID = splitted[0].Trim();
                        deviceInfo.Status = DeviceInfo.DeviceStatus.Connected;
                    }
                    
                }

            }

            return deviceInfo;
        }


        #endregion


    }


    class DeviceInfo : EventArgs
    {
        public enum DeviceStatus
        {
            Connected, Disconnected
        }

        private DeviceStatus status = DeviceStatus.Disconnected;
        private String deviceID = String.Empty;

        #region Properties

        /// <summary>
        /// Gets/Sets the device ID
        /// </summary>
        public String DeviceID
        {
            get { return deviceID; }
            set { deviceID = value; }
        }

        /// <summary>
        /// Gets/Sets the status of device
        /// </summary>
        public DeviceStatus Status
        {
            get { return status; }
            set { status = value; }
        }

        #endregion



    }


}
