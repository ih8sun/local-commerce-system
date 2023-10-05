﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Entidad;
using Negocio;

namespace Presentacion
{
    public partial class Frm_Categoria : Form
    {

        cnCategoria lista_neg = new cnCategoria();

        private Entidad.Categoria regActual;


        public Frm_Categoria()
        {
            InitializeComponent();
        }

        private void txtconsultar_TextChanged(object sender, EventArgs e)
        {
            listado();
        }
        private void listado()
        {
            DataTable dt = new DataTable();
            String dato = txtconsultar.Text;
            dt = lista_neg.Buscar(dato);
            gdvCliente.DataSource = dt;

        }
        private void limpiar()
        {

            txtcodigo.Text = "";
            txtconsultar.Text = "";
            txtdescripcion.Text = "";
            txtestado.Text = "";

            Button2.Enabled = true;
            Button3.Enabled = false;
            Button4.Enabled = false;
        }
        private void Frm_Categoria_Load(object sender, EventArgs e)
        {
            listado();

            Button2.Enabled = true;
            Button3.Enabled = false;
            Button4.Enabled = false;

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea Salir de Registro ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.No)
            {

                return;



            }

            this.Dispose();
            this.Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            listado();

            limpiar();
            Button2.Enabled = true;
            Button3.Enabled = false;
            Button4.Enabled = false;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            var oEntidad = new Entidad.Categoria();
            try
            {
                if (string.IsNullOrWhiteSpace(txtdescripcion.Text))
                {
                    MessageBox.Show("Debe Ingresar los Datos", "Aviso...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txtdescripcion.TextLength < 4)
                {
                    MessageBox.Show("La categoria debe de tener como minimo 4 caracteres", "Aviso...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {


                    if (regActual != null)

                        oEntidad.idcodigo = regActual.idcodigo;

                    oEntidad.idcodigo = txtcodigo.Text.Trim();
                    oEntidad.nombres = txtdescripcion.Text.Trim();
                    oEntidad.estado = txtestado.Text.Trim();


                    bool result = Negocio.cnCategoria.Grabar(oEntidad, true);
                    if (result)
                    {
                        MessageBox.Show("Datos Registrados Correctamente", "Aviso...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        listado();
                        limpiar();
                        Button2.Enabled = true;
                        Button3.Enabled = false;
                        Button4.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Ya existe un registro con la misma categoria", "Aviso...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally 
            { 
                oEntidad = null; 
            }
               
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            var oEntidad = new Entidad.Categoria();
            try
            {
                if (string.IsNullOrWhiteSpace(txtdescripcion.Text))
                {
                    MessageBox.Show("Debe Ingresar los Datos", "Aviso...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txtdescripcion.TextLength < 4)
                {
                    MessageBox.Show("La categoria debe de tener como minimo 4 caracteres", "Aviso...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {


                    if (regActual != null)

                        oEntidad.idcodigo = regActual.idcodigo;

                    oEntidad.idcodigo = txtcodigo.Text.Trim();
                    oEntidad.nombres = txtdescripcion.Text.Trim();
                    oEntidad.estado = txtestado.Text.Trim();


                    bool result = Negocio.cnCategoria.Grabar(oEntidad, false);
                    if (result)
                    {
                        MessageBox.Show("Datos Registrados Correctamente", "Aviso...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        listado();
                        limpiar();
                        Button2.Enabled = true;
                        Button3.Enabled = false;
                        Button4.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Ya existe un registro con la misma categoria", "Aviso...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                oEntidad = null;
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtdescripcion.Text))
            {
                MessageBox.Show("Debe Ingresar los Datos", "Aviso...", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                var oEntidad = new Entidad.Categoria();

                if (regActual != null)

                    oEntidad.idcodigo = regActual.idcodigo;

                oEntidad.idcodigo = txtcodigo.Text.Trim();
                oEntidad.estado = txtestado.Text.Trim();


                try
                {
                    MessageBox.Show("Se cambio de estado", "Aviso...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Negocio.cnCategoria.Cambiar(oEntidad);


                }
                catch (Exception ex)
                {
                }
                finally { oEntidad = null; }
                listado();
                limpiar();
                Button2.Enabled = true;
                Button3.Enabled = false;
                Button4.Enabled = false;
            }
        }

        private void gdvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcodigo.Text = gdvCliente.CurrentRow.Cells["codigo"].Value.ToString();
            txtdescripcion.Text = gdvCliente.CurrentRow.Cells["categoria"].Value.ToString();
            txtestado.Text = gdvCliente.CurrentRow.Cells["estado"].Value.ToString();

            Button3.Enabled = true;
            Button4.Enabled = true;
            Button2.Enabled = false;
        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtdescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtdescripcion.Text.Length == 50 && e.KeyChar != (char)Keys.Back)
            {
                MessageBox.Show("La categoria solo debe tener 50 caracteres máximo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;

                MessageBox.Show("Solo se Ingresa Letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);



            }
        }
    }
}
