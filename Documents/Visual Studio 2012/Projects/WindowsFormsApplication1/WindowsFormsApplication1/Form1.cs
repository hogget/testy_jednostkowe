using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using HtmlAgilityPack;
using System.Net;
using System.Web;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public string GetPageHtml(String _url)
        {
            using (var wc = new WebClient())
            {
                // Ustawiamy prawidłowe kodowanie dla tej strony
                wc.Encoding = Encoding.UTF8;
                // Dekodujemy HTML do czytelnych dla wszystkich znaków 
                var html = System.Net.WebUtility.HtmlDecode(wc.DownloadString(_url));
                return html;
            }
        }

        private void Pobierz_obrazek(String nazwa_strony)
        {

        }

        private void Send_email(String email, String tresc)
        {

            MailMessage mail = new MailMessage("aga.michalik788@gmail.com", email);
            mail.Subject = "Powiadomienie";
            mail.Body = tresc;

            SmtpClient client = new SmtpClient();
            client.Host = "smtp.gmail.com";
            client.Port = 587;
            client.UseDefaultCredentials = false; // domyslnie false 
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential("aga.michalik788@gmail.com", "javaandfriends");
               //try - catch
            try
            {
                client.Send(mail);
                MessageBox.Show("Wysłano maila");
            }
            catch (Exception ex)
            {
               // Console.WriteLine("Exception caught", ex.ToString());
                string a = ex.ToString();
                MessageBox.Show(a);
            }
        }

        private void start_Click(object sender, EventArgs e)
        {
            String adres = Adres_strony.Text;
            String email = Email.Text;
            String klucz = Klucz.Text;

            var doc = new HtmlAgilityPack.HtmlDocument();
            var pageHtml = GetPageHtml(adres);
            doc.LoadHtml(pageHtml);
            var nodes = doc.DocumentNode.Descendants("img");

            foreach (var node in nodes)
            {
                var Value1 = node.GetAttributeValue("alt", "");
                bool znalezionoObrazekZSzukanymKluczem = Value1.Substring(0, Value1.Length).Contains(klucz);

                if (znalezionoObrazekZSzukanymKluczem)
                    //sprobujmy 
                    Klucz.Text = node.GetAttributeValue("src", "");
                    //Send_email(email, node.GetAttributeValue("src", ""));
            }
        }

        private void Adres_strony_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


    }
}
