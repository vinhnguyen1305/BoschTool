using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security;

namespace DiagSupportingTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region Global Variable

        #endregion

        #region Handle Convert ASCII
        private void btnConvert_Click(object sender, EventArgs e)
        {
            string inputString_str = txbString.Text.ToString(); // get input from text box
            int inputLength_int = (int)inputString_str.ToString().Length; // get length of input string
            string outputHexCode_str = ""; // define output variable
            for (int i = 0; i < inputLength_int; i++)
            {
                outputHexCode_str = outputHexCode_str + "0x" + ((int)inputString_str[i]).ToString("x2").ToUpper() + ",";
            }
            outputHexCode_str = outputHexCode_str.Substring(0, outputHexCode_str.Length - 1);// remove the last comma
            txbHexCode.Text = outputHexCode_str.ToString();
        }

        private void btnCopyHexCode_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txbHexCode.Text.ToString());
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            char temp_Char;
            string inputHexCode_str = txbHexCode.Text.ToString();
            string outputStringAscii_str = "";
            inputHexCode_str = inputHexCode_str.Replace("0x", "");
            string[] inputEachElement = inputHexCode_str.Split(',');
            foreach (string element in inputEachElement)
            {
                temp_Char = (char)Convert.ToInt32(element,16);
                outputStringAscii_str += temp_Char;
            }   
            txbString.Text = outputStringAscii_str.ToString();
            
        }

        private void btnCopyString_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txbString.Text.ToString());
        }

        #endregion


        private void HandleCmd(string cmdInput)
        {
            Process proc = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();

            if (txbSandboxFolder.Text.ToString() == "")
            {
                MessageBox.Show("Please choose the sandbox folder first");
            }
            else
            {
                startInfo.FileName = "cmd.exe";
                startInfo.CreateNoWindow = true;
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardInput = true;
                startInfo.RedirectStandardOutput = true;

                proc.StartInfo = startInfo;
                proc.Start();

                proc.StandardInput.WriteLine("cd " + txbSandboxFolder.Text.ToString());
                proc.StandardInput.WriteLine(cmdInput);
                proc.StandardInput.Flush();
                proc.StandardInput.Close();
                proc.WaitForExit();

                string result = proc.StandardOutput.ReadToEnd();

                MessageBox.Show(result);
            }
        }

        private void btnChooseSanboxQAC_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            if(folderDialog.ShowDialog() == DialogResult.OK)
            {
                txbSandboxFolder.Text = folderDialog.SelectedPath;
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            string cleanAllCmd = "ab12 -t clean";
            HandleCmd(cleanAllCmd);
        }

        private void btnBuildSandbox_Click(object sender, EventArgs e)
        {
            string buildSandboxCmd = "ab12 -nm -j=7";
            HandleCmd(buildSandboxCmd);     
        }

        private void btnGetInputQAC_Click(object sender, EventArgs e)
        {
            OpenFileDialog QACInput = new OpenFileDialog();

            if (QACInput.ShowDialog() == DialogResult.OK) ;
            {
                try
                {
                    var qacInput = new StreamReader(QACInput.FileName);
                    txtQACListFile.Text = qacInput.ReadToEnd();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("FIle does not exist");
                }
            }
        }

        private void btnRunQAC_Click(object sender, EventArgs e)
        {
            string fileAfterRemovingSpaces = txtQACListFile.Text.Replace(" ", "");
            string[] fileToRunQAC = fileAfterRemovingSpaces.Split('\n');
            if (fileAfterRemovingSpaces == "")
            {
                MessageBox.Show("Please add the input file!");
            }
            else
            {
                foreach (string item in fileToRunQAC)
                {
                    try
                    {
                        HandleCmd("ab12 -q f=" + item);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Please check the input file!");
                    }
                }
            }
        }
    }
}
