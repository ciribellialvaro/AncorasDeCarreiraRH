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
            Console.WriteLine("\n\n\n\nDescobrindo o resultado\n" +
                "Agora reveja suas respostas e localize os itens em que você deu pontos mais altos (normalmente 5 ou 6)." +
                " Dessas respostas, selecione as três que sejam as mais verdadeiras para você e adicione a cada uma mais 4 pontos. " +
                "\n\n\n\nA seguir, vou mostrar o que cada grupo representa: ");


            Console.ReadKey();
            Console.WriteLine("\r\n\r\n1 — Competência técnica/funcional\r\n" +
                "Pessoas tecnicamente ancoradas comprometem-se com uma carreira" +
                " de especialização. Elas ficam motivadas quando são especialistas" +
                " em um determinado assunto, buscam trabalhos desafiadores," +
                " querem testar o conhecimento e a habilidade que têm em sua área de atuação." +
                "\r\n\r\nSão pessoas que não visam altos cargos administrativos " +
                "(essas, normalmente, são mais generalistas), e sim cargos de especialista em uma determinada área.\r\n\r\n" +
                "2 — Competência administrativa/geral\r\nQuem tem como âncora de carreira a competência administrativa geral busca," +
                " ao longo de sua vida profissional, atingir os mais altos níveis de responsabilidade na organização.\r\n\r\n" +
                "São pessoas que visam a liderança e têm como motivação atingir o topo da hierarquia corporativa. Para elas," +
                " a especialização é uma armadilha: entendem a importância de conhecer as áreas funcionais," +
                " mas não buscam se aprofundar tecnicamente, pois querem a função de gerência-geral.\r\n\r\n" +
                "3 — Autonomia e independência\r\nPessoas com essa âncora vão buscar, com o passar do tempo," +
                " uma carreira que possibilite maior independência, que permita impor suas próprias condições.\r\n\r\n" +
                "A autonomia é inerente a qualquer ser humano, em níveis diferentes, mas quem tem fortemente" +
                " essa âncora sente a necessidade de ser dono de seu próprio destino, fazer as coisas do seu jeito;" +
                " por isso, vai organizar sua vida profissional em torno de trabalhos que lhe proporcionem mais escolha e poder de decisão.\r\n\r\n" +
                "4 — Segurança e estabilidade\r\nAqui se enquadram pessoas que precisam se sentir seguras no ambiente de trabalho." +
                " Elas buscam maior previsibilidade do futuro, querem “saber onde pisam”." +
                " São atraídas por empregos em empresas que oferecem essa estabilidade, com bons planos de aposentadoria e boa reputação." +
                " É essa estabilidade, principalmente financeira, que vai guiar a carreira desses profissionais.\r\n\r\n" +
                "5 — Criatividade empreendedora\r\nNessa âncora, estão os profissionais com tino para a criação de novos negócios e organizações." +
                " Não são pessoas necessariamente com criatividade artística, mas sim com um espírito empreendedor," +
                " que querem estabelecer ou reestruturar negócios próprios.\r\n\r\nTêm motivação para, desde cedo," +
                " iniciar empreendimentos para ganhar dinheiro. Vale ressaltar que o enfoque aqui não é a busca por autonomia, e sim pela criação de negócios.\r\n\r\n" +
                "6 — Dedicação a uma causa\r\nPessoas com essa âncora são orientadas em sua carreira por valores que querem imprimir em seu trabalho." +
                " Elas se voltam para os valores e se dedicam a causas, mais do que aos seus talentos e competências. São profissionais que querem," +
                " de alguma forma, contribuir para um mundo melhor por meio de seu trabalho.\r\n\r\n" +
                "7 — Desafio puro\r\nNessa âncora," +
                " se encaixam profissionais que definem sucesso como a superação de obstáculos impossíveis ou como a capacidade de solucionar problemas insolúveis." +
                " São pessoas que necessitam sentir que podem conquistar qualquer coisa.\r\n\r\n" +
                "A busca por desafios permeia a carreira de quase todo mundo, mas, para quem é ancorado no desafio puro," +
                " é o que norteia a sua trajetória — todas as suas decisões profissionais vão sempre ser com o objetivo de superar desafios cada vez maiores.\r\n\r\n" +
                "8 — Estilo de vida\r\nMuitas vezes, interpretam essa âncora como sendo a de pessoas que não dão prioridade à sua carreira," +
                " mas não se trata disso. A questão é que pessoas ancoradas pelo estilo de vida buscam encontrar uma forma de integrar todas as suas necessidades:" +
                " individuais, de família e de carreira. Podem ser altamente motivadas pelo trabalho, mas entendem que ele deve ser apenas uma parte de sua vida como um todo.\r\n\r\n" +
                "São pessoas que querem, acima de tudo, flexibilidade. Por isso, olham mais para a atitude da empresa do que para o programa de trabalho propriamente dito." +
                " A diferença para a âncora da autonomia é que elas se adaptam bem ao ambiente organizacional, com suas regras e restrições, mas querem ter opções mais flexíveis de trabalho.");
            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
