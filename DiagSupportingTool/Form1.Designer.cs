namespace DiagSupportingTool
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtQACListFile = new System.Windows.Forms.TextBox();
            this.btnRunQAC = new System.Windows.Forms.Button();
            this.btnGetInputQAC = new System.Windows.Forms.Button();
            this.txbSandboxFolder = new System.Windows.Forms.TextBox();
            this.btnChooseSanboxQAC = new System.Windows.Forms.Button();
            this.btnBuildSandbox = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReverse = new System.Windows.Forms.Button();
            this.btnCopyString = new System.Windows.Forms.Button();
            this.btnCopyHexCode = new System.Windows.Forms.Button();
            this.txbHexCode = new System.Windows.Forms.TextBox();
            this.Code = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txbString = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pnlDiag = new System.Windows.Forms.Panel();
            this.lbService = new System.Windows.Forms.Label();
            this.lbLength = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbDID = new System.Windows.Forms.Label();
            this.btnCreateDID = new System.Windows.Forms.Button();
            this.txtNbOfDID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.pnlDiag.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(840, 438);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(832, 412);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtQACListFile);
            this.groupBox2.Controls.Add(this.btnRunQAC);
            this.groupBox2.Controls.Add(this.btnGetInputQAC);
            this.groupBox2.Controls.Add(this.txbSandboxFolder);
            this.groupBox2.Controls.Add(this.btnChooseSanboxQAC);
            this.groupBox2.Controls.Add(this.btnBuildSandbox);
            this.groupBox2.Controls.Add(this.btnClean);
            this.groupBox2.Location = new System.Drawing.Point(16, 217);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(801, 192);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SANDBOX SERVICES";
            // 
            // txtQACListFile
            // 
            this.txtQACListFile.Location = new System.Drawing.Point(244, 90);
            this.txtQACListFile.Multiline = true;
            this.txtQACListFile.Name = "txtQACListFile";
            this.txtQACListFile.Size = new System.Drawing.Size(516, 96);
            this.txtQACListFile.TabIndex = 6;
            // 
            // btnRunQAC
            // 
            this.btnRunQAC.Location = new System.Drawing.Point(120, 150);
            this.btnRunQAC.Name = "btnRunQAC";
            this.btnRunQAC.Size = new System.Drawing.Size(90, 40);
            this.btnRunQAC.TabIndex = 5;
            this.btnRunQAC.Text = "Run QAC";
            this.btnRunQAC.UseVisualStyleBackColor = true;
            this.btnRunQAC.Click += new System.EventHandler(this.btnRunQAC_Click);
            // 
            // btnGetInputQAC
            // 
            this.btnGetInputQAC.Location = new System.Drawing.Point(120, 90);
            this.btnGetInputQAC.Name = "btnGetInputQAC";
            this.btnGetInputQAC.Size = new System.Drawing.Size(90, 40);
            this.btnGetInputQAC.TabIndex = 4;
            this.btnGetInputQAC.Text = "Get Input QAC";
            this.btnGetInputQAC.UseVisualStyleBackColor = true;
            this.btnGetInputQAC.Click += new System.EventHandler(this.btnGetInputQAC_Click);
            // 
            // txbSandboxFolder
            // 
            this.txbSandboxFolder.Location = new System.Drawing.Point(120, 30);
            this.txbSandboxFolder.Multiline = true;
            this.txbSandboxFolder.Name = "txbSandboxFolder";
            this.txbSandboxFolder.Size = new System.Drawing.Size(640, 40);
            this.txbSandboxFolder.TabIndex = 3;
            // 
            // btnChooseSanboxQAC
            // 
            this.btnChooseSanboxQAC.Location = new System.Drawing.Point(6, 30);
            this.btnChooseSanboxQAC.Name = "btnChooseSanboxQAC";
            this.btnChooseSanboxQAC.Size = new System.Drawing.Size(90, 40);
            this.btnChooseSanboxQAC.TabIndex = 2;
            this.btnChooseSanboxQAC.Text = "Choose Sandbox";
            this.btnChooseSanboxQAC.UseVisualStyleBackColor = true;
            this.btnChooseSanboxQAC.Click += new System.EventHandler(this.btnChooseSanboxQAC_Click);
            // 
            // btnBuildSandbox
            // 
            this.btnBuildSandbox.Location = new System.Drawing.Point(6, 150);
            this.btnBuildSandbox.Name = "btnBuildSandbox";
            this.btnBuildSandbox.Size = new System.Drawing.Size(90, 40);
            this.btnBuildSandbox.TabIndex = 1;
            this.btnBuildSandbox.Text = "Build Sandbox";
            this.btnBuildSandbox.UseVisualStyleBackColor = true;
            this.btnBuildSandbox.Click += new System.EventHandler(this.btnBuildSandbox_Click);
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(6, 90);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(90, 40);
            this.btnClean.TabIndex = 0;
            this.btnClean.Text = "Clean All";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReverse);
            this.groupBox1.Controls.Add(this.btnCopyString);
            this.groupBox1.Controls.Add(this.btnCopyHexCode);
            this.groupBox1.Controls.Add(this.txbHexCode);
            this.groupBox1.Controls.Add(this.Code);
            this.groupBox1.Controls.Add(this.btnConvert);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txbString);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(801, 175);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ASCII CONVERSION";
            // 
            // btnReverse
            // 
            this.btnReverse.Location = new System.Drawing.Point(661, 39);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(99, 23);
            this.btnReverse.TabIndex = 7;
            this.btnReverse.Text = "Reverse";
            this.btnReverse.UseVisualStyleBackColor = true;
            this.btnReverse.Click += new System.EventHandler(this.btnReverse_Click);
            // 
            // btnCopyString
            // 
            this.btnCopyString.Location = new System.Drawing.Point(661, 88);
            this.btnCopyString.Name = "btnCopyString";
            this.btnCopyString.Size = new System.Drawing.Size(99, 65);
            this.btnCopyString.TabIndex = 6;
            this.btnCopyString.Text = "Copy String";
            this.btnCopyString.UseVisualStyleBackColor = true;
            this.btnCopyString.Click += new System.EventHandler(this.btnCopyString_Click);
            // 
            // btnCopyHexCode
            // 
            this.btnCopyHexCode.Location = new System.Drawing.Point(499, 88);
            this.btnCopyHexCode.Name = "btnCopyHexCode";
            this.btnCopyHexCode.Size = new System.Drawing.Size(99, 65);
            this.btnCopyHexCode.TabIndex = 6;
            this.btnCopyHexCode.Text = "Copy Hex Code";
            this.btnCopyHexCode.UseVisualStyleBackColor = true;
            this.btnCopyHexCode.Click += new System.EventHandler(this.btnCopyHexCode_Click);
            // 
            // txbHexCode
            // 
            this.txbHexCode.Location = new System.Drawing.Point(68, 90);
            this.txbHexCode.Multiline = true;
            this.txbHexCode.Name = "txbHexCode";
            this.txbHexCode.Size = new System.Drawing.Size(400, 65);
            this.txbHexCode.TabIndex = 5;
            // 
            // Code
            // 
            this.Code.AutoSize = true;
            this.Code.Location = new System.Drawing.Point(6, 114);
            this.Code.Name = "Code";
            this.Code.Size = new System.Drawing.Size(54, 13);
            this.Code.TabIndex = 4;
            this.Code.Text = "Hex Code";
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(499, 39);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(99, 23);
            this.btnConvert.TabIndex = 3;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "String";
            // 
            // txbString
            // 
            this.txbString.Location = new System.Drawing.Point(68, 41);
            this.txbString.Name = "txbString";
            this.txbString.Size = new System.Drawing.Size(400, 20);
            this.txbString.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pnlDiag);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(832, 412);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Diag";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pnlDiag
            // 
            this.pnlDiag.AutoScroll = true;
            this.pnlDiag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDiag.Controls.Add(this.lbService);
            this.pnlDiag.Controls.Add(this.lbLength);
            this.pnlDiag.Controls.Add(this.lbName);
            this.pnlDiag.Controls.Add(this.lbDID);
            this.pnlDiag.Controls.Add(this.btnCreateDID);
            this.pnlDiag.Controls.Add(this.txtNbOfDID);
            this.pnlDiag.Controls.Add(this.label1);
            this.pnlDiag.Location = new System.Drawing.Point(6, 9);
            this.pnlDiag.Name = "pnlDiag";
            this.pnlDiag.Size = new System.Drawing.Size(805, 400);
            this.pnlDiag.TabIndex = 14;
            // 
            // lbService
            // 
            this.lbService.AutoSize = true;
            this.lbService.Location = new System.Drawing.Point(658, 47);
            this.lbService.Name = "lbService";
            this.lbService.Size = new System.Drawing.Size(43, 13);
            this.lbService.TabIndex = 20;
            this.lbService.Text = "Service";
            // 
            // lbLength
            // 
            this.lbLength.AutoSize = true;
            this.lbLength.Location = new System.Drawing.Point(508, 47);
            this.lbLength.Name = "lbLength";
            this.lbLength.Size = new System.Drawing.Size(40, 13);
            this.lbLength.TabIndex = 19;
            this.lbLength.Text = "Length";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(128, 47);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(35, 13);
            this.lbName.TabIndex = 18;
            this.lbName.Text = "Name";
            // 
            // lbDID
            // 
            this.lbDID.AutoSize = true;
            this.lbDID.Location = new System.Drawing.Point(18, 47);
            this.lbDID.Name = "lbDID";
            this.lbDID.Size = new System.Drawing.Size(26, 13);
            this.lbDID.TabIndex = 17;
            this.lbDID.Text = "DID";
            // 
            // btnCreateDID
            // 
            this.btnCreateDID.Location = new System.Drawing.Point(182, 9);
            this.btnCreateDID.Name = "btnCreateDID";
            this.btnCreateDID.Size = new System.Drawing.Size(75, 23);
            this.btnCreateDID.TabIndex = 16;
            this.btnCreateDID.Text = "Create";
            this.btnCreateDID.UseVisualStyleBackColor = true;
            this.btnCreateDID.Click += new System.EventHandler(this.btnCreateDID_Click_1);
            // 
            // txtNbOfDID
            // 
            this.txtNbOfDID.Location = new System.Drawing.Point(98, 11);
            this.txtNbOfDID.Name = "txtNbOfDID";
            this.txtNbOfDID.Size = new System.Drawing.Size(70, 20);
            this.txtNbOfDID.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Number of DID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 473);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.pnlDiag.ResumeLayout(false);
            this.pnlDiag.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnCopyHexCode;
        private System.Windows.Forms.TextBox txbHexCode;
        private System.Windows.Forms.Label Code;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbString;
        private System.Windows.Forms.Button btnReverse;
        private System.Windows.Forms.Button btnCopyString;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnBuildSandbox;
        private System.Windows.Forms.Button btnChooseSanboxQAC;
        private System.Windows.Forms.TextBox txbSandboxFolder;
        private System.Windows.Forms.Button btnGetInputQAC;
        private System.Windows.Forms.Button btnRunQAC;
        private System.Windows.Forms.TextBox txtQACListFile;
        private System.Windows.Forms.Panel pnlDiag;
        private System.Windows.Forms.Label lbService;
        private System.Windows.Forms.Label lbLength;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbDID;
        private System.Windows.Forms.Button btnCreateDID;
        private System.Windows.Forms.TextBox txtNbOfDID;
        private System.Windows.Forms.Label label1;
    }
}

