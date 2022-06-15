using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace gorselprogramlamabütünleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'pansiyonDataSet.Oda' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.odaTableAdapter.Fill(this.pansiyonDataSet.Oda);

        }

        SqlConnection con = new SqlConnection("Data Source = DESKTOP-52JBBF9; Initial Catalog = Pansiyon; Integrated Security = True");
        SqlCommand com;
        
        private void button1_Click(object sender, EventArgs e)
        {

            var tc = textBox1.Text;
            var adsoyad = textBox2.Text;
            var cinsiyet = comboBox2.SelectedItem;
            var oda = comboBox1.SelectedItem;

            con.Open();
            com = new SqlCommand("INSERT Oda(TC, AdSoyad, Cinsiyet, Oda) VALUES ("+ tc +", '"+ adsoyad +"', '"+ cinsiyet +"', '"+ oda +"')", con);
            com.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Kayıt Eklendi!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var tc = textBox1.Text;
            con.Open();
            com = new SqlCommand("DELETE FROM Oda WHERE TC = "+ tc +"", con);
            com.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Kayıt Silindi!");
        }
    }
}
