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

            this.panel2 = new System.Windows.Forms.Panel();
            this.rjButton2 = new RJCodeAdvance.RJControls.RJButton();
            this.rjButton1 = new RJCodeAdvance.RJControls.RJButton();
            this.ourPanel1 = new OurComponent.OurPanel();

            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mony_write = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.month_many = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.privio_mony = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Block_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kw_price_KW = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kw_used = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Month_fee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.privous_reading = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.current_Reading = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sub_reading_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subscriber_adress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subscription_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_due = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meter_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bill_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkedBOX = new System.Windows.Forms.DataGridViewCheckBoxColumn();

            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.ourPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.dataGridView1);

            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 66);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1246, 545);

            this.panel1.TabIndex = 20;
            // 
            // checkBox1
            // 

            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(1202, 11);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(18, 17);

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
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);

            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);

            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;

            this.dataGridView1.RowTemplate.Height = 80;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1068, 365);
            this.dataGridView1.TabIndex = 23;
            // 
            // checkedBOX
            // 
            this.checkedBOX.HeaderText = "";
            this.checkedBOX.Name = "checkedBOX";
            // 
            // bill_id
            // 
            this.bill_id.DataPropertyName = "Bill_ID";
            this.bill_id.HeaderText = "رقم الفاتورة";
            this.bill_id.Name = "bill_id";
            this.bill_id.ReadOnly = true;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "اسم العميل";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // meter_number
            // 
            this.meter_number.DataPropertyName = "meter_number";
            this.meter_number.HeaderText = "رقم العداد";
            this.meter_number.Name = "meter_number";
            this.meter_number.ReadOnly = true;
            // 
            // total_due
            // 
            this.total_due.DataPropertyName = "total_due";
            this.total_due.HeaderText = "المبلغ الاجمالي";
            this.total_due.Name = "total_due";
            this.total_due.ReadOnly = true;
            // 
            // Subscription_Type
            // 
            this.Subscription_Type.DataPropertyName = "Subscription_Type";
            this.Subscription_Type.HeaderText = "الاشتراك";
            this.Subscription_Type.Name = "Subscription_Type";
            this.Subscription_Type.ReadOnly = true;
            // 
            // Data_time
            // 
            this.Data_time.DataPropertyName = "Data_time";
            this.Data_time.HeaderText = "التاريخ";
            this.Data_time.Name = "Data_time";
            this.Data_time.ReadOnly = true;
            // 
            // Subscriber_adress
            // 
            this.Subscriber_adress.DataPropertyName = "Subscriber_adress";
            this.Subscriber_adress.HeaderText = "العنوان";
            this.Subscriber_adress.Name = "Subscriber_adress";
            // 
            // sub_reading_ID
            // 
            this.sub_reading_ID.DataPropertyName = "sub_reading_ID";
            this.sub_reading_ID.HeaderText = "رقم القرءة";
            this.sub_reading_ID.Name = "sub_reading_ID";
            this.sub_reading_ID.ReadOnly = true;
            this.sub_reading_ID.Visible = false;
            // 
            // current_Reading
            // 
            this.current_Reading.DataPropertyName = "current_Reading";
            this.current_Reading.HeaderText = "القراءة الحالية ";
            this.current_Reading.Name = "current_Reading";
            this.current_Reading.ReadOnly = true;
            // 
            // privous_reading
            // 
            this.privous_reading.DataPropertyName = "privous_reading";
            this.privous_reading.HeaderText = "القراءة السابقة";
            this.privous_reading.Name = "privous_reading";
            this.privous_reading.ReadOnly = true;
            // 
            // Month_fee
            // 
            this.Month_fee.DataPropertyName = "Month_fee";
            this.Month_fee.HeaderText = "رسوم الاشتراك";
            this.Month_fee.Name = "Month_fee";
            // 
            // Kw_used
            // 
            this.Kw_used.DataPropertyName = "Kw_used";
            this.Kw_used.HeaderText = "الاستهلاك";
            this.Kw_used.Name = "Kw_used";
            this.Kw_used.ReadOnly = true;
            // 
            // kw_price_KW
            // 
            this.kw_price_KW.DataPropertyName = "kw_price_KW";
            this.kw_price_KW.HeaderText = "سعر الكيلو";
            this.kw_price_KW.Name = "kw_price_KW";
            this.kw_price_KW.ReadOnly = true;
            // 
            // Block_name
            // 
            this.Block_name.DataPropertyName = "Block_name";
            this.Block_name.HeaderText = "المربع";
            this.Block_name.Name = "Block_name";
            this.Block_name.ReadOnly = true;
            // 
            // privio_mony
            // 
            this.privio_mony.DataPropertyName = "privio_mony";
            this.privio_mony.HeaderText = "المتبقي";
            this.privio_mony.Name = "privio_mony";
            this.privio_mony.ReadOnly = true;
            // 
            // month_many
            // 
            this.month_many.DataPropertyName = "month_many";
            this.month_many.HeaderText = "الرسوم الشهرية";
            this.month_many.Name = "month_many";
            this.month_many.ReadOnly = true;
            // 
            // mony_write
            // 
            this.mony_write.DataPropertyName = "mony_write";
            this.mony_write.HeaderText = "المبلغ كتابة";
            this.mony_write.Name = "mony_write";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.rjButton2);
            this.panel2.Controls.Add(this.rjButton1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 464);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1068, 98);
            this.panel2.TabIndex = 21;
            // 
            // rjButton2
            // 
            this.rjButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rjButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.rjButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.rjButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton2.BorderRadius = 0;
            this.rjButton2.BorderSize = 0;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.ForeColor = System.Drawing.Color.White;
            this.rjButton2.Location = new System.Drawing.Point(229, 12);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(86, 59);

            this.rjButton2.TabIndex = 4;
            this.rjButton2.Text = "خروج";
            this.rjButton2.TextColor = System.Drawing.Color.White;
            this.rjButton2.UseVisualStyleBackColor = false;
            this.rjButton2.Click += new System.EventHandler(this.RjButton2_Click);
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
            this.rjButton1.Location = new System.Drawing.Point(591, 25);
            this.rjButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(76, 33);

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

            this.ourPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ourPanel1.Name = "ourPanel1";
            this.ourPanel1.Size = new System.Drawing.Size(1246, 66);

            this.ourPanel1.TabIndex = 19;
            this.ourPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OurPanel1_MouseDown);
            this.ourPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OurPanel1_MouseMove);
            this.ourPanel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OurPanel1_MouseUp);
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(203)))), ((int)(((byte)(226)))));
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(83, 19);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(32, 21);
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
            this.button6.Location = new System.Drawing.Point(20, 19);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(32, 21);
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
            this.button3.Location = new System.Drawing.Point(47, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(32, 21);
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

            this.label1.Location = new System.Drawing.Point(566, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "طباعة الفواتير";
            // 
            // mony_write
            // 
            this.mony_write.DataPropertyName = "mony_write";
            this.mony_write.HeaderText = "المبلغ كتابة";
            this.mony_write.MinimumWidth = 6;
            this.mony_write.Name = "mony_write";
            // 
            // month_many
            // 
            this.month_many.DataPropertyName = "month_many";
            this.month_many.HeaderText = "الرسوم الشهرية";
            this.month_many.MinimumWidth = 6;
            this.month_many.Name = "month_many";
            this.month_many.ReadOnly = true;
            // 
            // privio_mony
            // 
            this.privio_mony.DataPropertyName = "privio_mony";
            this.privio_mony.HeaderText = "المتبقي";
            this.privio_mony.MinimumWidth = 6;
            this.privio_mony.Name = "privio_mony";
            this.privio_mony.ReadOnly = true;
            // 
            // Block_name
            // 
            this.Block_name.DataPropertyName = "Block_name";
            this.Block_name.HeaderText = "المربع";
            this.Block_name.MinimumWidth = 6;
            this.Block_name.Name = "Block_name";
            this.Block_name.ReadOnly = true;
            // 
            // kw_price_KW
            // 
            this.kw_price_KW.DataPropertyName = "kw_price_KW";
            this.kw_price_KW.HeaderText = "سعر الكيلو";
            this.kw_price_KW.MinimumWidth = 6;
            this.kw_price_KW.Name = "kw_price_KW";
            this.kw_price_KW.ReadOnly = true;
            // 
            // Kw_used
            // 
            this.Kw_used.DataPropertyName = "Kw_used";
            this.Kw_used.HeaderText = "الاستهلاك";
            this.Kw_used.MinimumWidth = 6;
            this.Kw_used.Name = "Kw_used";
            this.Kw_used.ReadOnly = true;
            // 
            // Month_fee
            // 
            this.Month_fee.DataPropertyName = "Month_fee";
            this.Month_fee.HeaderText = "رسوم الاشتراك";
            this.Month_fee.MinimumWidth = 6;
            this.Month_fee.Name = "Month_fee";
            // 
            // privous_reading
            // 
            this.privous_reading.DataPropertyName = "privous_reading";
            this.privous_reading.HeaderText = "القراءة السابقة";
            this.privous_reading.MinimumWidth = 6;
            this.privous_reading.Name = "privous_reading";
            this.privous_reading.ReadOnly = true;
            // 
            // current_Reading
            // 
            this.current_Reading.DataPropertyName = "current_Reading";
            this.current_Reading.HeaderText = "القراءة الحالية ";
            this.current_Reading.MinimumWidth = 6;
            this.current_Reading.Name = "current_Reading";
            this.current_Reading.ReadOnly = true;
            // 
            // sub_reading_ID
            // 
            this.sub_reading_ID.DataPropertyName = "sub_reading_ID";
            this.sub_reading_ID.HeaderText = "رقم القرءة";
            this.sub_reading_ID.MinimumWidth = 6;
            this.sub_reading_ID.Name = "sub_reading_ID";
            this.sub_reading_ID.ReadOnly = true;
            this.sub_reading_ID.Visible = false;
            // 
            // Subscriber_adress
            // 
            this.Subscriber_adress.DataPropertyName = "Subscriber_adress";
            this.Subscriber_adress.HeaderText = "العنوان";
            this.Subscriber_adress.MinimumWidth = 6;
            this.Subscriber_adress.Name = "Subscriber_adress";
            // 
            // Data_time
            // 
            this.Data_time.DataPropertyName = "Data_time";
            this.Data_time.HeaderText = "التاريخ";
            this.Data_time.MinimumWidth = 6;
            this.Data_time.Name = "Data_time";
            this.Data_time.ReadOnly = true;
            // 
            // Subscription_Type
            // 
            this.Subscription_Type.DataPropertyName = "Subscription_Type";
            this.Subscription_Type.HeaderText = "الاشتراك";
            this.Subscription_Type.MinimumWidth = 6;
            this.Subscription_Type.Name = "Subscription_Type";
            this.Subscription_Type.ReadOnly = true;
            // 
            // total_due
            // 
            this.total_due.DataPropertyName = "total_due";
            this.total_due.HeaderText = "المبلغ الاجمالي";
            this.total_due.MinimumWidth = 6;
            this.total_due.Name = "total_due";
            this.total_due.ReadOnly = true;
            // 
            // meter_number
            // 
            this.meter_number.DataPropertyName = "meter_number";
            this.meter_number.HeaderText = "رقم العداد";
            this.meter_number.MinimumWidth = 6;
            this.meter_number.Name = "meter_number";
            this.meter_number.ReadOnly = true;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "اسم العميل";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // bill_id
            // 
            this.bill_id.DataPropertyName = "Bill_ID";
            this.bill_id.HeaderText = "رقم الفاتورة";
            this.bill_id.MinimumWidth = 6;
            this.bill_id.Name = "bill_id";
            this.bill_id.ReadOnly = true;
            // 
            // checkedBOX
            // 
            this.checkedBOX.HeaderText = "";
            this.checkedBOX.MinimumWidth = 6;
            this.checkedBOX.Name = "checkedBOX";
            // 
            // pringBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 692);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ourPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);

            this.Name = "pringBill";
            this.Text = "pringBill";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ourPanel1.ResumeLayout(false);
            this.ourPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private OurComponent.OurPanel ourPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.DataGridView dataGridView1;
        private RJCodeAdvance.RJControls.RJButton rjButton2;
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
    }
}