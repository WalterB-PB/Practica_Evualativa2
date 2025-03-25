namespace PracticaEvualativa_2
{
    partial class FrmGestionReservaHotel
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtNumeroHabitacion = new System.Windows.Forms.TextBox();
            this.txtTiempoEstadia = new System.Windows.Forms.TextBox();
            this.lstFechaReserva = new System.Windows.Forms.ListBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.dtpFechaReserva = new System.Windows.Forms.DateTimePicker();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.lblNumeroHabitacion = new System.Windows.Forms.Label();
            this.lblFechaReserva = new System.Windows.Forms.Label();
            this.lblTiempoEstadia = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(88, 180);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(130, 20);
            this.txtNombreCliente.TabIndex = 0;
            this.txtNombreCliente.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtNumeroHabitacion
            // 
            this.txtNumeroHabitacion.Location = new System.Drawing.Point(292, 180);
            this.txtNumeroHabitacion.Name = "txtNumeroHabitacion";
            this.txtNumeroHabitacion.Size = new System.Drawing.Size(130, 20);
            this.txtNumeroHabitacion.TabIndex = 1;
            // 
            // txtTiempoEstadia
            // 
            this.txtTiempoEstadia.Location = new System.Drawing.Point(471, 180);
            this.txtTiempoEstadia.Name = "txtTiempoEstadia";
            this.txtTiempoEstadia.Size = new System.Drawing.Size(130, 20);
            this.txtTiempoEstadia.TabIndex = 2;
            this.txtTiempoEstadia.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lstFechaReserva
            // 
            this.lstFechaReserva.FormattingEnabled = true;
            this.lstFechaReserva.Location = new System.Drawing.Point(325, 218);
            this.lstFechaReserva.Name = "lstFechaReserva";
            this.lstFechaReserva.Size = new System.Drawing.Size(97, 56);
            this.lstFechaReserva.TabIndex = 3;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(143, 268);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(267, 290);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 5;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(415, 290);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(555, 268);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 7;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            // 
            // dtpFechaReserva
            // 
            this.dtpFechaReserva.Location = new System.Drawing.Point(267, 130);
            this.dtpFechaReserva.Name = "dtpFechaReserva";
            this.dtpFechaReserva.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaReserva.TabIndex = 8;
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Location = new System.Drawing.Point(85, 161);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(79, 13);
            this.lblNombreCliente.TabIndex = 9;
            this.lblNombreCliente.Text = "Nombre Cliente";
            this.lblNombreCliente.Click += new System.EventHandler(this.lblNombreCliente_Click);
            // 
            // lblNumeroHabitacion
            // 
            this.lblNumeroHabitacion.AutoSize = true;
            this.lblNumeroHabitacion.Location = new System.Drawing.Point(289, 161);
            this.lblNumeroHabitacion.Name = "lblNumeroHabitacion";
            this.lblNumeroHabitacion.Size = new System.Drawing.Size(111, 13);
            this.lblNumeroHabitacion.TabIndex = 10;
            this.lblNumeroHabitacion.Text = "Numero de habitacion";
            this.lblNumeroHabitacion.Click += new System.EventHandler(this.lblNumeroHabitacion_Click);
            // 
            // lblFechaReserva
            // 
            this.lblFechaReserva.AutoSize = true;
            this.lblFechaReserva.Location = new System.Drawing.Point(264, 114);
            this.lblFechaReserva.Name = "lblFechaReserva";
            this.lblFechaReserva.Size = new System.Drawing.Size(90, 13);
            this.lblFechaReserva.TabIndex = 11;
            this.lblFechaReserva.Text = "Fecha de reserva";
            // 
            // lblTiempoEstadia
            // 
            this.lblTiempoEstadia.AutoSize = true;
            this.lblTiempoEstadia.Location = new System.Drawing.Point(468, 161);
            this.lblTiempoEstadia.Name = "lblTiempoEstadia";
            this.lblTiempoEstadia.Size = new System.Drawing.Size(80, 13);
            this.lblTiempoEstadia.TabIndex = 12;
            this.lblTiempoEstadia.Text = "Tiempo Estadia";
            this.lblTiempoEstadia.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(289, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(155, 13);
            this.lblTitulo.TabIndex = 13;
            this.lblTitulo.Text = "Gestion de reservar en un hotel";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // FrmGestionReservaHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblTiempoEstadia);
            this.Controls.Add(this.lblFechaReserva);
            this.Controls.Add(this.lblNumeroHabitacion);
            this.Controls.Add(this.lblNombreCliente);
            this.Controls.Add(this.dtpFechaReserva);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lstFechaReserva);
            this.Controls.Add(this.txtTiempoEstadia);
            this.Controls.Add(this.txtNumeroHabitacion);
            this.Controls.Add(this.txtNombreCliente);
            this.Name = "FrmGestionReservaHotel";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtNumeroHabitacion;
        private System.Windows.Forms.TextBox txtTiempoEstadia;
        private System.Windows.Forms.ListBox lstFechaReserva;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.DateTimePicker dtpFechaReserva;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Label lblNumeroHabitacion;
        private System.Windows.Forms.Label lblFechaReserva;
        private System.Windows.Forms.Label lblTiempoEstadia;
        private System.Windows.Forms.Label lblTitulo;
    }
}

