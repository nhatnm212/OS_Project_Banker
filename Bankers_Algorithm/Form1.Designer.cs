
namespace Bankers_Algorithm
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.text_nprocess = new System.Windows.Forms.TextBox();
            this.text_nresource = new System.Windows.Forms.TextBox();
            this.button_check = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.text_allocation = new System.Windows.Forms.TextBox();
            this.rich_allocation = new System.Windows.Forms.RichTextBox();
            this.button_allocation = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.text_max = new System.Windows.Forms.TextBox();
            this.rich_max = new System.Windows.Forms.RichTextBox();
            this.button_max = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.text_available = new System.Windows.Forms.TextBox();
            this.rich_output = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button_safe = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.rich_need = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.text_Prequest = new System.Windows.Forms.TextBox();
            this.text_Rrequest = new System.Windows.Forms.TextBox();
            this.radioButton_safe = new System.Windows.Forms.RadioButton();
            this.radioButton_request = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UTM Guanine", 17.8F);
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(160, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(872, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chương Trình Mô Phỏng Hoạt Động Thuật Toán Banker";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("UTM Helve", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(111, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số Lượng Tiến Trình";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("UTM Helve", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(411, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số Lượng Tài Nguyên";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // text_nprocess
            // 
            this.text_nprocess.BackColor = System.Drawing.Color.White;
            this.text_nprocess.Font = new System.Drawing.Font("UTM Helve", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_nprocess.Location = new System.Drawing.Point(324, 45);
            this.text_nprocess.Name = "text_nprocess";
            this.text_nprocess.Size = new System.Drawing.Size(47, 36);
            this.text_nprocess.TabIndex = 1;
            this.text_nprocess.TextChanged += new System.EventHandler(this.text_nprocess_TextChanged);
            // 
            // text_nresource
            // 
            this.text_nresource.BackColor = System.Drawing.Color.White;
            this.text_nresource.Font = new System.Drawing.Font("UTM Helve", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_nresource.Location = new System.Drawing.Point(634, 45);
            this.text_nresource.Name = "text_nresource";
            this.text_nresource.Size = new System.Drawing.Size(46, 36);
            this.text_nresource.TabIndex = 2;
            // 
            // button_check
            // 
            this.button_check.BackColor = System.Drawing.Color.DarkCyan;
            this.button_check.Font = new System.Drawing.Font("UTM Helve", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_check.ForeColor = System.Drawing.Color.White;
            this.button_check.Location = new System.Drawing.Point(760, 38);
            this.button_check.Name = "button_check";
            this.button_check.Size = new System.Drawing.Size(208, 48);
            this.button_check.TabIndex = 3;
            this.button_check.Text = "Xác nhận";
            this.button_check.UseVisualStyleBackColor = false;
            this.button_check.Click += new System.EventHandler(this.button_check_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("UTM Helve", 10.2F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(199, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Allocation";
            // 
            // text_allocation
            // 
            this.text_allocation.Enabled = false;
            this.text_allocation.Font = new System.Drawing.Font("UTM Helve", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_allocation.Location = new System.Drawing.Point(52, 105);
            this.text_allocation.Name = "text_allocation";
            this.text_allocation.Size = new System.Drawing.Size(110, 36);
            this.text_allocation.TabIndex = 6;
            // 
            // rich_allocation
            // 
            this.rich_allocation.Enabled = false;
            this.rich_allocation.Font = new System.Drawing.Font("UTM Helve", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rich_allocation.Location = new System.Drawing.Point(197, 73);
            this.rich_allocation.Name = "rich_allocation";
            this.rich_allocation.ReadOnly = true;
            this.rich_allocation.Size = new System.Drawing.Size(201, 142);
            this.rich_allocation.TabIndex = 8;
            this.rich_allocation.Text = "";
            this.rich_allocation.TextChanged += new System.EventHandler(this.rich_allocation_TextChanged);
            // 
            // button_allocation
            // 
            this.button_allocation.BackColor = System.Drawing.Color.DarkCyan;
            this.button_allocation.Enabled = false;
            this.button_allocation.Font = new System.Drawing.Font("UTM Helve", 9.2F, System.Drawing.FontStyle.Bold);
            this.button_allocation.ForeColor = System.Drawing.Color.White;
            this.button_allocation.Location = new System.Drawing.Point(56, 153);
            this.button_allocation.Name = "button_allocation";
            this.button_allocation.Size = new System.Drawing.Size(106, 38);
            this.button_allocation.TabIndex = 7;
            this.button_allocation.Text = "Truyền";
            this.button_allocation.UseVisualStyleBackColor = false;
            this.button_allocation.Click += new System.EventHandler(this.button_allocation_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("UTM Helve", 10.2F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(561, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Max";
            // 
            // text_max
            // 
            this.text_max.Enabled = false;
            this.text_max.Location = new System.Drawing.Point(436, 105);
            this.text_max.Name = "text_max";
            this.text_max.Size = new System.Drawing.Size(106, 39);
            this.text_max.TabIndex = 8;
            // 
            // rich_max
            // 
            this.rich_max.Enabled = false;
            this.rich_max.Font = new System.Drawing.Font("UTM Helve", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rich_max.Location = new System.Drawing.Point(565, 73);
            this.rich_max.Name = "rich_max";
            this.rich_max.ReadOnly = true;
            this.rich_max.Size = new System.Drawing.Size(201, 142);
            this.rich_max.TabIndex = 12;
            this.rich_max.Text = "";
            // 
            // button_max
            // 
            this.button_max.BackColor = System.Drawing.Color.DarkCyan;
            this.button_max.Enabled = false;
            this.button_max.Font = new System.Drawing.Font("UTM Helve", 9.2F, System.Drawing.FontStyle.Bold);
            this.button_max.ForeColor = System.Drawing.Color.White;
            this.button_max.Location = new System.Drawing.Point(436, 153);
            this.button_max.Name = "button_max";
            this.button_max.Size = new System.Drawing.Size(106, 38);
            this.button_max.TabIndex = 9;
            this.button_max.Text = "Truyền";
            this.button_max.UseVisualStyleBackColor = false;
            this.button_max.Click += new System.EventHandler(this.button_max_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("UTM Helve", 10.2F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(806, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "Available";
            // 
            // text_available
            // 
            this.text_available.Enabled = false;
            this.text_available.Font = new System.Drawing.Font("UTM Helve", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_available.Location = new System.Drawing.Point(810, 73);
            this.text_available.Name = "text_available";
            this.text_available.Size = new System.Drawing.Size(140, 36);
            this.text_available.TabIndex = 10;
            this.text_available.TextChanged += new System.EventHandler(this.text_available_TextChanged);
            // 
            // rich_output
            // 
            this.rich_output.Font = new System.Drawing.Font("UTM Helve", 10F, System.Drawing.FontStyle.Bold);
            this.rich_output.Location = new System.Drawing.Point(728, 107);
            this.rich_output.Name = "rich_output";
            this.rich_output.ReadOnly = true;
            this.rich_output.Size = new System.Drawing.Size(240, 223);
            this.rich_output.TabIndex = 16;
            this.rich_output.Text = "";
            this.rich_output.TextChanged += new System.EventHandler(this.rich_output_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("UTM Helve", 13.2F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(723, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 31);
            this.label7.TabIndex = 17;
            this.label7.Text = "Kết Quả";
            // 
            // button_safe
            // 
            this.button_safe.BackColor = System.Drawing.Color.Crimson;
            this.button_safe.Font = new System.Drawing.Font("UTM Helve", 10.2F, System.Drawing.FontStyle.Bold);
            this.button_safe.ForeColor = System.Drawing.Color.White;
            this.button_safe.Location = new System.Drawing.Point(35, 279);
            this.button_safe.Name = "button_safe";
            this.button_safe.Size = new System.Drawing.Size(123, 41);
            this.button_safe.TabIndex = 12;
            this.button_safe.Text = "Kiểm tra";
            this.button_safe.UseVisualStyleBackColor = false;
            this.button_safe.Click += new System.EventHandler(this.button_safe_Click);
            // 
            // button_clear
            // 
            this.button_clear.BackColor = System.Drawing.Color.Crimson;
            this.button_clear.Font = new System.Drawing.Font("UTM Helve", 10.2F, System.Drawing.FontStyle.Bold);
            this.button_clear.ForeColor = System.Drawing.Color.White;
            this.button_clear.Location = new System.Drawing.Point(169, 279);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(124, 41);
            this.button_clear.TabIndex = 16;
            this.button_clear.Text = "Xoá hết";
            this.button_clear.UseVisualStyleBackColor = false;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("UTM Helve", 13.2F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(453, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 31);
            this.label10.TabIndex = 27;
            this.label10.Text = "Need";
            // 
            // rich_need
            // 
            this.rich_need.Font = new System.Drawing.Font("UTM Helve", 10F, System.Drawing.FontStyle.Bold);
            this.rich_need.Location = new System.Drawing.Point(459, 107);
            this.rich_need.Name = "rich_need";
            this.rich_need.ReadOnly = true;
            this.rich_need.Size = new System.Drawing.Size(256, 223);
            this.rich_need.TabIndex = 28;
            this.rich_need.Text = "";
            this.rich_need.TextChanged += new System.EventHandler(this.rich_need_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("UTM Helve", 10.2F, System.Drawing.FontStyle.Italic);
            this.label8.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label8.Location = new System.Drawing.Point(169, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 23);
            this.label8.TabIndex = 21;
            this.label8.Text = "Tiến Trình";
            this.label8.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("UTM Helve", 10.2F, System.Drawing.FontStyle.Italic);
            this.label9.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label9.Location = new System.Drawing.Point(169, 202);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 23);
            this.label9.TabIndex = 22;
            this.label9.Text = "Tài Nguyên";
            this.label9.Visible = false;
            // 
            // text_Prequest
            // 
            this.text_Prequest.Font = new System.Drawing.Font("UTM Helve", 12F, System.Drawing.FontStyle.Bold);
            this.text_Prequest.Location = new System.Drawing.Point(286, 144);
            this.text_Prequest.Name = "text_Prequest";
            this.text_Prequest.Size = new System.Drawing.Size(139, 36);
            this.text_Prequest.TabIndex = 14;
            this.text_Prequest.Visible = false;
            // 
            // text_Rrequest
            // 
            this.text_Rrequest.Font = new System.Drawing.Font("UTM Helve", 12F, System.Drawing.FontStyle.Bold);
            this.text_Rrequest.Location = new System.Drawing.Point(286, 191);
            this.text_Rrequest.Name = "text_Rrequest";
            this.text_Rrequest.Size = new System.Drawing.Size(139, 36);
            this.text_Rrequest.TabIndex = 15;
            this.text_Rrequest.Visible = false;
            // 
            // radioButton_safe
            // 
            this.radioButton_safe.AutoSize = true;
            this.radioButton_safe.Checked = true;
            this.radioButton_safe.Enabled = false;
            this.radioButton_safe.Font = new System.Drawing.Font("UTM Helve", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_safe.Location = new System.Drawing.Point(148, 61);
            this.radioButton_safe.Name = "radioButton_safe";
            this.radioButton_safe.Size = new System.Drawing.Size(185, 27);
            this.radioButton_safe.TabIndex = 11;
            this.radioButton_safe.TabStop = true;
            this.radioButton_safe.Text = "Tiến Trình An Toàn";
            this.radioButton_safe.UseVisualStyleBackColor = true;
            this.radioButton_safe.CheckedChanged += new System.EventHandler(this.radioButton_safe_CheckedChanged);
            // 
            // radioButton_request
            // 
            this.radioButton_request.AutoSize = true;
            this.radioButton_request.Enabled = false;
            this.radioButton_request.Font = new System.Drawing.Font("UTM Helve", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_request.Location = new System.Drawing.Point(148, 109);
            this.radioButton_request.Name = "radioButton_request";
            this.radioButton_request.Size = new System.Drawing.Size(101, 27);
            this.radioButton_request.TabIndex = 13;
            this.radioButton_request.Text = "Yêu Cầu";
            this.radioButton_request.UseVisualStyleBackColor = true;
            this.radioButton_request.CheckedChanged += new System.EventHandler(this.radioButton_request_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.button_check);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.text_nprocess);
            this.groupBox1.Controls.Add(this.text_nresource);
            this.groupBox1.Font = new System.Drawing.Font("UTM Khuccamta", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkCyan;
            this.groupBox1.Location = new System.Drawing.Point(82, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(992, 104);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "NHẬP SỐ LƯỢNG";
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.rich_allocation);
            this.groupBox2.Controls.Add(this.button_allocation);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.text_allocation);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.rich_max);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.text_max);
            this.groupBox2.Controls.Add(this.button_max);
            this.groupBox2.Controls.Add(this.text_available);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("UTM Khuccamta", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.DarkCyan;
            this.groupBox2.Location = new System.Drawing.Point(82, 246);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(992, 238);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "NHẬP YÊU CẦU";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("UTM Helve", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(443, 73);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 23);
            this.label12.TabIndex = 2;
            this.label12.Text = "Tài nguyên";
            this.label12.Click += new System.EventHandler(this.label3_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("UTM Helve", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(59, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 23);
            this.label11.TabIndex = 2;
            this.label11.Text = "Tài nguyên";
            this.label11.Click += new System.EventHandler(this.label3_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.button_clear);
            this.groupBox3.Controls.Add(this.text_Rrequest);
            this.groupBox3.Controls.Add(this.button_safe);
            this.groupBox3.Controls.Add(this.radioButton_request);
            this.groupBox3.Controls.Add(this.text_Prequest);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.radioButton_safe);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.rich_need);
            this.groupBox3.Controls.Add(this.rich_output);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Font = new System.Drawing.Font("UTM Khuccamta", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Crimson;
            this.groupBox3.Location = new System.Drawing.Point(82, 499);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(992, 358);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "KẾT QUẢ";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(299, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 41);
            this.button1.TabIndex = 17;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("UTM Khuccamta", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(35, 62);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 24);
            this.label13.TabIndex = 21;
            this.label13.Text = "Lựa chọn: ";
            this.label13.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Bankers_Algorithm.Properties.Resources.Img;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(63, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 80);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1127, 899);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Bankers Algorithm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_nprocess;
        private System.Windows.Forms.TextBox text_nresource;
        private System.Windows.Forms.Button button_check;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text_allocation;
        private System.Windows.Forms.RichTextBox rich_allocation;
        private System.Windows.Forms.Button button_allocation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox text_max;
        private System.Windows.Forms.RichTextBox rich_max;
        private System.Windows.Forms.Button button_max;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox text_available;
        private System.Windows.Forms.RichTextBox rich_output;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_safe;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox rich_need;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox text_Prequest;
        private System.Windows.Forms.TextBox text_Rrequest;
        private System.Windows.Forms.RadioButton radioButton_safe;
        private System.Windows.Forms.RadioButton radioButton_request;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

