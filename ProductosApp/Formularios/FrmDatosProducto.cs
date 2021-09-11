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
    }   
}
