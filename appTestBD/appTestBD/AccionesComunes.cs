using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace appTestBD
{
    internal class AccionesComunes
    {
        public static void Mensaje(String mensaje) {
            MessageBox.Show(mensaje, "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void LlenarCombo(String consulta, ComboBox combo, string id, string Nombres)
        {
            combo.ValueMember = id;
            combo.DisplayMember = Nombres;
            DataTable dt = new DataTable();
            dt = Conexion.EjecutaSeleccion(consulta);
            dt.Rows.Add(0, "Todos");
            if (dt == null)
            {
                return;
            }
           combo.Items.Clear();
            combo.DataSource = dt;
        }

        public static string CrearConsulta(string accion,string variables,string tabla)
        {
            string consulta = accion + " " + variables + " from " + tabla;
            return consulta;
        }

        public static void LlenarDataGrid(string consulta,DataGridView datagrid)
        {
            DataTable dt = new DataTable();
            dt = Conexion.EjecutaSeleccion(consulta);
            datagrid.DataSource = dt;
        }

        public static void LlenarListview(string consulta,ListView lista)
        {             
            ListViewItem renglones = new ListViewItem();
            lista.Clear();
            DataTable dt = new DataTable();
            dt = Conexion.EjecutaSeleccion(consulta);
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                lista.Columns.Add(dt.Columns[i].ColumnName);
            }

            for (int i = 0; i < dt.Rows.Count; i++)
            {

                for (int j=0;j<dt.Columns.Count;j++)
                {
                    if (j == 0)
                    {
                        renglones = lista.Items.Add(dt.Rows[i][j].ToString());
                    }
                    else
                    {
                        renglones.SubItems.Add(dt.Rows[i][j].ToString()); 
                    }

                }
            }

        }
    }
}
