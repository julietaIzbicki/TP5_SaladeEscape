public static class Escape
{
    private static int estadoJuego=1;
    private static string[] incognitasSalas = new string[4];
    private static string[,] matPistas = new string[4,3];
    
    private static void InicializarJuego()
    {
        incognitasSalas[0]="PYTHON";
        incognitasSalas[1]="DEJAVA";
        incognitasSalas[2]="CSS";
        incognitasSalas[3]="CTRL S";

        matPistas[1,0]= "La programadora no queria ser conquistada";
	    matPistas[1,1]= "La respuesta tiene un lenguaje de programacion";
	    matPistas[1,2]= "Los alumnos de tercero no lo vieron";

        matPistas[2,0]= "Lenguaje de estilos";
	    matPistas[2,1]= "Hojas de estilo en cascada";
	    matPistas[2,2]= " es un lenguaje de diseño gráfico para definir y crear la presentación de un documento estructurado escrito en un lenguaje de marcado";

        matPistas[3,0]= "atajo";
	    matPistas[3,1]= "En las computadoras Apple es Command+S.";
	    matPistas[3,2]= "para guardar cambios en un archivo.";
    }
    public static int GetEstadoJuego()
    {
        return estadoJuego;
    }
    public static bool ResolverSala(int Sala, string Incognita)
    {
        if(incognitasSalas[Sala-1] != Incognita)
        {
            return false;
        }
        else
        {
            estadoJuego++;
            return true;
        }
    }
}