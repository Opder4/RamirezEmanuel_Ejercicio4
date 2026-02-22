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
            switch (activo)
            {
                case 1:
                    if (usuarios<100 || dato==1)
                    {
                        Console.WriteLine("Severidad: Baja");
                        Console.WriteLine("Respuesta recomendada: Activar antivirus");
                    }
                    else if (usuarios<1000 || dato==2)
                    {
                        Console.WriteLine("Severidad: Media");
                        Console.WriteLine("Respuesta recomendada: Supervición");
                    }
                    else if ((usuarios<5000 || dato==3) && persistencia=="s" )
                    {
                        Console.WriteLine("Severidad: Alta");
                        Console.WriteLine("Respuesta recomendada: Activar protocolos de seguridad");
                    }
                    else if ((usuarios>=5000 || dato==4) && persistencia=="s")
                    {
                        Console.WriteLine("Severidad: Crítica");
                        Console.WriteLine("Respuesta recomendada: Acciones de prevención inmediatas");
                    }
                    else
                    {
                        Console.WriteLine("Error");
                    }
                        break;
                case 2:
                    if (dato == 1)
                    {
                        Console.WriteLine("Severidad: Baja");
                        Console.WriteLine("Respuesta recomendada: Activar antivirus");
                    }
                    else if (dato == 2)
                    {
                        Console.WriteLine("Severidad: Media");
                        Console.WriteLine("Respuesta recomendada: Supervición");
                    }
                    else if (dato == 3 && persistencia == "s")
                    {
                        Console.WriteLine("Severidad: Alta");
                        Console.WriteLine("Respuesta recomendada: Activar protocolos de seguridad");
                    }
                    else if (dato == 4 && persistencia == "s")
                    {
                        Console.WriteLine("Severidad: Crítica");
                        Console.WriteLine("Respuesta recomendada: Acciones de prevención inmediatas");
                    }
                    else
                    {
                        Console.WriteLine("Error");
                    }
                        break;
                case 3:
                    if (dato == 3)
                    {
                        Console.WriteLine("Severidad: Baja");
                        Console.WriteLine("Respuesta recomendada: Activar antivirus");
                    }
                    else if (dato == 4)
                    {
                        Console.WriteLine("Severidad: Media");
                        Console.WriteLine("Respuesta recomendada: Supervición");
                    }
                    else if (dato == 3 && persistencia == "s")
                    {
                        Console.WriteLine("Severidad: Alta");
                        Console.WriteLine("Respuesta recomendada: Activar protocolos de seguridad");
                    }
                    else if (dato == 4 && persistencia == "s")
                    {
                        Console.WriteLine("Severidad: Crítica");
                        Console.WriteLine("Respuesta recomendada: Acciones de prevención inmediatas");
                    }
                    else
                    {
                        Console.WriteLine("Error");
                    }
                    break;
                case 4:
                    if (dato == 2)
                    {
                        Console.WriteLine("Severidad: Baja");
                        Console.WriteLine("Respuesta recomendada: Activar antivirus");
                    }
                    else if (usuarios<1000)
                    {
                        Console.WriteLine("Severidad: Media");
                        Console.WriteLine("Respuesta recomendada: Supervición");
                    }
                    else if (dato == 2 && persistencia == "s")
                    {
                        Console.WriteLine("Severidad: Alta");
                        Console.WriteLine("Respuesta recomendada: Activar protocolos de seguridad");
                    }
                    else if (usuarios>=1000 && persistencia == "s")
                    {
                        Console.WriteLine("Severidad: Crítica");
                        Console.WriteLine("Respuesta recomendada: Acciones de prevención inmediatas");
                    }
                    else
                    {
                        Console.WriteLine("Error");
                    }
                    break;
                default:
                    Console.WriteLine("Activo no válido");
                    break;
            }
            break;
        case 2:
            switch (activo)
            {
                case 1:
                    if (usuarios < 100 || dato == 1)
                    {
                        Console.WriteLine("Severidad: Baja");
                        Console.WriteLine("Respuesta recomendada: Activar antivirus");
                    }
                    else if (usuarios < 1000 || dato == 2)
                    {
                        Console.WriteLine("Severidad: Media");
                        Console.WriteLine("Respuesta recomendada: Supervición");
                    }
                    else if ((usuarios < 5000 || dato == 3) && persistencia == "s")
                    {
                        Console.WriteLine("Severidad: Alta");
                        Console.WriteLine("Respuesta recomendada: Activar protocolos de seguridad");
                    }
                    else if ((usuarios >= 5000 || dato == 4) && persistencia == "s")
                    {
                        Console.WriteLine("Severidad: Crítica");
                        Console.WriteLine("Respuesta recomendada: Acciones de prevención inmediatas");
                    }
                    else
                    {
                        Console.WriteLine("Error");
                    }
                    break;
                case 2:
                    if (dato == 1)
                    {
                        Console.WriteLine("Severidad: Baja");
                        Console.WriteLine("Respuesta recomendada: Activar antivirus");
                    }
                    else if (dato == 2)
                    {
                        Console.WriteLine("Severidad: Media");
                        Console.WriteLine("Respuesta recomendada: Supervición");
                    }
                    else if (dato == 3 && persistencia == "s")
                    {
                        Console.WriteLine("Severidad: Alta");
                        Console.WriteLine("Respuesta recomendada: Activar protocolos de seguridad");
                    }
                    else if (dato == 4 && persistencia == "s")
                    {
                        Console.WriteLine("Severidad: Crítica");
                        Console.WriteLine("Respuesta recomendada: Acciones de prevención inmediatas");
                    }
                    else
                    {
                        Console.WriteLine("Error");
                    }
                    break;
                case 3:
                    if (dato == 3)
                    {
                        Console.WriteLine("Severidad: Baja");
                        Console.WriteLine("Respuesta recomendada: Activar antivirus");
                    }
                    else if (dato == 4)
                    {
                        Console.WriteLine("Severidad: Media");
                        Console.WriteLine("Respuesta recomendada: Supervición");
                    }
                    else if (dato == 3 && persistencia == "s")
                    {
                        Console.WriteLine("Severidad: Alta");
                        Console.WriteLine("Respuesta recomendada: Activar protocolos de seguridad");
                    }
                    else if (dato == 4 && persistencia == "s")
                    {
                        Console.WriteLine("Severidad: Crítica");
                        Console.WriteLine("Respuesta recomendada: Acciones de prevención inmediatas");
                    }
                    else
                    {
                        Console.WriteLine("Error");
                    }
                    break;
                case 4:
                    if (dato == 2)
                    {
                        Console.WriteLine("Severidad: Baja");
                        Console.WriteLine("Respuesta recomendada: Activar antivirus");
                    }
                    else if (usuarios < 1000)
                    {
                        Console.WriteLine("Severidad: Media");
                        Console.WriteLine("Respuesta recomendada: Supervición");
                    }
                    else if (dato == 2 && persistencia == "s")
                    {
                        Console.WriteLine("Severidad: Alta");
                        Console.WriteLine("Respuesta recomendada: Activar protocolos de seguridad");
                    }
                    else if (usuarios >= 1000 && persistencia == "s")
                    {
                        Console.WriteLine("Severidad: Crítica");
                        Console.WriteLine("Respuesta recomendada: Acciones de prevención inmediatas");
                    }
                    else
                    {
                        Console.WriteLine("Error");
                    }
                    break;
                default:
                    Console.WriteLine("Activo no válido");
                    break;
            }
            break;
        case 3:
            switch (activo)
            {
                case 1:
                    if (usuarios < 100 || dato == 1)
                    {
                        Console.WriteLine("Severidad: Baja");
                        Console.WriteLine("Respuesta recomendada: Activar antivirus");
                    }
                    else if (usuarios < 1000 || dato == 2)
                    {
                        Console.WriteLine("Severidad: Media");
                        Console.WriteLine("Respuesta recomendada: Supervición");
                    }
                    else if ((usuarios < 5000 || dato == 3) && persistencia == "s")
                    {
                        Console.WriteLine("Severidad: Alta");
                        Console.WriteLine("Respuesta recomendada: Activar protocolos de seguridad");
                    }
                    else if ((usuarios >= 5000 || dato == 4) && persistencia == "s")
                    {
                        Console.WriteLine("Severidad: Crítica");
                        Console.WriteLine("Respuesta recomendada: Acciones de prevención inmediatas");
                    }
                    else
                    {
                        Console.WriteLine("Error");
                    }
                    break;
                case 2:
                    if (dato == 1)
                    {
                        Console.WriteLine("Severidad: Baja");
                        Console.WriteLine("Respuesta recomendada: Activar antivirus");
                    }
                    else if (dato == 2)
                    {
                        Console.WriteLine("Severidad: Media");
                        Console.WriteLine("Respuesta recomendada: Supervición");
                    }
                    else if (dato == 3 && persistencia == "s")
                    {
                        Console.WriteLine("Severidad: Alta");
                        Console.WriteLine("Respuesta recomendada: Activar protocolos de seguridad");
                    }
                    else if (dato == 4 && persistencia == "s")
                    {
                        Console.WriteLine("Severidad: Crítica");
                        Console.WriteLine("Respuesta recomendada: Acciones de prevención inmediatas");
                    }
                    else
                    {
                        Console.WriteLine("Error");
                    }
                    break;
                case 3:
                    if (dato == 3)
                    {
                        Console.WriteLine("Severidad: Baja");
                        Console.WriteLine("Respuesta recomendada: Activar antivirus");
                    }
                    else if (dato == 4)
                    {
                        Console.WriteLine("Severidad: Media");
                        Console.WriteLine("Respuesta recomendada: Supervición");
                    }
                    else if (dato == 3 && persistencia == "s")
                    {
                        Console.WriteLine("Severidad: Alta");
                        Console.WriteLine("Respuesta recomendada: Activar protocolos de seguridad");
                    }
                    else if (dato == 4 && persistencia == "s")
                    {
                        Console.WriteLine("Severidad: Crítica");
                        Console.WriteLine("Respuesta recomendada: Acciones de prevención inmediatas");
                    }
                    else
                    {
                        Console.WriteLine("Error");
                    }
                    break;
                case 4:
                    if (dato == 2)
                    {
                        Console.WriteLine("Severidad: Baja");
                        Console.WriteLine("Respuesta recomendada: Activar antivirus");
                    }
                    else if (usuarios < 1000)
                    {
                        Console.WriteLine("Severidad: Media");
                        Console.WriteLine("Respuesta recomendada: Supervición");
                    }
                    else if (dato == 2 && persistencia == "s")
                    {
                        Console.WriteLine("Severidad: Alta");
                        Console.WriteLine("Respuesta recomendada: Activar protocolos de seguridad");
                    }
                    else if (usuarios >= 1000 && persistencia == "s")
                    {
                        Console.WriteLine("Severidad: Crítica");
                        Console.WriteLine("Respuesta recomendada: Acciones de prevención inmediatas");
                    }
                    else
                    {
                        Console.WriteLine("Error");
                    }
                    break;
                default:
                    Console.WriteLine("Activo no válido");
                    break;
            }
            break;
        case 4:
            switch (activo)
            {
                case 1:
                    if (usuarios < 100 || dato == 1)
                    {
                        Console.WriteLine("Severidad: Baja");
                        Console.WriteLine("Respuesta recomendada: Activar antivirus");
                    }
                    else if (usuarios < 1000 || dato == 2)
                    {
                        Console.WriteLine("Severidad: Media");
                        Console.WriteLine("Respuesta recomendada: Supervición");
                    }
                    else if ((usuarios < 5000 || dato == 3) && persistencia == "s")
                    {
                        Console.WriteLine("Severidad: Alta");
                        Console.WriteLine("Respuesta recomendada: Activar protocolos de seguridad");
                    }
                    else if ((usuarios >= 5000 || dato == 4) && persistencia == "s")
                    {
                        Console.WriteLine("Severidad: Crítica");
                        Console.WriteLine("Respuesta recomendada: Acciones de prevención inmediatas");
                    }
                    else
                    {
                        Console.WriteLine("Error");
                    }
                    break;
                case 2:
                    if (dato == 1)
                    {
                        Console.WriteLine("Severidad: Baja");
                        Console.WriteLine("Respuesta recomendada: Activar antivirus");
                    }
                    else if (dato == 2)
                    {
                        Console.WriteLine("Severidad: Media");
                        Console.WriteLine("Respuesta recomendada: Supervición");
                    }
                    else if (dato == 3 && persistencia == "s")
                    {
                        Console.WriteLine("Severidad: Alta");
                        Console.WriteLine("Respuesta recomendada: Activar protocolos de seguridad");
                    }
                    else if (dato == 4 && persistencia == "s")
                    {
                        Console.WriteLine("Severidad: Crítica");
                        Console.WriteLine("Respuesta recomendada: Acciones de prevención inmediatas");
                    }
                    else
                    {
                        Console.WriteLine("Error");
                    }
                    break;
                case 3:
                    if (dato == 3)
                    {
                        Console.WriteLine("Severidad: Baja");
                        Console.WriteLine("Respuesta recomendada: Activar antivirus");
                    }
                    else if (dato == 4)
                    {
                        Console.WriteLine("Severidad: Media");
                        Console.WriteLine("Respuesta recomendada: Supervición");
                    }
                    else if (dato == 3 && persistencia == "s")
                    {
                        Console.WriteLine("Severidad: Alta");
                        Console.WriteLine("Respuesta recomendada: Activar protocolos de seguridad");
                    }
                    else if (dato == 4 && persistencia == "s")
                    {
                        Console.WriteLine("Severidad: Crítica");
                        Console.WriteLine("Respuesta recomendada: Acciones de prevención inmediatas");
                    }
                    else
                    {
                        Console.WriteLine("Error");
                    }
                    break;
                case 4:
                    if (dato == 2)
                    {
                        Console.WriteLine("Severidad: Baja");
                        Console.WriteLine("Respuesta recomendada: Activar antivirus");
                    }
                    else if (usuarios < 1000)
                    {
                        Console.WriteLine("Severidad: Media");
                        Console.WriteLine("Respuesta recomendada: Supervición");
                    }
                    else if (dato == 2 && persistencia == "s")
                    {
                        Console.WriteLine("Severidad: Alta");
                        Console.WriteLine("Respuesta recomendada: Activar protocolos de seguridad");
                    }
                    else if (usuarios >= 1000 && persistencia == "s")
                    {
                        Console.WriteLine("Severidad: Crítica");
                        Console.WriteLine("Respuesta recomendada: Acciones de prevención inmediatas");
                    }
                    else
                    {
                        Console.WriteLine("Error");
                    }
                    break;
                default:
                    Console.WriteLine("Activo no válido");
                    break;
            }
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
Console.WriteLine("");