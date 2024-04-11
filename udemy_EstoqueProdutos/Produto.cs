using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace udemy_EstoqueProdutos
{
    internal class Produto
    {
        private string _nome;
        private double _preco;
        private int _quantidade;

        public Produto (string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        public string Nome
        {
            get { return _nome; }
            set 
            { 
                if (_nome != null && _nome.Length > 1)
                {
                    _nome = Nome;
                }
            }
        }

        public double Preco
        {
            get { return _preco; }   
            set { _preco = Preco; }
        }
        
        public int Quantidade
        {
            get { return _quantidade; }
            set { _quantidade = Quantidade; }
        }

        /*
        public Produto(string Nome, double Preco, int Quantidade)
        {
            nome = Nome;
            preco = Preco;
            quantidade  = Quantidade;
        }

        public Produto (string Nome, double Preco)
        {
            nome = Nome;
            preco = Preco;
            quantidade = 5;
        }
        */
        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }

        public void AdicionarProdutos(int Quantidade)
        {
            _quantidade = _quantidade + Quantidade;
        }
        public void RemoverProdutos(int Quantidade)
        {
            _quantidade = _quantidade - Quantidade;
        }
    }
}
