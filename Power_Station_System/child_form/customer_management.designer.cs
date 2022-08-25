namespace Power_Station_System.chid_form
{
    partial class customer_management
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.search = new RJCodeAdvance.RJControls.RJTextBox();
            this.ourPanel2 = new OurComponent.OurPanel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rjButton3 = new RJCodeAdvance.RJControls.RJButton();
            this.rjButton1 = new RJCodeAdvance.RJControls.RJButton();
            this.rjButton2 = new RJCodeAdvance.RJControls.RJButton();
            this.datagride_view_customer = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phon_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iden_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inde_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtion_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ele_sub_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.ourPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagride_view_customer)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.panel2.Controls.Add(this.search);
            this.panel2.Controls.Add(this.ourPanel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(924, 66);
            this.panel2.TabIndex = 12;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint);
            // 
            // search
            // 
            this.search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.search.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.search.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.search.BorderRadius = 0;
            this.search.BorderSize = 1;
            this.search.Font = new System.Drawing.Font("LBC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.search.Location = new System.Drawing.Point(618, 15);
            this.search.Margin = new System.Windows.Forms.Padding(5);
            this.search.Multiline = false;
            this.search.Name = "search";
            this.search.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.search.PasswordChar = false;
            this.search.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.search.PlaceholderText = "";
            this.search.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.search.SelectionStart = 0;
            this.search.Size = new System.Drawing.Size(271, 43);
            this.search.TabIndex = 20;
            this.search.Texts = "";
            this.search.UnderlinedStyle = true;
            this.search._TextChanged += new System.EventHandler(this.Search__TextChanged);
            this.search.TabStopChanged += new System.EventHandler(this.Search_TabStopChanged);
            this.search.Validating += new System.ComponentModel.CancelEventHandler(this.Search_Validating);
            this.search.Validated += new System.EventHandler(this.Search_Validated);
            // 
            // ourPanel2
            // 
            this.ourPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ourPanel2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ourPanel2.BorderRaduis = 30;
            this.ourPanel2.Controls.Add(this.iconButton1);
            this.ourPanel2.ForeColor = System.Drawing.Color.Black;
            this.ourPanel2.GardientAngle = 90F;
            this.ourPanel2.GardientBottomClor = System.Drawing.Color.MediumSlateBlue;
            this.ourPanel2.GardientTopClor = System.Drawing.Color.MediumSlateBlue;
            this.ourPanel2.Location = new System.Drawing.Point(556, 12);
            this.ourPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ourPanel2.Name = "ourPanel2";
            this.ourPanel2.Size = new System.Drawing.Size(52, 43);
            this.ourPanel2.TabIndex = 17;
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton1.BackColor = System.Drawing.Color.Transparent;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("LBC", 11.25F);
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 25;
            this.iconButton1.Location = new System.Drawing.Point(0, 4);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(52, 43);
            this.iconButton1.TabIndex = 7;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.IconButton1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.panel1.Controls.Add(this.rjButton3);
            this.panel1.Controls.Add(this.rjButton1);
            this.panel1.Controls.Add(this.rjButton2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Font = new System.Drawing.Font("LBC", 8.25F);
            this.panel1.Location = new System.Drawing.Point(0, 489);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(924, 76);
            this.panel1.TabIndex = 17;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
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
            this.rjButton3.Font = new System.Drawing.Font("LBC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton3.ForeColor = System.Drawing.Color.White;
            this.rjButton3.Location = new System.Drawing.Point(448, 12);
            this.rjButton3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rjButton3.Name = "rjButton3";
            this.rjButton3.Size = new System.Drawing.Size(134, 37);
            this.rjButton3.TabIndex = 14;
            this.rjButton3.Text = "حذف";
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
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("LBC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(751, 12);
            this.rjButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(134, 37);
            this.rjButton1.TabIndex = 16;
            this.rjButton1.Text = "إضافة";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.RjButton1_Click);
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
            this.rjButton2.Font = new System.Drawing.Font("LBC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton2.ForeColor = System.Drawing.Color.White;
            this.rjButton2.Location = new System.Drawing.Point(598, 12);
            this.rjButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(134, 37);
            this.rjButton2.TabIndex = 15;
            this.rjButton2.Text = "تعديل";
            this.rjButton2.TextColor = System.Drawing.Color.White;
            this.rjButton2.UseVisualStyleBackColor = false;
            this.rjButton2.Click += new System.EventHandler(this.RjButton2_Click);
            // 
            // datagride_view_customer
            // 
            this.datagride_view_customer.AllowUserToAddRows = false;
            this.datagride_view_customer.AllowUserToDeleteRows = false;
            this.datagride_view_customer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagride_view_customer.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.datagride_view_customer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagride_view_customer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("LBC", 9.749999F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagride_view_customer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.datagride_view_customer.ColumnHeadersHeight = 45;
            this.datagride_view_customer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.name,
            this.phon_num,
            this.address,
            this.iden_type,
            this.inde_number,
            this.subtion_type,
            this.ele_sub_number,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("LBC", 9.749999F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagride_view_customer.DefaultCellStyle = dataGridViewCellStyle5;
            this.datagride_view_customer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagride_view_customer.EnableHeadersVisualStyles = false;
            this.datagride_view_customer.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.datagride_view_customer.Location = new System.Drawing.Point(0, 0);
            this.datagride_view_customer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.datagride_view_customer.Name = "datagride_view_customer";
            this.datagride_view_customer.ReadOnly = true;
            this.datagride_view_customer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("LBC", 9.749999F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagride_view_customer.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.datagride_view_customer.RowHeadersVisible = false;
            this.datagride_view_customer.RowHeadersWidth = 51;
            this.datagride_view_customer.RowTemplate.Height = 40;
            this.datagride_view_customer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagride_view_customer.Size = new System.Drawing.Size(924, 423);
            this.datagride_view_customer.TabIndex = 18;
            this.datagride_view_customer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Datagride_view_customer_CellContentClick);
            this.datagride_view_customer.Click += new System.EventHandler(this.Datagride_view_customer_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID_Subscriber";
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
            // phon_num
            // 
            this.phon_num.DataPropertyName = "Subscriber_Phone_Number";
            this.phon_num.HeaderText = "رقم الهاتف";
            this.phon_num.MinimumWidth = 6;
            this.phon_num.Name = "phon_num";
            this.phon_num.ReadOnly = true;
            // 
            // address
            // 
            this.address.DataPropertyName = "Subscriber_adress";
            this.address.HeaderText = "العنوان";
            this.address.MinimumWidth = 6;
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // iden_type
            // 
            this.iden_type.DataPropertyName = "Identification_Type";
            this.iden_type.HeaderText = "نوع الهوية";
            this.iden_type.MinimumWidth = 6;
            this.iden_type.Name = "iden_type";
            this.iden_type.ReadOnly = true;
            // 
            // inde_number
            // 
            this.inde_number.DataPropertyName = "Identity_number";
            this.inde_number.HeaderText = "رقم الهوية";
            this.inde_number.MinimumWidth = 6;
            this.inde_number.Name = "inde_number";
            this.inde_number.ReadOnly = true;
            // 
            // subtion_type
            // 
            this.subtion_type.DataPropertyName = "Subscription_Type";
            this.subtion_type.HeaderText = "نوع الاشتراك";
            this.subtion_type.MinimumWidth = 6;
            this.subtion_type.Name = "subtion_type";
            this.subtion_type.ReadOnly = true;
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
            this.Column2.DataPropertyName = "Block_name";
            this.Column2.HeaderText = "المربع";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Date_subsriber";
            this.Column3.HeaderText = "تاريخ الاشتراك";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.datagride_view_customer);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 66);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(924, 423);
            this.panel3.TabIndex = 18;
            this.panel3.BindingContextChanged += new System.EventHandler(this.Panel3_BindingContextChanged);
            // 
            // customer_management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 565);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "customer_management";
            this.Activated += new System.EventHandler(this.Add_customer_1_Activated);
            this.Load += new System.EventHandler(this.Add_customer_1_Load);
            this.panel2.ResumeLayout(false);
            this.ourPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagride_view_customer)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private RJCodeAdvance.RJControls.RJButton rjButton3;
        private RJCodeAdvance.RJControls.RJButton rjButton2;
        private RJCodeAdvance.RJControls.RJButton rjButton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private OurComponent.OurPanel ourPanel2;
        public System.Windows.Forms.DataGridView datagride_view_customer;
        private RJCodeAdvance.RJControls.RJTextBox search;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn phon_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn iden_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn inde_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtion_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn ele_sub_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Panel panel3;
    }
}