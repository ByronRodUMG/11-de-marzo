//void saludo(string nom_saludo)
//{
//    Console.WriteLine($"Hola {nom_saludo}, gusto de saludarte!");
//}

//int calculo(int edad)
//{
//    int añoNac = 2023 - edad;
//    return añoNac;
//}

//void desglose(String nom)
//{
//    String nuevo = nom.ToUpper();
//    String r = "";
//    int longitud = nom.Length;
//    for (int c = 0; c < nuevo.Length; c++)
//    {
//        Console.SetCursorPosition(10 + c, 10);
//        Console.Write(nuevo[c] + " ");
//        r = r + nuevo[c].ToString().ToLower();
//        Thread.Sleep(1000);
//        //nom = nom.Substring(0, c);
//    }
//}
bool palindromo(String nom)
{
    String nuevo = nom.ToUpper();
    String r = "";
    int longitud = nom.Length;

    for (int c = nuevo.Length - 1; c >= 0; c--)
    {
        r = r + nuevo[c].ToString().ToLower();
    }
    
    if (nuevo.Equals(r))
    {
        return true;
    }
    else
    { return false; }
}

palindromo("OSO");
if (palindromo==true)
{

}

//void desglose(String nom)
//{
//    String nuevo = nom.ToUpper();
//    String r = "";
//    int longitud = nom.Length;
//    for (int c = 0; c < nuevo.Length; c++)
//    {
//        Console.SetCursorPosition(10+c, 10);
//        Console.Write(nuevo[c]+" ");
//        r = r + nuevo[c].ToString().ToLower();
//        Thread.Sleep(1000);
//        //nom = nom.Substring(0, c);
//    }
//}

//void desglose(String nom)
//{
//    String nuevo = nom.ToUpper();
//    int longitud = nom.Length;
//    for (int c = nuevo.Length-1; c >= 0; c--)
//    {
//        Console.SetCursorPosition(10-c, 10);
//        Console.Write(nuevo[c]);
//        Thread.Sleep(1000);
//        //nom = nom.Substring(0, c);
//    }
//}

//String nombre;
//int edad;
//int año;

//desglose("María");
//palindromo("María");

//Console.WriteLine("Cual es tu nombre?");
//nombre = Console.ReadLine();
//saludo(nombre);
//Console.WriteLine("Cuantos años tienes?");
//edad = Convert.ToInt32(Console.ReadLine());
//año = calculo(edad);
//Console.WriteLine($"Naciste en el año {año}");
//Console.WriteLine($"Wow {nombre}, esa edad de {edad} es genial");