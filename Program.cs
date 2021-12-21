using System;
public class Program { 

    public static double capital,taxa,tipoJuros,resultado;
    public static string data_fin;
    public static int tempo;
    public static void Main(){
       
        Console.WriteLine("Digite o Capital Inicial: ");
        capital= double.Parse(Console.ReadLine());
        Console.WriteLine("Digite a taxa de Juros: ");
        taxa = double.Parse(Console.ReadLine())/100;
        Console.WriteLine("Digite a data do resgate: ");
        data_fin = Console.ReadLine();

        var resgate = DateTime.Parse(data_fin);
        var data_ini = DateTime.Now;
        tempo= ajustaMesAno(resgate) - ajustaMesAno(data_ini);
        
        
      // TimeSpan tempos= resgate.Substract(DateTime.Now.Month);

        Console.WriteLine("Escolha a Modalidade de Juros [0]Simples ou [1] Composto");
        tipoJuros = double.Parse(Console.ReadLine());
        
       // Console.WriteLine("o valor do resto é: {0}",numero);

        switch (tipoJuros){

            case 0: Console.WriteLine("Modalidade Escolhida: Juros Simples");
            tipoJuros = Simples(tipoJuros, capital, taxa);
            break;

            case 1: Console.WriteLine("Modalidade Escolhida: Juros Compostos");
            tipoJuros = Composto(tipoJuros, capital, taxa);
            break;

            default: Console.WriteLine("Opção Inválida");
            break;
       
    }
}

public static double Simples(double tipoJuros, double capital, double taxa){

double resultado = capital * tempo * taxa;
Console.WriteLine("Seu resgate ocorrerá em: {0} meses",tempo);
Console.WriteLine("O valor final é: {0}",resultado);
return resultado;

}

public static double Composto(double tipoJuros, double capital, double taxa){
/*var resgate = DateTime.Parse(data_fin);
var data_ini = DateTime.Now;
var tempo= (data_ini.Date.Month - resgate.Date.Month);*/ 
double resultado = capital * Math.Pow((1+ taxa), (tempo));
Console.WriteLine("Seu resgate ocorrerá em: {0} meses",tempo);
Console.WriteLine("O valor final é: {0}",resultado);
return resultado;

}

static int ajustaMesAno(DateTime d) {
    return d.Year * 12 + d.Month;
}
/*
public static int tempo(string data_fin ){

    var resgate = DateTime.Parse(data_fin);
        var data_ini = DateTime.Now;
        var tempo= (resgate.Date.Month - data_ini.Date.Month);
        return tempo;
}*/

}

