using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChamarFuncaoIntervaloTempo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static System.Timers.Timer _timer;

        private void Button1_Click(object sender, EventArgs e)
        {
            _timer = new System.Timers.Timer();
            _timer.AutoReset = false; //esse parametro igual a true executa apenas uma vez
            _timer.Interval = 10000; // 10 segundos - Intervalo em milésimos
            _timer.Elapsed += new System.Timers.ElapsedEventHandler(executarTarefa);
            _timer.Enabled = true;
        }

        static void executarTarefa(object sender, System.Timers.ElapsedEventArgs e)
        {
            _timer.Enabled = false;

            MessageBox.Show("Função chamda a cada 15 segundos");

            _timer.Enabled = true;
        }
    }
}
