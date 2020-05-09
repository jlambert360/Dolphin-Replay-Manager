using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using Microsoft.VisualBasic;

namespace Bird_s_Replay_Manager
{
    public partial class Form1 : Form
    {
        public string dolphinPath;
        public string replayFilePath;
        public string userInput;

        bool itemSelected = false;

        //These allow the form to be dragged around.
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        
        public Form1()
        {
            InitializeComponent();
        }

        #region ToolsMenu
        private void toolsButton_Click(object sender, EventArgs e)
        {
        }

        private void locationButton_Click(object sender, EventArgs e)
        {
            fileBrowse(); //Open file browser
            while (!File.Exists(dolphinPath + "/Dolphin.exe")) //While program can't find Dolphin.exe
            {
                System.Windows.Forms.MessageBox.Show("Please select the folder that contains Dolphin.exe", "Error!"); //Show an error popup
                fileBrowse(); //Reopen the file browser
            }
            listBox1.DataSource = null; //Clear data in listbox1
            listBox1.Items.Clear(); //Clear text in listbox1
            listBox2.DataSource = null; //Clear data in listbox2
            listBox2.Items.Clear(); //Clear text in listbox2
            listBox1.Items.Add("Replay Folder"); //Add text Replay Folder as 1st string in listbox1
            listBox2.Items.Add("User Save Folder"); //Add text User Save Folder as 1st string in listbox2
            PopulateListBox(listBox1, dolphinPath + "/ReplayData", "*"); //Add all .vff files to listbox1
            PopulateListBox(listBox2, dolphinPath + "/User/Wii/title/00010000/52534245/data/", "*"); //Add all .vff files to listbox2
        }

