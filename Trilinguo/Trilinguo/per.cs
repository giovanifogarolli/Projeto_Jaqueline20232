using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trilinguo
{
    internal class per
    {

        // PERGUNTA E RESPOSTA EM INGLES DIFIFULDADE FACIL

        private string[] pergunta =
        {
            "1",
            "2",
            "3",
            "4",
            "5",
        };
        private string[] resposta =
        {
            "1",
            "2",
            "3",
            "4",
            "5",
        };

        // PERGUNTA E RESPOSTA EM INGLES DIFIFULDADE MEDIO

        private string[] pergunta2 =
{
            "10",
            "20",
            "30",
            "40",
            "50",
        };
        private string[] resposta2 =
        {
            "10",
            "20",
            "30",
            "40",
            "50",
        };

        // ITALIANO

        // PERGUNTA E RESPOSTA EM INGLES DIFIFULDADE DIFICIL

        private string[] pergunta3 =
{
            "100",
            "200",
            "300",
            "400",
            "500",
        };
        private string[] resposta3 =
        {
            "100",
            "200",
            "300",
            "400",
            "500",
        };

        // PERGUNTA E RESPOSTA EM ITALIANO DIFICULDADE FACIL
        private string[] itpergunta1 =
        {
            "La ragazza è straniera",
            "Paul è in Italia per la prima volta",
            "Buon giorno, Jaqueline",
            "Ciao, João, come stai?",
            "Giovani vuole organizzare una festa",
        };
        private string[] itresposta1 = 
        {
            "A garota é estrangeira",
            "Paulo está na Italia pela primeira vez",
            "Bom dia, Jaqueline",
            "Olá João, como está?",
            "Giovani quer organizar uma festa",
        };

        // PERGUNTA E RESPOSTA EM ITALIANO DIFICULDADE MEDIA
        private string[] itpergunta2 =
        {
            "Dottore, ho tanto dolore e tanta paura",
            "Vorrei un paio di scarpe nere",
            "Sono convinto, ma quanto costa questo vestito?",
            "La famiglia è andata a fare un picnic",
            "Il papà decide di portare il cucciolo allo zoo",
        };
        private string[] itresposta2 =
        {
            "Doutor, tenho tanta dor e tanto medo",
            "Eu gostaria de um par de sapatos pretos",
            "Estou convencida, mas quanto custa esse vestido?",
            "A familia foi fazer um picnic",
            "O Papai decidiu levar o filhote ao zoológico",
        };

        // PERGUNTA E RESPOSTA EM ITALIANO DIFICULDADE DIFICIL
        private string[] itpergunta3 =
        {
            "Veramente ho un po'fretta, ma una birra la bevo con piacere.",
            "Vi lascio al vostro caffè",
            "Quando sono arrivato qui non conoscevo nessuno",
            "Qual è il vostro indirizzo?",
            "La maquina è rotta",
        };
        private string[] itresposta3 =
        {
            "Certamente estou com pressa, mas uma cerveja bebo com prazer",
            "Deixo-vos com vosso café",
            "Quando chegamos aqui não conheciamos ninguém",
            "Qual é o seu endereço?",
            "O carro está quebrado",
        };

        // IMAGEM E RESPOSTA EM ITALIANO DIFIFULDADE FACIL

        private string[] ITrespostaimg1 =
        {
            "Cane",
            "Gatto",
            "Vacca",
            "Leone",
            "Orso",
        };
        private Bitmap[] imagemIT1 = new Bitmap[]{
            Properties.Resources.Cachorro,
            Properties.Resources.gato,
            Properties.Resources.vaca,
            Properties.Resources.leão,
            Properties.Resources.Urso,
        };

        // IMAGEM E RESPOSTA EM ITALIANO DIFIFULDADE MEDIA

        private string[] ITrespostaimg2 =
{
            "Topo",
            "Pesce",
            "Lupo",
            "Rana",
            "Gufo",
        };
        private Bitmap[] imagemIT2 = new Bitmap[]{
            Properties.Resources.rato,
            Properties.Resources.peixe,
            Properties.Resources.Lupo,
            Properties.Resources.Ra,
            Properties.Resources.coruja,
        };

        // IMAGEM E RESPOSTA EM ITALIANO DIFIFULDADE DIFICIL

        private string[] ITrespostaimg3 =
{
            "Coccodrillo",
            "Scimmia",
            "Struzzo",
            "Fenicottero",
            "Piccione",
        };
        private Bitmap[] imagemIT3 = new Bitmap[]{
            Properties.Resources.Crocodilo,
            Properties.Resources.Macaco,
            Properties.Resources.Avestruz,
            Properties.Resources.Flamingo,
            Properties.Resources.pombo,
        };


        public string[] Pergunta { get => pergunta; set => pergunta = value; }
        public string[] Resposta { get => resposta; set => resposta = value; }
        public string[] Pergunta2 { get => pergunta2; set => pergunta2 = value; }
        public string[] Resposta2 { get => resposta2; set => resposta2 = value; }
        public string[] Pergunta3 { get => pergunta3; set => pergunta3 = value; }
        public string[] Resposta3 { get => resposta3; set => resposta3 = value; }
        public Bitmap[] ImagemIT1 { get => imagemIT1; set => imagemIT1 = value; }
        public string[] ITRespostaimg1 { get => ITrespostaimg1; set => ITrespostaimg1 = value; }
        public string[] ITRespostaimg2 { get => ITrespostaimg2; set => ITrespostaimg2 = value; }
        public Bitmap[] ImagemIT2 { get => imagemIT2; set => imagemIT2 = value; }
        public string[] ITRespostaimg3 { get => ITrespostaimg3; set => ITrespostaimg3 = value; }
        public Bitmap[] ImagemIT3 { get => imagemIT3; set => imagemIT3 = value; }
        public string[] Itpergunta1 { get => itpergunta1; set => itpergunta1 = value; }
        public string[] Itresposta1 { get => itresposta1; set => itresposta1 = value; }
        public string[] Itpergunta2 { get => itpergunta2; set => itpergunta2 = value; }
        public string[] Itresposta2 { get => itresposta2; set => itresposta2 = value; }
        public string[] Itpergunta3 { get => itpergunta3; set => itpergunta3 = value; }
        public string[] Itresposta3 { get => itresposta3; set => itresposta3 = value; }
    }
}
