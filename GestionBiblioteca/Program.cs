using GestionBiblioteca.Model;
using GestionBiblioteca.Services;
using static GestionBiblioteca.Utils.Validations;
class Program
{
    private static LibroService libroService = new();
    public static void Main(string[] args)
    {
        Console.WriteLine("----Sistema de Gestión de Biblioteca Digital----");
        bool showOptions = true;
        while (showOptions)
        {
            GetInput(ref showOptions);
        }
    }
    private static void GetInput(ref bool showOptions)
    {
        ShowMenu();
        string option = Console.ReadLine();
        int optionMenu;
        bool isValid = int.TryParse(option, out optionMenu);

        while (!isValid)
        {
            Console.WriteLine("Error - Debe ingresar un valor numérico. Intente nuevamente.");
            option = Console.ReadLine();
            isValid = int.TryParse(option, out optionMenu);
        }

        switch (optionMenu)
        {
            case 1:
                RegistrarLibro();
                break;
            case 2:
                ActualizarLibro();
                break;
            case 3:
                RegistrarUsuario();
                break;
            case 4:
                break;
            case 5:
                break;
            case 6:
                break;
            case 7:
                break;
            case 8:
                break;
            case 9:
                break;
            case 10:
                Console.WriteLine("Finalizando ejecución del programa!");
                showOptions = false;
                break;
            default:
                Console.WriteLine("Opción no válida. Intente nuevamente.");
                break;
            }
        }         

        private static void RegistrarLibro()
        {
            Console.WriteLine("Ingrese el titulo del libro: ");
            string titulo = ValidateString(Console.ReadLine());

            Console.WriteLine("Ingrese el Autor del libro: ");
            string autor = ValidateString(Console.ReadLine());


            Console.WriteLine("Ingrese el Año de Publicación del libro: ");
            DateTime fechaPublicacion = ValidateDate(Console.ReadLine());

            Console.WriteLine("Ingrese el ISBN del libro: ");
            string isbn = ValidateString(Console.ReadLine());

        }


        private static void ActualizarLibro()
        {
            Console.WriteLine("Ingrese el ISBN del libro que desea actualizar: ");
            string isbn = ValidateString(Console.ReadLine());

            Libro libroExistente = libroService.BuscarLibroPorId(isbn);

            if (libroExistente == null)
            {
                Console.WriteLine("Error: No se encontró un libro con el ISBN " + isbn);
                return;
            }

            Console.WriteLine("Ingrese el nuevo título del libro: ");
            string nuevoTitulo = ValidateString(Console.ReadLine());

            Console.WriteLine("Ingrese el nuevo autor del libro: ");
            string nuevoAutor = ValidateString(Console.ReadLine());

            Console.WriteLine("Ingrese el nuevo año de publicación del libro: ");
            DateTime nuevaFechaPublicacion = ValidateDate(Console.ReadLine());

            Console.WriteLine("Ingrese el nuevo ISBN del libro: ");
            string nuevoIsbn = ValidateString(Console.ReadLine());
            }   
        private static void RegistrarUsuario()
        {
            Console.WriteLine("Ingrese el nombre del usuario: ");
            string nombre = ValidateString(Console.ReadLine());

            Console.WriteLine("Ingrese el email del usuario: ");
            string email = ValidateString(Console.ReadLine());


            Console.WriteLine("Ingrese el teléfono del usuario: ");
            string telefono = ValidatePhoneNumber(Console.ReadLine());


        }

    private static void ShowMenu()
        {
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("1. Registrar Libro");
            Console.WriteLine("2. Actualizar Libro");
            Console.WriteLine("3. Registrar Usuario");
            Console.WriteLine("4. Actualizar Usuario");
            Console.WriteLine("5. Registrar Préstamo");
            Console.WriteLine("6. Registrar Devolución");
            Console.WriteLine("7. Buscar Libro por Título o Autor");
            Console.WriteLine("8. Listar Préstamos Activos");
            Console.WriteLine("9. Reporte de Libros Más Prestados");
            Console.WriteLine("10. Salir");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("Ingrese la opción deseada:");
        }



}