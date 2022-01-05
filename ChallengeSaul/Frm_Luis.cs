using ChallengeSaul.Model;
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
        public Frm_Luis()
        {
            InitializeComponent();
        }

        private void sincronizandoListasConGrafico()
        {
          if(Grafica.Series.Count > 0)
            {
                Grafica.Series.Clear();
            }

            
            for (int i = 0; i < EjeY.Count; i++)
            {
                Grafica.Series.Add($"Series{i+1}");
                Grafica.Series["Series1"].Points.AddXY(i+1, EjeY.ElementAt(i));
           
            }
        }

        private void ObtenerLista(int n)
        {
            Collatz.number_collatz(n);
            EjeY = Collatz.y_axis;
            lbl2n.Text = Collatz.par_count + "";
            lbl3n1.Text = Collatz.impar_count + "";
            lblTotal.Text = Collatz.count + "";

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

        private void nudNumero_ValueChanged(object sender, EventArgs e)
        {
            ObtenerLista(Int32.Parse(nudNumero.Value.ToString()));
            sincronizandoListasConGrafico();
        }
    }
        
}
