using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WebBrow
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            KeyDown += (s,e) => { if (e.KeyValue == (char)Keys.Enter) goButton.PerformClick(); };
            KeyDown += (s, e) => { if (e.KeyValue == (char)Keys.F5) plusButton.PerformClick(); };
          //  tekylistBox.Items.AddRange(File.ReadAllLines("save-pages.txt"));
          //  richTextBox1.Text = File.ReadAllText("history.txt");
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            webControl1.GoBack();
        }

        private void forwardButton_Click(object sender, EventArgs e)
        {
            webControl1.GoForward();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            webControl1.Refresh();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            webControl1.Stop();
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            tekylistBox.Items.Add(poisktoolStripTextBox1.Text);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = tekylistBox.SelectedIndex;
            try
            {
                Uri uri = new Uri(tekylistBox.Items[index].ToString());
                webControl1.Source = uri;
            }
            catch (Exception)
            {
                Uri uri = new Uri("https://ya.ru");
                webControl1.Source = uri;
            }
        }

        private void goButton_Click(object sender, EventArgs e)
        {
           if( tekylistBox.Text.Contains("https://") || tekylistBox.Text.Contains("http://") )
           {
                int index = tekylistBox.SelectedIndex;
                string namesite = poisktoolStripTextBox1.Text;
                try
                {
                    Uri uri = new Uri(namesite);
                    webControl1.Source = uri;
                    tekylistBox.Items[tekylistBox.SelectedIndex] = namesite;
                }
                catch (Exception)
                {
                    Uri uri = new Uri("https://ya.ru");
                    webControl1.Source = uri;
                    MessageBox.Show("Неверный адрес");
                }
                File.AppendAllText("history.txt", poisktoolStripTextBox1.Text + "\n");
                richTextBox1.Text = File.ReadAllText("history.txt");
            }
            else
            {
                Uri uri = new Uri("https://yandex.ru/search/?text=" + poisktoolStripTextBox1.Text);
                webControl1.Source = uri;
                File.AppendAllText("history.txt", "yanfex " + poisktoolStripTextBox1.Text + "\n");
                richTextBox1.Text = File.ReadAllText("history.txt");
            }

        }

        private void сохранитьВкладкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            File.AppendAllText("save-pages.txt", tekylistBox.Items[tekylistBox.SelectedIndex].ToString() + "\n");
            savelistBox.Items.Add(tekylistBox.Items[tekylistBox.SelectedIndex].ToString());
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tekylistBox.Items.RemoveAt(tekylistBox.SelectedIndex);
        }

        private void удалитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            savelistBox.Items.RemoveAt(savelistBox.SelectedIndex);
        }

        private void poisktoolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string[] history_searche = File.ReadAllLines("history.txt");
                AutoCompleteStringCollection str = new AutoCompleteStringCollection();
                foreach (string ste in history_searche)
                {
                    var ste2 = ste.Replace("yandex", "").Trim();
                    str.Add(ste2);
                }
                poisktoolStripTextBox1.AutoCompleteCustomSource = str;
            }
            catch (Exception) { };
        }

        private void cleanbutton_Click(object sender, EventArgs e)
        {
            File.WriteAllText("hisrory.txt", "");
            richTextBox1.Text = File.ReadAllText("histore.txt");
        }

        
    }
}
