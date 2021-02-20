
namespace WinFormUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbControlCar = new System.Windows.Forms.TabControl();
            this.tbPageAllCars = new System.Windows.Forms.TabPage();
            this.btnClrFilter = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgwAllCars = new System.Windows.Forms.DataGridView();
            this.tbPageAddCar = new System.Windows.Forms.TabPage();
            this.txtDailyPriceAdd = new System.Windows.Forms.MaskedTextBox();
            this.txtModelYearAdd = new System.Windows.Forms.MaskedTextBox();
            this.btnAddCar = new System.Windows.Forms.Button();
            this.txtCarDetailsAdd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxBrandAdd = new System.Windows.Forms.ComboBox();
            this.cbxColorAdd = new System.Windows.Forms.ComboBox();
            this.tbPageUpdateCar = new System.Windows.Forms.TabPage();
            this.txtDailyPriceUpdate = new System.Windows.Forms.MaskedTextBox();
            this.txtModelYearUpdate = new System.Windows.Forms.MaskedTextBox();
            this.btnUpdateCar = new System.Windows.Forms.Button();
            this.txtCarDetailsUpdate = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbxBrandUpdate = new System.Windows.Forms.ComboBox();
            this.cbxColorUpdate = new System.Windows.Forms.ComboBox();
            this.tbControlCar.SuspendLayout();
            this.tbPageAllCars.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAllCars)).BeginInit();
            this.tbPageAddCar.SuspendLayout();
            this.tbPageUpdateCar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbControlCar
            // 
            this.tbControlCar.AccessibleDescription = "";
            this.tbControlCar.Controls.Add(this.tbPageAllCars);
            this.tbControlCar.Controls.Add(this.tbPageAddCar);
            this.tbControlCar.Controls.Add(this.tbPageUpdateCar);
            this.tbControlCar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbControlCar.Location = new System.Drawing.Point(12, 12);
            this.tbControlCar.Name = "tbControlCar";
            this.tbControlCar.SelectedIndex = 0;
            this.tbControlCar.Size = new System.Drawing.Size(776, 426);
            this.tbControlCar.TabIndex = 0;
            // 
            // tbPageAllCars
            // 
            this.tbPageAllCars.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbPageAllCars.Controls.Add(this.btnClrFilter);
            this.tbPageAllCars.Controls.Add(this.comboBox2);
            this.tbPageAllCars.Controls.Add(this.comboBox1);
            this.tbPageAllCars.Controls.Add(this.label2);
            this.tbPageAllCars.Controls.Add(this.label1);
            this.tbPageAllCars.Controls.Add(this.dgwAllCars);
            this.tbPageAllCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbPageAllCars.Location = new System.Drawing.Point(4, 28);
            this.tbPageAllCars.Name = "tbPageAllCars";
            this.tbPageAllCars.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageAllCars.Size = new System.Drawing.Size(768, 394);
            this.tbPageAllCars.TabIndex = 0;
            this.tbPageAllCars.Text = "All Cars";
            // 
            // btnClrFilter
            // 
            this.btnClrFilter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClrFilter.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClrFilter.Location = new System.Drawing.Point(270, 26);
            this.btnClrFilter.Name = "btnClrFilter";
            this.btnClrFilter.Size = new System.Drawing.Size(127, 32);
            this.btnClrFilter.TabIndex = 18;
            this.btnClrFilter.Text = "Clear Filter";
            this.btnClrFilter.UseVisualStyleBackColor = false;
            this.btnClrFilter.Click += new System.EventHandler(this.btnClrFilter_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(133, 34);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.SelectionChangeCommitted += new System.EventHandler(this.comboBox2_SelectionChangeCommitted);
            // 
            // comboBox1
            // 
            this.comboBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.comboBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label2.Font = new System.Drawing.Font("Sarabun SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(132, 8);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(109, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Filter (Brand)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Font = new System.Drawing.Font("Sarabun SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filter (Color)";
            // 
            // dgwAllCars
            // 
            this.dgwAllCars.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwAllCars.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgwAllCars.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgwAllCars.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwAllCars.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwAllCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwAllCars.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwAllCars.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgwAllCars.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgwAllCars.Location = new System.Drawing.Point(3, 64);
            this.dgwAllCars.MultiSelect = false;
            this.dgwAllCars.Name = "dgwAllCars";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwAllCars.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgwAllCars.Size = new System.Drawing.Size(762, 333);
            this.dgwAllCars.TabIndex = 0;
            this.dgwAllCars.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwAllCars_CellClick);
            this.dgwAllCars.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwAllCars_CellContentClick);
            // 
            // tbPageAddCar
            // 
            this.tbPageAddCar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbPageAddCar.Controls.Add(this.txtDailyPriceAdd);
            this.tbPageAddCar.Controls.Add(this.txtModelYearAdd);
            this.tbPageAddCar.Controls.Add(this.btnAddCar);
            this.tbPageAddCar.Controls.Add(this.txtCarDetailsAdd);
            this.tbPageAddCar.Controls.Add(this.label7);
            this.tbPageAddCar.Controls.Add(this.label6);
            this.tbPageAddCar.Controls.Add(this.label3);
            this.tbPageAddCar.Controls.Add(this.label5);
            this.tbPageAddCar.Controls.Add(this.label4);
            this.tbPageAddCar.Controls.Add(this.cbxBrandAdd);
            this.tbPageAddCar.Controls.Add(this.cbxColorAdd);
            this.tbPageAddCar.Location = new System.Drawing.Point(4, 28);
            this.tbPageAddCar.Name = "tbPageAddCar";
            this.tbPageAddCar.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageAddCar.Size = new System.Drawing.Size(768, 394);
            this.tbPageAddCar.TabIndex = 1;
            this.tbPageAddCar.Text = "Add Car";
            // 
            // txtDailyPriceAdd
            // 
            this.txtDailyPriceAdd.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtDailyPriceAdd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDailyPriceAdd.Font = new System.Drawing.Font("Sarabun SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.txtDailyPriceAdd.Location = new System.Drawing.Point(177, 41);
            this.txtDailyPriceAdd.Mask = "0000";
            this.txtDailyPriceAdd.Name = "txtDailyPriceAdd";
            this.txtDailyPriceAdd.Size = new System.Drawing.Size(127, 28);
            this.txtDailyPriceAdd.TabIndex = 19;
            this.txtDailyPriceAdd.ValidatingType = typeof(int);
            // 
            // txtModelYearAdd
            // 
            this.txtModelYearAdd.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtModelYearAdd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtModelYearAdd.Font = new System.Drawing.Font("Sarabun SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.txtModelYearAdd.Location = new System.Drawing.Point(346, 41);
            this.txtModelYearAdd.Mask = "0000";
            this.txtModelYearAdd.Name = "txtModelYearAdd";
            this.txtModelYearAdd.Size = new System.Drawing.Size(127, 28);
            this.txtModelYearAdd.TabIndex = 18;
            this.txtModelYearAdd.ValidatingType = typeof(int);
            // 
            // btnAddCar
            // 
            this.btnAddCar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddCar.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCar.Location = new System.Drawing.Point(346, 103);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(127, 32);
            this.btnAddCar.TabIndex = 17;
            this.btnAddCar.Text = "Save Car";
            this.btnAddCar.UseVisualStyleBackColor = false;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // txtCarDetailsAdd
            // 
            this.txtCarDetailsAdd.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtCarDetailsAdd.Font = new System.Drawing.Font("Sarabun SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCarDetailsAdd.Location = new System.Drawing.Point(177, 110);
            this.txtCarDetailsAdd.Multiline = true;
            this.txtCarDetailsAdd.Name = "txtCarDetailsAdd";
            this.txtCarDetailsAdd.Size = new System.Drawing.Size(127, 24);
            this.txtCarDetailsAdd.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Font = new System.Drawing.Font("Sarabun SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(176, 81);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(95, 30);
            this.label7.TabIndex = 13;
            this.label7.Text = "Car Details:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Font = new System.Drawing.Font("Sarabun SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(344, 12);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(98, 30);
            this.label6.TabIndex = 12;
            this.label6.Text = "Model Year:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Sarabun SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(172, 12);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(92, 30);
            this.label3.TabIndex = 11;
            this.label3.Text = "Daily Price:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Font = new System.Drawing.Font("Sarabun SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(9, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 30);
            this.label5.TabIndex = 9;
            this.label5.Text = "Color:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Sarabun SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(6, 12);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(59, 30);
            this.label4.TabIndex = 8;
            this.label4.Text = "Brand:";
            // 
            // cbxBrandAdd
            // 
            this.cbxBrandAdd.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cbxBrandAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxBrandAdd.FormattingEnabled = true;
            this.cbxBrandAdd.Location = new System.Drawing.Point(11, 41);
            this.cbxBrandAdd.Name = "cbxBrandAdd";
            this.cbxBrandAdd.Size = new System.Drawing.Size(121, 24);
            this.cbxBrandAdd.TabIndex = 6;
            // 
            // cbxColorAdd
            // 
            this.cbxColorAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.cbxColorAdd.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cbxColorAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxColorAdd.FormattingEnabled = true;
            this.cbxColorAdd.Location = new System.Drawing.Point(14, 110);
            this.cbxColorAdd.Name = "cbxColorAdd";
            this.cbxColorAdd.Size = new System.Drawing.Size(121, 24);
            this.cbxColorAdd.TabIndex = 5;
            // 
            // tbPageUpdateCar
            // 
            this.tbPageUpdateCar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbPageUpdateCar.Controls.Add(this.txtDailyPriceUpdate);
            this.tbPageUpdateCar.Controls.Add(this.txtModelYearUpdate);
            this.tbPageUpdateCar.Controls.Add(this.btnUpdateCar);
            this.tbPageUpdateCar.Controls.Add(this.txtCarDetailsUpdate);
            this.tbPageUpdateCar.Controls.Add(this.label10);
            this.tbPageUpdateCar.Controls.Add(this.label11);
            this.tbPageUpdateCar.Controls.Add(this.label12);
            this.tbPageUpdateCar.Controls.Add(this.label8);
            this.tbPageUpdateCar.Controls.Add(this.label9);
            this.tbPageUpdateCar.Controls.Add(this.cbxBrandUpdate);
            this.tbPageUpdateCar.Controls.Add(this.cbxColorUpdate);
            this.tbPageUpdateCar.Location = new System.Drawing.Point(4, 28);
            this.tbPageUpdateCar.Name = "tbPageUpdateCar";
            this.tbPageUpdateCar.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageUpdateCar.Size = new System.Drawing.Size(768, 394);
            this.tbPageUpdateCar.TabIndex = 2;
            this.tbPageUpdateCar.Text = "Update Car";
            // 
            // txtDailyPriceUpdate
            // 
            this.txtDailyPriceUpdate.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtDailyPriceUpdate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDailyPriceUpdate.Font = new System.Drawing.Font("Sarabun SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.txtDailyPriceUpdate.Location = new System.Drawing.Point(347, 52);
            this.txtDailyPriceUpdate.Mask = "0000";
            this.txtDailyPriceUpdate.Name = "txtDailyPriceUpdate";
            this.txtDailyPriceUpdate.Size = new System.Drawing.Size(127, 28);
            this.txtDailyPriceUpdate.TabIndex = 26;
            this.txtDailyPriceUpdate.ValidatingType = typeof(int);
            // 
            // txtModelYearUpdate
            // 
            this.txtModelYearUpdate.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtModelYearUpdate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtModelYearUpdate.Font = new System.Drawing.Font("Sarabun SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.txtModelYearUpdate.Location = new System.Drawing.Point(516, 52);
            this.txtModelYearUpdate.Mask = "0000";
            this.txtModelYearUpdate.Name = "txtModelYearUpdate";
            this.txtModelYearUpdate.Size = new System.Drawing.Size(127, 28);
            this.txtModelYearUpdate.TabIndex = 25;
            this.txtModelYearUpdate.ValidatingType = typeof(int);
            // 
            // btnUpdateCar
            // 
            this.btnUpdateCar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdateCar.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCar.Location = new System.Drawing.Point(516, 114);
            this.btnUpdateCar.Name = "btnUpdateCar";
            this.btnUpdateCar.Size = new System.Drawing.Size(127, 32);
            this.btnUpdateCar.TabIndex = 24;
            this.btnUpdateCar.Text = "Update Car";
            this.btnUpdateCar.UseVisualStyleBackColor = false;
            // 
            // txtCarDetailsUpdate
            // 
            this.txtCarDetailsUpdate.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtCarDetailsUpdate.Font = new System.Drawing.Font("Sarabun SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCarDetailsUpdate.Location = new System.Drawing.Point(347, 120);
            this.txtCarDetailsUpdate.Multiline = true;
            this.txtCarDetailsUpdate.Name = "txtCarDetailsUpdate";
            this.txtCarDetailsUpdate.Size = new System.Drawing.Size(127, 25);
            this.txtCarDetailsUpdate.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label10.Font = new System.Drawing.Font("Sarabun SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(346, 92);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label10.Size = new System.Drawing.Size(95, 30);
            this.label10.TabIndex = 22;
            this.label10.Text = "Car Details:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label11.Font = new System.Drawing.Font("Sarabun SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(514, 23);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label11.Size = new System.Drawing.Size(98, 30);
            this.label11.TabIndex = 21;
            this.label11.Text = "Model Year:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label12.Font = new System.Drawing.Font("Sarabun SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(342, 23);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label12.Size = new System.Drawing.Size(92, 30);
            this.label12.TabIndex = 20;
            this.label12.Text = "Daily Price:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Font = new System.Drawing.Font("Sarabun SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(198, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 30);
            this.label8.TabIndex = 13;
            this.label8.Text = "Color:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label9.Font = new System.Drawing.Font("Sarabun SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(195, 23);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(59, 30);
            this.label9.TabIndex = 12;
            this.label9.Text = "Brand:";
            // 
            // cbxBrandUpdate
            // 
            this.cbxBrandUpdate.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cbxBrandUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxBrandUpdate.FormattingEnabled = true;
            this.cbxBrandUpdate.Location = new System.Drawing.Point(200, 52);
            this.cbxBrandUpdate.Name = "cbxBrandUpdate";
            this.cbxBrandUpdate.Size = new System.Drawing.Size(121, 24);
            this.cbxBrandUpdate.TabIndex = 11;
            // 
            // cbxColorUpdate
            // 
            this.cbxColorUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.cbxColorUpdate.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cbxColorUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxColorUpdate.FormattingEnabled = true;
            this.cbxColorUpdate.Location = new System.Drawing.Point(203, 121);
            this.cbxColorUpdate.Name = "cbxColorUpdate";
            this.cbxColorUpdate.Size = new System.Drawing.Size(121, 24);
            this.cbxColorUpdate.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbControlCar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tbControlCar.ResumeLayout(false);
            this.tbPageAllCars.ResumeLayout(false);
            this.tbPageAllCars.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAllCars)).EndInit();
            this.tbPageAddCar.ResumeLayout(false);
            this.tbPageAddCar.PerformLayout();
            this.tbPageUpdateCar.ResumeLayout(false);
            this.tbPageUpdateCar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbControlCar;
        private System.Windows.Forms.TabPage tbPageAllCars;
        private System.Windows.Forms.TabPage tbPageAddCar;
        private System.Windows.Forms.TabPage tbPageUpdateCar;
        private System.Windows.Forms.DataGridView dgwAllCars;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxBrandAdd;
        private System.Windows.Forms.ComboBox cbxColorAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCarDetailsAdd;
        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.MaskedTextBox txtModelYearAdd;
        private System.Windows.Forms.MaskedTextBox txtDailyPriceAdd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbxBrandUpdate;
        private System.Windows.Forms.ComboBox cbxColorUpdate;
        private System.Windows.Forms.MaskedTextBox txtDailyPriceUpdate;
        private System.Windows.Forms.MaskedTextBox txtModelYearUpdate;
        private System.Windows.Forms.Button btnUpdateCar;
        private System.Windows.Forms.TextBox txtCarDetailsUpdate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnClrFilter;
    }
}

