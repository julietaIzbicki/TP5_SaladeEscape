public static class Escape
{
    private static int estadoJuego=0;
    private static string[] incognitasSalas = new string[4];
    
    public  static void InicializarJuego()
    {
        estadoJuego=1;
        incognitasSalas[0]="PYTHON";
        incognitasSalas[1]="DEJAVA";
        incognitasSalas[2]="CSS";
        incognitasSalas[3]="CTRL S";
    }

    public static int GetEstadoJuego()
    {
        if(estadoJuego == 0){
            InicializarJuego();
            estadoJuego++;
        }
        return estadoJuego;
    }
    public static bool ResolverSala(int Sala, string Incognita)
    {
        if(Incognita.ToUpper() == incognitasSalas[Sala-1])
        {
            estadoJuego++;
            return true;
        }
        else
        {
            return false;
        }
    }
}