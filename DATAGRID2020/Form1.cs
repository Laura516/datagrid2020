using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Serialization; // manejo de archivos XML
using System.IO;  // escritura lectura 

namespace DATAGRID2020
{
    public partial class Form1 : Form
    {
        //Declarar Objetos
        //ArrayList listaAlumnos = new ArrayList();

        List<Alumno> listaAlumnos = new List<Alumno>(); // creando el objeto listaAlumnos ---> array
        ValidarCajas validacion = new ValidarCajas(); // creo un objeto de validación instanciando la clase validarCajas
        public Form1()
        {
            InitializeComponent();
        }

        private void tsAddUser_Click(object sender, EventArgs e)
        {
            // el codigo para agregar un almno

            //realiza validaciones

            if (!validacion.Vacio(txtcodigo, errorM, "El código no puede ser vacío"))
                if (validacion.TipoNumero(txtcodigo, errorM, "El código es númerico"))
                    if (!validacion.Vacio(txtnombre, errorM, "El Nombre no puede ser vacío"))
                        if (validacion.TipoTexto(txtnombre, errorM, "Debe diigitar texto"))
                            if (!validacion.Vacio(txtcorreo, errorM, "El correo no puede ser vacío"))
                                if (validacion.TipoCorreo(txtcorreo, errorM, "El correo no cumple con el formato"))
                                    if (!validacion.Vacio(txtnota1, errorM, "La nota no puede ser vacío"))
                                        if (validacion.TipoNumero(txtnota1, errorM, "la nota debe ser numérico"))
                                            if (!validacion.Vacio(txtnota2, errorM, "La nota no puede ser vacío"))
                                                if (validacion.TipoNumero(txtnota2, errorM, "la nota debe ser numérico"))
                                                    if (!validacion.Vacio(txtnota3, errorM, "La nota no puede ser vacío"))
                                                        if (validacion.TipoNumero(txtnota3, errorM, "la nota debe ser numérico"))
                                                            if (!validacion.Vacio(txtnota4, errorM, "La nota no puede ser vacío"))
                                                                if (validacion.TipoNumero(txtnota4, errorM, "la nota debe ser numérico"))
                                                                {
                                                                    if (!ExisteCodigo(Convert.ToInt32(txtcodigo.Text))) //si esto no existe haga la insersion
                                                                    {
                                                                        insertatrDatos();
                                                                        LimpiarCajas();
                                                                        errorM.Clear();
                                                                    }
                                                                    else
                                                                    {
                                                                        errorM.SetError(txtcodigo,"El código ya existe");
                                                                        txtcodigo.Focus();
                                                                        return;
                                                                    }
                                                                   
                                                                }





                                                                   

        }

        private void tsSaveFile_Click(object sender, EventArgs e) // guardar xml en el menú
        {
            //crear archivo xml
            XmlSerializer codificador = new XmlSerializer(typeof(List<Alumno>));
            TextWriter escribirXml = new StreamWriter("C:/Net/listaAlumnos.xml");
            codificador.Serialize(escribirXml, listaAlumnos);
            escribirXml.Close();
        }

        private void tsOpenFile_Click(object sender, EventArgs e) // boton de abrir Xml en el menú
        {
            //cargar los datos del xml
            //generar una lista con esos datos
            //mostrar esa lista en en datagrid     //serializer = es para escribir xml
                                                   //deserialize == es para leer xml

            listaAlumnos.Clear();
            XmlSerializer codificador = new XmlSerializer(typeof(List<Alumno>)); //formato xml
            FileStream leerXml = File.OpenRead("C:/Net/listaAlumnos.xml"); //lee archivo
            listaAlumnos = (List<Alumno>)codificador.Deserialize(leerXml); 
            leerXml.Close();

            dgTablaDatos.DataSource = null;
            dgTablaDatos.DataSource = listaAlumnos;
            
        }

        private void Form1_Load(object sender, EventArgs e) // evento  cargar formulario
        {
            //cuando se abra lea el archivo y lo muestre

            //cargar los datos del xml
            //generar una lista con esos datos
            //mostrar esa lista en en datagrid     //serializer = es para escribir xml
            //deserialize == es para leer xml

            listaAlumnos.Clear();
            
            if (File.Exists("C:/net/listaAlumnos.xml")) //si existe el archivo los cargue y los muetre, y sino existe, crea automaticamente un archivo nuevo xml
            {
                XmlSerializer codificador = new XmlSerializer(typeof(List<Alumno>)); //formato xml
                FileStream leerXml = File.OpenRead("C:/Net/listaAlumnos.xml"); //lee archivo
                listaAlumnos = (List<Alumno>)codificador.Deserialize(leerXml);
                leerXml.Close();
            }
            dgTablaDatos.DataSource = null;
            dgTablaDatos.DataSource = listaAlumnos;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e) // evento cerrar formulario
        {
            //cuando se cierra se guarde la información

            //crear archivo xml
            XmlSerializer codificador = new XmlSerializer(typeof(List<Alumno>));
            TextWriter escribirXml = new StreamWriter("C:/Net/listaAlumnos.xml");
            codificador.Serialize(escribirXml, listaAlumnos);
            escribirXml.Close();
        }

