﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_Seguridad
{
    public partial class Navegador : Form
    {
        public Navegador(String idUsuario)
        {
            InitializeComponent();

            string[] alias = { "idEmpresa", "nit", "nombre", "direccion", "telefono", "estatus"};
            navegador1.AsignarAlias(alias);
            navegador1.AsignarSalida(this);
            navegador1.AsignarColorFondo(Color.CadetBlue);
            navegador1.AsignarColorFuente(Color.Black);
            navegador1.AsignarTabla("empresa");
            navegador1.ObtenerIdAplicacion("1000");
            navegador1.ObtenerIdUsuario(idUsuario);
            navegador1.AsignarAyuda("1");
            navegador1.AsignarNombreForm("Mantenimiento empresa");
        }
    }
}