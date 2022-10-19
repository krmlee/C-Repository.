namespace WinFormsApp1
{
    public partial class teslaoils : Form
    {
        public teslaoils()
        {
            InitializeComponent();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            price_textBox_TextChanged( sender, e);
        }
        private void pay_button_Click(object sender, EventArgs e)
        {
            try {
                var oil = Convert.ToDouble(oil_sum_textBox.Text);
                var cafe = Convert.ToDouble(cafe_sum_textBox.Text);
                var sum = oil + cafe;
                string tostr = Convert.ToString(sum);
                last_textBox.Text = tostr;
            }
            catch { MessageBox.Show("Убедитесь что все пункты выполнены корректно!"); }
            
        }

        private void price_textBox_TextChanged(object sender, EventArgs e)
        {
            if(oil_comboBox.SelectedIndex == 0) { price_textBox.Text = "1"; }
            else if (oil_comboBox.SelectedIndex == 1) { price_textBox.Text = "2"; }
            else if(oil_comboBox.SelectedIndex == 2) { price_textBox.Text = "2"; }
            else if (oil_comboBox.SelectedIndex == 3) { price_textBox.Text = "1"; }
        }
        private void Value_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(Value_radioButton.Checked == true) { oil_value_textBox.ReadOnly = false; }
            else { oil_value_textBox.ReadOnly = true; oil_value_textBox.Text = "1"; }
        }
        private void oil_convert_button_Click(object sender, EventArgs e)
        {
            oil_sum_textBox.Text = convert(price_textBox.Text, oil_value_textBox.Text);
        }
        private string convert(string a,string b)
        {
           
                var multiplier = Convert.ToDouble(a);
                var factor = Convert.ToDouble(b);
                var toint = multiplier * factor;
                var tostr = Convert.ToString(toint);
                
            

            return tostr;
        }
       

        private string convert_cafe(string a, string b,string c,string d)
        {

            var multiplier1 = Convert.ToDouble(a);
            multiplier1 *= 4; 
            var multiplier2 = Convert.ToDouble(b);
            multiplier2 *= 5.4;
            var multiplier3 = Convert.ToDouble(c);
            multiplier3 *= 7.2;
            var multiplier4 = Convert.ToDouble(d);
            multiplier4 *= 4.2;
            var toint = multiplier1 + multiplier2 + multiplier3 + multiplier4 ;
            var tostr = Convert.ToString(toint);



            return tostr;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                hotdog_textBox.ReadOnly = false;
            }
            else { hotdog_textBox.Text = "0"; hotdog_textBox.ReadOnly = true; }
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                burger_textBox.ReadOnly = false;
            }
            else { burger_textBox.Text = "0"; burger_textBox.ReadOnly = true; }
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                potato_textBox.ReadOnly = false;
            }
            else { potato_textBox.Text = "0"; potato_textBox.ReadOnly = true; }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                cola_textBox.ReadOnly = false;
            }
            else { cola_textBox.Text = "0"; cola_textBox.ReadOnly = true; }
        }
        private void button_Click(object sender, EventArgs e)
        {
            cafe_sum_textBox.Text = convert_cafe(hotdog_textBox.Text, burger_textBox.Text, potato_textBox.Text, cola_textBox.Text);
        }

        
    }
}