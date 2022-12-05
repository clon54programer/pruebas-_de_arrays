string[] prueba = new string[] {"juan", "perro", "gato", "cerdo"};

Console.WriteLine("el arrray prueba tiene "+ prueba.Length);//nos da la cantidad de dtos del array

string master = " juna pelota tis ";

Console.WriteLine(master.Length);//lenght muestra la cantidad de bytes que ocupa
Console.WriteLine(master.ToLower().Replace("u", "b").Remove(4));//usamos mas metodos

//pruebas
//0
string[] MarcaCarros = new string[9] {"Ford", "Ferrari", "Toyota", "Hyundai", "Chevrolet", "Nissan", "Kia", "Renault", "nada"};
Console.WriteLine("coloque su nombre por favor");
string cliente = Console.ReadLine();

foreach(string i in MarcaCarros)
{
    //interacion
    Console.WriteLine("buenso dias señor "+cliente+" que carro desae comprar este dia");
    Console.WriteLine($"-{MarcaCarros[0]} -{MarcaCarros[1]} -{MarcaCarros[2]} -{MarcaCarros[3]} -{MarcaCarros[4]} -{MarcaCarros[5]} -{MarcaCarros[6]} -{MarcaCarros[7]} -{MarcaCarros[8]}\n");
    Console.WriteLine("si quiere uno coloque un numero del 0 al 7 o si no quiere nada coloque 8");
    
    //logica
    int LaMarca = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(MarcaCarros[LaMarca]);

    switch (LaMarca)
    {
        case 0:
            Console.WriteLine("su carro vale $1000 dolares");
            Console.WriteLine("lo desea comprar si o no");
            break;
        case 1:
            Console.WriteLine("su carro vale $30000 dolares");
            Console.WriteLine("lo desea comprar si o no");
            break;
        case 2:
            Console.WriteLine("su carro vale $2500 dolares");
            Console.WriteLine("lo desea comprar si o no");
            break;
        case 3:
            Console.WriteLine("su carro vale $1500 dolares");
            Console.WriteLine("lo desea comprar si o no");
            break;
        case 4:
            Console.WriteLine("su carro vale $3000 dolares");
            Console.WriteLine("lo desea comprar si o no");
            break;
        case 5:
            Console.WriteLine("su carro vale $2000 dolares");
            Console.WriteLine("lo desea comprar si o no");
            break;
        case 6:
            Console.WriteLine("su carro vale $2000 dolares");
               Console.WriteLine("lo desea comprar si o no");
            break;
        case 7:
            Console.WriteLine("su carro vale $1500 dolares");
            Console.WriteLine("lo desea comprar si o no");
            break;
        case 8:
            Console.WriteLine("gracias por visitarnos señor "+cliente);
            break;
        default:
            Console.WriteLine("coloque un numero del 0 al 7");
            break;
    }
    string compra = Console.ReadLine();
    if (compra == "si")
    {
        Console.WriteLine("gracias por su compra señor "+cliente);
        Environment.Exit(0);
    }
    else
    {
        Console.WriteLine("bueno elija otro señor "+cliente);
        Console.Clear();//esto limpia la consola y sigue el bucle normal
        Console.WriteLine("3 horas despues");
    }
        if (LaMarca == 8)
    {
        Environment.Exit(0);
    }

}