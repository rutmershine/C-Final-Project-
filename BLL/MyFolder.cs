using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL
{
    public class MyFolder
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private List<MyFolder> folders = new List<MyFolder>();

        public List<MyFolder> Folders
        {
            get { return folders; }
            set { folders = value; }
        }
        private List<MyFile> files = new List<MyFile>();

        public List<MyFile> Files
        {
            get { return files; }
            set { files = value; }
        }
        public MyFolder()
        {

        }
        public MyFolder(DriveInfo d)
        {
            if (d.IsReady)
            {
                try
                {
                    //string[] files = Directory.GetFiles(d.Name);
                    string[] directories = Directory.GetDirectories(d.Name);
                    foreach (var directory in directories)
                    {
                        MyFolder f = new MyFolder();
                        f.name = directory;
                        folders.Add(f);
                    }
                }
                catch (Exception) { throw; }
            }

        }

        public void CreateFolderContent()
        {
            innerFiles(this);

            try
            {
                string[] directories = Directory.GetDirectories(this.Name);
                foreach (var directory in directories)
                {
                    MyFolder mf = new MyFolder();
                    mf.name = directory;
                    folders.Add(mf);
                }
            }
            catch (Exception) { }
            

        }
        public void innerFiles(MyFolder folder)
        {
            try
            {
                string[] files = Directory.GetFiles(folder.Name);
                foreach (var file in files)
                {
                    FileInfo fi = new FileInfo(file);
                    MyFile f = null;
                    switch (fi.Extension.ToLower())
                    {
                        case ".jpg":
                        case ".jpeg":
                        case ".png":
                            f = new MyImageFile();
                            break;
                        case ".pdf":
                            f = new MyPDFile();
                            break;
                        default:
                            f = new MyTextFile();
                            break;
                    }
                    f.FileInfo = fi;
                    folder.Files.Add(f);
                }
            }
            catch (Exception) { }
        }


        //public MyFile typeOfFile(FileInfo file)
        //{
        //    switch (file.Extension.ToLower())
        //    {
        //        case ".jpg":
        //        case ".jpeg":
        //        case ".png":
        //            return new MyImageFile();
        //        case ".docx":
        //            return new MyWordFile();
        //        case ".txt":
        //        case ".sql":
        //        case ".java":
        //            return new MyTextFile();
        //        case ".xls":
        //        case ".xlsx":
        //            break;
        //        case ".pdf":
        //            return new MyPDFile();
        //    }
        //    return new MyFile();
        //}


        public void innerFolders()
        {

            try
            {
                foreach (var folder in folders)
                {
                    innerFiles(folder);

                    try
                    {
                        string[] directories = Directory.GetDirectories(folder.Name);
                        //string[] files = Directory.GetFiles(folder.Name);
                        foreach (var directory in directories)
                        {
                            MyFolder mf = new MyFolder();
                            mf.name = directory;
                            folder.folders.Add(mf);
                        }
                    }
                    catch (Exception) { }
                }
            }
            catch (Exception) { }
        }

    }
}
