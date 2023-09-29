using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AncorasDeCarreiraRH
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] respostas = new int[40];

            string[] perguntas = new string[]
            {
            "Sonho em ser tão bom no que faço que minha opinião de especialista seja sempre solicitada.",
            "Me sinto mais realizado em meu trabalho quando sou capaz de integrar e gerenciar o trabalho dos outros.",
            "Sonho em ter uma carreira que me dê a liberdade de fazer o trabalho do meu jeito e no tempo por mim programado.",
            "Segurança e estabilidade são mais importantes para mim do que liberdade e autonomia.",
            "Estou sempre procurando ideias que me permitam iniciar meu próprio negócio.",
            "Sentirei sucesso na minha carreira se sentir que contribuí verdadeiramente para o bem-estar da sociedade.",
            "Sonho com uma carreira na qual eu possa solucionar problemas ou vencer em situações extremamente desafiadoras.",
            "Prefiro deixar meu emprego a ser colocado em um trabalho que comprometa minha capacidade de satisfazer meus interesses pessoais e familiares.",
            "Só me sentirei bem-sucedido em minha carreira se puder desenvolver minhas habilidades técnicas e funcionais até o mais alto nível de competência.",
            "Sonho em dirigir uma organização complexa e tomar decisões que afetem muitas pessoas.",
            "Me sinto mais realizado em meu trabalho quando tenho total liberdade de definir minhas próprias tarefas, horários e procedimentos.",
            "Prefiro manter minha atividade atual a aceitar outra tarefa que possa colocar em risco minha segurança na empresa.",
            "Montar meu próprio negócio é mais importante para mim do que atingir uma alta posição gerencial como funcionário.",
            "Me sinto mais realizado em minha carreira quando posso utilizar meus talentos a serviço dos outros.",
            "Me sinto realizado em minha carreira apenas quando enfrento e supero desafios extremamente difíceis.",
            "Sonho com uma carreira que me permita integrar minhas necessidades pessoais, familiares e de trabalho.",
            "Me tornar um gerente técnico em minha área de especialização é mais atraente para mim do que me tornar um gerente geral em alguma organização.",
            "Me sentirei bem-sucedido em minha carreira apenas quando me tornar um gerente geral em alguma organização.",
            "Me sentirei bem-sucedido em minha carreira apenas quando alcançar total autonomia e liberdade.",
            "Procuro trabalhos em organizações que me deem senso de segurança e estabilidade.",
            "Me sinto realizado em minha carreira quando sou capaz de construir alguma coisa que seja inteiramente resultado de minhas ideias e esforços.",
            "Utilizar minhas habilidades para tornar o mundo um lugar melhor para se viver e trabalhar é mais importante para mim do que alcançar uma posição gerencial de alto nível.",
            "Me sinto mais realizado em minha carreira quando soluciono problemas aparentemente insolúveis ou venço o que aparentemente era impossível de ser vencido.",
            "Me sinto bem-sucedido na vida apenas quando sou capaz de equilibrar minhas necessidades pessoais, familiares e de carreira.",
            "Prefiro sair da empresa onde estou a aceitar uma tarefa em esquema rotativo que me afaste da minha área de experiência.",
            "Me tornar um diretor geral é mais atraente para mim do que me tornar um diretor técnico em minha área de especialização.",
            "Para mim, poder fazer um trabalho do meu jeito, livre de regras e restrições, é mais importante do que segurança.",
            "Me sinto mais realizado em meu trabalho quando percebo que tenho total segurança financeira e estabilidade no trabalho.",
            "Me sinto bem-sucedido em meu trabalho apenas quando posso criar ou construir alguma coisa que seja inteiramente de minha autoria.",
            "Sonho em ter uma carreira que faça uma real contribuição à humanidade e à sociedade.",
            "Procuro oportunidades de trabalho que desafiem fortemente minhas habilidades para solucionar problemas.",
            "Equilibrar as exigências da minha vida pessoal e profissional é mais importante do que alcançar alta posição gerencial.",
            "Me sinto plenamente realizado em meu trabalho quando sou capaz de empregar minhas habilidades e talentos especiais.",
            "Prefiro sair da empresa onde estou a aceitar um cargo que me afaste do caminho da diretoria geral.",
            "Prefiro sair da empresa onde estou a aceitar um cargo que reduza minha autonomia e liberdade.",
            "Sonho em ter uma carreira que me dê senso de segurança e estabilidade.",
            "Sonho em iniciar e montar meu próprio negócio.",
            "Prefiro sair da empresa onde estou a aceitar um cargo que prejudique minha capacidade de ser útil aos outros.",
            "Trabalhar em problemas praticamente insolúveis para mim é mais importante do que alcançar uma posição gerencial de alto nível.",
            "Sempre procurei oportunidades de trabalho que minimizassem interferências com assuntos pessoais e familiares."
            };

            Console.WriteLine("Por favor, responda cada pergunta de 1 a 6, onde 1 = discordo totalmente e 6 = concordo totalmente:\n");

            for (int i = 0; i < 40; i++)
            {
                Console.WriteLine($"Pergunta {i + 1}: {perguntas[i]}");

                int resposta = 0;
                bool respostaValida = false;

                while (!respostaValida)
                {
                    if (int.TryParse(Console.ReadLine(), out resposta) && resposta >= 1 && resposta <= 6)
                    {
                        respostaValida = true;
                    }
                    else
                    {
                        Console.WriteLine("Por favor, insira um número de 1 a 6.");
                    }
                }

                respostas[i] = resposta;
            }

            Console.WriteLine("\nSuas respostas foram as seguintes:");
            for (int i = 0; i < 40; i++)
            {
                Console.WriteLine($"Pergunta {i + 1}: {perguntas[i]} - Resposta: {respostas[i]}");
            }

            int[] somatorias = new int[8];
            somatorias[0] = respostas[0] + respostas[8] + respostas[16] + respostas[24] + respostas[32]; // Grupo 1
            somatorias[1] = respostas[1] + respostas[9] + respostas[17] + respostas[25] + respostas[33]; // Grupo 2
            somatorias[2] = respostas[2] + respostas[10] + respostas[18] + respostas[26] + respostas[34]; // Grupo 3
            somatorias[3] = respostas[3] + respostas[11] + respostas[19] + respostas[27] + respostas[35]; // Grupo 4
            somatorias[4] = respostas[4] + respostas[12] + respostas[20] + respostas[28] + respostas[36]; // Grupo 5
            somatorias[5] = respostas[5] + respostas[13] + respostas[21] + respostas[29] + respostas[37]; // Grupo 6
            somatorias[6] = respostas[6] + respostas[14] + respostas[22] + respostas[30] + respostas[38]; // Grupo 7
            somatorias[7] = respostas[7] + respostas[15] + respostas[23] + respostas[31] + respostas[39]; // Grupo 8

            string[] nomesGrupos = new string[]
           {
                "Técnico Funcional",
                "Segurança e Estabilidade",
                "Criatividade Empreendedora",
                "Dedicação a uma Causa",
                "Desafio Puro",
                "Estilo de Vida",
                "Desafio Puro",
                "Estilo de Vida"
           };

            // Exibindo os resultados dos grupos.
            Console.WriteLine("\nResultados dos grupos:");
            for (int i = 0; i < 8; i++)
            {
                double media = somatorias[i] / 5.0; // Calcula a média dividindo por 5.0 para obter um valor decimal.
                Console.WriteLine($"Grupo {i + 1} ({nomesGrupos[i]}): Soma = {somatorias[i]}, Média = {media:F2}");
            }


            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
