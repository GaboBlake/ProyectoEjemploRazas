using PracticaPerrito;

internal class Program
{
    private static void Main(string[] args)
    {
         Husky perro1=new Husky();
        perro1.Nombre="Lobo";
        perro1.Size="G";
        perro1.Peso=8.12M;
        perro1.Color="Negro";
        perro1.Comer();
        perro1.Correr();
        perro1.Jugar();

        ShibaInu shiba= new ShibaInu();
        shiba.Nombre="Akira";
        shiba.Size="G";
        shiba.Color="Amarillo";
        shiba.Peso=8.2M;
        shiba.Jugar();

        PastorAleman pastA = new PastorAleman();
        pastA.Nombre="Niza";
        pastA.Size="G"; 
        pastA.Color="Café";
        pastA.Peso =9.5M;
        pastA.Jugar();

        MostrarHijos(perro1);
        //MostrarHijos(shiba);
        //MostrarHijos(pastA);
    }

    public static void MostrarHijos(IMamifero m)
    {

        m.TenerHijos();

    }
   
}