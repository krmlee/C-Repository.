namespace WinFormsApp1
{
    partial class teslaoils
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.oil_convert_button = new System.Windows.Forms.Button();
            this.oil_price2_textBox = new System.Windows.Forms.TextBox();
            this.oil_value_textBox = new System.Windows.Forms.TextBox();
            this.price_textBox = new System.Windows.Forms.TextBox();
            this.oil_comboBox = new System.Windows.Forms.ComboBox();
            this.price_label = new System.Windows.Forms.Label();
            this.petrol_label = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.oil_sum_textBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Price_radioButton = new System.Windows.Forms.RadioButton();
            this.Value_radioButton = new System.Windows.Forms.RadioButton();
            this.cafe_groupBox = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cafe_sum_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cola_textBox = new System.Windows.Forms.TextBox();
            this.potato_textBox = new System.Windows.Forms.TextBox();
            this.burger_textBox = new System.Windows.Forms.TextBox();
            this.hotdog_textBox = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.last_textBox = new System.Windows.Forms.TextBox();
            this.pay_button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.cafe_groupBox.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.oil_convert_button);
            this.groupBox1.Controls.Add(this.oil_price2_textBox);
            this.groupBox1.Controls.Add(this.oil_value_textBox);
            this.groupBox1.Controls.Add(this.price_textBox);
            this.groupBox1.Controls.Add(this.oil_comboBox);
            this.groupBox1.Controls.Add(this.price_label);
            this.groupBox1.Controls.Add(this.petrol_label);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 296);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Автозаправка";
            // 
            // oil_convert_button
            // 
            this.oil_convert_button.Location = new System.Drawing.Point(298, 110);
            this.oil_convert_button.Name = "oil_convert_button";
            this.oil_convert_button.Size = new System.Drawing.Size(30, 23);
            this.oil_convert_button.TabIndex = 8;
            this.oil_convert_button.Text = "ok";
            this.oil_convert_button.UseVisualStyleBackColor = true;
            this.oil_convert_button.Click += new System.EventHandler(this.oil_convert_button_Click);
            // 
            // oil_price2_textBox
            // 
            this.oil_price2_textBox.Location = new System.Drawing.Point(171, 144);
            this.oil_price2_textBox.Name = "oil_price2_textBox";
            this.oil_price2_textBox.ReadOnly = true;
            this.oil_price2_textBox.Size = new System.Drawing.Size(121, 23);
            this.oil_price2_textBox.TabIndex = 7;
            this.oil_price2_textBox.Text = "coming soon...";
            // 
            // oil_value_textBox
            // 
            this.oil_value_textBox.Location = new System.Drawing.Point(171, 110);
            this.oil_value_textBox.Name = "oil_value_textBox";
            this.oil_value_textBox.ReadOnly = true;
            this.oil_value_textBox.Size = new System.Drawing.Size(121, 23);
            this.oil_value_textBox.TabIndex = 6;
            this.oil_value_textBox.Text = "1";
            // 
            // price_textBox
            // 
            this.price_textBox.Location = new System.Drawing.Point(171, 61);
            this.price_textBox.Name = "price_textBox";
            this.price_textBox.ReadOnly = true;
            this.price_textBox.Size = new System.Drawing.Size(121, 23);
            this.price_textBox.TabIndex = 5;
            this.price_textBox.Text = "0";
            this.price_textBox.TextChanged += new System.EventHandler(this.price_textBox_TextChanged);
            // 
            // oil_comboBox
            // 
            this.oil_comboBox.FormattingEnabled = true;
            this.oil_comboBox.Items.AddRange(new object[] {
            "A-92",
            "Super",
            "Premium",
            "Dizel"});
            this.oil_comboBox.Location = new System.Drawing.Point(171, 27);
            this.oil_comboBox.Name = "oil_comboBox";
            this.oil_comboBox.Size = new System.Drawing.Size(121, 23);
            this.oil_comboBox.TabIndex = 4;
            this.oil_comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // price_label
            // 
            this.price_label.AutoSize = true;
            this.price_label.Location = new System.Drawing.Point(32, 64);
            this.price_label.Name = "price_label";
            this.price_label.Size = new System.Drawing.Size(35, 15);
            this.price_label.TabIndex = 3;
            this.price_label.Text = "Цена";
            // 
            // petrol_label
            // 
            this.petrol_label.AutoSize = true;
            this.petrol_label.Location = new System.Drawing.Point(32, 35);
            this.petrol_label.Name = "petrol_label";
            this.petrol_label.Size = new System.Drawing.Size(46, 15);
            this.petrol_label.TabIndex = 2;
            this.petrol_label.Text = "Бензин";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.oil_sum_textBox);
            this.groupBox3.Location = new System.Drawing.Point(6, 193);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(209, 97);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "сумма:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "azn";
            // 
            // oil_sum_textBox
            // 
            this.oil_sum_textBox.Location = new System.Drawing.Point(51, 41);
            this.oil_sum_textBox.Name = "oil_sum_textBox";
            this.oil_sum_textBox.ReadOnly = true;
            this.oil_sum_textBox.Size = new System.Drawing.Size(89, 23);
            this.oil_sum_textBox.TabIndex = 0;
            this.oil_sum_textBox.Text = "0";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Price_radioButton);
            this.groupBox2.Controls.Add(this.Value_radioButton);
            this.groupBox2.Location = new System.Drawing.Point(6, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(108, 81);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // Price_radioButton
            // 
            this.Price_radioButton.AutoSize = true;
            this.Price_radioButton.Location = new System.Drawing.Point(10, 51);
            this.Price_radioButton.Name = "Price_radioButton";
            this.Price_radioButton.Size = new System.Drawing.Size(83, 19);
            this.Price_radioButton.TabIndex = 1;
            this.Price_radioButton.TabStop = true;
            this.Price_radioButton.Text = "стоимость";
            this.Price_radioButton.UseVisualStyleBackColor = true;
            // 
            // Value_radioButton
            // 
            this.Value_radioButton.AutoSize = true;
            this.Value_radioButton.Location = new System.Drawing.Point(9, 21);
            this.Value_radioButton.Name = "Value_radioButton";
            this.Value_radioButton.Size = new System.Drawing.Size(70, 19);
            this.Value_radioButton.TabIndex = 0;
            this.Value_radioButton.TabStop = true;
            this.Value_radioButton.Text = "емкость";
            this.Value_radioButton.UseVisualStyleBackColor = true;
            this.Value_radioButton.CheckedChanged += new System.EventHandler(this.Value_radioButton_CheckedChanged);
            // 
            // cafe_groupBox
            // 
            this.cafe_groupBox.Controls.Add(this.button1);
            this.cafe_groupBox.Controls.Add(this.groupBox4);
            this.cafe_groupBox.Controls.Add(this.cola_textBox);
            this.cafe_groupBox.Controls.Add(this.potato_textBox);
            this.cafe_groupBox.Controls.Add(this.burger_textBox);
            this.cafe_groupBox.Controls.Add(this.hotdog_textBox);
            this.cafe_groupBox.Controls.Add(this.textBox7);
            this.cafe_groupBox.Controls.Add(this.textBox6);
            this.cafe_groupBox.Controls.Add(this.textBox5);
            this.cafe_groupBox.Controls.Add(this.textBox4);
            this.cafe_groupBox.Controls.Add(this.checkBox4);
            this.cafe_groupBox.Controls.Add(this.checkBox3);
            this.cafe_groupBox.Controls.Add(this.checkBox2);
            this.cafe_groupBox.Controls.Add(this.checkBox1);
            this.cafe_groupBox.Location = new System.Drawing.Point(406, 12);
            this.cafe_groupBox.Name = "cafe_groupBox";
            this.cafe_groupBox.Size = new System.Drawing.Size(382, 296);
            this.cafe_groupBox.TabIndex = 1;
            this.cafe_groupBox.TabStop = false;
            this.cafe_groupBox.Text = "мини-кафе";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(214, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "подтвердить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cafe_sum_textBox);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(26, 199);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 91);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "сумма:";
            // 
            // cafe_sum_textBox
            // 
            this.cafe_sum_textBox.Location = new System.Drawing.Point(41, 35);
            this.cafe_sum_textBox.Name = "cafe_sum_textBox";
            this.cafe_sum_textBox.ReadOnly = true;
            this.cafe_sum_textBox.Size = new System.Drawing.Size(100, 23);
            this.cafe_sum_textBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "azn";
            // 
            // cola_textBox
            // 
            this.cola_textBox.Location = new System.Drawing.Point(276, 106);
            this.cola_textBox.Name = "cola_textBox";
            this.cola_textBox.ReadOnly = true;
            this.cola_textBox.Size = new System.Drawing.Size(41, 23);
            this.cola_textBox.TabIndex = 11;
            this.cola_textBox.Text = "0";
            // 
            // potato_textBox
            // 
            this.potato_textBox.Location = new System.Drawing.Point(276, 81);
            this.potato_textBox.Name = "potato_textBox";
            this.potato_textBox.ReadOnly = true;
            this.potato_textBox.Size = new System.Drawing.Size(41, 23);
            this.potato_textBox.TabIndex = 10;
            this.potato_textBox.Text = "0";
            // 
            // burger_textBox
            // 
            this.burger_textBox.Location = new System.Drawing.Point(276, 56);
            this.burger_textBox.Name = "burger_textBox";
            this.burger_textBox.ReadOnly = true;
            this.burger_textBox.Size = new System.Drawing.Size(41, 23);
            this.burger_textBox.TabIndex = 9;
            this.burger_textBox.Text = "0";
            // 
            // hotdog_textBox
            // 
            this.hotdog_textBox.Location = new System.Drawing.Point(276, 32);
            this.hotdog_textBox.Name = "hotdog_textBox";
            this.hotdog_textBox.ReadOnly = true;
            this.hotdog_textBox.Size = new System.Drawing.Size(41, 23);
            this.hotdog_textBox.TabIndex = 8;
            this.hotdog_textBox.Text = "0";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(214, 106);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(43, 23);
            this.textBox7.TabIndex = 7;
            this.textBox7.Text = "4.20";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(214, 82);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(43, 23);
            this.textBox6.TabIndex = 6;
            this.textBox6.Text = "7.20";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(214, 56);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(43, 23);
            this.textBox5.TabIndex = 5;
            this.textBox5.Text = "5.40";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(214, 32);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(43, 23);
            this.textBox4.TabIndex = 4;
            this.textBox4.Text = "4.00";
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(27, 110);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(78, 19);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "coca-cola";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(28, 86);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(61, 19);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "potato";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(27, 60);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(85, 19);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "hamburger";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(26, 34);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(70, 19);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "hot-dog";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.last_textBox);
            this.groupBox5.Controls.Add(this.pay_button);
            this.groupBox5.Location = new System.Drawing.Point(12, 314);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(776, 124);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "оплатить:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(421, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "итоговая сумма:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(582, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "azn";
            // 
            // last_textBox
            // 
            this.last_textBox.Location = new System.Drawing.Point(469, 59);
            this.last_textBox.Name = "last_textBox";
            this.last_textBox.ReadOnly = true;
            this.last_textBox.Size = new System.Drawing.Size(100, 23);
            this.last_textBox.TabIndex = 1;
            // 
            // pay_button
            // 
            this.pay_button.Location = new System.Drawing.Point(147, 36);
            this.pay_button.Name = "pay_button";
            this.pay_button.Size = new System.Drawing.Size(211, 68);
            this.pay_button.TabIndex = 0;
            this.pay_button.Text = "завершить";
            this.pay_button.UseVisualStyleBackColor = true;
            this.pay_button.Click += new System.EventHandler(this.pay_button_Click);
            // 
            // teslaoils
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.cafe_groupBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "teslaoils";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.cafe_groupBox.ResumeLayout(false);
            this.cafe_groupBox.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label price_label;
        private Label petrol_label;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private RadioButton Price_radioButton;
        private RadioButton Value_radioButton;
        private ComboBox oil_comboBox;
        private TextBox oil_price2_textBox;
        private TextBox oil_value_textBox;
        private TextBox price_textBox;
        private Label label1;
        private TextBox oil_sum_textBox;
        private GroupBox cafe_groupBox;
        private GroupBox groupBox4;
        private TextBox cafe_sum_textBox;
        private Label label2;
        private TextBox cola_textBox;
        private TextBox potato_textBox;
        private TextBox burger_textBox;
        private TextBox hotdog_textBox;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private GroupBox groupBox5;
        private Label label3;
        private TextBox last_textBox;
        private Button pay_button;
        private Button oil_convert_button;
        private Button button1;
        private Label label4;
    }
}