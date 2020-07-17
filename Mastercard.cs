namespace Encapsulamento_07
{   
    public class Mastercard : Cartao
    {
        public int parcelas {get;set;}

        public void DescontoMastercard(float desconto){
            System.Console.WriteLine( $"R$ {desconto} de desconto na compra, Parceladas em: {parcelas} Vezes");
        }
    }
}