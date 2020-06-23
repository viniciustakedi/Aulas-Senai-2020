using EstudoTaskool.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstudoTaskool
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        public frmListaUsuario()
        {

        }

        public void fmrListaUsuario_Load(object sender, EventArgs e)
        {
            List<Usuario> usuarios = new List<Usuario>();

            Usuario usuario = new Usuario
            {
                codigo = 1,
                nome = "Takedi",
                email = "takedi@email.com",
                senha = "131231",
                usuario = "takedi"
            };

            usuarios.Add(usuario);

            dgvListaUsuario.DataSource = usuarios;

        }
    }
}
