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

namespace Notepad_
{
    public partial class Form1 : Form
    {
        public int I { get; set; } = 1;
        private string FilePath { get; set; }
        RichTextBox richTextBox1 = new RichTextBox();
        public Form1()
        {
            InitializeComponent();
            saveFileDialog1.FileName = "Новый";
            saveFileDialog1.Filter = "(*.txt)|*.txt|(*.rtf)|*.rtf";
            richTextBox1.Dock = DockStyle.Fill;
            if (string.IsNullOrEmpty(FilePath))
            {
                var a = new TabPage();
                a.Name = $"new_{I}";
                a.Text = $"new {I}";
                tabControl1.TabPages.Add(a);
                tabControl1.SelectTab(a);
                tabControl1.SelectedTab.Controls.Add(richTextBox1);
            }
        }
        // Подменю "Файл".
        private void fileMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (openStripMenuItem.Selected)
            {
                using (OpenFileDialog dialog = new OpenFileDialog())
                {
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        FilePath = dialog.FileName;
                        richTextBox1.Text = File.ReadAllText(FilePath);
                    }
                }
            }
            else if (saveStripMenuItem.Selected)
            {
                if (string.IsNullOrEmpty(FilePath))
                {
                    using (SaveFileDialog dialog = new SaveFileDialog())
                    {
                        if (dialog.ShowDialog() == DialogResult.OK)
                        {
                            FilePath = dialog.FileName;
                            richTextBox1.SaveFile(FilePath);
                        }
                    }
                }
                else
                {
                    File.WriteAllText(FilePath, richTextBox1.Text);
                }
            }
            else if (saveUsStripMenuItem.Selected)
            {
                using (SaveFileDialog dialog = new SaveFileDialog())
                {
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        FilePath = dialog.FileName;
                        richTextBox1.SaveFile(FilePath);
                    }
                }
            }
            else if (exitStripMenuItem.Selected)
            {
                Close();
            }
        }
        // Подменю "Правка".
        private void editMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (Undo.Selected)
            {
                richTextBox1.Undo();
            }
            else if (Next.Selected)
            {
                richTextBox1.Redo();
            }
            else if (Cut.Selected)
            {
                richTextBox1.Cut();
            }
            else if (Copy.Selected)
            {
                richTextBox1.Copy();
            }
            else if (Paste.Selected)
            {
                richTextBox1.Paste();
            }
            else if (SelectAll.Selected)
            {
                richTextBox1.SelectAll();
            }
        }
        // Подменю "Шрифт".
        private void toolsMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (WordWrap.Selected)
            {
                WordWrap.Checked = !WordWrap.Checked;
                richTextBox1.WordWrap = WordWrap.Checked;
            }
            else if (Font.Selected)
            {
                using (FontDialog dialog = new FontDialog())
                {
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        richTextBox1.Font = dialog.Font;
                    }
                }
            }
        }
        // Подменю "Настройки".
        private void helpMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            MessageBox.Show("И так, это супер редактор текста Notepad++ второго поколения. Это бетта верси, надеюсь не будете критиковать сильно ))");
        }
        // Добавить вкладку.
        private void AddBox(object sender, EventArgs e)
        {
            I++;
            RichTextBox richTextBox1 = new RichTextBox();
            richTextBox1.Dock = DockStyle.Fill;
            var a = new TabPage();
            if (tabControl1.TabPages.Count == 1 && tabControl1.SelectedTab.Name == $"new_{I}")
            {
                I++;
            }
            a.Name = $"new_{I}";
            a.Text = $"new {I}";
            tabControl1.TabPages.Add(a);
            tabControl1.SelectTab(a.Name);
            tabControl1.SelectedTab.Controls.Add(richTextBox1);
            tabControl1.SelectTab($"new_{I - 1}");
            tabControl1.SelectTab(a.Name);
        }
        // Удалить вкладку.
        private void RemuveBox(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.Count > 1)
            {
                I--;
                tabControl1.TabPages.Remove(tabControl1.SelectedTab);
            }
        }

        // Выбор вкладки.
        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            tabControl1.SelectedTab.Controls.Add(richTextBox1);
        }
    }
}