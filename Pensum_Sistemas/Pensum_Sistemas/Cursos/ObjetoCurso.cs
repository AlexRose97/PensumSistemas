using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pensum_Sistemas.Cursos
{
    [Serializable]
    public class ObjetoCurso 
    {

        public int Semestre { set; get; }
        public int Codigo { set; get; }
        public string Curso { set; get; }
        public int Creditos { set; get; }
        public int Creditos_Pre { set; get; }
        public string cursos_Pre{ set; get; }
        public bool obligatorio { set; get; }
    }
}
