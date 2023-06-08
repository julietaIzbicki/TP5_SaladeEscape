public static class Escape
{
    private static int estadoJuego=1;
    private static string[] incognitasSalas = new string[4];

    private static void InicializarJuego()
    {
        incognitasSalas[0]="1";

    }
    public static int GetEstadoJuego()
    {
        return  estadoJuego;
    }
    public static bool ResolverSala(int Sala, string Incognita)
    {
        if(incognitasSalas[Sala-1] != Incognita)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}