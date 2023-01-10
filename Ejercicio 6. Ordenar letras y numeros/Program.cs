// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
//6.Mediante un ciclo, pedir 10 letras y 10 números, ordenar ascendentemente las letras,
//descendentemente los números. Imprimirlos.
Console.WriteLine("Con este programa ordenaremos ascendentemente 10 letras y descendentemente 10 números capturados por ti");
//DE
char[] letra = new char[10];
int[] numeros = new int[10];
//Proceso. 
for (int i = 0; i < letra.Length; i++)//Ciclo para capturar las letras.
{
    Console.WriteLine("Captura la letra No. " + (i + 1));
    letra[i] = Convert.ToChar(Console.ReadLine());
}
for (int i = 0; i < letra.Length; i++)
{
    for (int j = 0; j < letra.Length - 1; j++)
    {
        if (letra[i] < letra[j])//Ordenamiento de la burbuja para las letras. De mayor a menor
        {
            char temp = letra[i];
            letra[i] = letra[j];
            letra[j] = temp;
        }
    }
}
for (int i = 0; i < letra.Length; i++)//Hacemos un for para imprimir las letras ordenadas anteriormente. 
{
    Console.WriteLine("El ordenamiento de la letras capturadas inicia con " + letra[i] + " que representa el valor de " + (int)letra[i] + " en código ASCII");
}
//Comenzaremos con el ordenamiento de números que es de menor a mayor. 
//Para esto tomamos un método de la burbuja. 
for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine("Captura el número No. " + (i + 1));
    numeros[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < numeros.Length; i++)
{
    for (int j = 0; j < numeros.Length - 1; j++)
    {
        if (numeros[i] > numeros[j])//Por el signo los ordenaremos de menor a mayor. 
        {
            int temp = numeros[i];
            numeros[i] = numeros[j];
            numeros[j] = temp;
        }
    }
}
for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine("Tus números ordenados de menor a mayor es " + numeros[i]);
}