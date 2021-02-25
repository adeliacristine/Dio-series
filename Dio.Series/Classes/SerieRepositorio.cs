using System;
using System.Collections.Generic;
using DIO.Series.Interfaces;


namespace Dio.Series
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> listaSerie = new List<Serie>();

        public void Atualiza(int id,Serie objeto)
        {
            listaSerie[id] = objeto;
        }

        public void Exclui(int id)
        {
            listaSerie[id].Excluir();
        }

        public void Inserie(Serie objeto)
        {
           listaSerie.Add(objeto)
        }
        public List<Serie> Lista()
        {
            return listaSerie; 
        }
        public int ProximoId()
        {
          return listaSerie.Count;
        }
        public Serie RetornaPorId(int id)
        {
           return listaSerie[id];
        }
    }
}

public class Prog {

public static void main(String[] args) {

for (int i = 3; i < 20; i += 2) {

System.out.print((i % 3 + " "));

}

}

}

