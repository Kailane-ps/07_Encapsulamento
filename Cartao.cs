using System;
namespace Encapsulamento_07
{
    public class Cartao
    {
        public int numero {get; set;}
        public string bandeira {get;set;}
        public string token = "123456";
        protected int CVC {get;set;}


        public void AprovarCompra(){
            System.Console.ForegroundColor = ConsoleColor.Blue; 
            System.Console.WriteLine("A compra foi Aprovada!");
            Console.ResetColor();
        }

        public bool ValidarToken(){
            if (token != null)
            {
                return true;
            }  
                return false;       
            
        }
        protected bool ValidarCompar(){
            return true;
        }
    }
}