using System;
using System.Collections.Generic;
using System.Text;

namespace BlbliotecaDeJogos.Classes
{
    internal class Jogo
    {

        //Atributos
        private String titulo; 
        private int ano; 
        private String genero; 
        private int maxJogadores; 
        private int metacritic; 

        //Construtores
        public Jogo(String titulo, int ano, String genero, int maxJogadores, int metacritic)
        {
            this.titulo = titulo;
            this.ano = ano;
            this.genero = genero;
            this.maxJogadores = maxJogadores;
            this.metacritic = metacritic;
        }
        public Jogo(String titulo, int ano, String genero, int maxJogadores)
        {
            this.titulo = titulo;
            this.ano = ano;
            this.genero = genero;
            this.maxJogadores = maxJogadores;
        }

        // Metodos de Acesso
        public String getTitulo()
        {
            return this.titulo;
        }
        public void setTitulo(String titulo)
        {
            if (titulo != "")
            {
                this.titulo = titulo;
            }
        }
        public String getGenero()
        {
            return this.genero;
        }
        public void setGenero(String genero)
        {
            if (genero != "")
            {
                this.genero = genero;
            }
        }
        public int getAno()
        {
            return this.ano;
        }
        public void setAno(int ano)
        {
            if (ano > 1950)
            {
                this.ano = ano;
            }
        }
        public int getMaxJogadores()
        {
            return this.maxJogadores;
        }
        public void setMaxJogadores(int maxJogadores)
        {
            if (maxJogadores >= 1)
            {
                this.maxJogadores = maxJogadores;
            }
        }
        public int getMetacritic()
        {
            return this.metacritic;
        }
        public void setMetacritic(int metacritic)
        {
            if (metacritic >= 0 && metacritic <= 100)
            {
                this.metacritic = metacritic;
            }
        }



    }
}