        private void tsExit_Click(object sender, EventArgs e)
        {
            //cerrar la aplicación

            Application.Exit();
        }

      
        private void tsSearchUser_Click(object sender, EventArgs e)
        {
            //buscar un alumno por el codigo
            //Valido que no esten vacias las cajas

            if(!validacion.Vacio(txtcodigo,errorM,"para buscar debe haber un código"))
                if (validacion.TipoNumero(txtcodigo, errorM, "El código es númerico"))
                {
                    //validar que existan
                    if (ExisteCodigo(Convert.ToInt32(txtcodigo.Text)))
                    {
                        Alumno myAlumno = ObtenerDatos(Convert.ToInt32(txtcodigo.Text));
                        txtnombre.Text = myAlumno.Nombre;
                        txtcorreo.Text = myAlumno.Correo;
                        txtnota1.Text = myAlumno.Nota1.ToString();
                        txtnota2.Text = myAlumno.Nota2.ToString();
                        txtnota3.Text = myAlumno.Nota3.ToString();
                        txtnota4.Text = myAlumno.Nota4.ToString();

                        //Activar botones

                        tsEditUser.Enabled = true;
                        tsDeleteUser.Enabled = true;
                        txtcodigo.Enabled = false;
                        
                    }
                    else
                    {
                            errorM.SetError(txtcodigo, "El código no existe");
                            txtcodigo.Focus();
                            LimpiarCajas2();
                            return;
                    }

                }
        }

