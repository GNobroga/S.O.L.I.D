namespace OpenClosedPrinciple
{

    /*

        Suponha que eu queira calcular a margem de lucro do produto, eu não posso criar um método
        dentro dessa classe Product para calcular o lucro, porque isso fere o princípio do aberto para 
        extensão e fechado para modificação do SOLID. O ideal é extender essa classe com novas funcionalidades.

    */
    public class Product
    {
        public int Id { get; protected set; }

        public string? Name { get; protected set; }

        public string? Description { get; protected set; }

        public decimal Cost { get; protected set; }

        public decimal Sell { get; protected set; }


        private int _stock;

        public int Stock { 
            get => _stock; 
            protected set
            {
                if (value >= 0) {
                    _stock = value;
                }
            }
        }

        public bool Active { get; protected set; }
    }
}