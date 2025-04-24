using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace OdevReflectionAcunMedya
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKlasorSec_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    listBox1.Items.Clear();
                    string[] klasorler = Directory.GetDirectories(fbd.SelectedPath);

                    foreach (string klasor in klasorler)
                    {
                        string klasorAdi = Path.GetFileName(klasor);
                        listBox1.Items.Add($"📁 {klasorAdi}");

                        string[] csDosyalari = Directory.GetFiles(klasor, "*.cs");
                        foreach (string dosya in csDosyalari)
                        {
                            string[] satirlar = File.ReadAllLines(dosya);
                            foreach (string satir in satirlar)
                            {
                                string trimmedLine = satir.Trim();
                                if (trimmedLine.StartsWith("public class") || trimmedLine.StartsWith("class"))
                                {
                                    string[] kelimeler = trimmedLine.Split(' ');
                                    int classIndex = Array.IndexOf(kelimeler, "class");
                                    if (classIndex != -1 && kelimeler.Length > classIndex + 1)
                                    {
                                        string classIsmi = kelimeler[classIndex + 1];
                                        listBox1.Items.Add($"   📄 {classIsmi}");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            var odemeYontemleri = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(x => x.GetTypes())
                .Where(t => typeof(IOdemeYontemi).IsAssignableFrom(t) && !t.IsInterface && !t.IsAbstract);

            foreach (var yontem in odemeYontemleri)
            {
                comboBox1.Items.Add(yontem.Name);
            }
        }
        private void btnOdemeYap_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir ödeme yöntemi seçiniz.");
                return;
            }

            if (!decimal.TryParse(textBox1.Text, out decimal tutar))
            {
                MessageBox.Show("Lütfen geçerli bir tutar giriniz.");
                return;
            }

            string secilenYontem = comboBox1.SelectedItem.ToString();
            var odemeTipi = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(x => x.GetTypes())
                .FirstOrDefault(t => t.Name == secilenYontem);

            if (odemeTipi != null)
            {
                IOdemeYontemi odemeNesnesi = (IOdemeYontemi)Activator.CreateInstance(odemeTipi);
                string sonuc = odemeNesnesi.Ode(tutar);
                label1.Text = sonuc;
            }
        }

        private void btnOdemeYap_Click_1(object sender, EventArgs e)
        {

        }
    }
}
