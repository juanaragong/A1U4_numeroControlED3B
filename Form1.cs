namespace A1U4_numeroControlED3B
{
    public partial class Form1 : Form
    {
        Arbol arbolito = new Arbol();

        public Form1()
        {
            InitializeComponent();
            panelArbol.Paint += panelArbol_Paint;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dato;

            if (int.TryParse(txtDato.Text, out dato))
            {
                arbolito.Insertar(dato);

                // Solicita volver a dibujar el Panel
                panelArbol.Invalidate();

                txtDato.Clear();
                txtDato.Focus();
            }
            else
            {
                MessageBox.Show("Ingrese un número entero válido.");
            }
        }

        private void panelArbol_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode =
            System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            arbolito.Dibujar(e.Graphics, panelArbol.Width);
        }
    }
}
