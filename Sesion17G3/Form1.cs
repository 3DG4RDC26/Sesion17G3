using Sesion17G3.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sesion17G3.Modelos;

namespace Sesion17G3
{
   public partial class Form1 : Form
   {
      ProductoServicio productos;
      public Form1()
      {
         InitializeComponent();
         productos = new ProductoServicio();
      }

      private void tsbAgregar_Click(object sender, EventArgs e)
      {
         Producto prod = new Producto();
         prod.ID = int.Parse(tbID.Text);
         prod.Nombre = tbName.Text;
         prod.Descripcion = tbDescripcion.Text;
         prod.Precio
      }
   }
}
