//Creación de una matriz de tipo entero con 3 indices

//Asignar valores
int[] Prueba = new int[3];

Prueba[0]=2;
Prueba[1]=5;
Prueba[2]=6;

Console.WriteLine($"El indice 1 del vector int es: {Prueba[1]}");

//Inicializar matriz

String[] PruebaString=["Primero","Segundo","Tercero"];

Console.WriteLine($"El indice 1 del vector String es: {PruebaString[1]}");

//Ver el tamaño de una matriz:

Console.WriteLine($"El tamaño del vector string es: {PruebaString.Length}");

//Implementación de foreach con String

foreach (string i in PruebaString){

    Console.WriteLine(i);
}


//Implementación de foreach con int

foreach (int i in Prueba){

    Console.WriteLine(i);
}
