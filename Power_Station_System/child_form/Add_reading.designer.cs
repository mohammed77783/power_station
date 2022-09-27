namespace Power_Station_System.chid_form
{
    partial class Add_reading
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.search = new RJCodeAdvance.RJControls.RJTextBox();
            this.rjButton2 = new RJCodeAdvance.RJControls.RJButton();
            this.rjButton3 = new RJCodeAdvance.RJControls.RJButton();
            this.rjButton1 = new RJCodeAdvance.RJControls.RJButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.meter_ = new RJCodeAdvance.RJControls.RJTextBox();
            this.name_sub = new RJCodeAdvance.RJControls.RJTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.privosu_reading = new RJCodeAdvance.RJControls.RJTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.current_reading = new RJCodeAdvance.RJControls.RJTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.datagride_view_customer = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ele_sub_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagride_view_customer)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 237);
            this.panel1.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.rjButton2);
            this.panel3.Controls.Add(this.rjButton3);
            this.panel3.Controls.Add(this.rjButton1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Font = new System.Drawing.Font("LBC", 8.25F);
            this.panel3.Location = new System.Drawing.Point(0, 195);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 42);
            this.panel3.TabIndex = 6;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel3_Paint);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.iconButton1);
            this.panel4.Controls.Add(this.search);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(269, 42);
            this.panel4.TabIndex = 5;
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("LBC", 11.25F);
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(51)))), ((int)(((byte)(108)))));
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 25;
            this.iconButton1.Location = new System.Drawing.Point(233, 3);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(32, 33);
            this.iconButton1.TabIndex = 22;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // search
            // 
            this.search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.search.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.search.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.search.BorderRadius = 0;
            this.search.BorderSize = 1;
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.search.Location = new System.Drawing.Point(13, 4);
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
            // 
            // rjButton2
            // 
            this.rjButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rjButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.rjButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.rjButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton2.BorderRadius = 7;
            this.rjButton2.BorderSize = 0;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.Font = new System.Drawing.Font("LBC", 11.25F);
            this.rjButton2.ForeColor = System.Drawing.Color.White;
            this.rjButton2.Location = new System.Drawing.Point(528, 7);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(115, 30);
            this.rjButton2.TabIndex = 3;
            this.rjButton2.Text = "اضافة";
            this.rjButton2.TextColor = System.Drawing.Color.White;
            this.rjButton2.UseVisualStyleBackColor = false;
            this.rjButton2.Click += new System.EventHandler(this.RjButton2_Click);
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
            this.rjButton3.Font = new System.Drawing.Font("LBC", 11.25F);
            this.rjButton3.ForeColor = System.Drawing.Color.White;
            this.rjButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rjButton3.Location = new System.Drawing.Point(403, 7);
            this.rjButton3.Name = "rjButton3";
            this.rjButton3.Size = new System.Drawing.Size(115, 30);
            this.rjButton3.TabIndex = 4;
            this.rjButton3.Text = "الغاء";
            this.rjButton3.TextColor = System.Drawing.Color.White;
            this.rjButton3.UseVisualStyleBackColor = false;
            this.rjButton3.Click += new System.EventHandler(this.RjButton3_Click);
            // 
            // rjButton1
            // 
            this.rjButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rjButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.rjButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 7;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.Enabled = false;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("LBC", 11.25F);
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(653, 7);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(115, 30);
            this.rjButton1.TabIndex = 2;
            this.rjButton1.Text = "حفظ";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.RjButton1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.meter_);
            this.groupBox1.Controls.Add(this.name_sub);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.privosu_reading);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.current_reading);
            this.groupBox1.Font = new System.Drawing.Font("LBC", 8.25F);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(785, 181);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات القراءة";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("LBC", 9.749999F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(293, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 67;
            this.label6.Text = "رقم العداد :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // meter_
            // 
            this.meter_.BackColor = System.Drawing.Color.White;
            this.meter_.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.meter_.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.meter_.BorderRadius = 0;
            this.meter_.BorderSize = 1;
            this.meter_.Enabled = false;
            this.meter_.Font = new System.Drawing.Font("LBC", 8.25F);
            this.meter_.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.meter_.Location = new System.Drawing.Point(45, 66);
            this.meter_.Margin = new System.Windows.Forms.Padding(4);
            this.meter_.Multiline = false;
            this.meter_.Name = "meter_";
            this.meter_.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.meter_.PasswordChar = false;
            this.meter_.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.meter_.PlaceholderText = "";
            this.meter_.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.meter_.SelectionStart = 0;
            this.meter_.Size = new System.Drawing.Size(229, 31);
            this.meter_.TabIndex = 66;
            this.meter_.Texts = "";
            this.meter_.UnderlinedStyle = true;
            // 
            // name_sub
            // 
            this.name_sub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.name_sub.BackColor = System.Drawing.Color.White;
            this.name_sub.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.name_sub.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.name_sub.BorderRadius = 0;
            this.name_sub.BorderSize = 1;
            this.name_sub.Enabled = false;
            this.name_sub.Font = new System.Drawing.Font("LBC", 8.25F);
            this.name_sub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.name_sub.Location = new System.Drawing.Point(436, 28);
            this.name_sub.Margin = new System.Windows.Forms.Padding(4);
            this.name_sub.Multiline = false;
            this.name_sub.Name = "name_sub";
            this.name_sub.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.name_sub.PasswordChar = false;
            this.name_sub.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.name_sub.PlaceholderText = "";
            this.name_sub.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.name_sub.SelectionStart = 0;
            this.name_sub.Size = new System.Drawing.Size(260, 31);
            this.name_sub.TabIndex = 65;
            this.name_sub.Texts = "";
            this.name_sub.UnderlinedStyle = true;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("LBC", 9.749999F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(715, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 64;
            this.label3.Text = "الأسم :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("LBC", 9.749999F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(281, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 16);
            this.label5.TabIndex = 62;
            this.label5.Text = "القراءة السابقة :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // privosu_reading
            // 
            this.privosu_reading.BackColor = System.Drawing.Color.White;
            this.privosu_reading.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.privosu_reading.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.privosu_reading.BorderRadius = 0;
            this.privosu_reading.BorderSize = 1;
            this.privosu_reading.Enabled = false;
            this.privosu_reading.Font = new System.Drawing.Font("LBC", 8.25F);
            this.privosu_reading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.privosu_reading.Location = new System.Drawing.Point(42, 117);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("LBC", 9.749999F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(286, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 59;
            this.label4.Text = "تاريخ القراءة :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(41, 25);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(233, 24);
            this.dateTimePicker1.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("LBC", 9.749999F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(697, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "القراءة الحالية :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // current_reading
            // 
            this.current_reading.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.current_reading.BackColor = System.Drawing.Color.White;
            this.current_reading.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.current_reading.BorderFocusColor = System.Drawing.Color.White;
            this.current_reading.BorderRadius = 0;
            this.current_reading.BorderSize = 1;
            this.current_reading.Font = new System.Drawing.Font("LBC", 8.25F);
            this.current_reading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.current_reading.Location = new System.Drawing.Point(436, 126);
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
            this.current_reading.TabIndex = 21;
            this.current_reading.Texts = "";
            this.current_reading.UnderlinedStyle = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.datagride_view_customer);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 237);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 213);
            this.panel2.TabIndex = 4;
            // 
            // datagride_view_customer
            // 
            this.datagride_view_customer.AllowUserToAddRows = false;
            this.datagride_view_customer.AllowUserToDeleteRows = false;
            this.datagride_view_customer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagride_view_customer.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.datagride_view_customer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagride_view_customer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("LBC", 9.749999F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagride_view_customer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.datagride_view_customer.ColumnHeadersHeight = 40;
            this.datagride_view_customer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.name,
            this.address,
            this.ele_sub_number,
            this.Column2});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagride_view_customer.DefaultCellStyle = dataGridViewCellStyle4;
            this.datagride_view_customer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagride_view_customer.EnableHeadersVisualStyles = false;
            this.datagride_view_customer.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagride_view_customer.Location = new System.Drawing.Point(0, 0);
            this.datagride_view_customer.Name = "datagride_view_customer";
            this.datagride_view_customer.ReadOnly = true;
            this.datagride_view_customer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.datagride_view_customer.RowHeadersVisible = false;
            this.datagride_view_customer.RowHeadersWidth = 51;
            this.datagride_view_customer.RowTemplate.Height = 40;
            this.datagride_view_customer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagride_view_customer.Size = new System.Drawing.Size(800, 213);
            this.datagride_view_customer.TabIndex = 20;
            this.datagride_view_customer.Click += new System.EventHandler(this.Datagride_view_customer_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // name
            // 
            this.name.DataPropertyName = "Subscriber_name";
            this.name.HeaderText = "اسم المشترك";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // address
            // 
            this.address.DataPropertyName = "Subscriber_adress";
            this.address.HeaderText = "العنوان";
            this.address.MinimumWidth = 6;
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // ele_sub_number
            // 
            this.ele_sub_number.DataPropertyName = "Subscriber_ElectricMeter_ID";
            this.ele_sub_number.HeaderText = "رقم العداد";
            this.ele_sub_number.MinimumWidth = 6;
            this.ele_sub_number.Name = "ele_sub_number";
            this.ele_sub_number.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Status";
            this.Column2.HeaderText = "حالة القراءة";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Add_reading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Add_reading";
            this.Text = "Add_reading";
            this.Load += new System.EventHandler(this.Add_reading_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagride_view_customer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton iconButton1;
        private RJCodeAdvance.RJControls.RJTextBox search;
        private RJCodeAdvance.RJControls.RJButton rjButton2;
        private RJCodeAdvance.RJControls.RJButton rjButton3;
        private RJCodeAdvance.RJControls.RJButton rjButton1;
        public System.Windows.Forms.DataGridView datagride_view_customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn ele_sub_number;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private RJCodeAdvance.RJControls.RJTextBox meter_;
        private RJCodeAdvance.RJControls.RJTextBox name_sub;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private RJCodeAdvance.RJControls.RJTextBox privosu_reading;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private RJCodeAdvance.RJControls.RJTextBox current_reading;
    }
}