using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// User interface
Console.WriteLine("Welcome to our hotelling program! Can you state your name?");
string userName = Console.ReadLine();
Console.WriteLine($"Welcome, {userName}! Do you wish to register a new person?");
Console.WriteLine(" 1 - Yes\n 2 - No");
int userChoiceRegistration = Console.Read();

//Checking for opting out
if (userChoiceRegistration == 2)
{
    Console.WriteLine($"Got it! Thanks for using our program, {userName}.");
    System.Environment.Exit(0);
}

Console.WriteLine($"Ok, {userName}. Let's begin.");

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Hóspede 1");
Pessoa p2 = new Pessoa(nome: "Hóspede 2");

hospedes.Add(p1);
hospedes.Add(p2);

// Cria a suíte
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 3, valorDiaria: 30);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new Reserva(diasReservados: 5);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");