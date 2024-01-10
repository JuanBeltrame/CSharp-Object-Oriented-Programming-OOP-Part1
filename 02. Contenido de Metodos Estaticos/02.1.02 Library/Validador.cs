namespace _02._1._02_Library
{
    public class Validador
    {
        public static bool ValidateResponse(string letra)
        {
            char temporal;

            if (char.TryParse(letra, out temporal))
            {
                if (temporal == 'Y')
                {

                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
