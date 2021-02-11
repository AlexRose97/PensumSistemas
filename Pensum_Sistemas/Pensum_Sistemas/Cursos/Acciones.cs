using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Pensum_Sistemas.Cursos
{
    class Acciones
    {


        public List<ObjetoCurso> Mis_Cursos = new List<ObjetoCurso>();




        public void argregarCursos()
        {


            int[] semestre = {1,1,1,1,1,1,2,2,2,2,2,2,3,3,3,3,3,3,4,4,4,4,4,4,4,4,4,4,5,5,5,5,5,5,5,5,5,5,6,6,6,6,6,6,6,6,6,6,6,6,6,6,7,7,7,7,7,7,7,7,7,7,7,7,7,7,8,8,8,8,8,8,8,8,9,9,9,9,9,9,9,9,9,9,9,9,10,10,10,10,10,10,10,10,10,10,10,10};
            int[] codigo= {17,101,69,39,348,6,19,103,5,147,40,8,795,960,770,107,150,9,732,796,962,771,10,112,114,152,11,2025,736,777,964,772,18,116,118,368,650,28,722,601,14,781,778,773,122,120,200,652,335,786,366,3022,724,603,734,281,779,970,774,656,654,2036,787,3664,3658,700,285,975,775,283,797,700,706,1,729,786,972,966,785,788,738,798,288,702,1,2037,787,790,720,968,974,780,789,735,7990,710,706,799};
            string[] curso = {"SOCIAL HUMANISTICA 1","MATEMATICA BASICA 1","TECNICA COMPLEMENTARIA 1","DEPORTES 1","QUIMICA GENERAL 1","IDIOMA TECNICO 1","SOCIAL HUMANISTICA 2","MATEMATICA BASICA 2","TECNICAS DE ESTUDIO Y DE INVESTIGACION","FISICA BASICA","DEPORTES 2","IDIOMA TECNICO 2","LOGICA DE SISTEMAS","MATE COMPUTO 1","INTRODUCCION A LA PROGRAMACION Y COMPUTACION 1","MATEMATICA INTERMEDIA 1","FISICA 1","IDIOMA TECNICO 3","ESTADISTICA 1","LENGUAJES FORMALES Y DE PROGRAMACION","MATE COMPUTO 2","INTRODUCCION A LA PROGRAMACION Y COMPUTACION 2","LOGICA","MATEMATICA INTERMEDIA 2","MATEMATICA INTERMEDIA 3","FISICA 2","IDIOMA TECNICO 4","PRACTICA INICIAL","ANALISIS PROBABILISTICO","ORGANIZACIÓN DE LENGUAJES Y COMPILADORES 1","ORGANIZACIÓN COMPUTACIONAL","ESTRUCTURA DE DATOS","FILOSOFIA DE LA CIENCIA","MATEMATICA APLICADA 3","MATEMATICA APLICADA 1","PRINCIPIOS DE METROLOGIA","CONTABILIDAD 1","ECOLOGIA","TEORIA DE SISTEMAS 1","INVESTIGACION DE OPERACIONES 1","ECONOMIA","ORGANIZACIÓN DE LENGUAJES Y COMPILADORES 2","ARQUITECTURA DE COMPUTADORAS Y ENSAMBLADORES 1","MANEJO E IMPLEMENTACION DE ARCHIVOS","MATEMATICA APLICADA 4","MATEMATICA APLICADA 2","INGENIERIA ELECTRICA 1","CONTABILIDAD 2","GESTION DE DESASTRES","SIST. ORGANIZACIONALES Y GERENCIALES 1","LEGISLACION 1","PSICOLOGIA INDUSTRIAL","TEORIA DE SISTEMAS 2","INVESTIGACION DE OPERACIONES 2","ESTADISTICA 2","SISTEMAS OPERATIVOS 1","ARQUITECTURA DE COMPUTADORAS Y ENSAMBLADORES 2","REDES DE COMPUTADORAS 1","SISTEMA DE BASES DE DATOS 1","ADMINISTRACION DE EMPRESAS 1","CONTABILIDAD 3","PRACTICA INTERMEDIA","SIST. ORGANIZACIONALES Y GERENCIALES 2","LEGISLACION 2","ADMINISTRACION DE PERSONAL","INGENIERIA ECONOMICA 1","SISTEMAS OPERATIVOS 2","REDES DE COMPUTADORAS 2","SISTEMAS DE BASES DE DATOS 2","ANALISIS Y DISEÑO DE SISTEMAS 1","SEMINARIO DE SISTEMAS 1","ING. ECONOMICA 1","PREP. Y EV. DE PROYECTOS 1","ETICA PROFESIONAL","MODELACION Y SIMULACION 1","SISTEMAS ORGANIZACIONALES Y GERENCIALES 1","INTELIGENCIA ARTIFICIAL 1","SEGURIDAD Y AUDITORIA DE REDES","ANALISIS Y DISEÑO DE SISTEMAS 2","SISTEMAS APLICADOS 1","BASES DE DATOS AVANZADAS","SEMINARIO DE SISTEMAS 2","INTRODUCCION A LA EVALUACION DE IMPACTO AMBIENTAL","ING. ECONOMICA 2","ETICA PROFESIONAL","PRACTICA FINAL","SISTEMAS ORGANIZACIONALES Y GERENCIALES 2","EMPRENDEDORES DE NEG. INFORMATICOS","MODELACION Y SIMULACION 2","INTELIGENCIA ARTIFICIAL 2","REDES DE NUEVA GENERACION","SOFTWARE AVANZADO","SISTEMAS APLICADOS 2","AUDITORIA DE PROY. DE SOFTWARE","SEMINARIO DE INVESTIGACION EPS","PLANEAMIENTO","PREPARACION Y EVALUACION DE PROYECTOS 1","SEMINARIO DE INVESTIGACION"};
            int[] creditos = {4,7,3,1,3,2,4,7,3,5,1,2,2,5,4,10,6,2,5,3,5,5,2,5,5,6,2,0,4,4,3,5,3,5,6,3,3,3,5,5,4,5,5,4,4,6,5,3,3,0,0,0,5,5,5,5,4,4,5,5,3,0,0,0,0,0,4,4,4,5,3,5,0,0,5,4,4,4,5,5,5,3,4,4,4,0,4,4,5,4,4,6,5,5,4,6,4,3};
            int[] creditos_pre = {0,0,0,0,0,0,0,0,0,0,0,0,33,33,33,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,90,0,0,0,90,90,0,0,0,0,0,0,0,0,0,0,0,0,90,90,0,0,0,0,0,0,0,150,0,0,0,0,0,0,0,0,0,0,170,0,190,200,0,0,0,0,0,0,0,190,190,0,200,200,0,0,0,0,0,0,0,0,225,190,190,220};
            string[] curso_pre = { "","","","","","","17","101","","101","39","6","103","103","103","103","103/147","8","107/5","770/795/960","960/770/795","107/770/795/960","19","107","107","107/150","9","103/770","732","771/796/962","152/771/962","771/796/962","19","112/114","112/114","732/152/348","","","732/772/116/118","771/732","732","777/772","796/964","772/796","118","118","114/152","650","28","283/722","","","722/601/736","601","732","781/778","778","773/778","773","","652","778/777/773/2025","786","3662","3022","732","281","970","281/774","774","724","732","700","","724/603","283/722","781/775/724","975","283","283","775","797","","700","","2036","786","786","729","972","975","875","875/788","785","","","700","798"};
            bool[] obligatorio = { true,true,true,false,true,false,true,true,true,true,false,false,true,true,true,true,true,false,true,true,true,true,false,true,true,true,false,true,true,true,true,true,false,true,true,false,false,false,true,true,true,true,true,true,false,false,false,false,false,false,false,false,true,true,false,true,true,true,true,false,false,true,false,false,false,false,true,true,true,true,true,false,false,false,true,true,true,false,true,false,false,true,false,false,false,true,true,false,true,false,false,true,false,false,false,false,false,true};

            for (int i = 0; i < semestre.Length; i++)
            {
                Mis_Cursos.Add(new ObjetoCurso { Semestre=semestre[i],Codigo=codigo[i], Curso=curso[i], Creditos=creditos[i], Creditos_Pre=creditos_pre[i],obligatorio=obligatorio[i],cursos_Pre=curso_pre[i]});
            }




        }

        public List<ObjetoCurso> busqueda_Semestre(int semestre) {

            List<ObjetoCurso> Los_Cursos = new List<ObjetoCurso>();

            foreach (ObjetoCurso curso in Mis_Cursos)
            {
                if (curso.Semestre==semestre)
                {
                    Los_Cursos.Add(curso);
                }
            }
            
            return Los_Cursos;
        }
        public List<ObjetoCurso> busqueda_cursosDisponibles(int Creditos, Dictionary<int,ObjetoCurso> Aprobados)
        {

            List<ObjetoCurso> Los_Cursos = new List<ObjetoCurso>();
            string[] cursoPrerequisto;

            foreach (ObjetoCurso curso in Mis_Cursos)
            {

                /*================================================CURSO SIN PREREQUISITO=================================================*/
                if (curso.cursos_Pre.Split('/')[0].Equals("") && curso.Creditos_Pre<=Creditos)//si no tiene prerequisito y cumplo con creditos
                {



                    if (Aprobados.ContainsKey(curso.Codigo)==false)
                    {
                        Los_Cursos.Add(curso);
                    }




                }
                
                /*================================================CURSO CON PREREQUISITO=================================================*/
                else//posee prerequisito o no cumplo con creditos
                {
                    if (curso.Creditos_Pre<=Creditos)//poseeo los creditos
                    {
                        bool agregar = true;
                        cursoPrerequisto = curso.cursos_Pre.Split('/');
                        //verificar todos los prerequisitos
                        for (int i = 0; i < cursoPrerequisto.Length; i++)
                        {
                            if (Aprobados.ContainsKey(System.Convert.ToInt32(cursoPrerequisto[i]))==false)
                            {
                                agregar = false;
                                break;
                            }
                        }

                        if (agregar)
                        {
                            if (Aprobados.ContainsKey(curso.Codigo) == false)
                            {
                                Los_Cursos.Add(curso);
                            }
                        }
                    }
                }


               
            }

            return Los_Cursos;
        }
        public ObjetoCurso buscar_curso(int codigo) {
            ObjetoCurso micurso = new ObjetoCurso();

            foreach (ObjetoCurso s  in Mis_Cursos)
            {
                if (s.Codigo==codigo)
                {
                    micurso = s;
                    break;
                }
            }




            return micurso;


        }


        public List<ObjetoCurso> busqueda_Curso_todos(string curso) {

            List<ObjetoCurso> Los_Cursos = new List<ObjetoCurso>();

            foreach (ObjetoCurso s in Mis_Cursos)
            {
                if (s.Curso.Contains(curso))
                {
                    Los_Cursos.Add(s);
                }
            }

            return Los_Cursos;



        }



        /*==================================================GUARDAR LISTA SERIALIZADA================*/

        public void GUARDAR(Dictionary<int, ObjetoCurso> lista)
        {

            //serializacion para guardar la lista
            List<ObjetoCurso> Cursos = new List<ObjetoCurso>();
            foreach (ObjetoCurso c in lista.Values)
            {
                Cursos.Add(c);
            }


            XmlSerializer s = new XmlSerializer(typeof(List<ObjetoCurso>));
            TextWriter w = new StreamWriter(@"Lista.xml");
            s.Serialize(w,Cursos);
            w.Close();
        }
        public Dictionary<int, ObjetoCurso> CARGAR()
        {
            XmlSerializer s = new XmlSerializer(typeof(List<ObjetoCurso>));
            List<ObjetoCurso> Cursos = new List<ObjetoCurso>();
            TextReader r = new StreamReader("Lista.xml");
            Cursos = (List<ObjetoCurso>)s.Deserialize(r);
            r.Close();

            Dictionary<int, ObjetoCurso> Aprobados = new Dictionary<int, ObjetoCurso>();
            foreach (ObjetoCurso item in Cursos)
            {
                Aprobados.Add(item.Codigo, item);
            }
            return Aprobados;

        }

    }
}
