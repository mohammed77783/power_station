namespace Power_Station_System.child_form
{
    partial class pringBill
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pringBill));
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.checkedBOX = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bill_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meter_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_due = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subscription_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subscriber_adress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sub_reading_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.current_Reading = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.privous_reading = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Month_fee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kw_used = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kw_price_KW = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Block_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.privio_mony = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.month_many = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mony_write = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rjButton1 = new RJCodeAdvance.RJControls.RJButton();
            this.ourPanel1 = new OurComponent.OurPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.to_time = new System.Windows.Forms.DateTimePicker();
            this.from_taime = new System.Windows.Forms.DateTimePicker();
            this.rjButton3 = new RJCodeAdvance.RJControls.RJButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rjButton4 = new RJCodeAdvance.RJControls.RJButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.ourPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 131);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1068, 351);
            this.panel1.TabIndex = 20;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(1030, 16);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 24;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("LBC", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkedBOX,
            this.bill_id,
            this.name,
            this.meter_number,
            this.total_due,
            this.Subscription_Type,
            this.Data_time,
            this.Subscriber_adress,
            this.sub_reading_ID,
            this.current_Reading,
            this.privous_reading,
            this.Month_fee,
            this.Kw_used,
            this.kw_price_KW,
            this.Block_name,
            this.privio_mony,
            this.month_many,
            this.mony_write});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("LBC", 9.749999F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(0, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 80;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1068, 422);
            this.dataGridView1.TabIndex = 23;
            // 
            // checkedBOX
            // 
            this.checkedBOX.HeaderText = "";
            this.checkedBOX.MinimumWidth = 6;
            this.checkedBOX.Name = "checkedBOX";
            // 
            // bill_id
            // 
            this.bill_id.DataPropertyName = "Bill_ID";
            this.bill_id.HeaderText = "رقم الفاتورة";
            this.bill_id.MinimumWidth = 6;
            this.bill_id.Name = "bill_id";
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "اسم العميل";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            // 
            // meter_number
            // 
            this.meter_number.DataPropertyName = "meter_number";
            this.meter_number.HeaderText = "رقم العداد";
            this.meter_number.MinimumWidth = 6;
            this.meter_number.Name = "meter_number";
            // 
            // total_due
            // 
            this.total_due.DataPropertyName = "total_due";
            this.total_due.HeaderText = "المبلغ الاجمالي";
            this.total_due.MinimumWidth = 6;
            this.total_due.Name = "total_due";
            // 
            // Subscription_Type
            // 
            this.Subscription_Type.DataPropertyName = "Subscription_Type";
            this.Subscription_Type.HeaderText = "الاشتراك";
            this.Subscription_Type.MinimumWidth = 6;
            this.Subscription_Type.Name = "Subscription_Type";
            // 
            // Data_time
            // 
            this.Data_time.DataPropertyName = "Data_time";
            this.Data_time.HeaderText = "التاريخ";
            this.Data_time.MinimumWidth = 6;
            this.Data_time.Name = "Data_time";
            // 
            // Subscriber_adress
            // 
            this.Subscriber_adress.DataPropertyName = "Subscriber_adress";
            this.Subscriber_adress.HeaderText = "العنوان";
            this.Subscriber_adress.MinimumWidth = 6;
            this.Subscriber_adress.Name = "Subscriber_adress";
            // 
            // sub_reading_ID
            // 
            this.sub_reading_ID.DataPropertyName = "sub_reading_ID";
            this.sub_reading_ID.HeaderText = "رقم القرءة";
            this.sub_reading_ID.MinimumWidth = 6;
            this.sub_reading_ID.Name = "sub_reading_ID";
            this.sub_reading_ID.Visible = false;
            // 
            // current_Reading
            // 
            this.current_Reading.DataPropertyName = "current_Reading";
            this.current_Reading.HeaderText = "القراءة الحالية ";
            this.current_Reading.MinimumWidth = 6;
            this.current_Reading.Name = "current_Reading";
            // 
            // privous_reading
            // 
            this.privous_reading.DataPropertyName = "privous_reading";
            this.privous_reading.HeaderText = "القراءة السابقة";
            this.privous_reading.MinimumWidth = 6;
            this.privous_reading.Name = "privous_reading";
            // 
            // Month_fee
            // 
            this.Month_fee.DataPropertyName = "Month_fee";
            this.Month_fee.HeaderText = "رسوم الاشتراك";
            this.Month_fee.MinimumWidth = 6;
            this.Month_fee.Name = "Month_fee";
            // 
            // Kw_used
            // 
            this.Kw_used.DataPropertyName = "Kw_used";
            this.Kw_used.HeaderText = "الاستهلاك";
            this.Kw_used.MinimumWidth = 6;
            this.Kw_used.Name = "Kw_used";
            // 
            // kw_price_KW
            // 
            this.kw_price_KW.DataPropertyName = "kw_price_KW";
            this.kw_price_KW.HeaderText = "سعر الكيلو";
            this.kw_price_KW.MinimumWidth = 6;
            this.kw_price_KW.Name = "kw_price_KW";
            // 
            // Block_name
            // 
            this.Block_name.DataPropertyName = "Block_name";
            this.Block_name.HeaderText = "المربع";
            this.Block_name.MinimumWidth = 6;
            this.Block_name.Name = "Block_name";
            // 
            // privio_mony
            // 
            this.privio_mony.DataPropertyName = "privio_mony";
            this.privio_mony.HeaderText = "المتبقي";
            this.privio_mony.MinimumWidth = 6;
            this.privio_mony.Name = "privio_mony";
            // 
            // month_many
            // 
            this.month_many.DataPropertyName = "month_many";
            this.month_many.HeaderText = "الرسوم الشهرية";
            this.month_many.MinimumWidth = 6;
            this.month_many.Name = "month_many";
            // 
            // mony_write
            // 
            this.mony_write.DataPropertyName = "mony_write";
            this.mony_write.HeaderText = "المبلغ كتابة";
            this.mony_write.MinimumWidth = 6;
            this.mony_write.Name = "mony_write";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.rjButton4);
            this.panel2.Controls.Add(this.rjButton1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 482);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1068, 80);
            this.panel2.TabIndex = 21;
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
            this.rjButton1.Font = new System.Drawing.Font("LBC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(597, 21);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(92, 37);
            this.rjButton1.TabIndex = 3;
            this.rjButton1.Text = "طباعة";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.RjButton1_Click);
            // 
            // ourPanel1
            // 
            this.ourPanel1.BackColor = System.Drawing.Color.Transparent;
            this.ourPanel1.BorderRaduis = 5;
            this.ourPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ourPanel1.Controls.Add(this.groupBox1);
            this.ourPanel1.Controls.Add(this.button7);
            this.ourPanel1.Controls.Add(this.button6);
            this.ourPanel1.Controls.Add(this.button3);
            this.ourPanel1.Controls.Add(this.label1);
            this.ourPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ourPanel1.ForeColor = System.Drawing.Color.Black;
            this.ourPanel1.GardientAngle = 90F;
            this.ourPanel1.GardientBottomClor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.ourPanel1.GardientTopClor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.ourPanel1.Location = new System.Drawing.Point(0, 0);
            this.ourPanel1.Name = "ourPanel1";
            this.ourPanel1.Size = new System.Drawing.Size(1068, 131);
            this.ourPanel1.TabIndex = 19;
            this.ourPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OurPanel1_MouseDown);
            this.ourPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OurPanel1_MouseMove);
            this.ourPanel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OurPanel1_MouseUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.to_time);
            this.groupBox1.Controls.Add(this.from_taime);
            this.groupBox1.Controls.Add(this.rjButton3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(4, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(1058, 80);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "تحديد تاريخ الفاتورة";
            // 
            // to_time
            // 
            this.to_time.CalendarMonthBackground = System.Drawing.SystemColors.GradientActiveCaption;
            this.to_time.CustomFormat = "yyyy-MM-dd";
            this.to_time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.to_time.Location = new System.Drawing.Point(59, 19);
            this.to_time.Name = "to_time";
            this.to_time.Size = new System.Drawing.Size(177, 20);
            this.to_time.TabIndex = 81;
            // 
            // from_taime
            // 
            this.from_taime.CalendarMonthBackground = System.Drawing.SystemColors.GradientActiveCaption;
            this.from_taime.CustomFormat = "yyyy-MM-dd";
            this.from_taime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.from_taime.Location = new System.Drawing.Point(325, 17);
            this.from_taime.Name = "from_taime";
            this.from_taime.Size = new System.Drawing.Size(177, 20);
            this.from_taime.TabIndex = 80;
            // 
            // rjButton3
            // 
            this.rjButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rjButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.rjButton3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.rjButton3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton3.BorderRadius = 7;
            this.rjButton3.BorderSize = 0;
            this.rjButton3.FlatAppearance.BorderSize = 0;
            this.rjButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton3.Font = new System.Drawing.Font("LBC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rjButton3.ForeColor = System.Drawing.Color.White;
            this.rjButton3.Location = new System.Drawing.Point(925, 19);
            this.rjButton3.Name = "rjButton3";
            this.rjButton3.Size = new System.Drawing.Size(114, 45);
            this.rjButton3.TabIndex = 79;
            this.rjButton3.Text = "عرض";
            this.rjButton3.TextColor = System.Drawing.Color.White;
            this.rjButton3.UseVisualStyleBackColor = false;
            this.rjButton3.Click += new System.EventHandler(this.RjButton3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("LBC", 11.25F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(243, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 20);
            this.label7.TabIndex = 78;
            this.label7.Text = "الـــى : ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("LBC", 11.25F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(508, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 20);
            this.label8.TabIndex = 77;
            this.label8.Text = "مـــــن :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(203)))), ((int)(((byte)(226)))));
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(71, 15);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(27, 17);
            this.button7.TabIndex = 27;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(203)))), ((int)(((byte)(226)))));
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(17, 15);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(27, 17);
            this.button6.TabIndex = 26;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(203)))), ((int)(((byte)(226)))));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(40, 15);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(27, 17);
            this.button3.TabIndex = 25;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("LBC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(485, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "طباعة الفواتير";
            // 
            // rjButton4
            // 
            this.rjButton4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rjButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.rjButton4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.rjButton4.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton4.BorderRadius = 7;
            this.rjButton4.BorderSize = 0;
            this.rjButton4.FlatAppearance.BorderSize = 0;
            this.rjButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton4.Font = new System.Drawing.Font("LBC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rjButton4.ForeColor = System.Drawing.Color.White;
            this.rjButton4.Location = new System.Drawing.Point(364, 21);
            this.rjButton4.Name = "rjButton4";
            this.rjButton4.Size = new System.Drawing.Size(92, 37);
            this.rjButton4.TabIndex = 5;
            this.rjButton4.Text = "خروج";
            this.rjButton4.TextColor = System.Drawing.Color.White;
            this.rjButton4.UseVisualStyleBackColor = false;
            // 
            // pringBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 562);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ourPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "pringBill";
            this.Text = "pringBill";
            this.Load += new System.EventHandler(this.PringBill_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ourPanel1.ResumeLayout(false);
            this.ourPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private OurComponent.OurPanel ourPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.DataGridView dataGridView1;
        private RJCodeAdvance.RJControls.RJButton rjButton1;
        private System.Windows.Forms.CheckBox checkBox1;

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;

        private System.Windows.Forms.DataGridViewCheckBoxColumn checkedBOX;
        private System.Windows.Forms.DataGridViewTextBoxColumn bill_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn meter_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_due;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subscription_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subscriber_adress;
        private System.Windows.Forms.DataGridViewTextBoxColumn sub_reading_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn current_Reading;
        private System.Windows.Forms.DataGridViewTextBoxColumn privous_reading;
        private System.Windows.Forms.DataGridViewTextBoxColumn Month_fee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kw_used;
        private System.Windows.Forms.DataGridViewTextBoxColumn kw_price_KW;
        private System.Windows.Forms.DataGridViewTextBoxColumn Block_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn privio_mony;
        private System.Windows.Forms.DataGridViewTextBoxColumn month_many;
        private System.Windows.Forms.DataGridViewTextBoxColumn mony_write;
        private System.Windows.Forms.GroupBox groupBox1;
        private RJCodeAdvance.RJControls.RJButton rjButton3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker to_time;
        private System.Windows.Forms.DateTimePicker from_taime;
        private RJCodeAdvance.RJControls.RJButton rjButton4;
    }
}