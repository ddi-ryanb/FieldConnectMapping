
namespace FieldConnectMapping
{
    partial class FieldConnectMappingForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.colCcStartPin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCcEndPin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPinStep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnPopulateRandomly = new System.Windows.Forms.Button();
            this.btnCreateSlotCardConfig = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvSlotCardPins = new System.Windows.Forms.DataGridView();
            this.tpConnectorList = new System.Windows.Forms.TabPage();
            this.btnExpandConnectorList = new System.Windows.Forms.Button();
            this.btnOpenConnectorList = new System.Windows.Forms.Button();
            this.dgvConnectorTable = new System.Windows.Forms.DataGridView();
            this.tpExpandedConnectorList = new System.Windows.Forms.TabPage();
            this.dgvExpandedConnectorList = new System.Windows.Forms.DataGridView();
            this.tpNetlist = new System.Windows.Forms.TabPage();
            this.dgvNetlistContents = new System.Windows.Forms.DataGridView();
            this.tbFcMapping = new System.Windows.Forms.TabPage();
            this.btnCreateFcMap = new System.Windows.Forms.Button();
            this.dgvFcMap = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSlotCardArrangement)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSlotCardPins)).BeginInit();
            this.tpConnectorList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConnectorTable)).BeginInit();
            this.tpExpandedConnectorList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpandedConnectorList)).BeginInit();
            this.tpNetlist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNetlistContents)).BeginInit();
            this.tbFcMapping.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFcMap)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpenFcNetlist
            // 
            this.btnOpenFcNetlist.Location = new System.Drawing.Point(25, 13);
            this.btnOpenFcNetlist.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btnOpenFcNetlist.Name = "btnOpenFcNetlist";
            this.btnOpenFcNetlist.Size = new System.Drawing.Size(182, 120);
            this.btnOpenFcNetlist.TabIndex = 0;
            this.btnOpenFcNetlist.Text = "Open FC Netlist";
            this.btnOpenFcNetlist.UseVisualStyleBackColor = true;
            this.btnOpenFcNetlist.Click += new System.EventHandler(this.btnOpenFcNetlist_Click);
            // 
            // tbProjectName
            // 
            this.tbProjectName.Location = new System.Drawing.Point(595, 104);
            this.tbProjectName.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.tbProjectName.Name = "tbProjectName";
            this.tbProjectName.Size = new System.Drawing.Size(247, 47);
            this.tbProjectName.TabIndex = 1;
            this.tbProjectName.Text = "ASMI";
            this.tbProjectName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnDeviceName
            // 
            this.btnDeviceName.Location = new System.Drawing.Point(1107, 104);
            this.btnDeviceName.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btnDeviceName.Name = "btnDeviceName";
            this.btnDeviceName.Size = new System.Drawing.Size(247, 47);
            this.btnDeviceName.TabIndex = 2;
            this.btnDeviceName.Text = "Fusion-24";
            this.btnDeviceName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProjectName.Location = new System.Drawing.Point(624, 55);
            this.lblProjectName.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(208, 41);
            this.lblProjectName.TabIndex = 3;
            this.lblProjectName.Text = "Project Name";
            this.lblProjectName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDeviceType
            // 
            this.lblDeviceType.AutoSize = true;
            this.lblDeviceType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDeviceType.Location = new System.Drawing.Point(1149, 55);
            this.lblDeviceType.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblDeviceType.Name = "lblDeviceType";
            this.lblDeviceType.Size = new System.Drawing.Size(179, 41);
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
            this.colCcStartPin,
            this.colCcEndPin,
            this.colCodeName,
            this.colPinStep});
            this.dgvSlotCardArrangement.Location = new System.Drawing.Point(78, 145);
            this.dgvSlotCardArrangement.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.dgvSlotCardArrangement.Name = "dgvSlotCardArrangement";
            this.dgvSlotCardArrangement.RowHeadersWidth = 102;
            this.dgvSlotCardArrangement.RowTemplate.Height = 25;
            this.dgvSlotCardArrangement.Size = new System.Drawing.Size(1982, 824);
            this.dgvSlotCardArrangement.TabIndex = 5;
            this.dgvSlotCardArrangement.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSlotCardArrangement_CellEndEdit);
            // 
            // colSlotNum
            // 
            this.colSlotNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colSlotNum.DefaultCellStyle = dataGridViewCellStyle2;
            this.colSlotNum.HeaderText = "Slot #";
            this.colSlotNum.MinimumWidth = 12;
            this.colSlotNum.Name = "colSlotNum";
            this.colSlotNum.ReadOnly = true;
            this.colSlotNum.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colSlotNum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colSlotNum.Width = 96;
            // 
            // colCardDesc
            // 
            this.colCardDesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colCardDesc.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.colCardDesc.HeaderText = "Card Description";
            this.colCardDesc.MinimumWidth = 25;
            this.colCardDesc.Name = "colCardDesc";
            this.colCardDesc.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colCardDesc.Width = 500;
            // 
            // colCornerConnectorGroup
            // 
            this.colCornerConnectorGroup.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colCornerConnectorGroup.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.colCornerConnectorGroup.HeaderText = "Corner Connector Group";
            this.colCornerConnectorGroup.MinimumWidth = 12;
            this.colCornerConnectorGroup.Name = "colCornerConnectorGroup";
            this.colCornerConnectorGroup.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colCornerConnectorGroup.Width = 250;
            // 
            // colNumChannels
            // 
            this.colNumChannels.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colNumChannels.DefaultCellStyle = dataGridViewCellStyle3;
            this.colNumChannels.HeaderText = "# Channels";
            this.colNumChannels.MinimumWidth = 12;
            this.colNumChannels.Name = "colNumChannels";
            this.colNumChannels.ReadOnly = true;
            this.colNumChannels.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colNumChannels.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colNumChannels.Width = 159;
            // 
            // colCcStartPin
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colCcStartPin.DefaultCellStyle = dataGridViewCellStyle4;
            this.colCcStartPin.HeaderText = "Corner Connector Start Pin";
            this.colCcStartPin.MinimumWidth = 12;
            this.colCcStartPin.Name = "colCcStartPin";
            this.colCcStartPin.ReadOnly = true;
            this.colCcStartPin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colCcStartPin.Width = 250;
            // 
            // colCcEndPin
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colCcEndPin.DefaultCellStyle = dataGridViewCellStyle5;
            this.colCcEndPin.HeaderText = "Corner Connector End Pin";
            this.colCcEndPin.MinimumWidth = 12;
            this.colCcEndPin.Name = "colCcEndPin";
            this.colCcEndPin.ReadOnly = true;
            this.colCcEndPin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colCcEndPin.Width = 250;
            // 
            // colCodeName
            // 
            this.colCodeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colCodeName.DefaultCellStyle = dataGridViewCellStyle6;
            this.colCodeName.HeaderText = "Code Name";
            this.colCodeName.MinimumWidth = 12;
            this.colCodeName.Name = "colCodeName";
            this.colCodeName.ReadOnly = true;
            this.colCodeName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colCodeName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colCodeName.Width = 168;
            // 
            // colPinStep
            // 
            this.colPinStep.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colPinStep.DefaultCellStyle = dataGridViewCellStyle7;
            this.colPinStep.HeaderText = "Pin Step";
            this.colPinStep.MinimumWidth = 12;
            this.colPinStep.Name = "colPinStep";
            this.colPinStep.ReadOnly = true;
            this.colPinStep.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colPinStep.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colPinStep.Width = 126;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tpConnectorList);
            this.tabControl1.Controls.Add(this.tpExpandedConnectorList);
            this.tabControl1.Controls.Add(this.tpNetlist);
            this.tabControl1.Controls.Add(this.tbFcMapping);
            this.tabControl1.Location = new System.Drawing.Point(81, 248);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(20, 3);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(2167, 1048);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.btnPopulateRandomly);
            this.tabPage1.Controls.Add(this.btnCreateSlotCardConfig);
            this.tabPage1.Controls.Add(this.dgvSlotCardArrangement);
            this.tabPage1.Location = new System.Drawing.Point(10, 58);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(2147, 980);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Slot Card Mapping";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnPopulateRandomly
            // 
            this.btnPopulateRandomly.Location = new System.Drawing.Point(78, 21);
            this.btnPopulateRandomly.Name = "btnPopulateRandomly";
            this.btnPopulateRandomly.Size = new System.Drawing.Size(210, 107);
            this.btnPopulateRandomly.TabIndex = 7;
            this.btnPopulateRandomly.Text = "Populate Randomly";
            this.btnPopulateRandomly.UseVisualStyleBackColor = true;
            this.btnPopulateRandomly.Click += new System.EventHandler(this.btnPopulateRandomly_Click);
            // 
            // btnCreateSlotCardConfig
            // 
            this.btnCreateSlotCardConfig.Location = new System.Drawing.Point(351, 21);
            this.btnCreateSlotCardConfig.Name = "btnCreateSlotCardConfig";
            this.btnCreateSlotCardConfig.Size = new System.Drawing.Size(210, 107);
            this.btnCreateSlotCardConfig.TabIndex = 6;
            this.btnCreateSlotCardConfig.Text = "Create Slot Card Config";
            this.btnCreateSlotCardConfig.UseVisualStyleBackColor = true;
            this.btnCreateSlotCardConfig.Click += new System.EventHandler(this.btnCreateSlotCardConfig_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.dgvSlotCardPins);
            this.tabPage2.Location = new System.Drawing.Point(10, 58);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(2147, 980);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvSlotCardPins
            // 
            this.dgvSlotCardPins.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSlotCardPins.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvSlotCardPins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSlotCardPins.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvSlotCardPins.Location = new System.Drawing.Point(3, 6);
            this.dgvSlotCardPins.Name = "dgvSlotCardPins";
            this.dgvSlotCardPins.RowHeadersWidth = 102;
            this.dgvSlotCardPins.RowTemplate.Height = 49;
            this.dgvSlotCardPins.Size = new System.Drawing.Size(2101, 821);
            this.dgvSlotCardPins.TabIndex = 0;
            // 
            // tpConnectorList
            // 
            this.tpConnectorList.Controls.Add(this.btnExpandConnectorList);
            this.tpConnectorList.Controls.Add(this.btnOpenConnectorList);
            this.tpConnectorList.Controls.Add(this.dgvConnectorTable);
            this.tpConnectorList.Location = new System.Drawing.Point(10, 58);
            this.tpConnectorList.Name = "tpConnectorList";
            this.tpConnectorList.Size = new System.Drawing.Size(2147, 980);
            this.tpConnectorList.TabIndex = 4;
            this.tpConnectorList.Text = "Connector List";
            this.tpConnectorList.UseVisualStyleBackColor = true;
            // 
            // btnExpandConnectorList
            // 
            this.btnExpandConnectorList.Location = new System.Drawing.Point(351, 8);
            this.btnExpandConnectorList.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btnExpandConnectorList.Name = "btnExpandConnectorList";
            this.btnExpandConnectorList.Size = new System.Drawing.Size(230, 120);
            this.btnExpandConnectorList.TabIndex = 2;
            this.btnExpandConnectorList.Text = "Expand Connector List";
            this.btnExpandConnectorList.UseVisualStyleBackColor = true;
            this.btnExpandConnectorList.Click += new System.EventHandler(this.btnExpandConnectorList_Click);
            // 
            // btnOpenConnectorList
            // 
            this.btnOpenConnectorList.Location = new System.Drawing.Point(18, 8);
            this.btnOpenConnectorList.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btnOpenConnectorList.Name = "btnOpenConnectorList";
            this.btnOpenConnectorList.Size = new System.Drawing.Size(230, 120);
            this.btnOpenConnectorList.TabIndex = 1;
            this.btnOpenConnectorList.Text = "Open Connector List";
            this.btnOpenConnectorList.UseVisualStyleBackColor = true;
            this.btnOpenConnectorList.Click += new System.EventHandler(this.btnOpenConnectorList_Click);
            // 
            // dgvConnectorTable
            // 
            this.dgvConnectorTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConnectorTable.Location = new System.Drawing.Point(18, 139);
            this.dgvConnectorTable.Name = "dgvConnectorTable";
            this.dgvConnectorTable.RowHeadersWidth = 102;
            this.dgvConnectorTable.RowTemplate.Height = 49;
            this.dgvConnectorTable.Size = new System.Drawing.Size(2099, 818);
            this.dgvConnectorTable.TabIndex = 0;
            // 
            // tpExpandedConnectorList
            // 
            this.tpExpandedConnectorList.Controls.Add(this.dgvExpandedConnectorList);
            this.tpExpandedConnectorList.Location = new System.Drawing.Point(10, 58);
            this.tpExpandedConnectorList.Name = "tpExpandedConnectorList";
            this.tpExpandedConnectorList.Size = new System.Drawing.Size(2147, 980);
            this.tpExpandedConnectorList.TabIndex = 5;
            this.tpExpandedConnectorList.Text = "Expanded Connector List";
            this.tpExpandedConnectorList.UseVisualStyleBackColor = true;
            // 
            // dgvExpandedConnectorList
            // 
            this.dgvExpandedConnectorList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExpandedConnectorList.Location = new System.Drawing.Point(18, 29);
            this.dgvExpandedConnectorList.Name = "dgvExpandedConnectorList";
            this.dgvExpandedConnectorList.RowHeadersWidth = 102;
            this.dgvExpandedConnectorList.RowTemplate.Height = 49;
            this.dgvExpandedConnectorList.Size = new System.Drawing.Size(2083, 921);
            this.dgvExpandedConnectorList.TabIndex = 0;
            // 
            // tpNetlist
            // 
            this.tpNetlist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpNetlist.Controls.Add(this.dgvNetlistContents);
            this.tpNetlist.Controls.Add(this.btnOpenFcNetlist);
            this.tpNetlist.Location = new System.Drawing.Point(10, 58);
            this.tpNetlist.Name = "tpNetlist";
            this.tpNetlist.Size = new System.Drawing.Size(2147, 980);
            this.tpNetlist.TabIndex = 2;
            this.tpNetlist.Text = "Netlist Signals";
            this.tpNetlist.UseVisualStyleBackColor = true;
            // 
            // dgvNetlistContents
            // 
            this.dgvNetlistContents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNetlistContents.Location = new System.Drawing.Point(25, 144);
            this.dgvNetlistContents.Name = "dgvNetlistContents";
            this.dgvNetlistContents.RowHeadersWidth = 102;
            this.dgvNetlistContents.RowTemplate.Height = 49;
            this.dgvNetlistContents.Size = new System.Drawing.Size(2013, 805);
            this.dgvNetlistContents.TabIndex = 0;
            // 
            // tbFcMapping
            // 
            this.tbFcMapping.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbFcMapping.Controls.Add(this.btnCreateFcMap);
            this.tbFcMapping.Controls.Add(this.dgvFcMap);
            this.tbFcMapping.Location = new System.Drawing.Point(10, 58);
            this.tbFcMapping.Name = "tbFcMapping";
            this.tbFcMapping.Size = new System.Drawing.Size(2147, 980);
            this.tbFcMapping.TabIndex = 3;
            this.tbFcMapping.Text = "Field Connect Mapping";
            this.tbFcMapping.UseVisualStyleBackColor = true;
            // 
            // btnCreateFcMap
            // 
            this.btnCreateFcMap.Location = new System.Drawing.Point(12, 3);
            this.btnCreateFcMap.Name = "btnCreateFcMap";
            this.btnCreateFcMap.Size = new System.Drawing.Size(210, 107);
            this.btnCreateFcMap.TabIndex = 7;
            this.btnCreateFcMap.Text = "Create FC Map";
            this.btnCreateFcMap.UseVisualStyleBackColor = true;
            this.btnCreateFcMap.Click += new System.EventHandler(this.btnCreateFcMap_Click);
            // 
            // dgvFcMap
            // 
            this.dgvFcMap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFcMap.Location = new System.Drawing.Point(12, 118);
            this.dgvFcMap.Name = "dgvFcMap";
            this.dgvFcMap.RowHeadersWidth = 102;
            this.dgvFcMap.RowTemplate.Height = 49;
            this.dgvFcMap.Size = new System.Drawing.Size(2112, 841);
            this.dgvFcMap.TabIndex = 1;
            // 
            // FieldConnectMappingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2742, 1331);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblDeviceType);
            this.Controls.Add(this.lblProjectName);
            this.Controls.Add(this.btnDeviceName);
            this.Controls.Add(this.tbProjectName);
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "FieldConnectMappingForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSlotCardArrangement)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSlotCardPins)).EndInit();
            this.tpConnectorList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConnectorTable)).EndInit();
            this.tpExpandedConnectorList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpandedConnectorList)).EndInit();
            this.tpNetlist.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNetlistContents)).EndInit();
            this.tbFcMapping.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFcMap)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colCcStartPin;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCcEndPin;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPinStep;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnCreateSlotCardConfig;
        private System.Windows.Forms.DataGridView dgvSlotCardPins;
        private System.Windows.Forms.Button btnPopulateRandomly;
        private System.Windows.Forms.TabPage tpNetlist;
        private System.Windows.Forms.DataGridView dgvNetlistContents;
        private System.Windows.Forms.TabPage tbFcMapping;
        private System.Windows.Forms.DataGridView dgvFcMap;
        private System.Windows.Forms.Button btnCreateFcMap;
        private System.Windows.Forms.TabPage tpConnectorList;
        private System.Windows.Forms.Button btnOpenConnectorList;
        private System.Windows.Forms.DataGridView dgvConnectorTable;
        private System.Windows.Forms.Button btnExpandConnectorList;
        private System.Windows.Forms.TabPage tpExpandedConnectorList;
        private System.Windows.Forms.DataGridView dgvExpandedConnectorList;
    }
}

