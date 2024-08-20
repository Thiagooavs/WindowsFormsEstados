using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsEstados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblEstado.Text = cmbEstado.Items.Count.ToString();
        }

        private void bntEstado_Click(object sender, EventArgs e)
        {
            string est = cmbEstado.SelectedItem.ToString();
             
            if( est == "DF" | est == "GO" | est == "MT" | est == "MS")
            {
                cmbCentro.Items.Add(cmbEstado.SelectedItem.ToString());
                cmbEstado.Items.Remove(cmbEstado.SelectedItem);
                lblEstado.Text = cmbEstado.Items.Count.ToString();
                lblCentro.Text = cmbCentro.Items.Count.ToString();
            }
            else if(est == "PL" | est == "RS" | est == "SC")
            {
                cmbCentro.Items.Add(cmbEstado.SelectedItem.ToString());
                cmbEstado.Items.Remove(cmbEstado.SelectedItem);
                lblEstado.Text = cmbEstado.Items.Count.ToString();
                lblCentro.Text = cmbCentro.Items.Count.ToString();
            }
        }

        private void btnNorte_Click(object sender, EventArgs e)
        {
            cmbEstado.Items.Add(cmbNorte.SelectedItem.ToString()); 
            cmbNorte.Items.Remove(cmbNorte.SelectedItem);
            lblNorte.Text = cmbNorte.Items.Count.ToString();    
        }

        private void btnNordeste_Click(object sender, EventArgs e)
        {
            cmbEstado.Items.Add(cmbNordeste.SelectedItem.ToString());
            cmbNordeste.Items.Remove(cmbNordeste.SelectedItem);
            lblNordeste.Text = cmbNordeste.Items.Count.ToString();
        }

        private void btnCentro_Click(object sender, EventArgs e)
        {
            cmbEstado.Items.Add(cmbCentro.SelectedItem.ToString());
            cmbCentro.Items.Remove(cmbCentro.SelectedItem);
            lblCentro.Text = cmbCentro.Items.Count.ToString();
        }

        private void btnSudeste_Click(object sender, EventArgs e)
        {
            cmbEstado.Items.Add(cmbSuldeste.SelectedItem.ToString());
            cmbSuldeste.Items.Remove(cmbSuldeste.SelectedItem);
            lblSuldeste.Text = cmbSuldeste.Items.Count.ToString();
        }

        private void btnSul_Click(object sender, EventArgs e)
        {
            cmbEstado.Items.Add(cmbSul.SelectedItem.ToString());
            cmbSul.Items.Remove(cmbSul.SelectedItem);
            lblSul.Text = cmbSul.Items.Count.ToString();
        }
    }
}
