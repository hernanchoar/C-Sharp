using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hernan_Parcial.DAL
{
    public enum EnumTipo
    {
        Sonda_Especial=0,
        Robot_Explorador=1,
        Robot_Sonda=2,
    }
    public enum EnumCamara
    {
        Un_Mega_720 = 0,
        Un_Mega_960 = 1,
        Dos_Megas = 2,
        Tres_Megas = 3,
        Cinco_Megas = 4,
        Ocho_Megas = 5,
        Doce_Megas = 6,
        Treinta_y_Tres_Megas = 7,
    }
    public enum EnumBateria
    {
        Alkalinas = 0,
        Litio = 1,
        Recargables = 2,
        Pack_Baterias = 3,
    }
}
