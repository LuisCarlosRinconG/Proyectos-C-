 string mensajeUnicode="\u3053\u308C\u306F\u0031\u0030\u9032\u6570\u6574\u3067\u3059"; //Es un número decimal

string nombre_ruta="pruebas";
string rute=$@"C:\Users\LCR404854\OneDrive - Axity\Documentos\C# - .NET\CsharpProjects\{nombre_ruta}\obj";
int numeroa=7;
int numerob=10;

decimal quotient= (decimal)numeroa / (decimal)numerob;

Console.WriteLine($@"La ruta de acceso a un archivo es: {rute} 
                            Y el {mensajeUnicode}: {quotient}");
