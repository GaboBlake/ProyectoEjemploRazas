using System.Security.Cryptography.X509Certificates;

internal class Program
{
    public static void CambioNombre(Persona p)
    {
        p.Nombre="Valentin";
    }
  
    private static void Main(string[] args)
    {
      
        

        //Console.WriteLine("Hello, World!");
        Persona perso1=new Persona()
        {
            Nombre="Ricardo Elizalde"
        };
        







        
        perso1.FechaN=new DateOnly(1979,08,29);
        perso1.SalarioM=125000;

        //Impresión en consola
        Console.WriteLine(perso1.Nombre);
        Persona perso2= new Persona ("Gabriel Ordaz", new DateOnly(1996,11,18), 123441);
        Console.WriteLine(perso2.Nombre);
        Console.WriteLine(perso2.FechaN);
        Console.WriteLine(perso2.SalarioM);
        
        Console.ReadKey();

        CambioNombre(perso1);
        Console.WriteLine(perso1.Nombre);



    }
}

public class Persona {

    public Persona(){

        Nombre="Vacio";
        SalarioM=0;

    }

    public Persona(string name){
        Nombre=name;
    }

    public string Nombre { get; set; }
    public DateOnly FechaN { get; set; }

    public int MyProperty { get; set; }
    public decimal SalarioM { get; set; }
    public decimal SalarioA{
        get {
            return SalarioM*12;
        }
    }

    public decimal SalarioAnual() 
    {
        return SalarioM*12;
    }
    public void Caminar (int pasos){
        Console.WriteLine("Estas caminando: "+ pasos);
    }

    public Persona(string name, DateOnly date, decimal money)
    {
        Nombre=name;
        FechaN=date;
        SalarioM=money;
    }

}