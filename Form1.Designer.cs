
namespace FieldConnectMapping
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnOpenFcNetlist = new System.Windows.Forms.Button();
            this.tbProjectName = new System.Windows.Forms.TextBox();
            this.btnDeviceName = new System.Windows.Forms.TextBox();
            this.lblProjectName = new System.Windows.Forms.Label();
            this.lblDeviceType = new System.Windows.Forms.Label();
            this.dgvSlotCardArrangement = new System.Windows.Forms.DataGridView();
            this.colSlotNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCardDesc = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colCornerConnectorGroup = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colNumChannels = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPinStep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSlotCardArrangement)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpenFcNetlist
            // 
            this.btnOpenFcNetlist.Location = new System.Drawing.Point(59, 26);
            this.btnOpenFcNetlist.Name = "btnOpenFcNetlist";
            this.btnOpenFcNetlist.Size = new System.Drawing.Size(75, 44);
            this.btnOpenFcNetlist.TabIndex = 0;
            this.btnOpenFcNetlist.Text = "Open FC Netlist";
            this.btnOpenFcNetlist.UseVisualStyleBackColor = true;
            this.btnOpenFcNetlist.Click += new System.EventHandler(this.btnOpenFcNetlist_Click);
            // 
            // tbProjectName
            // 
            this.tbProjectName.Location = new System.Drawing.Point(245, 38);
            this.tbProjectName.Name = "tbProjectName";
            this.tbProjectName.Size = new System.Drawing.Size(104, 23);
            this.tbProjectName.TabIndex = 1;
            this.tbProjectName.Text = "ASMI";
            this.tbProjectName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnDeviceName
            // 
            this.btnDeviceName.Location = new System.Drawing.Point(456, 38);
            this.btnDeviceName.Name = "btnDeviceName";
            this.btnDeviceName.Size = new System.Drawing.Size(104, 23);
            this.btnDeviceName.TabIndex = 2;
            this.btnDeviceName.Text = "Fusion-24";
            this.btnDeviceName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProjectName.Location = new System.Drawing.Point(257, 20);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(83, 15);
            this.lblProjectName.TabIndex = 3;
            this.lblProjectName.Text = "Project Name";
            this.lblProjectName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDeviceType
            // 
            this.lblDeviceType.AutoSize = true;
            this.lblDeviceType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDeviceType.Location = new System.Drawing.Point(473, 20);
            this.lblDeviceType.Name = "lblDeviceType";
            this.lblDeviceType.Size = new System.Drawing.Size(72, 15);
            this.lblDeviceType.TabIndex = 4;
            this.lblDeviceType.Text = "DeviceType";
            this.lblDeviceType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvSlotCardArrangement
            // 
            this.dgvSlotCardArrangement.AllowUserToAddRows = false;
            this.dgvSlotCardArrangement.AllowUserToDeleteRows = false;
            this.dgvSlotCardArrangement.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSlotCardArrangement.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSlotCardArrangement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSlotCardArrangement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSlotNum,
            this.colCardDesc,
            this.colCornerConnectorGroup,
            this.colNumChannels,
            this.colCodeName,
            this.colPinStep});
            this.dgvSlotCardArrangement.Location = new System.Drawing.Point(59, 119);
            this.dgvSlotCardArrangement.Name = "dgvSlotCardArrangement";
            this.dgvSlotCardArrangement.RowTemplate.Height = 25;
            this.dgvSlotCardArrangement.Size = new System.Drawing.Size(501, 275);
            this.dgvSlotCardArrangement.TabIndex = 5;
            this.dgvSlotCardArrangement.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvSlotCardArrangement.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSlotCardArrangement_CellEndEdit);
            this.dgvSlotCardArrangement.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSlotCardArrangement_CellValidated);
            this.dgvSlotCardArrangement.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSlotCardArrangement_CellValueChanged);
            // 
            // colSlotNum
            // 
            this.colSlotNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colSlotNum.DefaultCellStyle = dataGridViewCellStyle2;
            this.colSlotNum.HeaderText = "Slot #";
            this.colSlotNum.Name = "colSlotNum";
            this.colSlotNum.ReadOnly = true;
            this.colSlotNum.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colSlotNum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colSlotNum.Width = 50;
            // 
            // colCardDesc
            // 
            this.colCardDesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colCardDesc.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.colCardDesc.HeaderText = "Card Description";
            this.colCardDesc.MinimumWidth = 25;
            this.colCardDesc.Name = "colCardDesc";
            this.colCardDesc.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colCardDesc.Width = 150;
            // 
            // colCornerConnectorGroup
            // 
            this.colCornerConnectorGroup.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.colCornerConnectorGroup.HeaderText = "Corner Connector Group";
            this.colCornerConnectorGroup.Name = "colCornerConnectorGroup";
            this.colCornerConnectorGroup.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colCornerConnectorGroup.Width = 75;
            // 
            // colNumChannels
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colNumChannels.DefaultCellStyle = dataGridViewCellStyle3;
            this.colNumChannels.HeaderText = "# Channels";
            this.colNumChannels.Name = "colNumChannels";
            this.colNumChannels.ReadOnly = true;
            this.colNumChannels.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colNumChannels.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colNumChannels.Width = 60;
            // 
            // colCodeName
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colCodeName.DefaultCellStyle = dataGridViewCellStyle4;
            this.colCodeName.HeaderText = "Code Name";
            this.colCodeName.Name = "colCodeName";
            this.colCodeName.ReadOnly = true;
            this.colCodeName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colCodeName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colCodeName.Width = 50;
            // 
            // colPinStep
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colPinStep.DefaultCellStyle = dataGridViewCellStyle5;
            this.colPinStep.HeaderText = "Pin Step";
            this.colPinStep.Name = "colPinStep";
            this.colPinStep.ReadOnly = true;
            this.colPinStep.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colPinStep.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colPinStep.Width = 50;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 406);
            this.Controls.Add(this.dgvSlotCardArrangement);
            this.Controls.Add(this.lblDeviceType);
            this.Controls.Add(this.lblProjectName);
            this.Controls.Add(this.btnDeviceName);
            this.Controls.Add(this.tbProjectName);
            this.Controls.Add(this.btnOpenFcNetlist);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSlotCardArrangement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenFcNetlist;
        private System.Windows.Forms.TextBox tbProjectName;
        private System.Windows.Forms.TextBox btnDeviceName;
        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.Label lblDeviceType;
        private System.Windows.Forms.DataGridView dgvSlotCardArrangement;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSlotNum;
        private System.Windows.Forms.DataGridViewComboBoxColumn colCardDesc;
        private System.Windows.Forms.DataGridViewComboBoxColumn colCornerConnectorGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumChannels;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPinStep;
    }
}

