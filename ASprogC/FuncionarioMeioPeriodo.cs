using System;

class FuncionarioMeioPeriodo : Funcionario, IBonus
{
    // Variáveis privadas para armazenar o salário por hora e o número de horas trabalhadas
    private double SalarioPorHora;
    private int HorasTrabalhadas;

    // Construtor para inicializar nome, matrícula, salário por hora e número de horas trabalhadas
    public FuncionarioMeioPeriodo(string nome, string matricula, double salarioPorHora, int horasTrabalhadas) : base(nome, matricula)
    {
        SalarioPorHora = salarioPorHora;
        HorasTrabalhadas = horasTrabalhadas;
    }

    // Implementação do método CalcularSalario
    public override double CalcularSalario()
    {
        return SalarioPorHora * HorasTrabalhadas;
    }

    // Implementação do método ExibirInformacoes
    public override void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Matrícula: {Matricula}");
        Console.WriteLine($"Salário por Hora: {SalarioPorHora}");
        Console.WriteLine($"Horas Trabalhadas: {HorasTrabalhadas}");
        Console.WriteLine($"Salário Total: {CalcularSalario()}");
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
        return CalcularSalario() * 0.05;
    }
}
