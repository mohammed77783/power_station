﻿namespace Power_Station_System.child_form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.rjButton2 = new RJCodeAdvance.RJControls.RJButton();
            this.rjButton1 = new RJCodeAdvance.RJControls.RJButton();
            this.ourPanel1 = new OurComponent.OurPanel();
            this.label1 = new System.Windows.Forms.Label();
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
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1068, 365);
            this.panel1.TabIndex = 20;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(1025, 13);
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
            dataGridViewCellStyle7.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("LBC", 9.749999F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.ColumnHeadersHeight = 40;
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
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("LBC", 9.749999F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
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
            this.rjButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rjButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.rjButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 0;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(824, 27);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(129, 59);
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
            this.ourPanel1.Controls.Add(this.label1);
            this.ourPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ourPanel1.ForeColor = System.Drawing.Color.Black;
            this.ourPanel1.GardientAngle = 90F;
            this.ourPanel1.GardientBottomClor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.ourPanel1.GardientTopClor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.ourPanel1.Location = new System.Drawing.Point(0, 0);
            this.ourPanel1.Name = "ourPanel1";
            this.ourPanel1.Size = new System.Drawing.Size(1068, 93);
            this.ourPanel1.TabIndex = 19;
            this.ourPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OurPanel1_MouseDown);
            this.ourPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OurPanel1_MouseMove);
            this.ourPanel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OurPanel1_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("LBC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(485, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "طباعة الفواتير";
            // 
            // pringBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 562);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ourPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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