using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ChallengeSaul
{
    public partial class Frm_Luis : Form
    {
        List<int> EjeY = new List<int>();
        List<int> EjeX = new List<int>();

        public Frm_Luis()
        {
            InitializeComponent();
            nudNumero.Maximum = Int32.MaxValue;
        }

        private void sincronizandoListasConGrafico()
        {
          if(Grafica.Series.Count > 0)
            {
                Grafica.Series.Clear();
            }

            Series s;
            for (int i = 0; i < EjeY.Count; i++)
            {
                s = Grafica.Series.Add(EjeX.ElementAt(i).ToString());
                s.Points.Add(EjeY.ElementAt(i));
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JPeg Imagen|*.jpg|PNG Imagen|*.png";
            saveFileDialog.Title = "Guardar gráfico como imagen";
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName != "")
            {
                System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog.OpenFile();
                switch (saveFileDialog.FilterIndex)
                {
                    case 1:
                        Grafica.SaveImage(fs, ChartImageFormat.Jpeg);
                        break;
                   
                    case 2:
                        Grafica.SaveImage(fs, ChartImageFormat.Png);
                        break;
                }
                fs.Close();
            }
        }
    }
        
}
