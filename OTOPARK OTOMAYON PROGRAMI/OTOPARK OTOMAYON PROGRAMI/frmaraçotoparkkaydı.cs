using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OTOPARK_OTOMAYON_PROGRAMI
{
    public partial class frmaraçotoparkkaydı : Form
    {
        public frmaraçotoparkkaydı()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmaraçotoparkkaydı_Load(object sender, EventArgs e)
        {
            baglanti.open
                sqlcommand komut = new sqlcommand("select 'from araç durumu  WHERE durumu='BOŞ' ", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboparkyeri.Items.Add(read["parkyeri"].ToStrıng());
            }
            baglanti.close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.open();,
            sqlcommand komut = new sqlcommand("insert into arac_otopark_kaydı(ad,soyad,telefon,email,plaka,marka,seri,renk,parkyeri,tarih ) values(@ad,@soyad,@telefon,@email,@plaka,@marka,@seri,@renk,@parkyeri,@tarih )" , baglanti);
            komut.parameters.addwithvalue("@Tc", textBox6.Text);
            komut.parameters.addwithvalue("@Ad", textBox7.Text);
            komut.parameters.addwithvalue("@Soyad", textBox1.Text);
            komut.parameters.addwithvalue("@telefon", textBox5.Text);
            komut.parameters.addwithvalue("@email", textBox4.Text);
            komut.parameters.addwithvalue("@plaka", textBox3.Text);
            komut.parameters.addwithvalue("@marka", combomarka.Text);
            komut.parameters.addwithvalue("@seri", comboset.Text);
            komut.parameters.addwithvalue("@parkyeri",comboparkyeri.Text);
            komut.parameters.addwithvalue("@tarih", DateTime.Now.ToString());

            komut.ExecuteNonQuery();
            baglanti.close();
            MessageBox.Show("Araç Kaydı Oluşturuldu");
            comboparkyeri.Items.Clear();
        }
    }
}
