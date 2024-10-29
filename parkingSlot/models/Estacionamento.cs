namespace Parkingslotcsharp.models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoHora)
        {
            this.precoInicial = precoInicial;
            this.precoHora = precoHora;
        }

        public void addVeiculo()
        {
            Console.WriteLine($"Digite a placa do veiculo: ");
            string placa = Console.ReadLine();
            veiculos.Add(placa);
            Console.WriteLine($"Veiculo com a placa {placa} adicionado");
        }

        public void removeVeiculo()
        {
            Console.WriteLine($"Digite a placa do veiculo a ser removida: ");
            string placa = Console.ReadLine();

            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veiculo ficou estacionado");
                int horas = int.Parse(Console.ReadLine());
                decimal valorTotal = precoInicial + precoHora * horas;

                veiculos.Remove(placa);
                Console.WriteLine($"O veiculo {placa} foi removido e o preço total foi de: R${valorTotal}.");
            }
            else
            {
                Console.WriteLine($"Este veiculo não está cadastrado");

            }
        }

        public void listVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("Os veiculos estácionados são: ");
                foreach (var v in veiculos)
                {
                    Console.WriteLine(v);
                }
            }
            else
            {
                Console.WriteLine("Não há veiculos estacionados.");
            }
        }
    }
}