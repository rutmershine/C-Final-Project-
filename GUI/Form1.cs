using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using BLL;

namespace GUI
{
    public partial class Form1 : Form
    {
        private MyBrowser browser;

        public Form1()
        {
            InitializeComponent();
        }

        private void TV_Show_AfterExpand(object sender, TreeViewEventArgs e)
        {
            TV_Show.BeginUpdate();

            //MyFolder folder = e.Node.Tag as MyFolder;
            //folder.innerFolders();

            //foreach (MyFolder f in folder.Folders)
            //{
            //    if(f.Folders == null)
            //    {
            //        f.innerFolders();

            //    }
            //}
            MyFolder me = e.Node.Tag as MyFolder;
            me.innerFolders();
            foreach (TreeNode f in e.Node.Nodes)//sons
            {

                foreach (var sub in (f.Tag as MyFolder).Folders)
                {
                    TreeNode t = new TreeNode(sub.Name);
                    t.Tag = sub;
                    f.Nodes.Add(t);
                }
            }


            //foreach (TreeNode s in e.Node.Nodes)
            //{
            //    try
            //    {
            //        DirectoryInfo di = new DirectoryInfo(s.FullPath);
            //        foreach (var st in di.GetFileSystemInfos())
            //        {
            //            s.Nodes.Add(st.Name);
            //        }
            //    }
            //    catch (Exception)
            //    {
            //    }

            //}
            TV_Show.EndUpdate();
        }

        private void InitializeTV()
        {
            TV_Show.BeginUpdate();

            

            foreach (MyFolder driver in browser.Folders)
            {
                TreeNode node = new TreeNode(driver.Name);
                node.Tag = driver;
                TV_Show.Nodes.Add(node);
                
                foreach (MyFolder folder in driver.Folders)
                {
                    TreeNode f_node = new TreeNode(folder.Name);
                    f_node.Tag = folder;
                    node.Nodes.Add(f_node);
                }
            }




            //DriveInfo[] allDrives = DriveInfo.GetDrives();
            //int i = 0;
            //foreach (DriveInfo d in allDrives)
            //{
            //    TV_Show.Nodes.Add(d.Name);
            //    DirectoryInfo di = new DirectoryInfo(d.Name);
            //    try
            //    {
            //        if (d.IsReady)
            //        {
            //            foreach (var dirf in di.GetFileSystemInfos())
            //            {

            //                TV_Show.Nodes[i].Nodes.Add(dirf.Name);

            //            }
            //        }
            //        i++;
            //    }
            //    catch (Exception)
            //    {
            //        throw new Exception();
            //    }
            //}
            TV_Show.EndUpdate();
        }
        bool isFirst = true;

        private void TV_Show_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (isFirst)
            {
                isFirst = false;
            }
            else
            {
                listView.Items.Clear();
                //MessageBox.Show("after select");
                MyFolder folder = e.Node.Tag as MyFolder;
                ShowSons(folder);
            }
        }

        private void ShowSons(MyFolder folder)
        {
            foreach (MyFolder f in folder.Folders)
            {
                ListViewItem item = new ListViewItem(f.Name);
                item.Tag = f;
                listView.Items.Add(item);
            }
            foreach (MyFile file in folder.Files)
            {
                ListViewItem item = new ListViewItem(file.FileInfo.Name);
                item.Tag = file;
                listView.Items.Add(item);
            }
        }

        private void listView_DoubleClick(object sender, EventArgs e)
        {
            //MyFolder folder = (sender as ListViewItem).Tag as MyFolder;
            //if(folder!= null)//if its a folder
            //{
            //    folder.CreateFolderContent();
            //    ShowSons(folder);
            //}
        }

        private void listView_ItemActivate(object sender, EventArgs e)
        {
            //MessageBox.Show("activate");
            ListViewItem listViewItem = listView.SelectedItems[0];
            listView.Clear();

            MyFolder folder = listViewItem.Tag as MyFolder;
            if (folder != null)//if its a folder
            {
                folder.CreateFolderContent();
                ShowSons(folder);
            }
            else
            {
                
            }
        }
        
        private void InitializeLV()
        {
            foreach (var driver in browser.Folders)
            {
                ListViewItem item = new ListViewItem(driver.Name);
                item.Tag = driver;
                listView.Items.Add(item);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            browser = MyBrowser.GetBrowser();
            InitializeTV();
            //TV_Show.SelectedNode = null;
            //TV_Show.SelectedNode.Checked = false;

            InitializeLV();
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(sender.ToString()+"selected items: "+listView.SelectedItems);
        }

        private void btn_addTag_Click(object sender, EventArgs e)
        {
            browser.AddTag(txt_tagName.Text, BLL.Color.Red);
        }
    }
}
