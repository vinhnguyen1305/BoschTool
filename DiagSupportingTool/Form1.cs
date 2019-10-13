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

        #region Handle SandboxServices
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


        #endregion



        private void CbbService_SelectedValueChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void TxtLength_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void CbbName_SelectedValueChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void TxtDID_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnCreateDID_Click_1(object sender, EventArgs e)
        {
            List<TextBox> txtDIDMatrix = new List<TextBox>();
            List<ComboBox> cbbNameMatrix = new List<ComboBox>();
            List<TextBox> txtLengthMatrix = new List<TextBox>();
            List<ComboBox> cbbServiceMatrix = new List<ComboBox>();
            TextBox oldTextboxDID = new TextBox() { Width = 0, Location = new Point(lbDID.Location.X, lbDID.Location.Y) };
            ComboBox oldCommboBoxName = new ComboBox() { Width = 0, Location = new Point(lbName.Location.X, lbName.Location.Y) };
            TextBox oldTextboxLength = new TextBox() { Width = 0, Location = new Point(lbLength.Location.X, lbLength.Location.Y) };
            ComboBox oldComboBoxService = new ComboBox() { Width = 0, Location = new Point(lbService.Location.X, lbService.Location.Y) };

            if(txtNbOfDID.Text == "")
            {
                MessageBox.Show("Please fill the number of DID!");
            }
            else
            {
                int numberOfDID = Convert.ToInt16(txtNbOfDID.Text.ToString());


                for (int i = 0; i < numberOfDID; i++)
                {
                    TextBox txtDID = new TextBox()
                    {
                        Width = 100,
                        Location = new Point(oldTextboxDID.Location.X, oldTextboxDID.Location.Y + 30),
                    };
                    txtDID.TextChanged += TxtDID_TextChanged;
                    pnlDiag.Controls.Add(txtDID);
                    oldTextboxDID = txtDID;

                    ComboBox cbbName = new ComboBox()
                    {
                        Width = 330,
                        Location = new Point(oldCommboBoxName.Location.X, oldCommboBoxName.Location.Y + 30),
                    };
                    cbbName.SelectedValueChanged += CbbName_SelectedValueChanged;
                    oldCommboBoxName = cbbName;
                    pnlDiag.Controls.Add(cbbName);

                    TextBox txtLength = new TextBox()
                    {
                        Width = 100,
                        Location = new Point(oldTextboxLength.Location.X, oldTextboxLength.Location.Y + 30)
                    };
                    txtLength.TextChanged += TxtLength_TextChanged;
                    oldTextboxLength = txtLength;
                    pnlDiag.Controls.Add(txtLength);

                    ComboBox cbbService = new ComboBox()
                    {
                        Width = 100,
                        Location = new Point(oldComboBoxService.Location.X, oldComboBoxService.Location.Y + 30)
                    };
                    cbbService.SelectedValueChanged += CbbService_SelectedValueChanged;
                    oldComboBoxService = cbbService;
                    pnlDiag.Controls.Add(cbbService);
                }
            }        
        }
    }
}
