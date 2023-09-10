using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trilinguo
{
    internal class eng
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

        

        public string[] Pergunta1 { get => pergunta; set => pergunta = value; }
        public string[] Resposta1 { get => resposta; set => resposta = value; }
        public string[] Pergunta2 { get => pergunta2; set => pergunta2 = value; }
        public string[] Resposta2 { get => resposta2; set => resposta2 = value; }
        public string[] Pergunta3 { get => pergunta3; set => pergunta3 = value; }
        public string[] Resposta3 { get => resposta3; set => resposta3 = value; }

    }
}
