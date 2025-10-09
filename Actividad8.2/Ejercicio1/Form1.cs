using Ejercicio1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        List<Multa> multas;
        public Form1()
        {
            InitializeComponent();
            multas = new List<Multa>();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            IExportable nuevo = null;
            string patente;
            DateTime vencimiento;
            double importe;

            try
            {
                patente = tbPatente.Text;
                //vencimiento = Convert.ToDateTime( dtpVencimiento.Text);
                //vencimiento = dtpVencimiento.Value;
                vencimiento = new DateTime(dtpVencimiento.Value.Day,dtpVencimiento.Value.Month,dtpVencimiento.Value.Year);

                importe = Convert.ToDouble(tbImporte.Text);

                //Multa unaMulta = new Multa(patente, vencimiento, importe);
                //if (unaMulta != null ) { multas.Add(unaMulta); }
                
                nuevo = new Multa(patente, vencimiento, importe);

                //ver si es actualziar o es para agregar uno nuevo
                multas.Sort();
                int idx = multas.BinarySearch(nuevo);



            }
            catch (ValidaPatenteException pex) { MessageBox.Show(pex.Message, "Formato", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            catch(Exception ex) { MessageBox.Show(ex.Message, "UPs!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        
        }
    }
}
