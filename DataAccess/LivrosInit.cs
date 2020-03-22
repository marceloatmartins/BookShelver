using BookShelver.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BookShelver.DataAccess
{
    public class LivrosInit : CreateDatabaseIfNotExists<LivroContext>
    {
        protected override void Seed(LivroContext context)
        {

            List<Genero> generos = new List<Genero>()
            {
                new Genero() { Name = "Administração" },
                new Genero() { Name = "Agropecuária" },
                new Genero() { Name = "Artes" },
                new Genero() { Name = "Autoajuda" },
                new Genero() { Name = "Ciências Biológicas" },
                new Genero() { Name = "Ciências Exatas" },
                new Genero() { Name = "Ciências Humanas e Sociais" },
                new Genero() { Name = "Cursos e Idiomas" },
                new Genero() { Name = "Didáticos" },
                new Genero() { Name = "Direito" },
                new Genero() { Name = "Economia" },
                new Genero() { Name = "Engenharia e Tecnologia" },
                new Genero() { Name = "Gastronomia" },
                new Genero() { Name = "Geografia e Historia" },
                new Genero() { Name = "Informática" },
                new Genero() { Name = "Linguística" },
                new Genero() { Name = "Literatura Nacional" },
                new Genero() { Name = "Medicina" },
                new Genero() { Name = "Religião" },
                new Genero() { Name = "Turismo" },
            };

            generos.ForEach(g => context.Generos.Add(g));

            List<Livro> livros = new List<Livro>()
            {
                new Livro() {
                            Title = "O Poder do Hábito - Por Que Fazemos o Que Fazemos na Vida e Nos Negócios",
                            Author = "Duhigg, Charles",
                            YearEdition = 2012,
                            Value = 40.00m,
                            Genero = generos.FirstOrDefault(g => g.Name == "Administração")
                },
                new Livro() {
                            Title = "Os Segredos da Mente Milionária - Aprenda a Enriquecer Mudando seus Conceitos Sobre o Dinheiro",
                            Author = "Eker, T. Harv",
                            YearEdition = 1992,
                            Value = 22.40m,
                            Genero = generos.FirstOrDefault(g => g.Name == "Administração")
                },
                new Livro() {
                            Title = "Adestramento Inteligente",
                            Author = "Rossi, Alexandre",
                            YearEdition = 2015,
                            Value = 20.80m,
                            Genero = generos.FirstOrDefault(g => g.Name == "Agropecuária")
                },
                new Livro() {
                            Title = "Aves Florestais do Brasil",
                            Author = "Bini, Etson",
                            YearEdition = 2014,
                            Value = 89.90m,
                            Genero = generos.FirstOrDefault(g => g.Name == "Agropecuária")
                },
                new Livro() {
                            Title = "Guerra Civil",
                            Author = "McNiven, Steve; MILLAR, MARK",
                            YearEdition = 2010,
                            Value = 48m,
                            Genero = generos.FirstOrDefault(g => g.Name == "Artes")
                },
                new Livro() {
                            Title = "Batman - A Morte da Família",
                            Author = "Capullo, Greg; Snyder, Scott",
                            YearEdition = 2016,
                            Value = 60.80m,
                            Genero = generos.FirstOrDefault(g => g.Name == "Artes")
                },
                new Livro() {
                            Title = "Manual de Sobrevivência do Adolescente",
                            Author = "Loures, Camila",
                            YearEdition = 2016,
                            Value = 19.90m,
                            Genero = generos.FirstOrDefault(g => g.Name == "Autoajuda")
                },
                new Livro() {
                            Title = "O Mapa da Felicidade - As Coordenadas Para Curar A Sua Vida e Nunca Mais Olhar Para Trás",
                            Author = "Capelas, Heloísa",
                            YearEdition = 2014,
                            Value = 23.90m,
                            Genero = generos.FirstOrDefault(g => g.Name == "Autoajuda")
                },
                new Livro() {
                            Title = "A Origem Das Espécies - Edição Ilustrada",
                            Author = "Darwin, Charles",
                            YearEdition = 2014,
                            Value = 71.90m,
                            Genero = generos.FirstOrDefault(g => g.Name == "Ciências Biológicas")
                },
                new Livro() {
                            Title = "A Sexta Extinção - Uma História Não Natural",
                            Author = "Kolbert, Elizabeth",
                            YearEdition = 2015,
                            Value = 17.00m,
                            Genero = generos.FirstOrDefault(g => g.Name == "Ciências Biológicas")
                },
                new Livro() {
                            Title = "Raciocínio Lógico Facilitado",
                            Author = "Villar, Bruno",
                            YearEdition = 2016,
                            Value = 134.10m,
                            Genero = generos.FirstOrDefault(g => g.Name == "Ciências Exatas")
                },
                new Livro() {
                            Title = "Cálculo",
                            Author = "Stewart, James",
                            YearEdition = 2015,
                            Value = 143.20m,
                            Genero = generos.FirstOrDefault(g => g.Name == "Ciências Exatas")
                },
                new Livro() {
                            Title = "Uma Breve História da Humanidad",
                            Author = "Harari, Yuval Noah",
                            YearEdition = 2015,
                            Value = 47.90m,
                            Genero = generos.FirstOrDefault(g => g.Name == "Ciências Humanas e Sociais")
                },
                new Livro() {
                            Title = "O Príncipe - Obra Completa",
                            Author = "Maquiavel, Nicolau",
                            YearEdition = 2007,
                            Value = 17.10m,
                            Genero = generos.FirstOrDefault(g => g.Name == "Ciências Humanas e Sociais")
                },
                new Livro() {
                            Title = "English Grammar In Use With Answers",
                            Author = "Murphy, Raymond",
                            YearEdition = 2012,
                            Value = 173.50m,
                            Genero = generos.FirstOrDefault(g => g.Name == "Cursos e Idiomas")
                },
                new Livro() {
                            Title = "Gramática Y Práctica de Español",
                            Author = "Fanjul, AdrIan",
                            YearEdition = 2014,
                            Value = 82.00m,
                            Genero = generos.FirstOrDefault(g => g.Name == "Cursos e Idiomas")
                },
                new Livro() {
                            Title = "Novíssima Gramática da Língua Portuguesa",
                            Author = "Cegalla, Domingos Paschoal",
                            YearEdition = 2009,
                            Value = 82.00m,
                            Genero = generos.FirstOrDefault(g => g.Name == "Didáticos")
                },
                new Livro() {
                            Title = "Química - Vol. Único",
                            Author = "Usberco, Joao; Salvador, Edgard",
                            YearEdition = 2013,
                            Value = 194.00m,
                            Genero = generos.FirstOrDefault(g => g.Name == "Didáticos")
                },
                new Livro() {
                            Title = "Direito Processual Civil Esquematizado",
                            Author = "Gonçalves, Marcus Vinicius Rios; (Coord.), Pedro Lenza",
                            YearEdition = 2016,
                            Value = 163.20m,
                            Genero = generos.FirstOrDefault(g => g.Name == "Direito")
                },
                new Livro() {
                            Title = "Direito Administrativo",
                            Author = "Pietro, Maria Sylvia Zanella Di",
                            YearEdition = 2016,
                            Value = 108.10m,
                            Genero = generos.FirstOrDefault(g => g.Name == "Direito")
                },
                new Livro() {
                            Title = "O Capital - No Século XXI",
                            Author = "Piketty, Thomas",
                            YearEdition = 2014,
                            Value = 34.20m,
                            Genero = generos.FirstOrDefault(g => g.Name == "Economia")
                },
                new Livro() {
                            Title = "Fundamentos de Economia",
                            Author = "Vasconcellos, Marco Antonio S.; Garcia, Manuel E.",
                            YearEdition = 2014,
                            Value = 68.10m,
                            Genero = generos.FirstOrDefault(g => g.Name == "Economia")
                },
                new Livro() {
                            Title = "Manual Do Mundo",
                            Author = "Alfredo Luis Mateus; Ibere Thenorio",
                            YearEdition = 2014,
                            Value = 39.70m,
                            Genero = generos.FirstOrDefault(g => g.Name == "Engenharia e Tecnologia")
                },
                new Livro() {
                            Title = "Ciência Engenharia de Materiais -Uma Introdução",
                            Author = "Callister Jr., William D.",
                            YearEdition = 2012,
                            Value = 223.80m,
                            Genero = generos.FirstOrDefault(g => g.Name == "Engenharia e Tecnologia")
                },
                new Livro() {
                            Title = "Bela Cozinha - As Receitas",
                            Author = "Gil , Bela",
                            YearEdition = 2014,
                            Value = 29.10m,
                            Genero = generos.FirstOrDefault(g => g.Name == "Gastronomia")
                },
                new Livro() {
                            Title = "Por Uma Vida Mais Doce",
                            Author = "Noce, Danielle",
                            YearEdition = 2014,
                            Value = 79.80m,
                            Genero = generos.FirstOrDefault(g => g.Name == "Gastronomia")
                },
                new Livro() {
                            Title = "1808",
                            Author = "Gomes, Laurentino",
                            YearEdition = 2014,
                            Value = 31.90m,
                            Genero = generos.FirstOrDefault(g => g.Name == "Geografia e Historia")
                },
                new Livro() {
                            Title = "A História do Mundo Para Quem Tem Pressa -Mais de 5000 Anos de História Resumidos Em 200 Páginas",
                            Author = "Marriot, Emma",
                            YearEdition = 2015,
                            Value = 22.60m,
                            Genero = generos.FirstOrDefault(g => g.Name == "Geografia e Historia")
                },
                new Livro() {
                            Title = "Redes de Computadores",
                            Author = "Tanenbaum, Andrew S.; J.Wetherall, David",
                            YearEdition = 2011,
                            Value = 166.40m,
                            Genero = generos.FirstOrDefault(g => g.Name == "Informática")
                },
                new Livro() {
                            Title = "Lógica de Programação - Conhecendo Algoritmos e Criando Programas",
                            Author = "Simão , Daniel Hayashida; Reis , Wellington José Dos",
                            YearEdition = 2015,
                            Value = 26.40m,
                            Genero = generos.FirstOrDefault(g => g.Name == "Informática")
                },
                new Livro() {
                            Title = "Mídia Training - Como Usar A Mídia A Seu Favor",
                            Author = "Barbeiro, Herodoto",
                            YearEdition = 2015,
                            Value = 25.30m,
                            Genero = generos.FirstOrDefault(g => g.Name == "Linguística")
                },
                new Livro() {
                            Title = "Anatomia de Um Julgamento - Ifigênia Em Forest Hills",
                            Author = "Malcolm, Janet",
                            YearEdition = 2012,
                            Value = 22.40m,
                            Genero = generos.FirstOrDefault(g => g.Name == "Linguística")
                },
                new Livro() {
                            Title = "Tratado de Medicina Interna Veterinária - Doenças do Cão e do Gato",
                            Author = "Ettinger, Stephen J.; Feldman, Edward C.",
                            YearEdition = 2004,
                            Value = 1309.50m,
                            Genero = generos.FirstOrDefault(g => g.Name == "Medicina")
                },
                new Livro() {
                            Title = "Clínica Veterinária - Um Tratado de Doenças dos Bovinos, Ovinos, Suínos, Caprinos e Equinos",
                            Author = "Outros; Blood, Douglas C.; Radostits, Otto M.",
                            YearEdition = 2002,
                            Value = 1080.00m,
                            Genero = generos.FirstOrDefault(g => g.Name == "Medicina")
                },
                new Livro() {
                            Title = "Quarto de Guerra - A Oração É Uma Arma Poderosa na Batalha Espiritual",
                            Author = "Fabry, Chris",
                            YearEdition = 2015,
                            Value = 25.50m,
                            Genero = generos.FirstOrDefault(g => g.Name == "Religião")
                },
                new Livro() {
                            Title = "Cristianismo Puro e Simples",
                            Author = "Lewis, C. S.",
                            YearEdition = 2009,
                            Value = 36.00m,
                            Genero = generos.FirstOrDefault(g => g.Name == "Religião")
                },
                new Livro() {
                            Title = "Não Conta Lá Em Casa",
                            Author = "Fran, André",
                            YearEdition = 2013,
                            Value = 56.60m,
                            Genero = generos.FirstOrDefault(g => g.Name == "Turismo")
                },
                new Livro() {
                            Title = "O Melhor Guia de Nova York",
                            Author = "Andrade, Pedro",
                            YearEdition = 2013,
                            Value = 29.30m,
                            Genero = generos.FirstOrDefault(g => g.Name == "Turismo")
                }
            };

            livros.ForEach(l => context.Livros.Add(l));

            context.SaveChanges();



        }
    }
}