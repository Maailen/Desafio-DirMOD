using System;
using System.Collections.Generic;

namespace Desafio_DirMOD
{
    class Program
    {
        static void Main(string[] args)
        {
            Convertir teclado = new Convertir();
            teclado.dictionary();
            teclado.conversion();
        }
    }
    public class Convertir
    {
        Dictionary<char, int> teclas = new Dictionary<char, int>();
        String texto_ingresado;
        String texto_convertido;
        public void dictionary() {
            //Se pasan los valores correspondientes de las teclas
            teclas.Add(' ', 0);
            teclas.Add('A', 2); teclas.Add('B', 22); teclas.Add('C', 222);
            teclas.Add('D', 3); teclas.Add('E', 33); teclas.Add('F', 333);
            teclas.Add('G', 4); teclas.Add('H', 44); teclas.Add('I', 444);
            teclas.Add('J', 5); teclas.Add('K', 55); teclas.Add('L', 555);
            teclas.Add('M', 6); teclas.Add('N', 66); teclas.Add('O', 666);
            teclas.Add('P', 7); teclas.Add('Q', 77); teclas.Add('R', 777); teclas.Add('S', 7777);
            teclas.Add('T', 8); teclas.Add('U', 88); teclas.Add('V', 888); 
            teclas.Add('W', 9); teclas.Add('X', 99); teclas.Add('Y', 999); teclas.Add('Z', 9999);
            
        }

        public void conversion(){
            Console.Clear(); //limpia la consola
            Console.Write("Ingrese texto o frase que desee convertir: "); //pide el ingreso del texto a convertir
            int op=1;

            while (op!=0){
                texto_ingresado = Console.ReadLine(); //Se lee el textro ingresado por consola
                texto_ingresado = texto_ingresado.ToUpper();
                char[] array = texto_ingresado.ToCharArray(); //Se pasa el texto a un array para poder realizar la conversión
                int size = array.Length;
                char aux1, aux2 = ' '; //auxiliares para comparar las letras del texto ingresado
                int b=0; //definición e inicialización de la bandera

                for (int i=0; i < size; i++) //recorre el array
                {
                    aux1 = array[i];
                    if (i!=0){

                    aux2 = array[i-1];
                
                        //Compara si la letra actual y la anterior pertenecen a la misma tecla
                    if((aux2=='A'|| aux2=='B' || aux2=='C') && (aux1=='A' || aux1=='B' || aux1=='C'))
                        b=1;
                        else if ((aux2=='D'|| aux2=='E' || aux2=='F') && (aux1=='D' || aux1=='E' || aux1=='F'))
                            b=1;
                            else if ((aux2=='G'|| aux2=='H' || aux2=='I') && (aux1=='G' || aux1=='H' || aux1=='I'))
                                b=1;
                                else if ((aux2=='J'|| aux2=='K' || aux2=='L') && (aux1=='J' || aux1=='K' || aux1=='L'))
                                    b=1;
                                    else if ((aux2=='M'|| aux2=='N' || aux2=='O') && (aux1=='M' || aux1=='N' || aux1=='O'))
                                        b=1;
                                        else if ((aux2=='P'|| aux2=='Q' || aux2=='R' || aux2=='S') && (aux1=='P' || aux1=='Q' || aux1=='R' || aux1=='S'))
                                            b=1;
                                            else if ((aux2=='T'|| aux2=='U' || aux2=='V') && (aux1=='T' || aux1=='U' || aux1=='V'))
                                                b=1;
                                                else if ((aux2=='W'|| aux2=='X' || aux2=='Y' || aux2=='Z') && (aux1=='W' || aux1=='X' || aux1=='Y' || aux1=='Z'))
                                                    b=1;
                                                    else if (aux2==' ' && aux1==' ')
                                                        b=1;
                    }
                    if (b==1){ //agrega espacio cuando se repite la tecla

                        texto_convertido = texto_convertido + " ";
                        b=0; //restablece la bandera

                    }
                    foreach (var letra in teclas)
                    {
                        if( array[i] == letra.Key) //compara el array con el diccionario disponible
                        {
                            texto_convertido = texto_convertido + letra.Value; 
                        }
                    }
                }
                Console.WriteLine("\n");
                Console.Write($"Secuencia de teclas que hay que pulsar para escribir el mensaje deseado: {texto_convertido}"); //resultado: texto ingresado convertido a secuencia numerica

                Console.WriteLine("\n");
                Console.WriteLine("¿Desea convertir otra frase?\n \t 0-NO 1-SI");
                Console.Write("Ingrese una opción: ");
                op = int.Parse(Console.ReadLine()); //parsea la opción que elija el usuario

                if (op!=0){

                    Console.Clear(); 
                    Console.Write("Ingrese otro texto o frase que desee convertir: "); //Pide el ingreso del texto a convertir nuevamente
                    texto_convertido=""; //vacía la variable final de conversión
                }
                else {
                    Console.WriteLine("\n");
                    Console.Beep(); //hace un pequeño beep en consola
                    Console.WriteLine("Decidió finalizar el programa.");
                    Console.WriteLine("\n");
                }
            }
        }
    }
}