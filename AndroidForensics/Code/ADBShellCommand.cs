using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AndroidForensics.Code
{
    abstract class ADBShellCommand
    {

        public class DD : ADBShellCommand
        {

            private string _inputFile = "";
            private string _outputFile = "";

            /// <summary>
            /// Constructor
            /// </summary>
            /// <param name="inputFile"></param>
            /// <param name="outputFile"></param>
            public DD(String inputFile, String outputFile)
            {
                this._inputFile = inputFile;
                this._outputFile = outputFile;
            }

            /// <summary>
            /// Returns the command string
            /// </summary>
            /// <returns></returns>
            public override string ToString()
            {
                return "dd if=" + _inputFile + " of=" + _outputFile;
            }

        }

        /// <summary>
        /// Removes the file/directory 
        /// </summary>
        public class RM : ADBShellCommand
        {

            private string _file = "";

            /// <summary>
            /// Constructor
            /// </summary>
            /// <param name="File"></param>
            public RM(String file)
            {
                this._file = file;
            }

            /// <summary>
            /// Returns the command string
            /// </summary>
            /// <returns></returns>
            public override string ToString()
            {
                return "rm " + _file;
            }

        }
                       

    }
}
