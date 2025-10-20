namespace BlazorVendas.model
{
    public class Pedido
    {
        private Int32 id;
        private DateTime dataPedido;
        private Int32 funcionarioId;
        private Int32 clienteId;
        private double valorTotal;

        public int Id { get => id; set => id = value; }
        public DateTime DataPedido { get => dataPedido; set => dataPedido = value; }
        public int FuncionarioId { get => funcionarioId; set => funcionarioId = value; }
        public int ClienteId { get => clienteId; set => clienteId = value; }
        public double ValorTotal { get => valorTotal; set => valorTotal = value; }

        public void RegistrarVenda()
        {
            //Registra
        }

        public string ListarVenda()
        {
            string resultado = "";
            return resultado;
        }
    }
}
