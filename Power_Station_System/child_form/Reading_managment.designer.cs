namespace Power_Station_System.chid_form
{
    partial class Reading_managment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reading_managment));
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.datagride_view_customer = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Subscriber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ele_sub_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.to_time = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.from_taime = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.rjButton6 = new RJCodeAdvance.RJControls.RJButton();
            this.rjButton2 = new RJCodeAdvance.RJControls.RJButton();
            this.rjButton3 = new RJCodeAdvance.RJControls.RJButton();
            this.rjButton1 = new RJCodeAdvance.RJControls.RJButton();
            this.search = new RJCodeAdvance.RJControls.RJTextBox();
            this.meter_id = new RJCodeAdvance.RJControls.RJTextBox();
            this.current_reading = new RJCodeAdvance.RJControls.RJTextBox();
            this.privosu_reading = new RJCodeAdvance.RJControls.RJTextBox();
            this.custo_name = new RJCodeAdvance.RJControls.RJTextBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagride_view_customer)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            this.Column1.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.from_taime);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.to_time);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.meter_id);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.current_reading);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.privosu_reading);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.custo_name);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("LBC", 9.749999F);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(800, 185);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات القراءة";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("LBC", 9.749999F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(723, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 69;
            this.label4.Text = "رقم العداد :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 71);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 67;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("LBC", 9.749999F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(723, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 64;
            this.label3.Text = "الأسم :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("LBC", 9.749999F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(282, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 62;
            this.label2.Text = "القراءة السابقة :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Font = new System.Drawing.Font("LBC", 9.749999F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(33, 25);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePicker1.Size = new System.Drawing.Size(233, 24);
            this.dateTimePicker1.TabIndex = 60;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("LBC", 9.749999F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(290, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 16);
            this.label9.TabIndex = 59;
            this.label9.Text = "تاريخ القراءة :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label9.Click += new System.EventHandler(this.Label9_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("LBC", 9.749999F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(708, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "القراءة الحالية :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 239);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rjButton6);
            this.panel2.Controls.Add(this.rjButton2);
            this.panel2.Controls.Add(this.rjButton3);
            this.panel2.Controls.Add(this.rjButton1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Font = new System.Drawing.Font("LBC", 9.749999F);
            this.panel2.Location = new System.Drawing.Point(0, 191);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 48);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.iconButton1);
            this.panel3.Controls.Add(this.search);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(269, 48);
            this.panel3.TabIndex = 22;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("LBC", 11.25F);
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(51)))), ((int)(((byte)(108)))));
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 25;
            this.iconButton1.Location = new System.Drawing.Point(224, 6);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(32, 32);
            this.iconButton1.TabIndex = 22;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // datagride_view_customer
            // 
            this.datagride_view_customer.AllowUserToAddRows = false;
            this.datagride_view_customer.AllowUserToDeleteRows = false;
            this.datagride_view_customer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagride_view_customer.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.datagride_view_customer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagride_view_customer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("LBC", 9.749999F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagride_view_customer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datagride_view_customer.ColumnHeadersHeight = 40;
            this.datagride_view_customer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.ID_Subscriber,
            this.name,
            this.address,
            this.ele_sub_number,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("LBC", 9.749999F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagride_view_customer.DefaultCellStyle = dataGridViewCellStyle2;
            this.datagride_view_customer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagride_view_customer.EnableHeadersVisualStyles = false;
            this.datagride_view_customer.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.datagride_view_customer.Location = new System.Drawing.Point(0, 0);
            this.datagride_view_customer.Name = "datagride_view_customer";
            this.datagride_view_customer.ReadOnly = true;
            this.datagride_view_customer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.datagride_view_customer.RowHeadersVisible = false;
            this.datagride_view_customer.RowHeadersWidth = 51;
            this.datagride_view_customer.RowTemplate.Height = 80;
            this.datagride_view_customer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagride_view_customer.Size = new System.Drawing.Size(800, 211);
            this.datagride_view_customer.TabIndex = 19;
            this.datagride_view_customer.Click += new System.EventHandler(this.Datagride_view_customer_Click);
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ID";
            this.Column2.HeaderText = "ID";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // ID_Subscriber
            // 
            this.ID_Subscriber.DataPropertyName = "Subscriber_name";
            this.ID_Subscriber.HeaderText = "اسم المشترك";
            this.ID_Subscriber.MinimumWidth = 6;
            this.ID_Subscriber.Name = "ID_Subscriber";
            this.ID_Subscriber.ReadOnly = true;
            // 
            // name
            // 
            this.name.DataPropertyName = "Current_Reading";
            this.name.HeaderText = "القراءه الحالية";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // address
            // 
            this.address.DataPropertyName = "Previous_Reading";
            this.address.HeaderText = "القراءه السابقة";
            this.address.MinimumWidth = 6;
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // ele_sub_number
            // 
            this.ele_sub_number.DataPropertyName = "Data_time";
            this.ele_sub_number.HeaderText = "التاريخ والوقت";
            this.ele_sub_number.MinimumWidth = 6;
            this.ele_sub_number.Name = "ele_sub_number";
            this.ele_sub_number.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Subscriber_ElectricMeter_ID";
            this.Column3.HeaderText = "رقم العداد";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Block_name";
            this.Column4.HeaderText = "المربع";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "invoice_state_relace";
            this.Column5.HeaderText = "حاله اصدار الفاتورة";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.datagride_view_customer);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Font = new System.Drawing.Font("LBC", 9.749999F);
            this.panel4.Location = new System.Drawing.Point(0, 239);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(800, 211);
            this.panel4.TabIndex = 4;
            // 
            // to_time
            // 
            this.to_time.CalendarMonthBackground = System.Drawing.SystemColors.GradientActiveCaption;
            this.to_time.CustomFormat = "yyyy-MM-dd";
            this.to_time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.to_time.Location = new System.Drawing.Point(35, 149);
            this.to_time.Name = "to_time";
            this.to_time.Size = new System.Drawing.Size(232, 24);
            this.to_time.TabIndex = 85;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("LBC", 11.25F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(278, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 20);
            this.label7.TabIndex = 83;
            this.label7.Text = "الـــى : ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // from_taime
            // 
            this.from_taime.CalendarMonthBackground = System.Drawing.SystemColors.GradientActiveCaption;
            this.from_taime.CustomFormat = "yyyy-MM-dd";
            this.from_taime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.from_taime.Location = new System.Drawing.Point(35, 113);
            this.from_taime.Name = "from_taime";
            this.from_taime.Size = new System.Drawing.Size(232, 24);
            this.from_taime.TabIndex = 87;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("LBC", 11.25F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(278, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 20);
            this.label8.TabIndex = 86;
            this.label8.Text = "مـــــن :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // rjButton6
            // 
            this.rjButton6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rjButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.rjButton6.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.rjButton6.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton6.BorderRadius = 7;
            this.rjButton6.BorderSize = 0;
            this.rjButton6.FlatAppearance.BorderSize = 0;
            this.rjButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton6.Font = new System.Drawing.Font("LBC", 11.25F);
            this.rjButton6.ForeColor = System.Drawing.Color.White;
            this.rjButton6.Image = ((System.Drawing.Image)(resources.GetObject("rjButton6.Image")));
            this.rjButton6.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.rjButton6.Location = new System.Drawing.Point(313, 6);
            this.rjButton6.Name = "rjButton6";
            this.rjButton6.Size = new System.Drawing.Size(87, 34);
            this.rjButton6.TabIndex = 27;
            this.rjButton6.Text = "عرض";
            this.rjButton6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rjButton6.TextColor = System.Drawing.Color.White;
            this.rjButton6.UseVisualStyleBackColor = false;
            this.rjButton6.Click += new System.EventHandler(this.RjButton6_Click);
            // 
            // rjButton2
            // 
            this.rjButton2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rjButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.rjButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.rjButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton2.BorderRadius = 7;
            this.rjButton2.BorderSize = 0;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.Font = new System.Drawing.Font("LBC", 11.25F);
            this.rjButton2.ForeColor = System.Drawing.Color.White;
            this.rjButton2.Location = new System.Drawing.Point(528, 8);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(115, 30);
            this.rjButton2.TabIndex = 24;
            this.rjButton2.Text = "تعديل";
            this.rjButton2.TextColor = System.Drawing.Color.White;
            this.rjButton2.UseVisualStyleBackColor = false;
            this.rjButton2.Click += new System.EventHandler(this.RjButton2_Click);
            // 
            // rjButton3
            // 
            this.rjButton3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rjButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.rjButton3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.rjButton3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton3.BorderRadius = 7;
            this.rjButton3.BorderSize = 0;
            this.rjButton3.FlatAppearance.BorderSize = 0;
            this.rjButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton3.Font = new System.Drawing.Font("LBC", 11.25F);
            this.rjButton3.ForeColor = System.Drawing.Color.White;
            this.rjButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rjButton3.Location = new System.Drawing.Point(408, 8);
            this.rjButton3.Name = "rjButton3";
            this.rjButton3.Size = new System.Drawing.Size(115, 30);
            this.rjButton3.TabIndex = 25;
            this.rjButton3.Text = "حذف";
            this.rjButton3.TextColor = System.Drawing.Color.White;
            this.rjButton3.UseVisualStyleBackColor = false;
            this.rjButton3.Click += new System.EventHandler(this.RjButton3_Click);
            // 
            // rjButton1
            // 
            this.rjButton1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rjButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.rjButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 7;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("LBC", 11.25F);
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(648, 8);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(115, 30);
            this.rjButton1.TabIndex = 23;
            this.rjButton1.Text = "اضافة";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.RjButton1_Click_1);
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.White;
            this.search.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.search.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.search.BorderRadius = 0;
            this.search.BorderSize = 1;
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.search.Location = new System.Drawing.Point(5, 6);
            this.search.Margin = new System.Windows.Forms.Padding(4);
            this.search.Multiline = false;
            this.search.Name = "search";
            this.search.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.search.PasswordChar = false;
            this.search.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.search.PlaceholderText = "ابحث هنا..";
            this.search.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.search.SelectionStart = 0;
            this.search.Size = new System.Drawing.Size(215, 33);
            this.search.TabIndex = 21;
            this.search.Texts = "";
            this.search.UnderlinedStyle = true;
            this.search._TextChanged += new System.EventHandler(this.Search__TextChanged_1);
            // 
            // meter_id
            // 
            this.meter_id.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.meter_id.BackColor = System.Drawing.Color.White;
            this.meter_id.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.meter_id.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.meter_id.BorderRadius = 0;
            this.meter_id.BorderSize = 1;
            this.meter_id.Enabled = false;
            this.meter_id.Font = new System.Drawing.Font("LBC", 8F);
            this.meter_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.meter_id.Location = new System.Drawing.Point(437, 81);
            this.meter_id.Margin = new System.Windows.Forms.Padding(4);
            this.meter_id.Multiline = false;
            this.meter_id.Name = "meter_id";
            this.meter_id.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.meter_id.PasswordChar = false;
            this.meter_id.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.meter_id.PlaceholderText = "";
            this.meter_id.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.meter_id.SelectionStart = 0;
            this.meter_id.Size = new System.Drawing.Size(260, 31);
            this.meter_id.TabIndex = 68;
            this.meter_id.Texts = "";
            this.meter_id.UnderlinedStyle = true;
            // 
            // current_reading
            // 
            this.current_reading.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.current_reading.BackColor = System.Drawing.Color.White;
            this.current_reading.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.current_reading.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.current_reading.BorderRadius = 0;
            this.current_reading.BorderSize = 1;
            this.current_reading.Font = new System.Drawing.Font("LBC", 8F);
            this.current_reading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.current_reading.Location = new System.Drawing.Point(437, 136);
            this.current_reading.Margin = new System.Windows.Forms.Padding(4);
            this.current_reading.Multiline = false;
            this.current_reading.Name = "current_reading";
            this.current_reading.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.current_reading.PasswordChar = false;
            this.current_reading.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.current_reading.PlaceholderText = "";
            this.current_reading.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.current_reading.SelectionStart = 0;
            this.current_reading.Size = new System.Drawing.Size(260, 31);
            this.current_reading.TabIndex = 66;
            this.current_reading.Texts = "";
            this.current_reading.UnderlinedStyle = true;
            // 
            // privosu_reading
            // 
            this.privosu_reading.BackColor = System.Drawing.Color.White;
            this.privosu_reading.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.privosu_reading.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.privosu_reading.BorderRadius = 0;
            this.privosu_reading.BorderSize = 1;
            this.privosu_reading.Enabled = false;
            this.privosu_reading.Font = new System.Drawing.Font("LBC", 8F);
            this.privosu_reading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.privosu_reading.Location = new System.Drawing.Point(33, 63);
            this.privosu_reading.Margin = new System.Windows.Forms.Padding(4);
            this.privosu_reading.Multiline = false;
            this.privosu_reading.Name = "privosu_reading";
            this.privosu_reading.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.privosu_reading.PasswordChar = false;
            this.privosu_reading.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.privosu_reading.PlaceholderText = "";
            this.privosu_reading.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.privosu_reading.SelectionStart = 0;
            this.privosu_reading.Size = new System.Drawing.Size(232, 31);
            this.privosu_reading.TabIndex = 61;
            this.privosu_reading.Texts = "";
            this.privosu_reading.UnderlinedStyle = true;
            // 
            // custo_name
            // 
            this.custo_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.custo_name.BackColor = System.Drawing.Color.White;
            this.custo_name.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.custo_name.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.custo_name.BorderRadius = 0;
            this.custo_name.BorderSize = 1;
            this.custo_name.Font = new System.Drawing.Font("LBC", 8F);
            this.custo_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.custo_name.Location = new System.Drawing.Point(437, 33);
            this.custo_name.Margin = new System.Windows.Forms.Padding(4);
            this.custo_name.Multiline = false;
            this.custo_name.Name = "custo_name";
            this.custo_name.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.custo_name.PasswordChar = false;
            this.custo_name.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.custo_name.PlaceholderText = "";
            this.custo_name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.custo_name.SelectionStart = 0;
            this.custo_name.Size = new System.Drawing.Size(260, 31);
            this.custo_name.TabIndex = 21;
            this.custo_name.Texts = "";
            this.custo_name.UnderlinedStyle = true;
            this.custo_name._TextChanged += new System.EventHandler(this.Search__TextChanged);
            // 
            // Reading_managment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reading_managment";
            this.Text = "Reading_managment";
            this.Load += new System.EventHandler(this.Reading_managment_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagride_view_customer)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private RJCodeAdvance.RJControls.RJTextBox privosu_reading;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private RJCodeAdvance.RJControls.RJTextBox custo_name;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DataGridView datagride_view_customer;
        private System.Windows.Forms.Panel panel2;
        private RJCodeAdvance.RJControls.RJButton rjButton2;
        private RJCodeAdvance.RJControls.RJButton rjButton3;
        private RJCodeAdvance.RJControls.RJButton rjButton1;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton iconButton1;
        private RJCodeAdvance.RJControls.RJTextBox search;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private RJCodeAdvance.RJControls.RJTextBox meter_id;
        private System.Windows.Forms.CheckBox checkBox1;
        private RJCodeAdvance.RJControls.RJTextBox current_reading;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Subscriber;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn ele_sub_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column5;
        private RJCodeAdvance.RJControls.RJButton rjButton6;
        private System.Windows.Forms.DateTimePicker from_taime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker to_time;
        private System.Windows.Forms.Label label7;
    }
}