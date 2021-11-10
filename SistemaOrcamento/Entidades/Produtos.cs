// Created by Roberto Sá on 14/09/2021

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Produtos
{ 	
	
	// Receber e enviar dados para o banco de dados
	int id_produto;
	string nome;
	string descricao;
	string unidade;
	string valor;

    public int Id_produto { get => id_produto; set => id_produto = value; }
    public string Nome { get => nome; set => nome = value; }
    public string Descricao { get => descricao; set => descricao = value; }
    public string Unidade { get => unidade; set => unidade = value; }
    public string Valor { get => valor; set => valor = value; }
}
