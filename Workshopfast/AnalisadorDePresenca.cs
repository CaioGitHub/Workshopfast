using System.Collections.Generic;
using System.Linq;

namespace Workshopfast
{
    public class AnalisadorDePresenca
    {
        string[] atas;
        //construtor
        public AnalisadorDePresenca(string[] atas)
        {
            this.atas = atas;
        }

        public string[] ColaboradoresQueViram2WorkshopsSeguidos()
        {
            List<string> listaFinal = new List<string>();
            List<string> listaAnterior = new List<string>();
            for (int i = 0; i < atas.Length; i++)
            {
                if (i != 0)
                {
                    var listaAtual = atas[i].Split(" ");
                    for (int a = 0; a < listaAtual.Length; a++)
                    {
                        if (listaAnterior.Contains(listaAtual[a]))
                        {
                            listaFinal.Add(listaAtual[a]);
                        }

                    }
                }
                listaAnterior = atas[i].Split(" ").ToList();
            }
            return listaFinal.Distinct().OrderBy(x => x).ToArray();
        }
    }

}
