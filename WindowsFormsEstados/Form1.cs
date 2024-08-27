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

            if (cmbEstado.SelectedIndex != -1)
            {
                string est = cmbEstado.SelectedItem.ToString();
                if (est == "DF" | est == "GO" | est == "MT" | est == "MS")
                {
                    cmbCentro.Items.Add(cmbEstado.SelectedItem.ToString());
                    cmbEstado.Items.Remove(cmbEstado.SelectedItem);
                    lblEstado.Text = cmbEstado.Items.Count.ToString();
                    lblCentro.Text = cmbCentro.Items.Count.ToString();

                }
                else if (est == "PL" | est == "RS" | est == "SC")
                {
                    cmbSul.Items.Add(cmbEstado.SelectedItem.ToString());
                    cmbEstado.Items.Remove(cmbEstado.SelectedItem);
                    lblEstado.Text = cmbEstado.Items.Count.ToString();
                    lblSul.Text = cmbSul.Items.Count.ToString();
                }
                else if (est == "SP" | est == "RJ" | est == "ES")
                {
                    cmbSuldeste.Items.Add(cmbEstado.SelectedItem.ToString());
                    cmbEstado.Items.Remove(cmbEstado.SelectedItem);
                    lblEstado.Text = cmbEstado.Items.Count.ToString();
                    lblSuldeste.Text = cmbSuldeste.Items.Count.ToString();
                }
                else if (est == "AM" | est == "RR" | est == "AP" | est == "PA" | est == "TO" | est == "RO" | est == "AC")
                {
                    cmbNorte.Items.Add(cmbEstado.SelectedItem.ToString());
                    cmbEstado.Items.Remove(cmbEstado.SelectedItem);
                    lblEstado.Text = cmbEstado.Items.Count.ToString();
                    lblNorte.Text = cmbNorte.Items.Count.ToString();
                }
                else if (est == "MA" | est == "PI" | est == "CE" | est == "RN" | est == "PE" | est == "PB" | est == "SE" | est == "AL" | est == "BA")
                {
                    cmbNordeste.Items.Add(cmbEstado.SelectedItem.ToString());
                    cmbEstado.Items.Remove(cmbEstado.SelectedItem);
                    lblEstado.Text = cmbEstado.Items.Count.ToString();
                    lblNordeste.Text = cmbNordeste.Items.Count.ToString();
                }


            }
            else
            {
                cmbEstado.Focus();
            }
        }

        private void btnNorte_Click(object sender, EventArgs e)
        {
            if (cmbNorte.SelectedIndex != -1)
            {
                cmbEstado.Items.Add(cmbNorte.SelectedItem.ToString());
                cmbNorte.Items.Remove(cmbNorte.SelectedItem);
                lblNorte.Text = cmbNorte.Items.Count.ToString();
                lblEstado.Text = cmbEstado.Items.Count.ToString();
            }
            else
            {
                cmbNorte.Focus();
            }

        }

        private void btnNordeste_Click(object sender, EventArgs e)
        {
            if (cmbNordeste.SelectedIndex != -1)
            {
                cmbEstado.Items.Add(cmbNordeste.SelectedItem.ToString());
                cmbNordeste.Items.Remove(cmbNordeste.SelectedItem);
                lblNordeste.Text = cmbNordeste.Items.Count.ToString();
                lblEstado.Text = cmbEstado.Items.Count.ToString();
            }
            else
            {
                cmbNordeste.Focus();
            }

        }

        private void btnCentro_Click(object sender, EventArgs e)
        {
            if (cmbCentro.SelectedIndex != -1)
            {
                cmbEstado.Items.Add(cmbCentro.SelectedItem.ToString());
                cmbCentro.Items.Remove(cmbCentro.SelectedItem);
                lblCentro.Text = cmbCentro.Items.Count.ToString();
                lblEstado.Text = cmbEstado.Items.Count.ToString();

            }
            else
            {
                cmbCentro.Focus();
            }
        }

        private void btnSudeste_Click(object sender, EventArgs e)
        {
            if (cmbSuldeste.SelectedIndex != -1)
            {
                cmbEstado.Items.Add(cmbSuldeste.SelectedItem.ToString());
                cmbSuldeste.Items.Remove(cmbSuldeste.SelectedItem);
                lblSuldeste.Text = cmbSuldeste.Items.Count.ToString();
                lblEstado.Text = cmbEstado.Items.Count.ToString();
            }
            else
            {
                cmbSuldeste.Focus();
            }

        }

        private void btnSul_Click(object sender, EventArgs e)
        {
            if (cmbSul.SelectedIndex != -1)
            {
                cmbEstado.Items.Add(cmbSul.SelectedItem.ToString());
                cmbSul.Items.Remove(cmbSul.SelectedItem);
                lblSul.Text = cmbSul.Items.Count.ToString();
                lblEstado.Text = cmbEstado.Items.Count.ToString();
            }
            else
            {
                cmbSul.Focus();
            }

        }
    }
}