        private void tsDeleteUser_Click(object sender, EventArgs e)
        {
            //Borrar datos del estudiante
            DialogResult confirmarBorrar = MessageBox.Show("¿Está seguro de borrar?", "confirmar borrada", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (confirmarBorrar == DialogResult.OK)
            {
                Alumno myAlumno = ObtenerDatos(Convert.ToInt32(txtcodigo.Text));
                listaAlumnos.Remove(myAlumno); //remove sirve para quitar algun dato de la lista

                dgTablaDatos.DataSource = null; // es importante colocarlo para actualizar la información de datagrid
                dgTablaDatos.DataSource = listaAlumnos; //esto es para mostrar la información en el data grid  
                
                
                
                //activar botones
                tsEditUser.Enabled = false;
                tsDeleteUser.Enabled = false;
                txtcodigo.Enabled = true;
                LimpiarCajas();
            }


        }


        private void tsEditUser_Click(object sender, EventArgs e)
        {
            //Editar datos
            //realiza validaciones

            if (!validacion.Vacio(txtnombre, errorM, "El Nombre no puede ser vacío"))
                if (validacion.TipoTexto(txtnombre, errorM, "Debe diigitar texto"))
                    if (!validacion.Vacio(txtcorreo, errorM, "El correo no puede ser vacío"))
                        if (validacion.TipoCorreo(txtcorreo, errorM, "El correo no cumple con el formato"))
                            if (!validacion.Vacio(txtnota1, errorM, "La nota no puede ser vacío"))
                                if (validacion.TipoNumero(txtnota1, errorM, "la nota debe ser numérico"))
                                    if (!validacion.Vacio(txtnota2, errorM, "La nota no puede ser vacío"))
                                        if (validacion.TipoNumero(txtnota2, errorM, "la nota debe ser numérico"))
                                            if (!validacion.Vacio(txtnota3, errorM, "La nota no puede ser vacío"))
                                                if (validacion.TipoNumero(txtnota3, errorM, "la nota debe ser numérico"))
                                                    if (!validacion.Vacio(txtnota4, errorM, "La nota no puede ser vacío"))
                                                        if (validacion.TipoNumero(txtnota4, errorM, "la nota debe ser numérico"))
                                                            guardarCambios();
                                                       
                                                               



        }

        //  ************************************ Mis métodos ************************************

        // metodo o funcion para ver el array en consola

        private void verArreglo()
        {
            foreach (Alumno itemAlumno in listaAlumnos)
            {
                Console.WriteLine("--------------------------------------------------------");
                Console.WriteLine(itemAlumno.Nombre);
                Console.WriteLine(itemAlumno.Codigo);
                Console.WriteLine(itemAlumno.Correo);
                Console.WriteLine(itemAlumno.Nota1);
                Console.WriteLine(itemAlumno.Nota2);
                Console.WriteLine(itemAlumno.Nota3);
                Console.WriteLine(itemAlumno.Nota4);
                Console.WriteLine(itemAlumno.NotaFinal);
                Console.WriteLine(itemAlumno.NotaConcepto);
                Console.WriteLine("--------------------------------------------------------");
            }
        }

        private void insertatrDatos()
        {
            // creamo un objeto alumno y a sus propiedades les asignamos los valores de las cajas de texto
            // Agregar el objeto a la lista
            // visualizamos la lista en el datagrid

            Alumno objetoAlumno = new Alumno(); // instancio la clase alumno y creo el objeto MyAlumno

            // desde los elementos del formulario creo el alumno nuevo

            objetoAlumno.Codigo = Convert.ToInt32(txtcodigo.Text);
            objetoAlumno.Nombre = txtnombre.Text;
            objetoAlumno.Correo = txtcorreo.Text;
            objetoAlumno.Nota1 = Convert.ToDouble(txtnota1.Text);
            objetoAlumno.Nota2 = Convert.ToDouble(txtnota2.Text);
            objetoAlumno.Nota3 = Convert.ToDouble(txtnota3.Text);
            objetoAlumno.Nota4 = Convert.ToDouble(txtnota4.Text);

            // calculamos el resto
            objetoAlumno.NotaFinal = (objetoAlumno.Nota1 + objetoAlumno.Nota2 + objetoAlumno.Nota3 + objetoAlumno.Nota4) / 4;

            if (objetoAlumno.NotaFinal >= 3.5)
                objetoAlumno.NotaConcepto = "Aprobado";
            else
                objetoAlumno.NotaConcepto = "Reprobado";

            //Agrego el objeto alumno al arreglo 
            listaAlumnos.Add(objetoAlumno);

            //Alimento el datagrid o visualizo en el datagrid el arreglo

            dgTablaDatos.DataSource = null; // es importante colocarlo para actualizar la información de datagrid
            dgTablaDatos.DataSource = listaAlumnos; //esto es para mostrar la información en el data grid


        }


        //validar que el nuevo código no exista en la lista
        // retorna un false o un true

        private Boolean ExisteCodigo(int codigo)
        {
            foreach (Alumno myAlumno in listaAlumnos)
            {
                if (myAlumno.Codigo == codigo)
                    return true;
            }
            return false;
        }

        //traemos el objeto de un Alumno
        // retorna un objeto alumno de la lista con el codigo de la caja de texto
        private Alumno ObtenerDatos(int codigo)
        {
            foreach (Alumno miAlumnno in listaAlumnos)
            {
                if (miAlumnno.Codigo == codigo)
                    return miAlumnno;
            }
            return null;
        }

        private void guardarCambios()
        {

            //Es un Método crea un objeto alumno "con el codigo que esta en la caja de texto codigo" 
            //como el objeto es de la lista, Actualiza los valores

            Alumno myAlumno = ObtenerDatos(Convert.ToInt32(txtcodigo.Text));
            myAlumno.Nombre = txtnombre.Text;
            myAlumno.Correo = txtcorreo.Text;
            myAlumno.Nota1 = Convert.ToDouble(txtnota1.Text);
            myAlumno.Nota2 = Convert.ToDouble(txtnota2.Text);
            myAlumno.Nota3 = Convert.ToDouble(txtnota3.Text);
            myAlumno.Nota4 = Convert.ToDouble(txtnota4.Text);

            // calculamos el resto
            myAlumno.NotaFinal = (myAlumno.Nota1 + myAlumno.Nota2 + myAlumno.Nota3 + myAlumno.Nota4) / 4;

            if (myAlumno.NotaFinal >= 3.5)
                myAlumno.NotaConcepto = "Aprobado";
            else
                myAlumno.NotaConcepto = "Reprobado";

            dgTablaDatos.DataSource = null; // es importante colocarlo para actualizar la información de datagrid
            dgTablaDatos.DataSource = listaAlumnos; //esto es para mostrar la información en el data grid   


            //activar botones
            tsEditUser.Enabled = false;
            tsDeleteUser.Enabled = false;
            txtcodigo.Enabled = true;
            LimpiarCajas();
        }

        private void LimpiarCajas()
        {
            txtcodigo.Clear();
            txtcorreo.Clear();
            txtnombre.Clear();
            txtnota1.Clear();
            txtnota2.Clear();
            txtnota3.Clear();
            txtnota4.Clear();

            txtcodigo.Focus();
        }

        private void LimpiarCajas2()
        {
            txtcorreo.Clear();
            txtnombre.Clear();
            txtnota1.Clear();
            txtnota2.Clear();
            txtnota3.Clear();
            txtnota4.Clear();

            txtcodigo.Focus();
        }

    }


}
