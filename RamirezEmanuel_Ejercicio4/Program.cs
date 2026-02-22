Console.WriteLine("Ingrese el Tipo de incidente:");
Console.WriteLine("");
Console.WriteLine("1. Malware");
Console.WriteLine("2. Phishing");
Console.WriteLine("3. Acceso no autorizado");
Console.WriteLine("4. Fuga de información");
Console.WriteLine("");
int incidente=int.Parse(Console.ReadLine());
Console.WriteLine("");
Console.WriteLine("Ingrese el Activo afectado:");
Console.WriteLine("");
Console.WriteLine("1. PC");
Console.WriteLine("2. Servidor");
Console.WriteLine("3. Base de datos");
Console.WriteLine("4. Red");
Console.WriteLine("");
int activo=int.Parse(Console.ReadLine());
Console.WriteLine("");
Console.WriteLine("Ingrese el Dato comprometido: ");
Console.WriteLine("");
Console.WriteLine("1. Ninguno");
Console.WriteLine("2. Internos");
Console.WriteLine("3. Personales");
Console.WriteLine("4. Financieros");
Console.WriteLine("");
int dato=int.Parse(Console.ReadLine());
Console.WriteLine("");
Console.WriteLine("Hay persistencia con el incidente? (s/n)");
Console.WriteLine("");
string persistencia=Console.ReadLine();
Console.WriteLine("");
Console.WriteLine("Ingrese el número de usuarios afectados: ");
Console.WriteLine("");
int usuarios=int.Parse(Console.ReadLine());
Console.WriteLine("");
if (dato>=1 && dato<=4 && (persistencia=="s" || persistencia=="n") && usuarios >= 0)
{
    switch (incidente)
    {
        case 1:

            break;
        case 2:

            break;
        case 3:

            break;
        case 4:

            break;
        default:
            Console.WriteLine("Incidente no válido");
            break;
    }
}
else
{
    Console.WriteLine("Los datos ingresados no son válidos");
}