        private void fileBrowse()
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog(); //Display the file browser dialog

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath)) //Set path to folder that was selected
                {
                    string[] files = Directory.GetFiles(fbd.SelectedPath); //Get all files in the selected path
                    dolphinPath = fbd.SelectedPath; //Set dolphinPath to the selected path 
                }
            }
        }

        private void inputBox()
        {
            userInput = Interaction.InputBox("Rename selected replay (EX: Replays vs. Ant)", "Rename selected replay", "", -1, -1); //Pop up an input box
        }

        private void PopulateListBox(ListBox lsb, string Folder, string FileType)
        {
            DirectoryInfo dinfo = new DirectoryInfo(Folder); //Set directory to a folder
            FileInfo[] Files = dinfo.GetFiles(FileType); //Get all files of a specific type
            foreach (FileInfo file in Files) //Get all files
            {
                lsb.Items.Add(file.Name); //Add files names to listbox
            }
        }

        private void useReplayButton_Click(object sender, EventArgs e)
        {
            if (itemSelected == true) //Check if an item is selected
                replayFilePath = dolphinPath + "/ReplayData/" + listBox1.SelectedItem.ToString(); //Set replayFilePath to the selected replay file

            while (File.Exists(dolphinPath + "/User/Wii/title/00010000/52534245/data/collect.vff") && itemSelected == true) //While there is a collect.vff file in the user folder
            {
                string path = dolphinPath + "/ReplayData/collect Backup 1.vff"; //Set path to a default backup in the ReplayData folder

                for (int i = 1; File.Exists(path);  ++i) //Add 1 to file name until no matching file name is found
                {
                    if (!File.Exists(dolphinPath + "/ReplayData/collect Backup 1.vff")) //If default replay backup doesnt't exist
                        path = dolphinPath + "/ReplayData/collect Backup 1.vff"; //Set path to default replay backup

                    else if (File.Exists(path)) //But if a replay backup does exist
                    {
                        path = dolphinPath + "/ReplayData/collect Backup " + i + ".vff"; //Set path to backup + an open number
                    }
                }

                System.IO.File.Move(dolphinPath + "/User/Wii/title/00010000/52534245/data/collect.vff", path); //Move the save file in the user folder to the ReplayData folder and rename it to backup
                listBox1.Items.Remove(listBox1.SelectedItem); //Remove the currently selected replay
                listBox1.ClearSelected(); //Clear which replay was selected
                listBox1.DataSource = null; //Clear data in listbox1
                listBox1.Items.Clear(); //Clear text in listbox1
                PopulateListBox(listBox1, dolphinPath + "/ReplayData", "*"); //Add all .vff files back to listbox1
                listBox2.DataSource = null; //Clear data in listbox2
                listBox2.Items.Clear(); //Clear text in listbox2
                PopulateListBox(listBox2, dolphinPath + "/User/Wii/title/00010000/52534245/data/", "*"); //Add all .vff files back up listbox2
            }
            if (!File.Exists(dolphinPath + "/User/Wii/title/00010000/52534245/data/collect.vff") && itemSelected == true) //If there is no replay save file in the user folder
            {
                System.IO.File.Move(replayFilePath, dolphinPath + "/User/Wii/title/00010000/52534245/data/collect.vff"); //Move the selected replay to the user folder and rename it
                listBox1.Items.Remove(listBox1.SelectedItem); //Remove the currently selected replay
                listBox1.ClearSelected(); //Clear which replay was selected
                listBox1.DataSource = null; //Clear data in listbox1
                listBox1.Items.Clear(); //Clear text in listbox1
                PopulateListBox(listBox1, dolphinPath + "/ReplayData", "*"); //Add all .vff files back to listbox1
                listBox2.DataSource = null; //Clear data in listbox2
                listBox2.Items.Clear(); //Clear text in listbox2
                PopulateListBox(listBox2, dolphinPath + "/User/Wii/title/00010000/52534245/data/", "*"); //Add all .vff files back up listbox2
            }
            else if (itemSelected == false) //If no item is selected
            {
                MessageBox.Show("No item selected!", "Error!"); //Display an error popup
            }
        }

        private void renameButton_Click(object sender, EventArgs e)
        {
            if (dolphinPath == null) //If no path was chosen yet
            {
                MessageBox.Show("Please set the path to your dolphin folder!", "Error!"); //Display an error
            }
            else
            {
                inputBox(); //Open the input box
                if (itemSelected == true) //Check if an item is selected
                    replayFilePath = dolphinPath + "/ReplayData/" + listBox1.SelectedItem.ToString(); //Set replayFilePath to the selected replay file
                while (File.Exists(dolphinPath + "/ReplayData/" + userInput)) //Check if a file with the inputed name already exists
                {
                    MessageBox.Show("A file with the name " + userInput + " already exists!", "Error!"); //Display an error
                    inputBox(); //Reopen the input box
                }
                if (userInput != "" && !File.Exists(dolphinPath + "/ReplayData/" + userInput)) //If the input box isn't blank and a file with the user inputted name doesn't exist
                {
                    System.IO.File.Move(replayFilePath, dolphinPath + "/ReplayData/" + userInput); //Rename the selected replay to the user's input
                    listBox1.Items.Remove(listBox1.SelectedItem); //Remove the currently selected replay
                    listBox1.ClearSelected(); //Clear which replay was selected
                    listBox1.DataSource = null; //Clear data in listbox1
                    listBox1.Items.Clear(); //Clear text in listbox1
                    listBox1.Items.Add("Replay Folder"); //Add text Replay Folder as 1st string in listbox1
                    PopulateListBox(listBox1, dolphinPath + "/ReplayData", "*"); //Add all .vff files back to listbox1
                }
            }
        }

        private void moveReplaysButton_Click(object sender, EventArgs e)
        {
            if (dolphinPath != null) //If dolphin path is set
            {
                string[] Files = Directory.GetFiles(dolphinPath + "/User/Wii/title/00010000/52534245/data/"); //Get all files in the brawl save folder
                foreach (string file in Files) //Get all files
                {
                    var name = new FileInfo(file).Name; //name is file names
                    name = name.ToLower(); //Set names to lower case

                    if (!name.Contains(".bin") && !name.Contains(".dat") && !name.Contains(".mod")) //Do nothing if the file is a .bin .dat or .mod file
                    {
                        System.IO.File.Move(dolphinPath + "/User/Wii/title/00010000/52534245/data/" + name, dolphinPath + "/ReplayData/" + name); //Move all replay files to the replay folder
                    }
                }
                listBox1.DataSource = null; //Clear data in listbox1
                listBox1.Items.Clear(); //Clear text in listbox1
                listBox2.DataSource = null; //Clear data in listbox2
                listBox2.Items.Clear(); //Clear text in listbox2
                listBox1.Items.Add("Replay Folder"); //Add text Replay Folder as 1st string in listbox1
                listBox2.Items.Add("User Save Folder"); //Add text User Save Folder as 1st string in listbox2
                PopulateListBox(listBox1, dolphinPath + "/ReplayData", "*"); //Add all .vff files to listbox1
                PopulateListBox(listBox2, dolphinPath + "/User/Wii/title/00010000/52534245/data/", "*"); //Add all .vff files to listbox2
            }
            else //If no path was set yet
            {
                MessageBox.Show("Please set the path to your dolphin folder!", "Error!"); //Display an error
            }
        }
        #endregion

        private void closeButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0); //Close the program
        }

        private void maximizeButton_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized) //If window is already maximized
                this.WindowState = FormWindowState.Normal; //Set window size to normal
            else //If window isn't maximized
            this.WindowState = FormWindowState.Maximized; //Maximize the window
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; //Minimize the window
        }

        private void titleBarPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) //If left mouse button is clicked
            {
                ReleaseCapture(); //Releases the mouse capture from a window in the current thread and restores normal mouse input processing
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0); //Sends the specified message to a window
            }
        }

        private void titleBarPanel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) //If left mouse button is clicked
            {
                ReleaseCapture(); //Releases the mouse capture from a window in the current thread and restores normal mouse input processing
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0); //Sends the specified message to a window
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) //If left mouse button is clicked
            {
                ReleaseCapture(); //Releases the mouse capture from a window in the current thread and restores normal mouse input processing
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0); //Sends the specified message to a window
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) //If left mouse button is clicked
            {
                ReleaseCapture(); //Releases the mouse capture from a window in the current thread and restores normal mouse input processing
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0); //Sends the specified message to a window
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1) //If something is selected in listbox1
            {
                string filePath = dolphinPath + "/ReplayData/" + listBox1.SelectedItem.ToString(); //Set the filePath to the path of the selected item

                if (File.Exists(filePath)) //If the file exists in the file path
                {
                    itemSelected = true; //Set item selected to true
                }
                else //If the file doesn't exist (which should never happen)
                {
                    itemSelected = false; //Set item selected to false
                    listBox1.ClearSelected(); //Clear the selection
                }
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex != -1) //If something is selected in listbox2
            {
                listBox2.ClearSelected(); //Clear the selection
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            if (dolphinPath != null) //If dolphin path is set
            {
                listBox1.DataSource = null; //Clear data in listbox1
                listBox1.Items.Clear(); //Clear text in listbox1
                listBox2.DataSource = null; //Clear data in listbox2
                listBox2.Items.Clear(); //Clear text in listbox2
                listBox1.Items.Add("Replay Folder"); //Add text Replay Folder as 1st string in listbox1
                listBox2.Items.Add("User Save Folder"); //Add text User Save Folder as 1st string in listbox2
                PopulateListBox(listBox1, dolphinPath + "/ReplayData", "*"); //Add all .vff files to listbox1
                PopulateListBox(listBox2, dolphinPath + "/User/Wii/title/00010000/52534245/data/", "*"); //Add all .vff files to listbox2
            }
        }
    }
}
