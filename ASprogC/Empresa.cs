using System;
using System.Collections.Generic;

class Empresa
{
    // Lista de funcionários
    private List<Funcionario> Funcionarios;

    // Construtor
    public Empresa()
    {
        Funcionarios = new List<Funcionario>();
    }

    // Método para adicionar um funcionário à lista
    public void AdicionarFuncionario(Funcionario funcionario)
    {
        Funcionarios.Add(funcionario);
    }

    // Método para remover um funcionário da lista com base na matrícula
    public void RemoverFuncionario(string matricula)
    {
        List<Funcionario> funcionariosParaRemover = new List<Funcionario>();

        foreach (var funcionario in Funcionarios)
        {
            if (funcionario.Matricula == matricula)
            {
                funcionariosParaRemover.Add(funcionario);
            }
        }

        foreach (var funcionario in funcionariosParaRemover)
        {
            Funcionarios.Remove(funcionario);
        }
    }

    // Método para exibir as informações de todos os funcionários na lista
    public void ExibirFuncionarios()
    {
        foreach (var funcionario in Funcionarios)
        {
            funcionario.ExibirInformacoes();
            Console.WriteLine();
        }
    }

    // Método para adicionar projeto(s) a um funcionário
    public void AdicionarProjeto(string matricula, List<string> projetos)
    {
        foreach (var funcionario in Funcionarios)
        {
            if (funcionario.Matricula == matricula)
            {
                funcionario.AdicionarProjeto(projetos);
                return;
            }
        }
        Console.WriteLine("Funcionário não encontrado.");
    }
}

