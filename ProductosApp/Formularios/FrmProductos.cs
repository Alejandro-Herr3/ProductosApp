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
                    break;
                case 1:
                    cmbMeasureUnit.Visible = true;
                    break;
                case 2:
                    nudMaximo.Visible = true;
                    nudMinino.Visible = true;
                    break;
                case 3:
                    dtpCaducidad.Visible = true;
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
    }
}
