using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Empresa empresa = new Empresa();
        bool sair = false;

        while (!sair)
        {
            Console.WriteLine();
            Console.WriteLine("==== Menu ====");
            Console.WriteLine("1. Adicionar Funcionário de Tempo Integral");
            Console.WriteLine("2. Adicionar Funcionário de Meio Período");
            Console.WriteLine("3. Remover Funcionário");
            Console.WriteLine("4. Exibir Informações de Todos os Funcionários");
            Console.WriteLine("5. Adicionar Projeto(s) a um Funcionário");
            Console.WriteLine("6. Sair");
            Console.Write("Escolha uma opção: ");

            string? opcao = Console.ReadLine();
            Console.WriteLine();

            switch (opcao)
            {
                case "1":
                    AdicionarFuncionarioTempoIntegral(empresa);
                    break;
                case "2":
                    AdicionarFuncionarioMeioPeriodo(empresa);
                    break;
                case "3":
                    RemoverFuncionario(empresa);
                    break;
                case "4":
                    ExibirFuncionarios(empresa);
                    break;
                case "5":
                    AdicionarProjeto(empresa);
                    break;
                case "6":
                    sair = true;
                    Console.WriteLine("Encerrando o programa...");
                    break;
                default:
                    Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
                    break;
            }
        }
    }

    static void AdicionarFuncionarioTempoIntegral(Empresa empresa)
    {
        Console.Write("Digite o nome do funcionário de tempo integral: ");
        string? nome = Console.ReadLine();
        if (nome == null)
        {
            Console.WriteLine("Nome não pode ser nulo.");
            return;
        }

        Console.Write("Digite a matrícula do funcionário: ");
        string? matricula = Console.ReadLine();
        if (matricula == null)
        {
            Console.WriteLine("Matrícula não pode ser nula.");
            return;
        }

        Console.Write("Digite o salário mensal do funcionário: ");
        double salarioMensal;
        while (!double.TryParse(Console.ReadLine(), out salarioMensal))
        {
            Console.WriteLine("Valor inválido. Digite novamente o salário mensal:");
        }

        FuncionarioTempoIntegral funcionario = new FuncionarioTempoIntegral(nome, matricula, salarioMensal);
        empresa.AdicionarFuncionario(funcionario);

        Console.WriteLine("Funcionário de tempo integral adicionado com sucesso!");
    }

    static void AdicionarFuncionarioMeioPeriodo(Empresa empresa)
    {
        Console.Write("Digite o nome do funcionário de meio período: ");
        string? nome = Console.ReadLine();
        if (nome == null)
        {
            Console.WriteLine("Nome não pode ser nulo.");
            return;
        }

        Console.Write("Digite a matrícula do funcionário: ");
        string? matricula = Console.ReadLine();
        if (matricula == null)
        {
            Console.WriteLine("Matrícula não pode ser nula.");
            return;
        }

        Console.Write("Digite o salário por hora do funcionário: ");
        double salarioPorHora;
        while (!double.TryParse(Console.ReadLine(), out salarioPorHora))
        {
            Console.WriteLine("Valor inválido. Digite novamente o salário por hora:");
        }

        Console.Write("Digite o número de horas trabalhadas pelo funcionário: ");
        int horasTrabalhadas;
        while (!int.TryParse(Console.ReadLine(), out horasTrabalhadas))
        {
            Console.WriteLine("Valor inválido. Digite novamente o número de horas trabalhadas:");
        }

        FuncionarioMeioPeriodo funcionario = new FuncionarioMeioPeriodo(nome, matricula, salarioPorHora, horasTrabalhadas);
        empresa.AdicionarFuncionario(funcionario);

        Console.WriteLine("Funcionário de meio período adicionado com sucesso!");
    }

    static void RemoverFuncionario(Empresa empresa)
    {
        Console.Write("Digite a matrícula do funcionário que deseja remover: ");
        string? matricula = Console.ReadLine();
        if (matricula == null)
        {
            Console.WriteLine("Matrícula não pode ser nula.");
            return;
        }

        empresa.RemoverFuncionario(matricula);

        Console.WriteLine("Funcionário removido com sucesso!");
    }

    static void ExibirFuncionarios(Empresa empresa)
    {
        Console.WriteLine("=== Funcionários da Empresa ===");
        empresa.ExibirFuncionarios();
    }

    static void AdicionarProjeto(Empresa empresa)
    {
        Console.Write("Digite a matrícula do funcionário ao qual deseja adicionar projeto(s): ");
        string? matricula = Console.ReadLine();
        if (matricula == null)
        {
            Console.WriteLine("Matrícula não pode ser nula.");
            return;
        }

        Console.Write("Digite o nome do projeto ou lista de projetos separados por vírgula: ");
        string? entradaProjetos = Console.ReadLine();
        if (entradaProjetos == null)
        {
            Console.WriteLine("A lista de projetos não pode ser nula.");
            return;
        }

        string[] projetos = entradaProjetos.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
        List<string> listaProjetos = new List<string>(projetos);

        empresa.AdicionarProjeto(matricula, listaProjetos);

        Console.WriteLine("Projeto(s) adicionado(s) com sucesso!");
    }
}
