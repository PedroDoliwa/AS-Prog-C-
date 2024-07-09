using System;

class FuncionarioTempoIntegral : Funcionario, IBonus
{
    // Variável privada para armazenar o salário mensal
    private double SalarioMensal;

    // Construtor para inicializar nome, matrícula e salário mensal
    public FuncionarioTempoIntegral(string nome, string matricula, double salarioMensal) : base(nome, matricula)
    {
        SalarioMensal = salarioMensal;
    }

    // Implementação do método CalcularSalario
    public override double CalcularSalario()
    {
        return SalarioMensal;
    }

    // Implementação do método ExibirInformacoes
    public override void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Matrícula: {Matricula}");
        Console.WriteLine($"Salário Mensal: {SalarioMensal}");
        Console.WriteLine($"Bônus: {CalcularBonus()}");
        Console.WriteLine("Projetos: ");
        foreach (var projeto in Projetos)
        {
            Console.WriteLine($"- {projeto}");
        }
    }

    // Implementação do método CalcularBonus da interface IBonus
    public double CalcularBonus()
    {
        return SalarioMensal * 0.10;
    }
}
