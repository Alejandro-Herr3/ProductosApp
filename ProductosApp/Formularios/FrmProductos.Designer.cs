
namespace ProductosApp.Formularios
{
    partial class FrmProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbFinder = new System.Windows.Forms.ComboBox();
            this.cmbMeasureUnit = new System.Windows.Forms.ComboBox();
            this.rtbProdcutoView = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.nudMinino = new System.Windows.Forms.NumericUpDown();
            this.nudMaximo = new System.Windows.Forms.NumericUpDown();
            this.dtpCaducidad = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaximo)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbFinder
            // 
            this.cmbFinder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFinder.FormattingEnabled = true;
            this.cmbFinder.Items.AddRange(new object[] {
            "ID",
            "Unidad de Medida",
            "Rango de Precio",
            "Fecha de Vencimiento"});
            this.cmbFinder.Location = new System.Drawing.Point(12, 12);
            this.cmbFinder.Name = "cmbFinder";
            this.cmbFinder.Size = new System.Drawing.Size(159, 21);
            this.cmbFinder.TabIndex = 0;
            this.cmbFinder.SelectedIndexChanged += new System.EventHandler(this.cmbFinder_SelectedIndexChanged);
            // 
            // cmbMeasureUnit
            // 
            this.cmbMeasureUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMeasureUnit.FormattingEnabled = true;
            this.cmbMeasureUnit.Location = new System.Drawing.Point(177, 12);
            this.cmbMeasureUnit.Name = "cmbMeasureUnit";
            this.cmbMeasureUnit.Size = new System.Drawing.Size(308, 21);
            this.cmbMeasureUnit.TabIndex = 1;
            this.cmbMeasureUnit.Visible = false;
            // 
            // rtbProdcutoView
            // 
            this.rtbProdcutoView.Location = new System.Drawing.Point(12, 39);
            this.rtbProdcutoView.Name = "rtbProdcutoView";
            this.rtbProdcutoView.Size = new System.Drawing.Size(554, 248);
            this.rtbProdcutoView.TabIndex = 2;
            this.rtbProdcutoView.Text = "";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnNew);
            this.flowLayoutPanel1.Controls.Add(this.btnUpdate);
            this.flowLayoutPanel1.Controls.Add(this.btnDelete);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 293);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(554, 39);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(3, 3);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "Nuevo";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(84, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Editar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(165, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(177, 13);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(308, 20);
            this.txtID.TabIndex = 4;
            this.txtID.Visible = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(491, 13);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // nudMinino
            // 
            this.nudMinino.Location = new System.Drawing.Point(177, 12);
            this.nudMinino.Name = "nudMinino";
            this.nudMinino.Size = new System.Drawing.Size(153, 20);
            this.nudMinino.TabIndex = 6;
            this.nudMinino.Visible = false;
            // 
            // nudMaximo
            // 
            this.nudMaximo.Location = new System.Drawing.Point(336, 12);
            this.nudMaximo.Name = "nudMaximo";
            this.nudMaximo.Size = new System.Drawing.Size(149, 20);
            this.nudMaximo.TabIndex = 6;
            this.nudMaximo.Visible = false;
            // 
            // dtpCaducidad
            // 
            this.dtpCaducidad.Location = new System.Drawing.Point(177, 13);
            this.dtpCaducidad.Name = "dtpCaducidad";
            this.dtpCaducidad.Size = new System.Drawing.Size(308, 20);
            this.dtpCaducidad.TabIndex = 7;
            this.dtpCaducidad.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(246, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 345);
            this.Controls.Add(this.dtpCaducidad);
            this.Controls.Add(this.nudMaximo);
            this.Controls.Add(this.nudMinino);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.rtbProdcutoView);
            this.Controls.Add(this.cmbMeasureUnit);
            this.Controls.Add(this.cmbFinder);
            this.Name = "FrmProductos";
            this.Text = "Manejo de Productos";
            this.Load += new System.EventHandler(this.FrmProductos_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudMinino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaximo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbFinder;
        private System.Windows.Forms.ComboBox cmbMeasureUnit;
        private System.Windows.Forms.RichTextBox rtbProdcutoView;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.NumericUpDown nudMinino;
        private System.Windows.Forms.NumericUpDown nudMaximo;
        private System.Windows.Forms.DateTimePicker dtpCaducidad;
        private System.Windows.Forms.Button button1;
    }
}