using BusinessLogic;
using Entities;

public class Program
{
    public static void Main(string[] args)
    {
        ProductManager manager = new ProductManager();
        int option = 0;

        do
        {
            Console.WriteLine("Bienvenido al gestor de productos Dummy");
            Console.WriteLine("1. Añadir un producto");
            Console.WriteLine("2. Consultar listado de productos");
            Console.WriteLine("3. Salir del menú");

            try
            {
                option = Int32.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Product product = new Product();

                        Console.Write("ID del producto: ");
                        product.Id = Int32.Parse(Console.ReadLine());

                        Console.Write("Nombre del producto: ");
                        product.Name = Console.ReadLine();

                        Console.Write("Precio del producto: ");
                        product.Price = Double.Parse(Console.ReadLine());

                        Console.Write("Stock del producto: ");
                        product.Stock = Int32.Parse(Console.ReadLine());

                        if (manager.AddProduct(product, out List<string> errors))
                        {
                            Console.WriteLine("Producto agregado correctamente.");
                        }
                        else
                        {
                            Console.WriteLine("Errores al agregar el producto:");
                            foreach (var err in errors)
                                Console.WriteLine("- " + err);
                        }
                        break;

                    case 2:
                        var productList = manager.GetProducts();
                        Console.WriteLine("Listado de productos existentes:");

                        foreach (var item in productList)
                        {
                            Console.WriteLine($"ID: {item.Id}, Nombre: {item.Name}, Precio: {item.Price}, Stock: {item.Stock}");
                        }
                        break;

                    case 3:
                        Console.WriteLine("Saliendo del programa.");
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Entrada inválida. Asegúrese de ingresar números válidos.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrió un error inesperado: " + ex.Message);
            }

        } while (option != 3);
    }
}