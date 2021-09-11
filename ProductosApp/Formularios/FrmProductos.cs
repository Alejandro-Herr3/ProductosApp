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
    public partial class FrmProductos : Form
    {
        private ProductoModel productoModel;
        private Producto[] productos;
        public FrmProductos()
        {
            productoModel = new ProductoModel();
            InitializeComponent();
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            cmbMeasureUnit.Items.AddRange(Enum.GetValues(typeof(UnidadMedida)).Cast<object>().ToArray());
        }

        private void cmbFinder_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbFinder.SelectedIndex)
            {
                case 0:
                    txtID.Visible = true;
                    cmbMeasureUnit.Visible = false;
                    nudMaximo.Visible = false;
                    nudMinino.Visible = false;
                    dtpCaducidad.Visible = false;

                    break;
                case 1:
                    cmbMeasureUnit.Visible = true;
                    txtID.Visible = false;
                    nudMaximo.Visible = false;
                    nudMinino.Visible = false;
                    dtpCaducidad.Visible = false;
                    break;
                case 2:
                    nudMaximo.Visible = true;
                    nudMinino.Visible = true;
                    cmbMeasureUnit.Visible = false;
                    dtpCaducidad.Visible = false;
                    txtID.Visible = false;
                    break;
                case 3:
                    dtpCaducidad.Visible = true;
                    nudMaximo.Visible = false;
                    nudMinino.Visible = false;
                    cmbMeasureUnit.Visible = false;
                    txtID.Visible = false;
                    break;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FrmDatosProducto frmDatosProducto = new FrmDatosProducto();
            frmDatosProducto.pModel = productoModel;
            frmDatosProducto.ShowDialog();

            string json = string.Empty;

            productos = productoModel.GetAll();

            for (int i = 0; i < productos.Length; i++)
            {
                json = $@"{json}{productoModel.GetProductosAsJason(productos[i])}";
            }
            rtbProdcutoView.Text = json;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            switch (cmbFinder.SelectedIndex)
            {
                case 0:
                    int idint;
                    int.TryParse(txtID.Text, out idint);
                    string id = string.Empty;
                    id = $@"{id}{productoModel.ConvertirBusqueda(productoModel.GetProductosById(idint))}";
                    MessageBox.Show($"{id}");
                    break;
                case 1:
                    string unidad = string.Empty;
                    unidad = $@"{unidad}{productoModel.ConvertirBusqueda(productoModel.GetProductosByUnidadMedida((UnidadMedida)cmbMeasureUnit.SelectedIndex))}";
                    MessageBox.Show($"{unidad}");
                    break;
                case 2:
                    string valor = string.Empty;
                    valor = $@"{valor}{productoModel.ConvertirBusqueda(productoModel.GetProductosByRangoPrecio(nudMinino.Value, nudMaximo.Value))}";
                    MessageBox.Show($"{valor}");
                    break;
                case 3:
                    string fecha = string.Empty;
                    fecha = $@"{fecha}{productoModel.ConvertirBusqueda(productoModel.GetProductosByFechaVencimiento(dtpCaducidad.Value))}";
                    MessageBox.Show($"{fecha}");
                    break;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FrmDatosProducto frmDatosProducto = new FrmDatosProducto();
            frmDatosProducto.pModel = productoModel;
            frmDatosProducto.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            FrmDatosProducto frmDatosProducto = new FrmDatosProducto();
            frmDatosProducto.pModel = productoModel;
            frmDatosProducto.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
