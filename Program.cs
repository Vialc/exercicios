using System;
public class Program { 

    public static double capital,taxa,tipoJuros,resultado;
    public static DateTime resgate;
    public static void Main(){
      
        Console.WriteLine("Escolha a Modalidade de Juros [0]Simples ou [1] Composto");
        tipoJuros = double.Parse(Console.ReadLine());
        
       // Console.WriteLine("o valor do resto é: {0}",numero);

        switch (tipoJuros){

            case 0: Console.WriteLine("Modalidade Escolhida: Juros Simples");
            tipoJuros = Simples(tipoJuros, capital, taxa, resgate);
            break;

            case 1: Console.WriteLine("Modalidade Escolhida: Juros Compostos");
            tipoJuros = Composto(tipoJuros, capital, taxa, resgate);
            break;

            default: Console.WriteLine("Opção Inválida");
            break;
       
    }
}

public static double Simples(double tipoJuros, double capital, double taxa, DateTime resgate){

Console.WriteLine("Digite o Capital Inicial: ");
capital= double.Parse(Console.ReadLine());
Console.WriteLine("Digite a taxa de Juros: ");
taxa = double.Parse(Console.ReadLine())/100;
Console.WriteLine("Digite a data do resgate: ");
resgate =new DateTime(Console.Read());
int tempo= resgate.Month - DateTime.Now.Month;
double resultado = capital * tempo * taxa;
Console.WriteLine("Seu resgate ocorrerá em: {0} meses",tempo);
return resultado;

}

public static double Composto(double tipoJuros, double capital, double taxa, DateTime resgate){

Console.WriteLine("Digite o Capital Inicial: ");
capital= double.Parse(Console.ReadLine());
Console.WriteLine("Digite a taxa de Juros: ");
taxa = double.Parse(Console.ReadLine())/100;
Console.WriteLine("Digite a data do resgate: ");
resgate =new DateTime(Console.Read());
int tempo= resgate.Month - DateTime.Now.Month;   
double resultado = capital * Math.Pow((1+ taxa), tempo);
Console.WriteLine("Seu resgate ocorrerá em: {0} meses",tempo);
Console.WriteLine("O valor final é: {0}",resultado);
return resultado;

}

}

