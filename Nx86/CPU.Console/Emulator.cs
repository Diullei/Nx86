namespace CPU.Console
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;

    using Be.Windows.Forms;

    public partial class Emulator : Form, IEmulatorShell
    {
        private readonly EmulatorController _controller;

        public Emulator()
        {
            InitializeComponent();
            this._controller = new EmulatorController(this, new Engine());
        }

        protected override void OnLoad(EventArgs e)
        {
            // _controller.LoadUI();
        }

        public string AL
        {
            get
            {
                return this.txtAL.Text;
            }

            set
            {
                if (this.txtAL.Text != value)
                {
                    this.txtAL.BackColor = Color.Yellow;
                    this.txtAL.ForeColor = Color.Blue;
                }

                this.txtAL.Text = value;
            }
        }

        public string AH
        {
            get
            {
                return this.txtAH.Text;
            }

            set
            {
                if (this.txtAH.Text != value)
                {
                    this.txtAH.BackColor = Color.Yellow;
                    this.txtAH.ForeColor = Color.Blue;
                }

                this.txtAH.Text = value;
            }
        }

        public string BL
        {
            get
            {
                return this.txtBL.Text;
            }

            set
            {
                if (this.txtBL.Text != value)
                {
                    this.txtBL.BackColor = Color.Yellow;
                    this.txtBL.ForeColor = Color.Blue;
                }

                this.txtBL.Text = value;
            }
        }

        public string BH
        {
            get
            {
                return this.txtBH.Text;
            }

            set
            {
                if (this.txtBH.Text != value)
                {
                    this.txtBH.BackColor = Color.Yellow;
                    this.txtBH.ForeColor = Color.Blue;
                }

                this.txtBH.Text = value;
            }
        }

        public string CL
        {
            get
            {
                return this.txtCL.Text;
            }

            set
            {
                if (this.txtCL.Text != value)
                {
                    this.txtCH.BackColor = Color.Yellow;
                    this.txtCH.ForeColor = Color.Blue;
                }

                this.txtCL.Text = value;
            }
        }

        public string CH
        {
            get
            {
                return this.txtCH.Text;
            }

            set
            {
                if (this.txtCH.Text != value)
                {
                    this.txtCH.BackColor = Color.Yellow;
                    this.txtCH.ForeColor = Color.Blue;
                }

                this.txtCH.Text = value;
            }
        }
     
        public string DL
        {
            get
            {
                return this.txtDL.Text;
            }

            set
            {
                if (this.txtDL.Text != value)
                {
                    this.txtDL.BackColor = Color.Yellow;
                    this.txtDL.ForeColor = Color.Blue;
                }

                this.txtDL.Text = value;
            }
        }

        public string DH
        {
            get
            {
                return this.txtDH.Text;
            }

            set
            {
                if (this.txtDH.Text != value)
                {
                    this.txtDH.BackColor = Color.Yellow;
                    this.txtDH.ForeColor = Color.Blue;
                }

                this.txtDH.Text = value;
            }
        }

        public string CS
        {
            get
            {
                return this.txtCS.Text;
            }

            set
            {
                if (this.txtCS.Text != value)
                {
                    this.txtCS.BackColor = Color.Yellow;
                    this.txtCS.ForeColor = Color.Blue;
                }

                this.txtCS.Text = value;
            }
        }

        public string IP
        {
            get
            {
                return this.txtIP.Text;
            }

            set
            {
                if (this.txtIP.Text != value)
                {
                    this.txtIP.BackColor = Color.Yellow;
                    this.txtIP.ForeColor = Color.Blue;
                }

                this.txtIP.Text = value;
            }
        }

        public string SS
        {
            get
            {
                return this.txtSS.Text;
            }

            set
            {
                if (this.txtSS.Text != value)
                {
                    this.txtSS.BackColor = Color.Yellow;
                    this.txtSS.ForeColor = Color.Blue;
                }

                this.txtSS.Text = value;
            }
        }

        public string SP
        {
            get
            {
                return this.txtSP.Text;
            }

            set
            {
                if (this.txtSP.Text != value)
                {
                    this.txtSP.BackColor = Color.Yellow;
                    this.txtSP.ForeColor = Color.Blue;
                }

                this.txtSP.Text = value;
            }
        }

        public string BP
        {
            get
            {
                return this.txtBP.Text;
            }

            set
            {
                if (this.txtBP.Text != value)
                {
                    this.txtBP.BackColor = Color.Yellow;
                    this.txtBP.ForeColor = Color.Blue;
                }

                this.txtBP.Text = value;
            }
        }

        public string SI
        {
            get
            {
                return this.txtSI.Text;
            }

            set
            {
                if (this.txtSI.Text != value)
                {
                    this.txtSI.BackColor = Color.Yellow;
                    this.txtSI.ForeColor = Color.Blue;
                }

                this.txtSI.Text = value;
            }
        }

        public string DI
        {
            get
            {
                return this.txtDI.Text;
            }

            set
            {
                if (this.txtDI.Text != value)
                {
                    this.txtDI.BackColor = Color.Yellow;
                    this.txtDI.ForeColor = Color.Blue;
                }

                this.txtDI.Text = value;
            }
        }

        public string DS
        {
            get
            {
                return this.txtDS.Text;
            }

            set
            {
                if (this.txtDS.Text != value)
                {
                    this.txtDS.BackColor = Color.Yellow;
                    this.txtDS.ForeColor = Color.Blue;
                }

                this.txtDS.Text = value;
            }
        }

        public string ES
        {
            get
            {
                return this.txtES.Text;
            }

            set
            {
                if (this.txtES.Text != value)
                {
                    this.txtES.BackColor = Color.Yellow;
                    this.txtES.ForeColor = Color.Blue;
                }

                this.txtES.Text = value;
            }
        }

        public string Offset
        {
            get
            {
                return this.lblOffset.Text;
            }

            set
            {
                this.lblOffset.Text = value;
            }
        }

        public void SetCode(List<string> instructions)
        {
            dgvCode.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvCode.RowTemplate.Height = 15;

            instructions.Add(string.Empty);
            dgvCode.DataSource = instructions.Select(x => new { Value = x }).ToList();

            foreach (DataGridViewColumn column in dgvCode.Columns)
            {
                column.Width = 200;   
            }
        }

        public void SetCodePosition(int position)
        {
            if (dgvCode.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvCode.SelectedRows)
                {
                    row.Selected = false;
                }
            }

            dgvCode.Rows[position].Selected = true;

            dgvCode.Show();
        }

        public void ShowInfoMessage(string message)
        {
            MessageBox.Show(message);
        }

        public void SetTextboxBackColorToWhite()
        {
            this.txtAL.BackColor = Color.White;
            this.txtAH.BackColor = Color.White;
            this.txtBL.BackColor = Color.White;
            this.txtBH.BackColor = Color.White;
            this.txtCL.BackColor = Color.White;
            this.txtCH.BackColor = Color.White;
            this.txtDL.BackColor = Color.White;
            this.txtDH.BackColor = Color.White;

            this.txtCS.BackColor = Color.White;
            this.txtIP.BackColor = Color.White;
            this.txtSS.BackColor = Color.White;
            this.txtSP.BackColor = Color.White;
            this.txtBP.BackColor = Color.White;
            this.txtSI.BackColor = Color.White;
            this.txtDI.BackColor = Color.White;
            this.txtDS.BackColor = Color.White;
            this.txtES.BackColor = Color.White;
        }

        public void SetTextboxFontColorToBlack()
        {
            this.txtAL.ForeColor = Color.Black;
            this.txtAH.ForeColor = Color.Black;
            this.txtBL.ForeColor = Color.Black;
            this.txtBH.ForeColor = Color.Black;
            this.txtCL.ForeColor = Color.Black;
            this.txtCH.ForeColor = Color.Black;
            this.txtDL.ForeColor = Color.Black;
            this.txtDH.ForeColor = Color.Black;

            this.txtCS.ForeColor = Color.Black;
            this.txtIP.ForeColor = Color.Black;
            this.txtSS.ForeColor = Color.Black;
            this.txtSP.ForeColor = Color.Black;
            this.txtBP.ForeColor = Color.Black;
            this.txtSI.ForeColor = Color.Black;
            this.txtDI.ForeColor = Color.Black;
            this.txtDS.ForeColor = Color.Black;
            this.txtES.ForeColor = Color.Black;
        }

        public void SetMem(List<string> data)
        {
            dgvMem.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvMem.RowTemplate.Height = 15;

            dgvMem.DataSource = data.Select(x => new { Value = x }).ToList();

            foreach (DataGridViewColumn column in dgvMem.Columns)
            {
                column.Width = 200;
            }
        }

        public void SetFileName(string fileName)
        {
            this.Text = string.Format("Nx86 [{0}]", fileName);
        }

        public void SetMemRegion(long offset, int len)
        {
            if (dgvMem.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvMem.SelectedRows)
                {
                    row.Selected = false;
                }
            }

            for (var i = offset; i < offset + len; i++)
            {
                dgvMem.Rows[(int)i].Selected = true;
            }

            dgvMem.FirstDisplayedScrollingRowIndex = (int)offset;
        }

        private void btnExecNextStep_Click(object sender, EventArgs e)
        {
            _controller.ExecAndGoNextStep();
        }

        private void dgvCode_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var dataGridView = sender as DataGridView;
            e.CellStyle.Font = new Font(new FontFamily("Consolas"), 8);
            e.CellStyle.SelectionBackColor = Color.Yellow;
            e.CellStyle.SelectionForeColor = Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _controller.Reload();
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog
                                {
                                    Title = "Open Code File",
                                    Filter = "COM_ files|*.com_"//,
                                    //InitialDirectory = @"C:\"
                                };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _controller.OpenFile(dialog.FileName);
            }
        }

        private void dgvMem_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var dataGridView = sender as DataGridView;
            e.CellStyle.Font = new Font(new FontFamily("Consolas"), 8);
            e.CellStyle.SelectionBackColor = Color.GreenYellow;
            e.CellStyle.SelectionForeColor = Color.Black;
        }
    }
}
