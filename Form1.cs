using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public sealed partial class Restaurante : Form
    {

        public static Restaurante Instancia { get; } = new Restaurante();
        private Restaurante()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        #region Eventos
        private void Mesa1_Click(object sender, EventArgs e)
        {
            OpenMesa1();
        }
        #endregion

        #region Metodos
        private void OpenMesa1()
        {
            Mesa4 mesa4 = new Mesa4();
            mesa4.Show();
            this.Hide();
        }
        #endregion

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
