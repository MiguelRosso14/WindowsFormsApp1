using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Mesa4 : Form
    {
        public Mesa4()
        {
            InitializeComponent();
        }

         #region Eventos
        private void Numerodepersonas_SelectedIndexChanged(object sender, EventArgs e)
        {
            OpenMesa1();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Cancel();
        }


        #endregion
        #region Metodos
        private void OpenMesa1()
        {
            Restaurante.Instancia.Show();
        }

        private void Cancel()
        {
            Restaurante.Instancia.Show();
            this.Close();
        }


        #endregion

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Mesero newMesero = new Mesero();
            {
                Personas = Numerodepersonas.Text;,
                Familia = Nombrefamilia.Text;,

            };
        }
    }
}
