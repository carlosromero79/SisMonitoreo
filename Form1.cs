using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ping HacerPing = new Ping();
            int iTiempoEspera = 5000;
            PingReply RespuestaPing;
            string sDireccion = string.Empty;
            string[] strDirecciones = txtIP.Text.ToString().Split(',');
            
            
            
            foreach (var itm in strDirecciones)
            {
                RespuestaPing = HacerPing.Send(itm, iTiempoEspera);
                if (RespuestaPing.Status == IPStatus.Success)
                {
                    txtLog.AppendText("PING " +
                        itm.ToString() +

                        " -- CORRECTO" +
                        " TIEMPO DE RESPUESTA = " +
                        RespuestaPing.RoundtripTime.ToString() +
                        " MS" +
                        "\n");
                }
                else
                {
                    txtLog.AppendText("ERROR: PING A " +
                        itm.ToString() +
                        "\n");
                }

            }




        }
    }
}
