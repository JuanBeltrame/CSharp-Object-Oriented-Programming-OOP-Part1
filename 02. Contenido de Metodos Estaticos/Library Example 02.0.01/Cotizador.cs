namespace Library_Example_02._0._01
{
    public static class Cotizador
    {
        private const decimal pesosPorDolarComprado = 96.75M;
        private const decimal pesosPorDolarVendido = 102.82M;

        public static decimal CotizarVentaDolares(decimal montoDolaresAVender)
        {
            decimal costoEnPesos = montoDolaresAVender * pesosPorDolarVendido;

            return costoEnPesos;
        }

        public static decimal CotizadorCompraDolares(decimal montoDolaresAComprar)
        {
            decimal pagoEnPesos = montoDolaresAComprar * pesosPorDolarComprado;

            return pagoEnPesos;
        }
    }
}
