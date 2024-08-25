namespace Veronica_Ejercicio4_ListaPersonas2
{
    partial class PersonasForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelDocumento = new Label();
            textBoxDocumento = new TextBox();
            labelNombre = new Label();
            textBoxNombre = new TextBox();
            labelApellido = new Label();
            textBoxApellido = new TextBox();
            labelTelefono = new Label();
            textBoxTelefono = new TextBox();
            buttonAceptar = new Button();
            buttonCancelar = new Button();
            groupBoxPersonaEdicion = new GroupBox();
            buttonNuevo = new Button();
            groupBoxListaPersonas = new GroupBox();
            buttonAgregar = new Button();
            buttonModificar = new Button();
            buttonEliminar = new Button();
            PersonasListView = new ListView();
            DocumentoHeader1 = new ColumnHeader();
            NombreHeader2 = new ColumnHeader();
            ApellidoHeader3 = new ColumnHeader();
            TelefonoHeader4 = new ColumnHeader();
            button1 = new Button();
            groupBoxPersonaEdicion.SuspendLayout();
            groupBoxListaPersonas.SuspendLayout();
            SuspendLayout();
            // 
            // labelDocumento
            // 
            labelDocumento.AutoSize = true;
            labelDocumento.Location = new Point(21, 40);
            labelDocumento.Name = "labelDocumento";
            labelDocumento.Size = new Size(106, 25);
            labelDocumento.TabIndex = 0;
            labelDocumento.Text = "Documento";
            // 
            // textBoxDocumento
            // 
            textBoxDocumento.Location = new Point(21, 68);
            textBoxDocumento.Name = "textBoxDocumento";
            textBoxDocumento.Size = new Size(234, 31);
            textBoxDocumento.TabIndex = 1;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(328, 40);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(78, 25);
            labelNombre.TabIndex = 2;
            labelNombre.Text = "Nombre";
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(328, 68);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(258, 31);
            textBoxNombre.TabIndex = 3;
            // 
            // labelApellido
            // 
            labelApellido.AutoSize = true;
            labelApellido.Location = new Point(21, 129);
            labelApellido.Name = "labelApellido";
            labelApellido.Size = new Size(78, 25);
            labelApellido.TabIndex = 4;
            labelApellido.Text = "Apellido";
            // 
            // textBoxApellido
            // 
            textBoxApellido.Location = new Point(21, 157);
            textBoxApellido.Name = "textBoxApellido";
            textBoxApellido.Size = new Size(234, 31);
            textBoxApellido.TabIndex = 5;
            // 
            // labelTelefono
            // 
            labelTelefono.AutoSize = true;
            labelTelefono.Location = new Point(328, 129);
            labelTelefono.Name = "labelTelefono";
            labelTelefono.Size = new Size(79, 25);
            labelTelefono.TabIndex = 6;
            labelTelefono.Text = "Telefono";
            // 
            // textBoxTelefono
            // 
            textBoxTelefono.Location = new Point(328, 157);
            textBoxTelefono.Name = "textBoxTelefono";
            textBoxTelefono.Size = new Size(258, 31);
            textBoxTelefono.TabIndex = 7;
            // 
            // buttonAceptar
            // 
            buttonAceptar.Location = new Point(651, 68);
            buttonAceptar.Name = "buttonAceptar";
            buttonAceptar.Size = new Size(113, 35);
            buttonAceptar.TabIndex = 8;
            buttonAceptar.Text = "Aceptar";
            buttonAceptar.UseVisualStyleBackColor = true;
            buttonAceptar.Click += buttonAceptar_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(651, 153);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(113, 35);
            buttonCancelar.TabIndex = 9;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // groupBoxPersonaEdicion
            // 
            groupBoxPersonaEdicion.Controls.Add(button1);
            groupBoxPersonaEdicion.Controls.Add(buttonNuevo);
            groupBoxPersonaEdicion.Controls.Add(buttonCancelar);
            groupBoxPersonaEdicion.Controls.Add(buttonAceptar);
            groupBoxPersonaEdicion.Controls.Add(textBoxTelefono);
            groupBoxPersonaEdicion.Controls.Add(labelTelefono);
            groupBoxPersonaEdicion.Controls.Add(textBoxApellido);
            groupBoxPersonaEdicion.Controls.Add(labelApellido);
            groupBoxPersonaEdicion.Controls.Add(textBoxNombre);
            groupBoxPersonaEdicion.Controls.Add(labelNombre);
            groupBoxPersonaEdicion.Controls.Add(textBoxDocumento);
            groupBoxPersonaEdicion.Controls.Add(labelDocumento);
            groupBoxPersonaEdicion.Enabled = false;
            groupBoxPersonaEdicion.Location = new Point(30, 274);
            groupBoxPersonaEdicion.Name = "groupBoxPersonaEdicion";
            groupBoxPersonaEdicion.Size = new Size(879, 256);
            groupBoxPersonaEdicion.TabIndex = 4;
            groupBoxPersonaEdicion.TabStop = false;
            groupBoxPersonaEdicion.Text = "Persona";
            groupBoxPersonaEdicion.Enter += groupBoxPersonaEdicion_Enter;
            // 
            // buttonNuevo
            // 
            buttonNuevo.Location = new Point(775, 103);
            buttonNuevo.Name = "buttonNuevo";
            buttonNuevo.Size = new Size(100, 43);
            buttonNuevo.TabIndex = 10;
            buttonNuevo.Text = "Nuevo";
            buttonNuevo.UseVisualStyleBackColor = true;
            buttonNuevo.Click += buttonNuevo_Click;
            // 
            // groupBoxListaPersonas
            // 
            groupBoxListaPersonas.Controls.Add(buttonAgregar);
            groupBoxListaPersonas.Controls.Add(buttonModificar);
            groupBoxListaPersonas.Controls.Add(buttonEliminar);
            groupBoxListaPersonas.Controls.Add(PersonasListView);
            groupBoxListaPersonas.Location = new Point(30, 15);
            groupBoxListaPersonas.Name = "groupBoxListaPersonas";
            groupBoxListaPersonas.Size = new Size(879, 261);
            groupBoxListaPersonas.TabIndex = 5;
            groupBoxListaPersonas.TabStop = false;
            groupBoxListaPersonas.Text = "groupBox1";
            // 
            // buttonAgregar
            // 
            buttonAgregar.Location = new Point(707, 181);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(152, 48);
            buttonAgregar.TabIndex = 7;
            buttonAgregar.Text = "Agregar";
            buttonAgregar.UseVisualStyleBackColor = true;
            buttonAgregar.Click += buttonAgregar_Click;
            // 
            // buttonModificar
            // 
            buttonModificar.Location = new Point(707, 107);
            buttonModificar.Name = "buttonModificar";
            buttonModificar.Size = new Size(152, 48);
            buttonModificar.TabIndex = 6;
            buttonModificar.Text = "Modificar";
            buttonModificar.UseVisualStyleBackColor = true;
            buttonModificar.Click += buttonModificar_Click;
            // 
            // buttonEliminar
            // 
            buttonEliminar.Location = new Point(707, 35);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(152, 48);
            buttonEliminar.TabIndex = 5;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // PersonasListView
            // 
            PersonasListView.Columns.AddRange(new ColumnHeader[] { DocumentoHeader1, NombreHeader2, ApellidoHeader3, TelefonoHeader4 });
            PersonasListView.Location = new Point(19, 32);
            PersonasListView.Margin = new Padding(4, 5, 4, 5);
            PersonasListView.Name = "PersonasListView";
            PersonasListView.Size = new Size(615, 197);
            PersonasListView.TabIndex = 4;
            PersonasListView.UseCompatibleStateImageBehavior = false;
            PersonasListView.View = View.Details;
            // 
            // DocumentoHeader1
            // 
            DocumentoHeader1.Text = "Documento";
            DocumentoHeader1.Width = 150;
            // 
            // NombreHeader2
            // 
            NombreHeader2.Text = "Nombre";
            NombreHeader2.Width = 150;
            // 
            // ApellidoHeader3
            // 
            ApellidoHeader3.Text = "Apellido";
            ApellidoHeader3.Width = 150;
            // 
            // TelefonoHeader4
            // 
            TelefonoHeader4.Text = "Telefono";
            TelefonoHeader4.Width = 150;
            // 
            // button1
            // 
            button1.Location = new Point(121, 210);
            button1.Name = "button1";
            button1.Size = new Size(188, 32);
            button1.TabIndex = 11;
            button1.Text = "Hola";
            button1.UseVisualStyleBackColor = true;
            // 
            // PersonasForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(990, 550);
            Controls.Add(groupBoxListaPersonas);
            Controls.Add(groupBoxPersonaEdicion);
            Margin = new Padding(4, 5, 4, 5);
            Name = "PersonasForm";
            Text = "Ejercicio4 - Lista Personas";
            Load += PersonasForm_Load;
            groupBoxPersonaEdicion.ResumeLayout(false);
            groupBoxPersonaEdicion.PerformLayout();
            groupBoxListaPersonas.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label labelDocumento;
        private TextBox textBoxDocumento;
        private Label labelNombre;
        private TextBox textBoxNombre;
        private Label labelApellido;
        private TextBox textBoxApellido;
        private Label labelTelefono;
        private TextBox textBoxTelefono;
        private Button buttonAceptar;
        private Button buttonCancelar;
        private GroupBox groupBoxPersonaEdicion;
        private GroupBox groupBoxListaPersonas;
        private Button buttonAgregar;
        private Button buttonModificar;
        private Button buttonEliminar;
        private ListView PersonasListView;
        private ColumnHeader DocumentoHeader1;
        private ColumnHeader NombreHeader2;
        private ColumnHeader ApellidoHeader3;
        private ColumnHeader TelefonoHeader4;
        private Button buttonNuevo;
        private Button button1;
    }
}