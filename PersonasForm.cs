namespace Veronica_Ejercicio4_ListaPersonas2
{
    public partial class PersonasForm : Form
    {
        PersonasModel model;
        public PersonasForm()
        {
            InitializeComponent();
        }

        private void PersonasForm_Load(object sender, EventArgs e)
        {
            model = new PersonasModel();
            foreach (var persona in model.Personas)
            {
                var item = new ListViewItem();
                item.Text = persona.Documento.ToString(); //el Text es lo que va en la PRIMER COLUMNA que en este caso es documento
                //el resto de las columnas va en SUBITEMS
                item.SubItems.Add(persona.Apellido);
                item.SubItems.Add(persona.Nombre);
                item.SubItems.Add(persona.Telefono);

                //en la propiedad tag que es de tipo object, guardo lo que quiero
                item.Tag = persona; //asi puedo meter un objetco en cada fila que me sirve para identificar
                                    //entonces uso una referencia al objeto persona que es una fila y la guardo en el tag

                PersonasListView.Items.Add(item);
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            //primero verifico que haya algo para eliminar, que la lista no este vaia
            // PersonasListView.SelectedItems es una coleccion de los item seleccionados
            if (PersonasListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecciona una persona de la lista", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            //veo cual es la persona seleccionada
            //este es el item de la persona seleccionada, NO es la persona seleccionada que se guardo en TAG
            //var personasSeleccionadas = PersonasListView.SelectedItems[0]; 

            //var --> tipo object
            //digo que este objecto es una persona y fuerzo esta asignacion
            //asigno la referencia de TAG a la variable de TIPO persona personasSeleccionadas
            // --> entonces CASTEO: digo que se mire el objecto como clase Persona
            //esto da error si en el tag meto algo que no es persona
            Persona personasSeleccionadas = (Persona)PersonasListView.SelectedItems[0].Tag;

            //pide confirmacion para borrar seleccion, en caso de que se arrepienta.
            if (MessageBox.Show($"Se dispone a borrar {personasSeleccionadas.Apellido} {personasSeleccionadas.Nombre}. ¿Esta usted seguro?.", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
            {
                return;
            }

            //borro la persona seleccionada del modelo
            var error = model.Borrar(personasSeleccionadas);
            //asumo que cada operacion da error, entonces devuelvo un mensaje en caso de que salte ERROR
            if (error != null)
            {
                MessageBox.Show(error, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //borro de mi lista tambien, cuando borro persona
            PersonasListView.Items.Remove(PersonasListView.SelectedItems[0]); //[0] - borra el item seleccionado porque lo acabo de eliminar



        }

        //laprimera parte toma los datos de la persona seleccionada y los carga en la parte de abajo del formulario
        //la segunda parte se queda esperando
        private void buttonModificar_Click(object sender, EventArgs e)
        {

            //primero verifico que haya algo para modificar, que la lista no este vacia. Quiero saber la persona seleccionada
            // PersonasListView.SelectedItems es una coleccion de los item seleccionados
            if (PersonasListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecciona una persona de la lista", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Persona personasSeleccionadas = (Persona)PersonasListView.SelectedItems[0].Tag;

            //copio los datos de la persona al texbox
            textBoxDocumento.Text = personasSeleccionadas.Documento.ToString();
            textBoxApellido.Text = personasSeleccionadas.Apellido;
            textBoxNombre.Text = personasSeleccionadas.Nombre;
            textBoxTelefono.Text = personasSeleccionadas.Telefono;

            //ahora habilito o deshabilito los GroupBox
            groupBoxPersonaEdicion.Enabled = true; //habilito porque lo tenia grisado antes, cuando elimine
            groupBoxListaPersonas.Enabled = false; //deshabilito (griseo) el grupo de arriba


        }
    }
}