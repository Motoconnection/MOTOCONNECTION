﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace MOTOCONNECTION.Conexion
{
    class TamañoAutomaticoDeDatabase
    {
        public static void Multilinea(ref DataGridView List)
        {
            List.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //List.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
            //List.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //List.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //List.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            //List.EnableHeadersVisualStyles = false;
            //DataGridViewCellStyle styCabeceras = new DataGridViewCellStyle();
            //styCabeceras.BackColor = System.Drawing.Color.Black;
            //styCabeceras.ForeColor = System.Drawing.Color.Orange;
            //styCabeceras.Font = new Font("Candara", 10, FontStyle.Bold);
            //List.ColumnHeadersDefaultCellStyle = styCabeceras;
        }
    }
}
