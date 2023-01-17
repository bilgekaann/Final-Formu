using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkulProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void SetStatus(ToolStripMenuItem toolStripMenuItem)
        {
            toolStripStatusLabel1.Text = toolStripMenuItem.Text + "Tıklandı";
        }

        private void öğrenciPaneliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ogr = new OgrenciPanel();
            ogr.MdiParent = this;
            ogr.Show();
            SetStatus((ToolStripMenuItem)sender);
        }

        private void öğrenciDersPaneliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ogrders = new OgrenciDersPanel();
            ogrders.MdiParent = this;
            ogrders.Show();
            SetStatus((ToolStripMenuItem)sender);
        }

        private void okulYönetimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var yonetim = new OkulYonetim();
            yonetim.MdiParent = this;
            yonetim.Show();
            SetStatus((ToolStripMenuItem)sender);
        }

        private void dersPaneliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ders = new DersPaneli();
            ders.MdiParent = this;
            ders.Show();
            SetStatus((ToolStripMenuItem)sender);
        }
    }
}
