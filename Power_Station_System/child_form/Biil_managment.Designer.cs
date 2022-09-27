namespace Power_Station_System.child_form
{
    partial class Biil_managment
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rjButton1 = new RJCodeAdvance.RJControls.RJButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rjButton3 = new RJCodeAdvance.RJControls.RJButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID_reading = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gr_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gr_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gr_meter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gr_current = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gr_privio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gr_manthe_fes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gr_alistihlak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kw_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gr_mony = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gr_almtikhrat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gr_hol_mony = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gr_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.blok = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.I_D = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.search = new RJCodeAdvance.RJControls.RJTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.to_time = new System.Windows.Forms.DateTimePicker();
            this.from_taime = new System.Windows.Forms.DateTimePicker();
            this.rjButton2 = new RJCodeAdvance.RJControls.RJButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("LBC", 9.749999F);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1019, 172);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.panel2.Controls.Add(this.rjButton2);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.rjButton1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Font = new System.Drawing.Font("LBC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 129);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1019, 43);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.iconButton1);
            this.panel3.Controls.Add(this.search);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(269, 43);
            this.panel3.TabIndex = 5;
            // 
            // rjButton1
            // 
            this.rjButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rjButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.rjButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 0;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(882, 8);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(119, 29);
            this.rjButton1.TabIndex = 2;
            this.rjButton1.Text = "حفظ";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.RjButton1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.groupBox1.Controls.Add(this.to_time);
            this.groupBox1.Controls.Add(this.from_taime);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.rjButton3);
            this.groupBox1.Font = new System.Drawing.Font("LBC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(5, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(1004, 120);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "عرض البيانات حسب";
            // 
            // rjButton3
            // 
            this.rjButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rjButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.rjButton3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.rjButton3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton3.BorderRadius = 0;
            this.rjButton3.BorderSize = 0;
            this.rjButton3.FlatAppearance.BorderSize = 0;
            this.rjButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton3.ForeColor = System.Drawing.Color.Transparent;
            this.rjButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rjButton3.Location = new System.Drawing.Point(803, 23);
            this.rjButton3.Name = "rjButton3";
            this.rjButton3.Size = new System.Drawing.Size(189, 35);
            this.rjButton3.TabIndex = 4;
            this.rjButton3.Text = "أصدار فواتير لقراءات النزول الميداني";
            this.rjButton3.TextColor = System.Drawing.Color.Transparent;
            this.rjButton3.UseVisualStyleBackColor = false;
            this.rjButton3.Click += new System.EventHandler(this.RjButton3_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 172);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1019, 290);
            this.panel4.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("LBC", 9.749999F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 40;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_reading,
            this.gr_name,
            this.gr_address,
            this.gr_meter,
            this.gr_current,
            this.gr_privio,
            this.gr_manthe_fes,
            this.gr_alistihlak,
            this.Kw_price,
            this.gr_mony,
            this.gr_almtikhrat,
            this.gr_hol_mony,
            this.gr_date,
            this.blok,
            this.I_D});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("LBC", 9.749999F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 80;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1019, 290);
            this.dataGridView1.TabIndex = 23;
            // 
            // ID_reading
            // 
            this.ID_reading.DataPropertyName = "ID";
            this.ID_reading.HeaderText = "id_reading";
            this.ID_reading.Name = "ID_reading";
            this.ID_reading.ReadOnly = true;
            this.ID_reading.Visible = false;
            // 
            // gr_name
            // 
            this.gr_name.DataPropertyName = "Subscriber_name";
            this.gr_name.HeaderText = "الاسم";
            this.gr_name.MinimumWidth = 6;
            this.gr_name.Name = "gr_name";
            this.gr_name.ReadOnly = true;
            // 
            // gr_address
            // 
            this.gr_address.DataPropertyName = "Subscriber_adress";
            this.gr_address.HeaderText = "العنوان";
            this.gr_address.Name = "gr_address";
            this.gr_address.ReadOnly = true;
            // 
            // gr_meter
            // 
            this.gr_meter.DataPropertyName = "Subscriber_ElectricMeter_ID";
            this.gr_meter.HeaderText = "رقم العداد";
            this.gr_meter.Name = "gr_meter";
            this.gr_meter.ReadOnly = true;
            // 
            // gr_current
            // 
            this.gr_current.DataPropertyName = "Current_Reading";
            this.gr_current.HeaderText = "القراءة الحالية";
            this.gr_current.MinimumWidth = 6;
            this.gr_current.Name = "gr_current";
            this.gr_current.ReadOnly = true;
            // 
            // gr_privio
            // 
            this.gr_privio.DataPropertyName = "Previous_Reading";
            this.gr_privio.HeaderText = "القراءة السابقة";
            this.gr_privio.MinimumWidth = 6;
            this.gr_privio.Name = "gr_privio";
            this.gr_privio.ReadOnly = true;
            // 
            // gr_manthe_fes
            // 
            this.gr_manthe_fes.DataPropertyName = "Month_fee";
            this.gr_manthe_fes.HeaderText = "قيمة الاشتراك";
            this.gr_manthe_fes.MinimumWidth = 6;
            this.gr_manthe_fes.Name = "gr_manthe_fes";
            this.gr_manthe_fes.ReadOnly = true;
            // 
            // gr_alistihlak
            // 
            this.gr_alistihlak.HeaderText = "الاستهلاك";
            this.gr_alistihlak.Name = "gr_alistihlak";
            this.gr_alistihlak.ReadOnly = true;
            // 
            // Kw_price
            // 
            this.Kw_price.DataPropertyName = "KW_price";
            this.Kw_price.HeaderText = "سعر الكيلو";
            this.Kw_price.Name = "Kw_price";
            this.Kw_price.ReadOnly = true;
            // 
            // gr_mony
            // 
            this.gr_mony.HeaderText = "المبلغ";
            this.gr_mony.Name = "gr_mony";
            this.gr_mony.ReadOnly = true;
            // 
            // gr_almtikhrat
            // 
            this.gr_almtikhrat.HeaderText = "المتاخرات";
            this.gr_almtikhrat.Name = "gr_almtikhrat";
            this.gr_almtikhrat.ReadOnly = true;
            // 
            // gr_hol_mony
            // 
            this.gr_hol_mony.HeaderText = "المبلغ الاجمالي";
            this.gr_hol_mony.MinimumWidth = 6;
            this.gr_hol_mony.Name = "gr_hol_mony";
            this.gr_hol_mony.ReadOnly = true;
            // 
            // gr_date
            // 
            this.gr_date.DataPropertyName = "Data_time";
            this.gr_date.HeaderText = "التأريخ";
            this.gr_date.Name = "gr_date";
            this.gr_date.ReadOnly = true;
            // 
            // blok
            // 
            this.blok.DataPropertyName = "ID_Block";
            this.blok.HeaderText = "المربع";
            this.blok.Name = "blok";
            this.blok.ReadOnly = true;
            this.blok.Visible = false;
            // 
            // I_D
            // 
            this.I_D.DataPropertyName = "ID_Subscriber";
            this.I_D.HeaderText = "id";
            this.I_D.Name = "I_D";
            this.I_D.ReadOnly = true;
            this.I_D.Visible = false;
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
            this.iconButton1.Location = new System.Drawing.Point(226, 6);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(32, 31);
            this.iconButton1.TabIndex = 24;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // search
            // 
            this.search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search.BackColor = System.Drawing.Color.White;
            this.search.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.search.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.search.BorderRadius = 0;
            this.search.BorderSize = 1;
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.search.Location = new System.Drawing.Point(10, 5);
            this.search.Margin = new System.Windows.Forms.Padding(4);
            this.search.Multiline = false;
            this.search.Name = "search";
            this.search.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.search.PasswordChar = false;
            this.search.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.search.PlaceholderText = "ابحث هنا..";
            this.search.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.search.SelectionStart = 0;
            this.search.Size = new System.Drawing.Size(214, 33);
            this.search.TabIndex = 23;
            this.search.Texts = "";
            this.search.UnderlinedStyle = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("LBC", 11.25F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(227, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 20);
            this.label7.TabIndex = 74;
            this.label7.Text = "الـــى";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("LBC", 11.25F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(224, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 20);
            this.label8.TabIndex = 73;
            this.label8.Text = "مـــــن";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // to_time
            // 
            this.to_time.CalendarMonthBackground = System.Drawing.SystemColors.GradientActiveCaption;
            this.to_time.CustomFormat = "yyyy-MM-dd";
            this.to_time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.to_time.Location = new System.Drawing.Point(35, 73);
            this.to_time.Name = "to_time";
            this.to_time.Size = new System.Drawing.Size(177, 23);
            this.to_time.TabIndex = 83;
            // 
            // from_taime
            // 
            this.from_taime.CalendarMonthBackground = System.Drawing.SystemColors.GradientActiveCaption;
            this.from_taime.CustomFormat = "yyyy-MM-dd";
            this.from_taime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.from_taime.Location = new System.Drawing.Point(35, 39);
            this.from_taime.Name = "from_taime";
            this.from_taime.Size = new System.Drawing.Size(177, 23);
            this.from_taime.TabIndex = 82;
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
            this.rjButton2.ForeColor = System.Drawing.Color.Transparent;
            this.rjButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rjButton2.Location = new System.Drawing.Point(693, 6);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(169, 32);
            this.rjButton2.TabIndex = 6;
            this.rjButton2.Text = "طباعة الفواتير";
            this.rjButton2.TextColor = System.Drawing.Color.Transparent;
            this.rjButton2.UseVisualStyleBackColor = false;
            // 
            // Biil_managment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 462);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Biil_managment";
            this.Text = "Biil_managment";
            this.Load += new System.EventHandler(this.Biil_managment_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private RJCodeAdvance.RJControls.RJButton rjButton3;
        private RJCodeAdvance.RJControls.RJButton rjButton1;
        private System.Windows.Forms.GroupBox groupBox1;

        private RJCodeAdvance.RJControls.RJButton rjButton4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_reading;
        private System.Windows.Forms.DataGridViewTextBoxColumn gr_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn gr_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn gr_meter;
        private System.Windows.Forms.DataGridViewTextBoxColumn gr_current;
        private System.Windows.Forms.DataGridViewTextBoxColumn gr_privio;
        private System.Windows.Forms.DataGridViewTextBoxColumn gr_manthe_fes;
        private System.Windows.Forms.DataGridViewTextBoxColumn gr_alistihlak;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kw_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn gr_mony;
        private System.Windows.Forms.DataGridViewTextBoxColumn gr_almtikhrat;
        private System.Windows.Forms.DataGridViewTextBoxColumn gr_hol_mony;
        private System.Windows.Forms.DataGridViewTextBoxColumn gr_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn blok;
        private System.Windows.Forms.DataGridViewTextBoxColumn I_D;
        private FontAwesome.Sharp.IconButton iconButton1;
        private RJCodeAdvance.RJControls.RJTextBox search;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private RJCodeAdvance.RJControls.RJButton rjButton2;
        private System.Windows.Forms.DateTimePicker to_time;
        private System.Windows.Forms.DateTimePicker from_taime;
    }
}