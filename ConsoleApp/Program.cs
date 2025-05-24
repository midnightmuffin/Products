
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Bienvenido al gestor de productos Dummy");
        Console.WriteLine("Por favor, elige una opción:");
        Console.WriteLine("1. Añadir un producto");
        Console.WriteLine("2. Consultar listado de productos");

        var option = Int32.Parse(Console.ReadLine());

        switch (option)
        {
            case 1:
                Console.WriteLine("Digite la información del producto.");
                // Aquí iría la lógica para añadir un producto
                break;

            case 2:
                Console.WriteLine("Listado de productos existentes:");
                // Aquí iría la lógica para consultar el listado de productos
                break;
             
            case 3:
                Console.WriteLine("Salir del menú.");
                break;

            default:
                Console.WriteLine("Opción no válida. Por favor, elige una opción válida.");
                break;
        }
    }
}