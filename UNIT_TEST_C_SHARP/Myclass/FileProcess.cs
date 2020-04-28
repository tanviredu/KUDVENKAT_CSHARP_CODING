using System;
using System.IO;

namespace Myclass
{
    class FileProcess
    {

        // we make a method that will check the 
        // check the file and return booliean
        public bool FileExists(string fileName) {

            // check the file name passed as a argument

            if (string.IsNullOrEmpty(fileName)) {
                throw new ArgumentNullException("fileName");
            }//else
            return File.Exists(fileName);
        }
        
    }
}
