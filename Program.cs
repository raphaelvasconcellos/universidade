using Microsoft.Extensions.DependencyInjection;

public class Program
{
    static void Main(string[] args)
    {
        var serviceCollection = new ServiceCollection();

        serviceCollection.AddSingleton<IAlunoRepository, AlunoRepository>();
        serviceCollection.AddSingleton<IAlunoService, AlunoService>();
        


        var serviceProvider = serviceCollection.BuildServiceProvider(); //Cria um container de serviceProvider

        var aluno = serviceProvider.GetService<IAlunoService>();

        Console.WriteLine("Programa encerrado!")    ;
    }

}



