using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hernan_Parcial.DAL;

namespace Hernan_Parcial
{
    public class GstRobot
    {
        //private List<Bateria> baterias = new List<Bateria>();
        private List<Robot> robots = new List<Robot>();
        public List<Robot> Robots
        {
            get { return robots; }
        }

        //public bool altaRobot(Explorador robot)
        public List<Robot> AltaRobot(Robot robot)
        {
            try
            {
                Robots.Add(robot);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return robots;
        }
    }
}
