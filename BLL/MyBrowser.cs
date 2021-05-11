using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BLL
{
     public class MyBrowser
    {

        static MyBrowser browser;
        string path = @"..\..\..\AllTags.xml";
        XDocument doc;


        private List<MyFolder> folders = new List<MyFolder>();

        public List<MyFolder> Folders
        {
            get { return folders; }
            set { folders = value; }
        }

        private MyBrowser()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (var drive in drives)
            {
                MyFolder folder = new MyFolder(drive);
                folder.Name = drive.Name;
                folders.Add(folder);
            }
            doc = XDocument.Load(path);
        }

        public static MyBrowser GetBrowser()
        {
            if (browser == null)
                browser = new MyBrowser();
            return browser;
        }

        public List<MyTag> GetAllTags()
        {
            var tags = doc.Root.Elements();
            List<MyTag> tagsList = tags.Select(tag => new MyTag()
            { Name = tag.Attribute("Name").Value }).ToList();
            return tagsList;
        }

        public void AddTag(string name, Color color)
        {
            XElement newTag = new XElement("Tag",new XAttribute("Name",name));
            doc.Root.Add(newTag);
            doc.Save(path);
        }
    }
}
