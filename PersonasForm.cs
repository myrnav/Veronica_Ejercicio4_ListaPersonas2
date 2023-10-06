using System.Windows.Forms;

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

        //revertir cambios del group box 2 PersonaEdicion
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            //vacio los textboxes asi no queda los datos de los usuarios que queria modificar antes
            textBoxDocumento.Text = "";
            textBoxApellido.Text = "";
            textBoxNombre.Text = "";
            textBoxTelefono.Text = "";

            //ahora habilito o deshabilito los GroupBox
            groupBoxPersonaEdicion.Enabled = false; //deshabilito (griseo) el grupo de arriba
            groupBoxListaPersonas.Enabled = true; //habilito porque lo tenia grisado antes
        }

        //del groupBox2 - PersonaEdicion
        //el modelo es quien modifica
        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            Persona personasAModificar = (Persona)PersonasListView.SelectedItems[0].Tag;

            //esto es valido
            //pero tengo que entrar los 4 datos en los parentesis, el problema es cuando tengo MUCHOS datos
            //entonces creo un nuevo objeto persona
            //model.Modificar(personasAModificar, textBoxDocumento.Text, textBoxApellido.Text /*...etc*/);

            //creo el nuevo objeto persona
            Persona personaNuevaVersion = new Persona();
            //lo construyo a partir de la pantalla
            //estoy obligado a hacer aca las VALIDACIONES INDISPENSABLES para poder crear el objeto

            //VALIDO documento
            if (!int.TryParse(textBoxDocumento.Text, out int documento))
            {
                MessageBox.Show("No se ha ingresado un documento válido.");
                return;
            }
            personaNuevaVersion.Documento = documento;
            personaNuevaVersion.Apellido = textBoxApellido.Text;
            personaNuevaVersion.Nombre = textBoxNombre.Text;
            personaNuevaVersion.Telefono = textBoxTelefono.Text;


            //con esto, si agrego mas datos en el futuro porque se modifico el requerimiento
            //esto no cambia.
            //le estoy diciendo al modelo que modifique a esta persona con estos nuevos datos
            //cuando lo defino, no se los datos de esta persona. Entonces la FIRMA NO CAMBIA
            //FIRMA: es la defiinicion "model.Modificar(personasAModificar, personaNuevaVersion)"
            var error = model.Modificar(personasAModificar, personaNuevaVersion);
            //entonces siempre voy a crear acciones que no cambien, como firmas que no cambian con respecto de los datos
            //asumo que cada operacion da error, entonces devuelvo un mensaje en caso de que salte ERROR

            if (error != null)
            {
                MessageBox.Show(error, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //si esta todo bien, si el modelo modifico TODOS los datos, tengo que modificar la fila del LISTVIEW
            var item = PersonasListView.SelectedItems[0];
            item.Text = personasAModificar.Documento.ToString(); //el Text es lo que va en la PRIMER COLUMNA que en este caso es documento
                                                                 //el resto de las columnas va en SUBITEMS
            item.SubItems[1].Text = personasAModificar.Apellido; //agrego [x] para poder actualizar la vista de la pantalla
            // si dejo asi no me muestra la actualizacion en la lista de panatalla item.SubItems.Add(personasAModificar.Nombre); 
            item.SubItems[2].Text = personasAModificar.Nombre;
            item.SubItems[3].Text = personasAModificar.Telefono;

            //el TAG no lo cambio! porque no estoy reemplazando la vieja version objeto por la nuevo objeto
            //solo estoy copiando los datos!!! de personasAModificar


            //vacio los textboxes asi no queda los datos de los usuarios a modificar
            textBoxDocumento.Text = "";
            textBoxApellido.Text = "";
            textBoxNombre.Text = "";
            textBoxTelefono.Text = "";

            //ahora habilito o deshabilito los GroupBox
            groupBoxPersonaEdicion.Enabled = false; //deshabilito (griseo) el grupo de arriba
            groupBoxListaPersonas.Enabled = true; //habilito porque lo tenia grisado antes
        }

        //Agregar nuevos usuarios a la lista
        private void buttonAgregar_Click(object sender, EventArgs e)
        {

            //ahora habilito o deshabilito los GroupBox
            groupBoxPersonaEdicion.Enabled = true;
            groupBoxListaPersonas.Enabled = true;


        }


        private void buttonNuevo_Click(object sender, EventArgs e)
        {

            //METODO 1
            /*
             * Esto funciona 
            PersonasListView.Items.Add(textBoxDocumento.Text);
            PersonasListView.Items[PersonasListView.Items.Count - 1].SubItems.Add(textBoxApellido.Text);
            PersonasListView.Items[PersonasListView.Items.Count - 1].SubItems.Add(textBoxNombre.Text);
            PersonasListView.Items[PersonasListView.Items.Count - 1].SubItems.Add(textBoxTelefono.Text);
            */

            //METODO 2
            //Esto funciona, pero no es eficiente con varios datos
            // Obtener los valores del TextBox
            int documento = int.Parse(textBoxDocumento.Text);
            string apellido = textBoxApellido.Text;
            string nombre = textBoxNombre.Text;
            string telefono = textBoxTelefono.Text;

            // Crear una nueva persona
            Persona personasNueva = new Persona();
            personasNueva.Documento = documento;
            personasNueva.Apellido = apellido;
            personasNueva.Nombre = nombre;
            personasNueva.Telefono = telefono;

            // Agregar la nueva persona al ListView
            ListViewItem item = new ListViewItem(personasNueva.Documento.ToString());
            item.SubItems.Add(personasNueva.Apellido);
            item.SubItems.Add(personasNueva.Nombre);
            item.SubItems.Add(personasNueva.Telefono);
            PersonasListView.Items.Add(item);

            //limpio los TextBox
            textBoxDocumento.Text = "";
            textBoxApellido.Text = "";
            textBoxNombre.Text = "";
            textBoxTelefono.Text = "";

            groupBoxPersonaEdicion.Enabled = false;
            groupBoxListaPersonas.Enabled = true;

            //METODO 3
            /*ESTO ME CARGA MAL, ME INGRESA UN 0 EN DOCUMENTO
             * Persona personasNueva = new Persona();

             var error = model.Agregar(personasNueva);
             if (error != null)
             {
                 MessageBox.Show(error, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 return;
             }

             ListViewItem Nuevoitem = new ListViewItem();

             Nuevoitem.Text = personasNueva.Documento.ToString();
             Nuevoitem.SubItems.Add(personasNueva.Apellido);
             Nuevoitem.SubItems.Add(personasNueva.Nombre);
             Nuevoitem.SubItems.Add(personasNueva.Telefono);
             PersonasListView.Items.Add(Nuevoitem);
             * */

        }



        private void groupBoxPersonaEdicion_Enter(object sender, EventArgs e)
        {

        }



    }
}