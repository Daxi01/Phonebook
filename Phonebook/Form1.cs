using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phonebook
{
    public partial class Phonebook : Form
    {
        string path = "C:/Users/daxi0/source/repos/Phonebook/Phonebook/data.txt";

        public Phonebook()
        {
            InitializeComponent();

            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)  //btn_save, nevim jak prejmenovat
        {
            if(lb_udaje.SelectedIndex != -1)
            {
                Kontakt selectedContact = (Kontakt)lb_udaje.SelectedItem;

                tb_name.Text = selectedContact.name;
                tb_surname.Text = selectedContact.surname;
                tb_prefix.Text = selectedContact.prefix.ToString();
                tb_phone.Text = selectedContact.phone.ToString();
                tb_email.Text = selectedContact.email;
                tb_job.Text = selectedContact.job;


            }
        }

        public void ZapsatSoubor()
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                foreach (var item in lb_udaje.Items)
                {
                    sw.WriteLine(item.ToString());
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if(lb_udaje.SelectedIndex != -1) 
            { 
                lb_udaje.Items.RemoveAt(lb_udaje.SelectedIndex);
                ZapsatSoubor();

                VymazTextFieldy();
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string name = tb_name.Text;
            string surname = tb_surname.Text;
            int prefix = int.Parse(tb_prefix.Text);
            int phone = int.Parse(tb_phone.Text);
            string email = tb_email.Text;
            string job = tb_job.Text;

            Kontakt kontakt = new Kontakt(name, surname, email, prefix, phone, job);

            lb_udaje.Items.Add(kontakt);
            ZapsatSoubor();
            VymazTextFieldy();
        }

        private void LoadData()
        {
            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);

                foreach (string line in lines)
                {
                    Kontakt kontakt = ParseLineToContact(line);
                    if(kontakt != null) 
                    { 
                    lb_udaje.Items.Add(kontakt);
                    }
                }
            }
        }

        private Kontakt ParseLineToContact(string line)
        {
            string[] parts = line.Split('-');

            if (parts.Length == 6)
            {
                string name = parts[0];
                string surname = parts[1];
                int prefix = int.Parse(parts[2]);
                int phone = int.Parse(parts[3]);
                string email = parts[4];
                string job = parts[5];

                return new Kontakt(name, surname, email, prefix, phone, job);
            }
            else
            {
                return null;
            }
        }

        private void VymazTextFieldy()
        {
            tb_name.Clear();
            tb_surname.Clear();
            tb_prefix.Clear();
            tb_phone.Clear();
            tb_email.Clear();
            tb_job.Clear(); 
        }
    }

}
