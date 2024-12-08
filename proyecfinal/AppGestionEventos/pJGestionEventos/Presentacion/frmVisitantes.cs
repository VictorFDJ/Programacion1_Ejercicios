using pJGestionEventos.Datos;
using pJGestionEventos.Etidades;
using pJGestionEventos.Presentacion.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pJGestionEventos.Presentacion
{
    public partial class frmVisitantes : Form
    {
        public frmVisitantes()
        {
            InitializeComponent();
        }
        #region "variables"
        int icodigoVisitante = 0;
        bool eEstadoGuardar = true;
        #endregion



        #region "Metodos"
        private void CargarVisitantes(string cBuscar)
        {
            D_Visitantes Datos = new D_Visitantes();
            dtvLista.DataSource = Datos.Lista_Visitantes(cBuscar);
            FormatoListaVisitantes9();
            
        }

        private void FormatoListaVisitantes9() {
            dtvLista.Columns[0].Width = 45;
            dtvLista.Columns[1].Width = 140;
            dtvLista.Columns[2].Width = 240;
            dtvLista.Columns[3].Width = 160;
            dtvLista.Columns[4].Width = 150;

        }

        private void CargarEventos()
        {
            D_Eventos Datos = new D_Eventos();
            cbmEvento.DataSource = Datos.Lista_Eventos();
            cbmEvento.ValueMember = "id_evento";
            cbmEvento.DisplayMember = "nombre_evento";
            cbmEvento.SelectedIndex = -1;

        }
        private void ActivarTextos(bool bEstado)
        {

            txtNombre.Enabled = bEstado;
            txtDireccion.Enabled = bEstado;
            txtTelefono.Enabled = bEstado;
            dtmFecha.Enabled = bEstado;
            cbmEvento.Enabled = bEstado;
            txtBuscar.Enabled = !bEstado;

        }
        private void ActivarBotones(bool bEstado)
        {
            btnNuevo.Enabled = bEstado;
            btnActualizar.Enabled = bEstado;
            btnReporte.Enabled = bEstado;
            btnEliminar.Enabled = bEstado;


            btnGuardar.Visible = !bEstado;
            btnCancelar.Visible = !bEstado;


        }

        private void SelecionarVisitantes() {
            icodigoVisitante = Convert.ToInt32(dtvLista.CurrentRow.Cells["ID"].Value);
            txtNombre.Text = Convert.ToString(dtvLista.CurrentRow.Cells["Nombre"].Value);
            txtDireccion.Text = Convert.ToString(dtvLista.CurrentRow.Cells["Direccion"].Value);
            txtTelefono.Text = Convert.ToString(dtvLista.CurrentRow.Cells["Telefono"].Value);
            cbmEvento.Text = Convert.ToString(dtvLista.CurrentRow.Cells["Eventos"].Value);
            

        }
        private void Limpiar() {
            txtBuscar.Clear();
            txtNombre.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();

            cbmEvento.SelectedIndex = -1;
            icodigoVisitante = 0;
        }
        private void GuardarVisitantes()
        {
            V_Visitante visitante = new V_Visitante();
            visitante.nombre_visitante = txtNombre.Text;
            visitante.direccion_visi = txtDireccion.Text;
            visitante.fecha_nacimiento = dtmFecha.Value;
            visitante.telefono = txtTelefono.Text;
            visitante.id_evento =Convert.ToInt32(cbmEvento.SelectedValue);

            D_Visitantes Datos = new D_Visitantes();
            string respuesta = Datos.Guardar_Visitantes(visitante);
            if(respuesta == "OK")
            {

                CargarVisitantes("%");
                Limpiar();
                ActivarTextos(false);
                ActivarBotones(true);

                MessageBox.Show("Datos Guardados","SISTEMA DE GESTION DE EVENTOS",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show(respuesta, "SISTEMA DE GESTION DE EVENTOS", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }


        }
        private void ActualizarVisitantes()
        {
            V_Visitante visitante = new V_Visitante();
            visitante.ID_visitante = icodigoVisitante;
            visitante.nombre_visitante = txtNombre.Text;
            visitante.direccion_visi = txtDireccion.Text;
            visitante.fecha_nacimiento = dtmFecha.Value;
            visitante.telefono = txtTelefono.Text;
            visitante.id_evento = Convert.ToInt32(cbmEvento.SelectedValue);

            D_Visitantes Datos = new D_Visitantes();
            string respuesta = Datos.Actualizar_Visitantes(visitante);
            if (respuesta == "OK")
            {

                CargarVisitantes("%");
                Limpiar();
                ActivarTextos(false);
                ActivarBotones(true);

                MessageBox.Show("Datos Actualizados", "SISTEMA DE GESTION DE EVENTOS", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show(respuesta, "SISTEMA DE GESTION DE EVENTOS", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }


        }
        private void DesativarVisitantes(int iCodigoVisitante)
        {
            

            D_Visitantes Datos = new D_Visitantes();
            string respuesta = Datos.Desativar_Visitantes(iCodigoVisitante);
            if (respuesta == "OK")
            {

                CargarVisitantes("%");
                Limpiar();
                ActivarTextos(false);
                ActivarBotones(true);

                MessageBox.Show("Registro Eliminado", "SISTEMA DE GESTION DE EVENTOS", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show(respuesta, "SISTEMA DE GESTION DE EVENTOS", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }


        }


        private bool ValidarTextos()
        {
            bool hayTexto = false;
            if (string.IsNullOrEmpty(txtNombre.Text)) hayTexto = true;
            if (string.IsNullOrEmpty(txtDireccion.Text)) hayTexto = true;
            if (string.IsNullOrEmpty(txtTelefono.Text)) hayTexto = true;

            return hayTexto;

        }
        #endregion
        private void frmVisitantes_Load(object sender, EventArgs e)
        {
            CargarVisitantes("%");
            CargarEventos();

            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarVisitantes(txtBuscar.Text);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            eEstadoGuardar = true;
            icodigoVisitante = 0;
            

            ActivarTextos(true);
            ActivarBotones(false);
            txtNombre.Select();
            Limpiar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            eEstadoGuardar = true;
            icodigoVisitante = 0;

            ActivarTextos(false);
            ActivarBotones(true);
            Limpiar();
        }

        private void dtvLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelecionarVisitantes();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (icodigoVisitante == 0)
            {
                MessageBox.Show("Seleciona un registro","SISTEMA DE GESTION DE EVENTOS", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

            }
            else {
                eEstadoGuardar = false;
                ActivarTextos(true);
                ActivarBotones(false);
                txtNombre.Select();

            }

           

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarTextos())
            {
                MessageBox.Show("Hay campos vacios, debes llenar todos los campos obligatorios", "SISTEMA GESTION DE EVENTOS",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else {

                if (eEstadoGuardar)
                {

                    GuardarVisitantes();
                }
                else
                {
                    ActualizarVisitantes();

                }
                
            
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (icodigoVisitante == 0)
            {
                MessageBox.Show("Seleciona un registro", "SISTEMA DE GESTION DE EVENTOS", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

            }
            else
            {
                DialogResult resultado = MessageBox.Show("Esta seguro de eliminar este registro?", "SISTEMA DE GESTION DE EVENTOS", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information);
                if (resultado == DialogResult.Yes) {

                    DesativarVisitantes(icodigoVisitante);
                }


            }
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            rfmReporte reporte = new rfmReporte();
            reporte.txtFiltrar.Text = txtBuscar.Text;
            reporte.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

        
}
