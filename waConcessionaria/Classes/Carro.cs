using System;
using System.Collections.Generic;
using System.Globalization;

namespace Classes {
    public class Carro {
        public int codigo { get; set; }
        public string modelo { get; set; }
        public int anoFabricacao { get; set; }
        public double precoBasico { get; set; }
        public Marca marca { get; set; }
        public List<Acessorio> acessorios { get; set; }
        public static List<Carro> lstCarros = new List<Carro>();

        public Carro() {
                
        }

        public Carro(int codigo, string modelo, int anoFabricacao, double precoBasico, Marca marca) {



            this.codigo = codigo;
            this.modelo = modelo;
            this.anoFabricacao = anoFabricacao;
            this.precoBasico = precoBasico;
            this.marca = marca;
            acessorios = null;
        }

        public double calcValorTotal() {
            double precoTotal = 0;
            if (this.acessorios != null) {
                foreach (var item in this.acessorios) {
                    precoTotal += item.preco;
                }
                return this.precoBasico + precoTotal;
            }
            else {
                return this.precoBasico;
            }
        }

        public override string ToString() {
            return codigo
                + ", "
                + modelo
                + ", Ano: "
                + anoFabricacao
                + ", Preço básico: "
                + precoBasico
                + ", Preço total: "
                + calcValorTotal();
        }

        
    }
}