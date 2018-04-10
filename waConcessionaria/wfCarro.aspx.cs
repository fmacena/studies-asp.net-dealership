using System;
using Classes;
using System.Collections.Generic;
using System.Web.UI.WebControls;
using System.Drawing;
using System.Globalization;

namespace waConcessionaria {

    public partial class wfCarro : System.Web.UI.Page {

        protected void Page_Load(object sender, EventArgs e) {

            if (IsPostBack) {
                lbListagemDeMarcas.Text = "";
            }
        }

        protected void Button1_Click(object sender, EventArgs e) {

            List<Carro> listaDeCarros = new List<Carro>();

            Marca m1 = new Marca(1001, "Volkswagen", "Alemanha");
            Marca m2 = new Marca(1002, "General Motors", "Estados Unidos");

            listaDeCarros.Add(new Carro(101, "Fusca", 1980, 5000.0, m1));
            listaDeCarros.Add(new Carro(102, "Golf", 2016, 60000.0, m1));
            listaDeCarros.Add(new Carro(103, "Fox", 2017, 30000.0, m1));
            listaDeCarros.Add(new Carro(104, "Cruze", 2016, 30000.0, m2));
            listaDeCarros.Add(new Carro(105, "Cobalt", 2015, 25000.0, m2));
            listaDeCarros.Add(new Carro(106, "Cobalt", 2017, 35000.0, m2));

            switch (ddlMenu.SelectedValue.ToString()) {
                case "1":
                    lbListagemDeMarcas.Text = "1 empty!";
                    break;
                case "2":
                    listaCarros(listaDeCarros);
                    break;
                case "3":
                    lbListagemDeMarcas.Text = "3 empty!";
                    break;
                case "4":
                    lbListagemDeMarcas.Text = "4 empty!";
                    break;
                case "5":
                    lbListagemDeMarcas.Text = "5 empty!";
                    break;
                case "6":
                    lbListagemDeMarcas.Text = "6 empty!";
                    break;
                case "7":
                    lbListagemDeMarcas.Text = "7 empty!";
                    break;
            }
        }

        public void listaCarros(List<Carro> listaDeCarros) {
            
            //Variaveis para os objetos
            Table table;
            TableHeaderRow header;
            TableRow row;
            TableCell cell;

            //Variáveis para o cabecalho
            string headerCarCodigo = "CODIGO";
            string headerCarModelo = "MODELO";
            string headerCarAnoFabricacao = "ANO";
            string headerCarPrecoBasico = "PREÇO BÁSICO";
            string headerCarMarca = "MARCA";
            string headerCarPrecorTotal = "PREÇO TOTAL";

            //Tabela
            table = new Table();
            table.CellPadding = 5;
            table.BorderWidth = 2;
            table.BorderColor = Color.FromArgb(190, 190, 190);

            #region "Table header"
            //Cabecalho
            header = new TableHeaderRow();
            header.Font.Size = 9;
            header.ForeColor = Color.FromArgb(55, 55, 55);
            header.BackColor = Color.FromArgb(190, 190, 190);
            header.BorderWidth = 1;
            header.BorderColor = Color.FromArgb(255, 255, 255);

            //Cabecalho - Coluna 1
            cell = new TableHeaderCell();
            cell.Text = headerCarMarca;
            header.Cells.Add(cell);
            header.Cells.Add(cell);

            //Cabecalho - Coluna 2
            cell = new TableHeaderCell();
            cell.Text = headerCarCodigo;
            header.Cells.Add(cell);
            header.Cells.Add(cell);

            //Cabecalho - Coluna 3
            cell = new TableHeaderCell();
            cell.Text = headerCarModelo;
            header.Cells.Add(cell);
            header.Cells.Add(cell);

            //Cabecalho - Coluna 4
            cell = new TableHeaderCell();
            cell.Text = headerCarAnoFabricacao;
            header.Cells.Add(cell);
            header.Cells.Add(cell);

            //Cabecalho - Coluna 5
            cell = new TableHeaderCell();
            cell.Text = headerCarPrecoBasico;
            header.Cells.Add(cell);
            header.Cells.Add(cell);

            //Cabecalho - Coluna 6
            cell = new TableHeaderCell();
            cell.Text = headerCarPrecorTotal;
            header.Cells.Add(cell);
            header.Cells.Add(cell);

            //Atribui header à tabela
            table.Rows.Add(header);
            #endregion

            #region "Table rows"
            for (int i = 0; i < listaDeCarros.Count; i++) {

                row = new TableRow();
                
                //Linha [i] - Coluna 1
                cell = new TableCell();
                cell.Text = listaDeCarros[i].marca.nome;
                row.Cells.Add(cell);
                table.Rows.Add(row);

                //Linha [i] - Coluna 2
                cell = new TableCell();
                cell.Text = listaDeCarros[i].codigo.ToString();
                row.Cells.Add(cell);
                table.Rows.Add(row);

                //Linha [i] - Coluna 3
                cell = new TableCell();
                cell.Text = listaDeCarros[i].modelo;
                row.Cells.Add(cell);
                table.Rows.Add(row);

                //Linha [i] - Coluna 4
                cell = new TableCell();
                cell.Text = listaDeCarros[i].anoFabricacao.ToString();
                row.Cells.Add(cell);
                table.Rows.Add(row);

                //Linha [i] - Coluna 5
                cell = new TableCell();
                cell.Text = listaDeCarros[i].precoBasico.ToString();
                row.Cells.Add(cell);
                table.Rows.Add(row);

                //Linha [i] - Coluna 6
                cell = new TableCell();
                cell.Text = listaDeCarros[i].calcValorTotal().ToString();
                row.Cells.Add(cell);
                table.Rows.Add(row);

                //Layout das linhas
                row.BackColor = Color.FromArgb(230, 230, 230);
                row.BorderColor = Color.FromArgb(0, 0, 0);
                row.BorderWidth = 2;
                row.HorizontalAlign = HorizontalAlign.Center;
                row.VerticalAlign = VerticalAlign.Middle;
            }
            #endregion

            //Joga a tabela na tela
            phListagem.Controls.Add(table);
        }
    }
}