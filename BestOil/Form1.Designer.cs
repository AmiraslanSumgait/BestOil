
namespace BestOil
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
            this.cb_FuelType = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.txtBox_Price = new Guna.UI.WinForms.GunaTextBox();
            this.txtBox_Perliter = new Guna.UI.WinForms.GunaTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_Price = new Guna.UI.WinForms.GunaRadioButton();
            this.rb_PerLiter = new Guna.UI.WinForms.GunaRadioButton();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.txtBox_FuelPrice = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtbox_GasStation_Amount = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaGroupBox2 = new Guna.UI.WinForms.GunaGroupBox();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.tbx_HotDog_Price = new System.Windows.Forms.TextBox();
            this.tbx_HotDog_Count = new System.Windows.Forms.TextBox();
            this.Count = new System.Windows.Forms.Label();
            this.tbx_Hamburger_Count = new System.Windows.Forms.TextBox();
            this.tbx_Hamburger_Price = new System.Windows.Forms.TextBox();
            this.cbx_HotDog = new System.Windows.Forms.CheckBox();
            this.cbx_Hamburger = new System.Windows.Forms.CheckBox();
            this.cbx_PotatoFri = new System.Windows.Forms.CheckBox();
            this.tbx_PotatoFri_Count = new System.Windows.Forms.TextBox();
            this.tbx_PotatoFri_Price = new System.Windows.Forms.TextBox();
            this.tbx_CocoCola_Count = new System.Windows.Forms.TextBox();
            this.tbx_CocoCola_Price = new System.Windows.Forms.TextBox();
            this.cbx_CocoCola = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.txtbox_Minicafe_Amount = new Guna.UI.WinForms.GunaTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbx_AllAmount = new System.Windows.Forms.TextBox();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.btn_Buy = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_Calculate = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaGroupBox1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gunaGroupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_FuelType
            // 
            this.cb_FuelType.BackColor = System.Drawing.Color.Transparent;
            this.cb_FuelType.BaseColor = System.Drawing.Color.White;
            this.cb_FuelType.BorderColor = System.Drawing.Color.Silver;
            this.cb_FuelType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_FuelType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_FuelType.FocusedColor = System.Drawing.Color.Empty;
            this.cb_FuelType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_FuelType.ForeColor = System.Drawing.Color.RoyalBlue;
            this.cb_FuelType.FormattingEnabled = true;
            this.cb_FuelType.Location = new System.Drawing.Point(77, 45);
            this.cb_FuelType.Name = "cb_FuelType";
            this.cb_FuelType.OnHoverItemBaseColor = System.Drawing.Color.Navy;
            this.cb_FuelType.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cb_FuelType.Size = new System.Drawing.Size(160, 26);
            this.cb_FuelType.TabIndex = 0;
            this.cb_FuelType.SelectedIndexChanged += new System.EventHandler(this.cb_FuelType_SelectedIndexChanged);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(3, 45);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(42, 21);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Fuel";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(3, 85);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(48, 21);
            this.gunaLabel2.TabIndex = 2;
            this.gunaLabel2.Text = "Price";
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Controls.Add(this.groupBox2);
            this.gunaGroupBox1.Controls.Add(this.txtBox_Price);
            this.gunaGroupBox1.Controls.Add(this.txtBox_Perliter);
            this.gunaGroupBox1.Controls.Add(this.groupBox1);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel3);
            this.gunaGroupBox1.Controls.Add(this.txtBox_FuelPrice);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel2);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel1);
            this.gunaGroupBox1.Controls.Add(this.cb_FuelType);
            this.gunaGroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Location = new System.Drawing.Point(12, 21);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(316, 344);
            this.gunaGroupBox1.TabIndex = 0;
            this.gunaGroupBox1.Text = "Gas Station";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // txtBox_Price
            // 
            this.txtBox_Price.BaseColor = System.Drawing.Color.White;
            this.txtBox_Price.BorderColor = System.Drawing.Color.DarkTurquoise;
            this.txtBox_Price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBox_Price.FocusedBaseColor = System.Drawing.Color.White;
            this.txtBox_Price.FocusedBorderColor = System.Drawing.Color.DarkTurquoise;
            this.txtBox_Price.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBox_Price.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Price.ForeColor = System.Drawing.Color.Black;
            this.txtBox_Price.Location = new System.Drawing.Point(162, 174);
            this.txtBox_Price.Name = "txtBox_Price";
            this.txtBox_Price.PasswordChar = '\0';
            this.txtBox_Price.SelectedText = "";
            this.txtBox_Price.Size = new System.Drawing.Size(133, 30);
            this.txtBox_Price.TabIndex = 7;
            this.txtBox_Price.TextChanged += new System.EventHandler(this.txtBox_Price_TextChanged);
            // 
            // txtBox_Perliter
            // 
            this.txtBox_Perliter.BaseColor = System.Drawing.Color.White;
            this.txtBox_Perliter.BorderColor = System.Drawing.Color.DarkTurquoise;
            this.txtBox_Perliter.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBox_Perliter.FocusedBaseColor = System.Drawing.Color.White;
            this.txtBox_Perliter.FocusedBorderColor = System.Drawing.Color.DarkTurquoise;
            this.txtBox_Perliter.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBox_Perliter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Perliter.Location = new System.Drawing.Point(162, 138);
            this.txtBox_Perliter.Name = "txtBox_Perliter";
            this.txtBox_Perliter.PasswordChar = '\0';
            this.txtBox_Perliter.SelectedText = "";
            this.txtBox_Perliter.Size = new System.Drawing.Size(133, 30);
            this.txtBox_Perliter.TabIndex = 6;
            this.txtBox_Perliter.TextChanged += new System.EventHandler(this.txtBox_Perliter_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(219)))), ((int)(((byte)(214)))));
            this.groupBox1.Controls.Add(this.rb_Price);
            this.groupBox1.Controls.Add(this.rb_PerLiter);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(7, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(149, 66);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // rb_Price
            // 
            this.rb_Price.BaseColor = System.Drawing.SystemColors.Control;
            this.rb_Price.CheckedOffColor = System.Drawing.Color.Gray;
            this.rb_Price.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.rb_Price.FillColor = System.Drawing.Color.White;
            this.rb_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Price.Location = new System.Drawing.Point(0, 37);
            this.rb_Price.Name = "rb_Price";
            this.rb_Price.Size = new System.Drawing.Size(104, 21);
            this.rb_Price.TabIndex = 1;
            this.rb_Price.Text = "With Price";
            this.rb_Price.CheckedChanged += new System.EventHandler(this.rb_Price_CheckedChanged);
            // 
            // rb_PerLiter
            // 
            this.rb_PerLiter.BaseColor = System.Drawing.SystemColors.Control;
            this.rb_PerLiter.CheckedOffColor = System.Drawing.Color.Gray;
            this.rb_PerLiter.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.rb_PerLiter.FillColor = System.Drawing.Color.White;
            this.rb_PerLiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_PerLiter.Location = new System.Drawing.Point(0, 10);
            this.rb_PerLiter.Name = "rb_PerLiter";
            this.rb_PerLiter.Size = new System.Drawing.Size(94, 21);
            this.rb_PerLiter.TabIndex = 0;
            this.rb_PerLiter.Text = "With liter";
            this.rb_PerLiter.CheckedChanged += new System.EventHandler(this.rb_PerLiter_CheckedChanged);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(243, 91);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(27, 13);
            this.gunaLabel3.TabIndex = 4;
            this.gunaLabel3.Text = "Azn";
            // 
            // txtBox_FuelPrice
            // 
            this.txtBox_FuelPrice.Enabled = false;
            this.txtBox_FuelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_FuelPrice.Location = new System.Drawing.Point(77, 85);
            this.txtBox_FuelPrice.Name = "txtBox_FuelPrice";
            this.txtBox_FuelPrice.ReadOnly = true;
            this.txtBox_FuelPrice.Size = new System.Drawing.Size(160, 22);
            this.txtBox_FuelPrice.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gunaLabel4);
            this.groupBox2.Controls.Add(this.txtbox_GasStation_Amount);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(7, 221);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Amount";
            // 
            // txtbox_GasStation_Amount
            // 
            this.txtbox_GasStation_Amount.BaseColor = System.Drawing.Color.White;
            this.txtbox_GasStation_Amount.BorderColor = System.Drawing.Color.Silver;
            this.txtbox_GasStation_Amount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbox_GasStation_Amount.Enabled = false;
            this.txtbox_GasStation_Amount.FocusedBaseColor = System.Drawing.Color.White;
            this.txtbox_GasStation_Amount.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtbox_GasStation_Amount.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtbox_GasStation_Amount.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_GasStation_Amount.Location = new System.Drawing.Point(65, 38);
            this.txtbox_GasStation_Amount.Name = "txtbox_GasStation_Amount";
            this.txtbox_GasStation_Amount.PasswordChar = '\0';
            this.txtbox_GasStation_Amount.SelectedText = "";
            this.txtbox_GasStation_Amount.Size = new System.Drawing.Size(84, 30);
            this.txtbox_GasStation_Amount.TabIndex = 0;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(155, 75);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(36, 20);
            this.gunaLabel4.TabIndex = 1;
            this.gunaLabel4.Text = "Azn";
            // 
            // gunaGroupBox2
            // 
            this.gunaGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox2.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox2.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox2.Controls.Add(this.groupBox3);
            this.gunaGroupBox2.Controls.Add(this.tbx_CocoCola_Count);
            this.gunaGroupBox2.Controls.Add(this.tbx_CocoCola_Price);
            this.gunaGroupBox2.Controls.Add(this.cbx_CocoCola);
            this.gunaGroupBox2.Controls.Add(this.tbx_PotatoFri_Count);
            this.gunaGroupBox2.Controls.Add(this.tbx_PotatoFri_Price);
            this.gunaGroupBox2.Controls.Add(this.cbx_PotatoFri);
            this.gunaGroupBox2.Controls.Add(this.cbx_Hamburger);
            this.gunaGroupBox2.Controls.Add(this.cbx_HotDog);
            this.gunaGroupBox2.Controls.Add(this.tbx_Hamburger_Count);
            this.gunaGroupBox2.Controls.Add(this.tbx_Hamburger_Price);
            this.gunaGroupBox2.Controls.Add(this.Count);
            this.gunaGroupBox2.Controls.Add(this.tbx_HotDog_Count);
            this.gunaGroupBox2.Controls.Add(this.tbx_HotDog_Price);
            this.gunaGroupBox2.Controls.Add(this.gunaLabel6);
            this.gunaGroupBox2.Controls.Add(this.gunaLabel5);
            this.gunaGroupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGroupBox2.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox2.Location = new System.Drawing.Point(415, 21);
            this.gunaGroupBox2.Name = "gunaGroupBox2";
            this.gunaGroupBox2.Size = new System.Drawing.Size(367, 344);
            this.gunaGroupBox2.TabIndex = 1;
            this.gunaGroupBox2.Text = "MIni-Cafe";
            this.gunaGroupBox2.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.Location = new System.Drawing.Point(-2, 31);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(66, 25);
            this.gunaLabel5.TabIndex = 1;
            this.gunaLabel5.Text = "Foods";
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.Location = new System.Drawing.Point(139, 50);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(48, 21);
            this.gunaLabel6.TabIndex = 2;
            this.gunaLabel6.Text = "Price";
            // 
            // tbx_HotDog_Price
            // 
            this.tbx_HotDog_Price.Enabled = false;
            this.tbx_HotDog_Price.Location = new System.Drawing.Point(129, 77);
            this.tbx_HotDog_Price.Name = "tbx_HotDog_Price";
            this.tbx_HotDog_Price.Size = new System.Drawing.Size(96, 26);
            this.tbx_HotDog_Price.TabIndex = 3;
            // 
            // tbx_HotDog_Count
            // 
            this.tbx_HotDog_Count.Enabled = false;
            this.tbx_HotDog_Count.Location = new System.Drawing.Point(241, 77);
            this.tbx_HotDog_Count.Name = "tbx_HotDog_Count";
            this.tbx_HotDog_Count.Size = new System.Drawing.Size(100, 26);
            this.tbx_HotDog_Count.TabIndex = 4;
            this.tbx_HotDog_Count.TextChanged += new System.EventHandler(this.tbx_HotDog_Count_TextChanged);
            // 
            // Count
            // 
            this.Count.AutoSize = true;
            this.Count.Location = new System.Drawing.Point(261, 51);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(57, 20);
            this.Count.TabIndex = 2;
            this.Count.Text = "Count";
            // 
            // tbx_Hamburger_Count
            // 
            this.tbx_Hamburger_Count.Enabled = false;
            this.tbx_Hamburger_Count.Location = new System.Drawing.Point(241, 109);
            this.tbx_Hamburger_Count.Name = "tbx_Hamburger_Count";
            this.tbx_Hamburger_Count.Size = new System.Drawing.Size(100, 26);
            this.tbx_Hamburger_Count.TabIndex = 6;
            this.tbx_Hamburger_Count.TextChanged += new System.EventHandler(this.tbx_Hamburger_Count_TextChanged);
            // 
            // tbx_Hamburger_Price
            // 
            this.tbx_Hamburger_Price.Enabled = false;
            this.tbx_Hamburger_Price.Location = new System.Drawing.Point(129, 109);
            this.tbx_Hamburger_Price.Name = "tbx_Hamburger_Price";
            this.tbx_Hamburger_Price.Size = new System.Drawing.Size(96, 26);
            this.tbx_Hamburger_Price.TabIndex = 5;
            // 
            // cbx_HotDog
            // 
            this.cbx_HotDog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(219)))), ((int)(((byte)(214)))));
            this.cbx_HotDog.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.cbx_HotDog.Location = new System.Drawing.Point(3, 77);
            this.cbx_HotDog.Name = "cbx_HotDog";
            this.cbx_HotDog.Size = new System.Drawing.Size(105, 25);
            this.cbx_HotDog.TabIndex = 7;
            this.cbx_HotDog.Text = "Hot-dog";
            this.cbx_HotDog.UseVisualStyleBackColor = false;
            this.cbx_HotDog.CheckedChanged += new System.EventHandler(this.cbx_HotDog_CheckedChanged);
            // 
            // cbx_Hamburger
            // 
            this.cbx_Hamburger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(219)))), ((int)(((byte)(214)))));
            this.cbx_Hamburger.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.cbx_Hamburger.Location = new System.Drawing.Point(3, 111);
            this.cbx_Hamburger.Name = "cbx_Hamburger";
            this.cbx_Hamburger.Size = new System.Drawing.Size(120, 25);
            this.cbx_Hamburger.TabIndex = 8;
            this.cbx_Hamburger.Text = "Hamburger";
            this.cbx_Hamburger.UseVisualStyleBackColor = false;
            this.cbx_Hamburger.CheckedChanged += new System.EventHandler(this.cbx_Hamburger_CheckedChanged);
            // 
            // cbx_PotatoFri
            // 
            this.cbx_PotatoFri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(219)))), ((int)(((byte)(214)))));
            this.cbx_PotatoFri.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.cbx_PotatoFri.Location = new System.Drawing.Point(3, 142);
            this.cbx_PotatoFri.Name = "cbx_PotatoFri";
            this.cbx_PotatoFri.Size = new System.Drawing.Size(120, 25);
            this.cbx_PotatoFri.TabIndex = 9;
            this.cbx_PotatoFri.Text = "Potato Fri";
            this.cbx_PotatoFri.UseVisualStyleBackColor = false;
            this.cbx_PotatoFri.CheckedChanged += new System.EventHandler(this.cbx_PotatoFri_CheckedChanged);
            // 
            // tbx_PotatoFri_Count
            // 
            this.tbx_PotatoFri_Count.Enabled = false;
            this.tbx_PotatoFri_Count.Location = new System.Drawing.Point(241, 142);
            this.tbx_PotatoFri_Count.Name = "tbx_PotatoFri_Count";
            this.tbx_PotatoFri_Count.Size = new System.Drawing.Size(100, 26);
            this.tbx_PotatoFri_Count.TabIndex = 11;
            this.tbx_PotatoFri_Count.TextChanged += new System.EventHandler(this.tbx_PotatoFri_Count_TextChanged);
            // 
            // tbx_PotatoFri_Price
            // 
            this.tbx_PotatoFri_Price.Enabled = false;
            this.tbx_PotatoFri_Price.Location = new System.Drawing.Point(129, 143);
            this.tbx_PotatoFri_Price.Name = "tbx_PotatoFri_Price";
            this.tbx_PotatoFri_Price.Size = new System.Drawing.Size(96, 26);
            this.tbx_PotatoFri_Price.TabIndex = 10;
            // 
            // tbx_CocoCola_Count
            // 
            this.tbx_CocoCola_Count.Enabled = false;
            this.tbx_CocoCola_Count.Location = new System.Drawing.Point(241, 173);
            this.tbx_CocoCola_Count.Name = "tbx_CocoCola_Count";
            this.tbx_CocoCola_Count.Size = new System.Drawing.Size(100, 26);
            this.tbx_CocoCola_Count.TabIndex = 14;
            this.tbx_CocoCola_Count.TextChanged += new System.EventHandler(this.tbx_CocoCola_Count_TextChanged);
            // 
            // tbx_CocoCola_Price
            // 
            this.tbx_CocoCola_Price.Enabled = false;
            this.tbx_CocoCola_Price.Location = new System.Drawing.Point(129, 175);
            this.tbx_CocoCola_Price.Name = "tbx_CocoCola_Price";
            this.tbx_CocoCola_Price.Size = new System.Drawing.Size(96, 26);
            this.tbx_CocoCola_Price.TabIndex = 13;
            // 
            // cbx_CocoCola
            // 
            this.cbx_CocoCola.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(219)))), ((int)(((byte)(214)))));
            this.cbx_CocoCola.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.cbx_CocoCola.Location = new System.Drawing.Point(3, 175);
            this.cbx_CocoCola.Name = "cbx_CocoCola";
            this.cbx_CocoCola.Size = new System.Drawing.Size(120, 25);
            this.cbx_CocoCola.TabIndex = 12;
            this.cbx_CocoCola.Text = "Coco-Cola";
            this.cbx_CocoCola.UseVisualStyleBackColor = false;
            this.cbx_CocoCola.CheckedChanged += new System.EventHandler(this.cbx_CocoCola_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gunaLabel7);
            this.groupBox3.Controls.Add(this.txtbox_Minicafe_Amount);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(55, 216);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Amount";
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel7.Location = new System.Drawing.Point(155, 75);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(36, 20);
            this.gunaLabel7.TabIndex = 1;
            this.gunaLabel7.Text = "Azn";
            // 
            // txtbox_Minicafe_Amount
            // 
            this.txtbox_Minicafe_Amount.BaseColor = System.Drawing.Color.White;
            this.txtbox_Minicafe_Amount.BorderColor = System.Drawing.Color.Silver;
            this.txtbox_Minicafe_Amount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbox_Minicafe_Amount.Enabled = false;
            this.txtbox_Minicafe_Amount.FocusedBaseColor = System.Drawing.Color.White;
            this.txtbox_Minicafe_Amount.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtbox_Minicafe_Amount.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtbox_Minicafe_Amount.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_Minicafe_Amount.Location = new System.Drawing.Point(65, 38);
            this.txtbox_Minicafe_Amount.Name = "txtbox_Minicafe_Amount";
            this.txtbox_Minicafe_Amount.PasswordChar = '\0';
            this.txtbox_Minicafe_Amount.SelectedText = "";
            this.txtbox_Minicafe_Amount.Size = new System.Drawing.Size(84, 30);
            this.txtbox_Minicafe_Amount.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.LightCoral;
            this.groupBox4.Controls.Add(this.btn_Calculate);
            this.groupBox4.Controls.Add(this.btn_Buy);
            this.groupBox4.Controls.Add(this.gunaLabel8);
            this.groupBox4.Controls.Add(this.tbx_AllAmount);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(19, 390);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(763, 178);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "All of the amount";
            // 
            // tbx_AllAmount
            // 
            this.tbx_AllAmount.Enabled = false;
            this.tbx_AllAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_AllAmount.Location = new System.Drawing.Point(416, 52);
            this.tbx_AllAmount.MinimumSize = new System.Drawing.Size(122, 30);
            this.tbx_AllAmount.Multiline = true;
            this.tbx_AllAmount.Name = "tbx_AllAmount";
            this.tbx_AllAmount.Size = new System.Drawing.Size(184, 66);
            this.tbx_AllAmount.TabIndex = 1;
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel8.Location = new System.Drawing.Point(615, 88);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(51, 30);
            this.gunaLabel8.TabIndex = 2;
            this.gunaLabel8.Text = "Azn";
            // 
            // btn_Buy
            // 
            this.btn_Buy.Animated = true;
            this.btn_Buy.AnimationHoverSpeed = 0.07F;
            this.btn_Buy.AnimationSpeed = 0.03F;
            this.btn_Buy.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(102)))));
            this.btn_Buy.BorderColor = System.Drawing.Color.Black;
            this.btn_Buy.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_Buy.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_Buy.CheckedForeColor = System.Drawing.Color.White;
            this.btn_Buy.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_Buy.CheckedImage")));
            this.btn_Buy.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_Buy.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Buy.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Buy.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Buy.ForeColor = System.Drawing.Color.Black;
            this.btn_Buy.Image = null;
            this.btn_Buy.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Buy.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Buy.Location = new System.Drawing.Point(254, 124);
            this.btn_Buy.Name = "btn_Buy";
            this.btn_Buy.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Buy.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Buy.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Buy.OnHoverImage = null;
            this.btn_Buy.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Buy.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Buy.Size = new System.Drawing.Size(180, 48);
            this.btn_Buy.TabIndex = 3;
            this.btn_Buy.Text = "Buy";
            this.btn_Buy.Click += new System.EventHandler(this.btn_Buy_Click);
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.Animated = true;
            this.btn_Calculate.AnimationHoverSpeed = 0.07F;
            this.btn_Calculate.AnimationSpeed = 0.03F;
            this.btn_Calculate.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(102)))));
            this.btn_Calculate.BorderColor = System.Drawing.Color.Black;
            this.btn_Calculate.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_Calculate.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_Calculate.CheckedForeColor = System.Drawing.Color.White;
            this.btn_Calculate.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_Calculate.CheckedImage")));
            this.btn_Calculate.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_Calculate.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Calculate.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Calculate.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Calculate.ForeColor = System.Drawing.Color.Black;
            this.btn_Calculate.Image = null;
            this.btn_Calculate.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Calculate.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Calculate.Location = new System.Drawing.Point(117, 52);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Calculate.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Calculate.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Calculate.OnHoverImage = null;
            this.btn_Calculate.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Calculate.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Calculate.Size = new System.Drawing.Size(180, 53);
            this.btn_Calculate.TabIndex = 4;
            this.btn_Calculate.Text = "Calculate";
            this.btn_Calculate.Click += new System.EventHandler(this.btn_Calculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(795, 580);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.gunaGroupBox2);
            this.Controls.Add(this.gunaGroupBox1);
            this.MaximumSize = new System.Drawing.Size(811, 619);
            this.MinimumSize = new System.Drawing.Size(811, 619);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gunaGroupBox2.ResumeLayout(false);
            this.gunaGroupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaComboBox cb_FuelType;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private System.Windows.Forms.TextBox txtBox_FuelPrice;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI.WinForms.GunaRadioButton rb_PerLiter;
        private Guna.UI.WinForms.GunaTextBox txtBox_Price;
        private Guna.UI.WinForms.GunaTextBox txtBox_Perliter;
        private Guna.UI.WinForms.GunaRadioButton rb_Price;
        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaTextBox txtbox_GasStation_Amount;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox2;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private System.Windows.Forms.TextBox tbx_HotDog_Price;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private System.Windows.Forms.Label Count;
        private System.Windows.Forms.TextBox tbx_HotDog_Count;
        private System.Windows.Forms.TextBox tbx_Hamburger_Count;
        private System.Windows.Forms.TextBox tbx_Hamburger_Price;
        private System.Windows.Forms.TextBox tbx_CocoCola_Count;
        private System.Windows.Forms.TextBox tbx_CocoCola_Price;
        private System.Windows.Forms.CheckBox cbx_CocoCola;
        private System.Windows.Forms.TextBox tbx_PotatoFri_Count;
        private System.Windows.Forms.TextBox tbx_PotatoFri_Price;
        private System.Windows.Forms.CheckBox cbx_PotatoFri;
        private System.Windows.Forms.CheckBox cbx_Hamburger;
        private System.Windows.Forms.CheckBox cbx_HotDog;
        private System.Windows.Forms.GroupBox groupBox3;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaTextBox txtbox_Minicafe_Amount;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tbx_AllAmount;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaAdvenceButton btn_Buy;
        private Guna.UI.WinForms.GunaAdvenceButton btn_Calculate;
    }
}

