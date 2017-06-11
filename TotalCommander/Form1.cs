using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //driver instatiation

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (DriveInfo di in DriveInfo.GetDrives())
            {
                driverList.Items.Add(di.Name);
                driverList2.Items.Add(di.Name);
            }
        }

        private void DriverList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //First drive on Click
        private void DriveOnClick(object sender, MouseEventArgs e)
        {
            listView1.Clear();
            string help = driverList.SelectedItems[0].Text;

            foreach (String director in Directory.GetDirectories(help))
            {
                listView1.Items.Add(new FileInfo(director).Name);
            }

            path1.Text = help;
        }

        //Second drive on click
        private void DriveOnClick2(object sender, MouseEventArgs e)
        {
            listView3.Clear();
            string help = driverList2.SelectedItems[0].Text;

            foreach (String director in Directory.GetDirectories(help))
            {
                listView3.Items.Add(new FileInfo(director).Name);
            }
            path2.Text = help;
        }

        //a helpful method

        private string spliting(string split)
        {
            int p = 0;
            for (int i = split.Length - 2; i >= 0; i--)
            {
                if (split[i] == '\\')
                {
                    p = i + 1;
                    break;
                }
                if (split[i] == ':')
                    return split;
            }
            split = split.Remove(p);
            return split;
        }

        //backButton 2

        private void backButton2_Click(object sender, EventArgs e)
        {
            path2.Text = spliting(path2.Text);
            listView3.Clear();
            foreach (String director in Directory.GetDirectories(path2.Text))
            {
                listView3.Items.Add(new FileInfo(director).Name);
            }
            foreach (String director in Directory.GetFiles(path2.Text, "*.txt"))
            {
                listView3.Items.Add(new FileInfo(director).Name);
            }

        }

        //backButton 1
        private void backButton_Click(object sender, EventArgs e)
        {

            path1.Text = spliting(path1.Text);
            listView1.Clear();
            foreach (String director in Directory.GetDirectories(path1.Text))
            {
                listView1.Items.Add(new FileInfo(director).Name);
            }
            foreach (String director in Directory.GetFiles(path1.Text, "*.txt"))
            {
                listView1.Items.Add(new FileInfo(director).Name);
            }

        }

        //ListView1

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string help = listView1.SelectedItems[0].Text;
            if (help.Contains(".txt"))
            {
                Process.Start(path1.Text + help);
            }
            else
            {
                listView1.Clear();
                foreach (String director in Directory.GetDirectories(path1.Text + help))
                {
                    listView1.Items.Add(new FileInfo(director).Name);
                }
                foreach (String director in Directory.GetFiles(path1.Text + help, "*.txt"))
                {
                    listView1.Items.Add(new FileInfo(director).Name);
                }
                path1.Text = path1.Text + help + "\\";
            }
        }

        //listview3

        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string help = listView3.SelectedItems[0].Text;
            if (help.Contains(".txt"))
            {
                Process.Start(path2.Text + help);
            }
            else
            {
                listView3.Clear();
                foreach (String director in Directory.GetDirectories(path2.Text + help))
                {
                    listView3.Items.Add(new FileInfo(director).Name);
                }
                foreach (String director in Directory.GetFiles(path2.Text + help, "*.txt"))
                {
                    listView3.Items.Add(new FileInfo(director).Name);
                }
                path2.Text = path2.Text + help + "\\";
            }

        }

        //create Folder 1

        private void create1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Directory.Exists(path1.Text + "New Folder"))
                {
                    Directory.CreateDirectory(path1.Text + "New Folder");
                    listView1.Items.Add("New Folder");
                    if (path2.Text.CompareTo(path1.Text) == 0)
                        listView3.Items.Add("New Folder");
                }
            }
            catch (Exception ex)
            {
                ex.GetBaseException();
            }
        }

        //create Folder 2

        private void create2_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Directory.Exists(path2.Text + "New Folder"))
                {
                    Directory.CreateDirectory(path2.Text + "New Folder");
                    listView3.Items.Add("New Folder");
                    if (path2.Text.CompareTo(path1.Text) == 0)
                        listView1.Items.Add("New Folder");
                }
            }
            catch (Exception ex)
            {
                ex.GetBaseException();
            }
        }

        //file create 1

        private void file1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(path1.Text + "New Text File"))
                {
                    File.CreateText(path1.Text + "New Text File");
                    listView1.Items.Add("New Text File.txt");
                    if (path2.Text.CompareTo(path1.Text) == 0)
                        listView3.Items.Add("New Text File.txt");
                }
            }
            catch (Exception ex)
            {
                ex.GetBaseException();
            }
        }

       //file create 2

        private void file2_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(path1.Text + "New Text File"))
                {
                    File.CreateText(path2.Text + "New Text File");
                    listView3.Items.Add("New Text File.txt");
                    if (path2.Text.CompareTo(path1.Text) == 0)
                        listView1.Items.Add("New Text File.txt");
                }
            }
            catch (Exception ex)
            {
                ex.GetBaseException();
            }
        }
    }
}
