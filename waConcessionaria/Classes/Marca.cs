using System.Collections.Generic;

namespace Classes {
    public class Marca {
        public int codigo { get; set; }
        public string nome { get; set; }
        public string paisOrigem { get; set; }
        //public List<Carro> carros { get; set; }

        public Marca(int codigo, string nome, string paisOrigem) {
            this.codigo = codigo;
            this.nome = nome;
            this.paisOrigem = paisOrigem;
        }
    }
}