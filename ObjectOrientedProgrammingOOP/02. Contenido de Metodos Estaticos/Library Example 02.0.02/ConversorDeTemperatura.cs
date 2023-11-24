namespace Library_Example_02._0._02
{
    public class ConversorDeTemperatura
    {
        private const float ceroAbsoluto = 273.15F;

        /// <summary>
        /// Convierte una temperatura en grados celcius a grados kelvin
        /// </summary>
        /// <param name="temperaturaCelsius"> Temperatura en grados celsius a convertir.</param>
        /// <returns> Temperatura en grados Kelvin correspondiente al argumento proporcionado </returns>
        public static float ConvertirCelciusAKelvin(float temperaturaCelsius)
        {
            float temperaturaKelvin = temperaturaCelsius + ceroAbsoluto;

            return temperaturaKelvin;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="temperatuaKelvin"></param>
        /// <returns></returns>
        public static float ConvertirKelvinACelciud(float temperatuaKelvin)
        {
            float temperaturaCelsius = temperatuaKelvin - ceroAbsoluto;

            return temperaturaCelsius;
        }
    }
}
