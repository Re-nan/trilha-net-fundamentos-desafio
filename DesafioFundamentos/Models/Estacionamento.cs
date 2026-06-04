namespace DesafioFundamentos.Models
{
    /// <summary>
    /// A classe Estacionamento é responsável por gerenciar as operações de um estacionamento, 
    /// como adicionar veículos, remover veículos e listar os veículos estacionados. 
    /// Ela utiliza uma lista para armazenar as placas dos veículos e calcula o valor a ser pago com base 
    /// no preço inicial e no preço por hora.
    /// </summary>
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        /// <summary>
        /// Construtor da classe Estacionamento recebe o preço inicial e o preço por hora como parâmetros e 
        /// os atribui às variáveis correspondentes.
        /// </summary>
        /// <param name="precoInicial">Define o preço inicial do Estacionamento</param>
        /// <param name="precoPorHora">Define o preço da hora do Estacionamento</param>
        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        /// <summary>
        /// É responsável por adicionar um veículo ao estacionamento. Ele solicita ao usuário que digite a placa 
        /// do veículo e, em seguida, adiciona essa placa à lista de veículos estacionados.
        /// </summary>
        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();
            veiculos.Add(placa);
        }

        /// <summary>
        /// É responsável por remover um veículo do estacionamento. Ele solicita ao usuário que digite a placa 
        /// do veículo. Se o veículo existir na lista, ele solicita a quantidade de horas que o veículo permaneceu 
        /// estacionado, e calcula o valor total a ser pago com base no preço inicial e no preço por hora. 
        /// Em seguida, ele remove a placa da lista de veículos e exibe o valor total a ser pago. 
        /// Se o veículo não existir na lista, ele exibe uma mensagem de erro.
        /// </summary>
        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                int horas = Convert.ToInt32(Console.ReadLine());

                // Calculo do valor total a ser pago
                decimal valorTotal = precoInicial + (precoPorHora * horas);

                // Removendo a placa digitada da lista de veículos
                veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal.ToString("C")}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        /// <summary>
        /// É responsável por listar os veículos estacionados. Ele verifica se há veículos na lista e, se houver, 
        /// exibe as placas dos veículos estacionados.
        /// </summary>
        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                
                foreach (var veiculo in veiculos)
                {
                    Console.WriteLine("Veículo: " + veiculo);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
