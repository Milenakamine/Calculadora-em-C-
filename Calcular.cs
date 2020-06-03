using System;

namespace Calculadora_em_C_
{
    public class Calcular
    {
        public float numero1 { get; set; }
        public float numero2 { get; set; }
        
        public float resultado{ get; set; }
        protected string operador { get; set; }
//pois não preciso que mostre
     
        public void somar(){
            resultado=numero1+numero2;
        }
        public void subtrair(){
            resultado=numero1-numero2;
        }
        public void multiplicar(){
            resultado=numero1*numero2;
        }
        public void dividir(){
            resultado=numero1/numero2;
        }
        
       
    }
}