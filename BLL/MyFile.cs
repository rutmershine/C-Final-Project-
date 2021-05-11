using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public abstract class MyFile
    {
        List<MyTag> tags = new List<MyTag>();
        public MyFile()
        {

        }

        private FileInfo fileInfo;

        public FileInfo FileInfo
        {
            get { return fileInfo; }
            set { fileInfo = value; }
        }


        public abstract void ShowPreview();


    }
}
