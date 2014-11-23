namespace CPU.Console
{
    partial class Emulator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Emulator));
            this.label1 = new System.Windows.Forms.Label();
            this.txtAH = new System.Windows.Forms.TextBox();
            this.txtAL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBL = new System.Windows.Forms.TextBox();
            this.txtBH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCL = new System.Windows.Forms.TextBox();
            this.txtCH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDL = new System.Windows.Forms.TextBox();
            this.txtDH = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCS = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSS = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSI = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBP = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSP = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtES = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDS = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtDI = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExecNextStep = new System.Windows.Forms.Button();
            this.dgvCode = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblOffset = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.dgvMem = new System.Windows.Forms.DataGridView();
            this.txtCF = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtZF = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtOF = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtSF = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtDF = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtIF = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtAF = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtPF = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCode)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMem)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "AX";
            // 
            // txtAH
            // 
            this.txtAH.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAH.Location = new System.Drawing.Point(35, 32);
            this.txtAH.Name = "txtAH";
            this.txtAH.Size = new System.Drawing.Size(27, 20);
            this.txtAH.TabIndex = 1;
            this.txtAH.Text = "00";
            this.txtAH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAL
            // 
            this.txtAL.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAL.Location = new System.Drawing.Point(68, 32);
            this.txtAL.Name = "txtAL";
            this.txtAL.Size = new System.Drawing.Size(27, 20);
            this.txtAL.TabIndex = 2;
            this.txtAL.Text = "00";
            this.txtAL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "H";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "L";
            // 
            // txtBL
            // 
            this.txtBL.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBL.Location = new System.Drawing.Point(68, 58);
            this.txtBL.Name = "txtBL";
            this.txtBL.Size = new System.Drawing.Size(27, 20);
            this.txtBL.TabIndex = 7;
            this.txtBL.Text = "00";
            this.txtBL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBH
            // 
            this.txtBH.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBH.Location = new System.Drawing.Point(35, 58);
            this.txtBH.Name = "txtBH";
            this.txtBH.Size = new System.Drawing.Size(27, 20);
            this.txtBH.TabIndex = 6;
            this.txtBH.Text = "00";
            this.txtBH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "BX";
            // 
            // txtCL
            // 
            this.txtCL.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCL.Location = new System.Drawing.Point(68, 84);
            this.txtCL.Name = "txtCL";
            this.txtCL.Size = new System.Drawing.Size(27, 20);
            this.txtCL.TabIndex = 10;
            this.txtCL.Text = "00";
            this.txtCL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCH
            // 
            this.txtCH.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCH.Location = new System.Drawing.Point(35, 84);
            this.txtCH.Name = "txtCH";
            this.txtCH.Size = new System.Drawing.Size(27, 20);
            this.txtCH.TabIndex = 9;
            this.txtCH.Text = "00";
            this.txtCH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "CX";
            // 
            // txtDL
            // 
            this.txtDL.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDL.Location = new System.Drawing.Point(68, 110);
            this.txtDL.Name = "txtDL";
            this.txtDL.Size = new System.Drawing.Size(27, 20);
            this.txtDL.TabIndex = 13;
            this.txtDL.Text = "00";
            this.txtDL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDH
            // 
            this.txtDH.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDH.Location = new System.Drawing.Point(35, 110);
            this.txtDH.Name = "txtDH";
            this.txtDH.Size = new System.Drawing.Size(27, 20);
            this.txtDH.TabIndex = 12;
            this.txtDH.Text = "00";
            this.txtDH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "DX";
            // 
            // txtCS
            // 
            this.txtCS.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCS.Location = new System.Drawing.Point(35, 136);
            this.txtCS.Name = "txtCS";
            this.txtCS.Size = new System.Drawing.Size(60, 20);
            this.txtCS.TabIndex = 14;
            this.txtCS.Text = "0000";
            this.txtCS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "CS";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "IP";
            // 
            // txtIP
            // 
            this.txtIP.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIP.Location = new System.Drawing.Point(35, 162);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(60, 20);
            this.txtIP.TabIndex = 16;
            this.txtIP.Text = "0000";
            this.txtIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "SS";
            // 
            // txtSS
            // 
            this.txtSS.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSS.Location = new System.Drawing.Point(35, 188);
            this.txtSS.Name = "txtSS";
            this.txtSS.Size = new System.Drawing.Size(60, 20);
            this.txtSS.TabIndex = 18;
            this.txtSS.Text = "0000";
            this.txtSS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 269);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "SI";
            // 
            // txtSI
            // 
            this.txtSI.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSI.Location = new System.Drawing.Point(35, 266);
            this.txtSI.Name = "txtSI";
            this.txtSI.Size = new System.Drawing.Size(60, 20);
            this.txtSI.TabIndex = 24;
            this.txtSI.Text = "0000";
            this.txtSI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 243);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "BP";
            // 
            // txtBP
            // 
            this.txtBP.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBP.Location = new System.Drawing.Point(35, 240);
            this.txtBP.Name = "txtBP";
            this.txtBP.Size = new System.Drawing.Size(60, 20);
            this.txtBP.TabIndex = 22;
            this.txtBP.Text = "0000";
            this.txtBP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 217);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "SP";
            // 
            // txtSP
            // 
            this.txtSP.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSP.Location = new System.Drawing.Point(35, 214);
            this.txtSP.Name = "txtSP";
            this.txtSP.Size = new System.Drawing.Size(60, 20);
            this.txtSP.TabIndex = 20;
            this.txtSP.Text = "0000";
            this.txtSP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 347);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "ES";
            // 
            // txtES
            // 
            this.txtES.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtES.Location = new System.Drawing.Point(35, 344);
            this.txtES.Name = "txtES";
            this.txtES.Size = new System.Drawing.Size(60, 20);
            this.txtES.TabIndex = 30;
            this.txtES.Text = "0000";
            this.txtES.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 321);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(22, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "DS";
            // 
            // txtDS
            // 
            this.txtDS.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDS.Location = new System.Drawing.Point(35, 318);
            this.txtDS.Name = "txtDS";
            this.txtDS.Size = new System.Drawing.Size(60, 20);
            this.txtDS.TabIndex = 28;
            this.txtDS.Text = "0000";
            this.txtDS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 295);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(18, 13);
            this.label15.TabIndex = 27;
            this.label15.Text = "DI";
            // 
            // txtDI
            // 
            this.txtDI.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDI.Location = new System.Drawing.Point(35, 292);
            this.txtDI.Name = "txtDI";
            this.txtDI.Size = new System.Drawing.Size(60, 20);
            this.txtDI.TabIndex = 26;
            this.txtDI.Text = "0000";
            this.txtDI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAH);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtES);
            this.groupBox1.Controls.Add(this.txtAL);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDS);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDI);
            this.groupBox1.Controls.Add(this.txtBH);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtBL);
            this.groupBox1.Controls.Add(this.txtSI);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtCH);
            this.groupBox1.Controls.Add(this.txtBP);
            this.groupBox1.Controls.Add(this.txtCL);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtSP);
            this.groupBox1.Controls.Add(this.txtDH);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtDL);
            this.groupBox1.Controls.Add(this.txtSS);
            this.groupBox1.Controls.Add(this.txtCS);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtIP);
            this.groupBox1.Location = new System.Drawing.Point(9, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(103, 373);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "registers";
            // 
            // btnExecNextStep
            // 
            this.btnExecNextStep.Location = new System.Drawing.Point(123, 8);
            this.btnExecNextStep.Name = "btnExecNextStep";
            this.btnExecNextStep.Size = new System.Drawing.Size(51, 46);
            this.btnExecNextStep.TabIndex = 33;
            this.btnExecNextStep.Text = "Next";
            this.btnExecNextStep.UseVisualStyleBackColor = true;
            this.btnExecNextStep.Click += new System.EventHandler(this.btnExecNextStep_Click);
            // 
            // dgvCode
            // 
            this.dgvCode.BackgroundColor = System.Drawing.Color.White;
            this.dgvCode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCode.ColumnHeadersVisible = false;
            this.dgvCode.Enabled = false;
            this.dgvCode.Location = new System.Drawing.Point(261, 92);
            this.dgvCode.Name = "dgvCode";
            this.dgvCode.ReadOnly = true;
            this.dgvCode.RowHeadersVisible = false;
            this.dgvCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvCode.Size = new System.Drawing.Size(200, 341);
            this.dgvCode.TabIndex = 34;
            this.dgvCode.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvCode_CellFormatting);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblOffset);
            this.panel1.Location = new System.Drawing.Point(261, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 25);
            this.panel1.TabIndex = 35;
            // 
            // lblOffset
            // 
            this.lblOffset.AutoSize = true;
            this.lblOffset.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOffset.Location = new System.Drawing.Point(71, 4);
            this.lblOffset.Name = "lblOffset";
            this.lblOffset.Size = new System.Drawing.Size(61, 13);
            this.lblOffset.TabIndex = 36;
            this.lblOffset.Text = "0000:0000";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(66, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 46);
            this.button1.TabIndex = 36;
            this.button1.Text = "Reload";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Location = new System.Drawing.Point(9, 8);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(51, 46);
            this.btnLoadFile.TabIndex = 37;
            this.btnLoadFile.Text = "Load";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // dgvMem
            // 
            this.dgvMem.BackgroundColor = System.Drawing.Color.White;
            this.dgvMem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMem.ColumnHeadersVisible = false;
            this.dgvMem.Location = new System.Drawing.Point(118, 64);
            this.dgvMem.Name = "dgvMem";
            this.dgvMem.ReadOnly = true;
            this.dgvMem.RowHeadersVisible = false;
            this.dgvMem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvMem.Size = new System.Drawing.Size(137, 369);
            this.dgvMem.TabIndex = 40;
            this.dgvMem.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvMem_CellFormatting);
            // 
            // txtCF
            // 
            this.txtCF.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCF.Location = new System.Drawing.Point(34, 15);
            this.txtCF.Name = "txtCF";
            this.txtCF.Size = new System.Drawing.Size(20, 20);
            this.txtCF.TabIndex = 33;
            this.txtCF.Text = "0";
            this.txtCF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 18);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(20, 13);
            this.label16.TabIndex = 32;
            this.label16.Text = "CF";
            // 
            // txtZF
            // 
            this.txtZF.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZF.Location = new System.Drawing.Point(34, 39);
            this.txtZF.Name = "txtZF";
            this.txtZF.Size = new System.Drawing.Size(20, 20);
            this.txtZF.TabIndex = 42;
            this.txtZF.Text = "0";
            this.txtZF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(7, 42);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(20, 13);
            this.label17.TabIndex = 41;
            this.label17.Text = "ZF";
            // 
            // txtOF
            // 
            this.txtOF.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOF.Location = new System.Drawing.Point(34, 88);
            this.txtOF.Name = "txtOF";
            this.txtOF.Size = new System.Drawing.Size(20, 20);
            this.txtOF.TabIndex = 46;
            this.txtOF.Text = "0";
            this.txtOF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(7, 91);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(21, 13);
            this.label18.TabIndex = 45;
            this.label18.Text = "OF";
            // 
            // txtSF
            // 
            this.txtSF.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSF.Location = new System.Drawing.Point(34, 64);
            this.txtSF.Name = "txtSF";
            this.txtSF.Size = new System.Drawing.Size(20, 20);
            this.txtSF.TabIndex = 44;
            this.txtSF.Text = "0";
            this.txtSF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(7, 67);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(20, 13);
            this.label19.TabIndex = 43;
            this.label19.Text = "SF";
            // 
            // txtDF
            // 
            this.txtDF.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDF.Location = new System.Drawing.Point(34, 185);
            this.txtDF.Name = "txtDF";
            this.txtDF.Size = new System.Drawing.Size(20, 20);
            this.txtDF.TabIndex = 54;
            this.txtDF.Text = "0";
            this.txtDF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(7, 188);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(21, 13);
            this.label20.TabIndex = 53;
            this.label20.Text = "DF";
            // 
            // txtIF
            // 
            this.txtIF.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIF.Location = new System.Drawing.Point(34, 161);
            this.txtIF.Name = "txtIF";
            this.txtIF.Size = new System.Drawing.Size(20, 20);
            this.txtIF.TabIndex = 52;
            this.txtIF.Text = "0";
            this.txtIF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(7, 164);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(16, 13);
            this.label21.TabIndex = 51;
            this.label21.Text = "IF";
            // 
            // txtAF
            // 
            this.txtAF.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAF.Location = new System.Drawing.Point(34, 136);
            this.txtAF.Name = "txtAF";
            this.txtAF.Size = new System.Drawing.Size(20, 20);
            this.txtAF.TabIndex = 50;
            this.txtAF.Text = "0";
            this.txtAF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(7, 139);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(20, 13);
            this.label22.TabIndex = 49;
            this.label22.Text = "AF";
            // 
            // txtPF
            // 
            this.txtPF.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPF.Location = new System.Drawing.Point(34, 112);
            this.txtPF.Name = "txtPF";
            this.txtPF.Size = new System.Drawing.Size(20, 20);
            this.txtPF.TabIndex = 48;
            this.txtPF.Text = "0";
            this.txtPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(7, 115);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(20, 13);
            this.label23.TabIndex = 47;
            this.label23.Text = "PF";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.txtDF);
            this.groupBox2.Controls.Add(this.txtCF);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.txtIF);
            this.groupBox2.Controls.Add(this.txtZF);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.txtAF);
            this.groupBox2.Controls.Add(this.txtSF);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.txtPF);
            this.groupBox2.Controls.Add(this.txtOF);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Location = new System.Drawing.Point(467, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(60, 212);
            this.groupBox2.TabIndex = 55;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "flags";
            // 
            // Emulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 442);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvMem);
            this.Controls.Add(this.btnLoadFile);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvCode);
            this.Controls.Add(this.btnExecNextStep);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Emulator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nx86";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCode)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMem)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAH;
        private System.Windows.Forms.TextBox txtAL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBL;
        private System.Windows.Forms.TextBox txtBH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCL;
        private System.Windows.Forms.TextBox txtCH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDL;
        private System.Windows.Forms.TextBox txtDH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCS;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSS;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSI;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBP;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSP;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtES;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtDS;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtDI;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExecNextStep;
        private System.Windows.Forms.DataGridView dgvCode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblOffset;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.DataGridView dgvMem;
        private System.Windows.Forms.TextBox txtCF;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtZF;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtOF;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtSF;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtDF;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtIF;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtAF;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtPF;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

