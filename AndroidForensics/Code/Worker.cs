using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AndroidForensics.Properties;
using System.Windows.Forms;

namespace AndroidForensics.Code
{
    class Worker
    {
        #region Fields

        private static Worker _worker;
        private static String _SDCard = "/sdcard";
        private static String _outputPath = @"C:\Dump\Ara";
        private static frmSettings _settings;


        #endregion

        #region Events

        /// <summary>
        /// Gets triggered when any extraction happens
        /// </summary>
        public event ExtractionHandler Extracted;

        #endregion

        #region Delegates

        public delegate void ExtractionHandler(ExtractionMessage message);

        #endregion


        #region Constructors

        /// <summary>
        /// Private constructor
        /// </summary>
        private Worker()
        {

        }


        #endregion

        #region Public Methods

        /// <summary>
        /// Returns the worker instance
        /// </summary>
        /// <returns></returns>
        public static Worker GetInstance(frmSettings settings)
        {
            _settings = settings;

            //Check whether the instance has already been created
            if (_worker == null)
                _worker = new Worker();

            //Update the output path
            _outputPath = _settings.OutputPath.Text;
            ADBUtility.ExecutablePath = _settings.SDKPath.Text + @"\platform-tools\adb";

            return _worker;
        }

        /// <summary>
        /// Starts the Extraction process
        /// </summary>
        public void StartExtraction()
        {
            ShowExtractionMessage("Starting Extraction");
                        

            Extract();

            ShowExtractionMessage("Extraction completed successfully", true);
        }


        #endregion


        #region Private Methods

        private void Extract()
        {
            //Declarations
            CheckBox chkExtraction;
            String[] arrExtraction;
            String[] arrData;

            foreach (Control control in _settings.ExtractionConfig.Controls)
            {
                //If its a checkbox
                if (control.GetType() == typeof(CheckBox))
                {
                    chkExtraction = (CheckBox)control;

                    if (chkExtraction.Checked)
                    {
                        arrExtraction = chkExtraction.Tag.ToString().Split(new Char[] { ';' });

                        arrData = arrExtraction[1].Split(new Char[] { ',' });

                        ShowExtractionMessage("Extracting from " + arrExtraction[0]);

                        //For each of the required db
                        foreach (String db in arrData)
                        {
                            ShowExtractionMessage("Extracting the file " + db);

                            //Extract the required data
                            ExtractData(arrExtraction[0], db);
                        }
                    }
                }
            }

        }


        /// <summary>
        /// Extracts the Telephony Information
        /// </summary>
        private void ExtractData(String strSourcePath, String strDatabaseFile)
        {
            //Declarations
            ADBShellCommand command;
            String strInputFile;
            String strOutputFile;
            String strOutput;
            
            //Construct the command 
            strInputFile = "data/data/" + strSourcePath + "/" + strDatabaseFile;
            strOutputFile = _SDCard + "/" + strDatabaseFile;
            command = new ADBShellCommand.DD(strInputFile, strOutputFile);
            //Send the command
            strOutput = ADBUtility.SendShellCommands(command);

            //Display to UI
            ShowExtractionMessage(strOutput);
            
            //Pull the file
            strOutput = ADBUtility.RetrieveFile(strOutputFile, _outputPath);

            //Display to UI
            ShowExtractionMessage(strOutput);

            //Construct the command to remove the file
            command = new ADBShellCommand.RM(strOutputFile);
            //Send the command to remove the file
            strOutput = ADBUtility.SendShellCommands(command);


            //Display to UI
            ShowExtractionMessage(strOutput);
                        
        }

 


        /// <summary>
        /// Display the command's result message to the UI
        /// </summary>
        /// <param name="message"></param>
        /// <param name="isExtractionCompleted"></param>
        private void ShowExtractionMessage(String message, Boolean isExtractionCompleted = false)
        {
            //Declarations
            ExtractionMessage extractionMessage = new ExtractionMessage(message.Trim() + "\r\n\r\n");
            extractionMessage.IsExtractionCompleted = isExtractionCompleted;

            //Raise the event
            Extracted(extractionMessage);
        }


        #endregion


        public class ExtractionMessage : EventArgs
        {
            /// <summary>
            /// Contains the extraction message which needs to be displayed
            /// </summary>
            private String _message = String.Empty;

            private Boolean _isExtractionCompleted = false;

            /// <summary>
            /// Gets/Sets whether the extraction of all data is completed
            /// </summary>
            public Boolean IsExtractionCompleted
            {
                get { return _isExtractionCompleted; }
                set { _isExtractionCompleted = value; }
            }

            /// <summary>
            /// Constructor
            /// </summary>
            /// <param name="message"></param>
            public ExtractionMessage(String message)
            {
                this._message = message;
            }

            public override string ToString()
            {
                return _message;
            }
        }

    }
}
