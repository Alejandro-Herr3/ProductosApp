using Domain.Entities;
using Domain.Enums;
using Infraestructure.Productos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductosApp.Formularios
{
    public partial class FrmDatosProducto: Form
    {
        public ProductoModel pModel { get; set; }
        public FrmDatosProducto()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtNombre == null || txtDescripcion == null || nudExistencia == null || nudPrecio == null || dtpVencimiento == null || cmbMeaureUnit == null)
            {
                throw new ArgumentException("Todos los campos deben tener su respectivos datos"); 
            }

            Producto p = new Producto()
            {
                Id = pModel.GetLastProductId() + 1,
                Nombre = txtNombre.Text,
                Descripcion = txtDescripcion.Text,
                Existencia = (int)nudExistencia.Value,
                Precio = nudPrecio.Value,
                Vencimiento = dtpVencimiento.Value,
                UnidadMedida = (UnidadMedida)cmbMeaureUnit.SelectedIndex
            };

            pModel.Add(p);

            Dispose();
        }

        private void FrmDatosProducto_Load(object sender, EventArgs e)
        {
            cmbMeaureUnit.Items.AddRange(Enum.GetValues(typeof(UnidadMedida)).Cast<object>().ToArray());
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id;
            int.TryParse(txtidbuscar.Text, out id);
            Producto p = new Producto();
            p = pModel.Actualizar(id);
            txtNombre.Text = p.Nombre;
            txtDescripcion.Text = p.Descripcion;
            nudExistencia.Value = p.Existencia;
            nudPrecio.Value = p.Precio;
            dtpVencimiento.Value = p.Vencimiento;
            cmbMeaureUnit.SelectedItem = p.UnidadMedida;

            p = new Producto()
            {
                Nombre = txtNombre.Text,
                Descripcion = txtDescripcion.Text,
                Existencia = (int)nudExistencia.Value,
                Precio = nudPrecio.Value,
                Vencimiento = dtpVencimiento.Value,
                UnidadMedida = (UnidadMedida)cmbMeaureUnit.SelectedIndex
            };
            pModel.Update(p);

            Dispose();
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            int id;
            int.TryParse(txtidbuscar.Text, out id);
            Producto p = new Producto();
            p = pModel.Actualizar(id);
            txtNombre.Text = p.Nombre;
            txtDescripcion.Text = p.Descripcion;
            nudExistencia.Value = p.Existencia;
            nudPrecio.Value = p.Precio;
            dtpVencimiento.Value = p.Vencimiento;
            cmbMeaureUnit.SelectedItem = p.UnidadMedida;

            pModel.Delete(p);

            Dispose();
        }
    }   
}
