using System;
using System.Collections.Generic;

abstract class Funcionario
{
    // Variáveis públicas para armazenar nome, matrícula e lista de projetos
    public string Nome;
    public string Matricula;
    public List<string> Projetos;

    // Construtor para inicializar nome e matrícula
    public Funcionario(string nome, string matricula)
    {
        Nome = nome;
        Matricula = matricula;
        Projetos = new List<string>();
    }

    // Métodos abstratos
    public abstract double CalcularSalario();
    public abstract void ExibirInformacoes();

    // Método sobrecarregado para adicionar um único projeto
    public void AdicionarProjeto(string projeto)
    {
        Projetos.Add(projeto);
    }

    // Método sobrecarregado para adicionar uma lista de projetos
    public void AdicionarProjeto(List<string> projetos)
    {
        Projetos.AddRange(projetos);
    }
}
