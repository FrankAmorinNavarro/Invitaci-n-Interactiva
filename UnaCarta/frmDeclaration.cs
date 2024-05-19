namespace UnaCarta
{
    public partial class frmDeclaration : Form
    {
        public frmDeclaration()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            /*Muestra el panel.*/
            panel1.Show();
        }

        private void frmDeclaration_Load(object sender, EventArgs e)
        {
            //Esto oculta el primer panel.
            panel1.Hide(); 

            //Evita que los botones se señalen con el TAB.
            btnNo.TabStop = false;
            btnUno.TabStop = false;

        }
        public void MoverBoton()
        {
            //Generamos coordenadas para que el botón se mueva y no salga del panel.
            Random r = new Random();
            int x = r.Next(0, this.Width - btnNo.Width); //Coordenada del ancho.
            int y = r.Next(0, this.Height - btnNo.Height); //Coordenada de altura.
            btnNo.Location = new Point(x, y);
        }

        private void btnNo_MouseMove(object sender, MouseEventArgs e)
        {   
            //Llamamos al método "MoverBoron()."
            MoverBoton();
            //Validamos.
            if (btnNo.Location == btnUno.Location || btnNo.Location == label1.Location)
            {
                MoverBoton();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            //Cerramos el programa. 
            Close();    
        }
    }
}
