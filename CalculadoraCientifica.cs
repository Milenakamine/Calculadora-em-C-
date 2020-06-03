namespace Calculadora_em_C_
{
    public class CalculadoraCientifica : Calcular
    {
         private string[] valores {get; set;}
         private float soma{get;set;}

        public void CalcularMedia(string txtConsole){
             resultado = 0;
            
            valores=txtConsole.Split(";");
            for(int i=0; i<valores.Length; i++)
            {
                soma= soma+float.Parse(valores[i]); 
//colocamos o parse pois valores esta em string
            }
            resultado = soma/valores.Length;

        }
    public void ControlarMetodos(string entradausu){
        string[] dados = entradausu.Split(" ");
        operador= dados[1];
        numero1= float.Parse(dados[0]);
        numero2=float.Parse(dados[2]);


        switch(operador){
            case "+":
            somar();
            break;

            case "-":
            subtrair();
            break;

            case "x":
            multiplicar();
            break;

            case "/":
            dividir();
            break;
        

        default:
        somar();
        break;

        }
    }
    }
}