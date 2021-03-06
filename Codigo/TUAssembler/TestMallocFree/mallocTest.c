#include <stdio.h>
            #define bool int
            #define true 1
            #define false 0

            int cantPedidosMemoria = 0;
            char* pedidos[sizeof(int)*10000];
            int tamanioPedidos[sizeof(int)*10000];
            bool fueLiberado[sizeof(bool)*10000];
            char* malloc2(int cantBytes)
            {
               int i;
               char* ret_value;
               ret_value = malloc(cantBytes + 8 + 8);	//8 bytes antes y 8 bytes despues para controlar que no se pase de la longitud del buffer
               pedidos[cantPedidosMemoria] = ret_value;
               tamanioPedidos[cantPedidosMemoria] = cantBytes;
               fueLiberado[cantPedidosMemoria] = false;
               for(i=0; i<8; i++){
                   ((char*)ret_value)[i] = 'A';
                   ((char*)ret_value)[cantBytes + 8 + i] = 'A';
               }
               cantPedidosMemoria++;
               return ret_value + 8;
            }
            

            void free2all()
            {
               int i;
               int bytesNoLiberados = 0;
               for(i=0; i<cantPedidosMemoria; i++){
                   free(pedidos[i]);
                   if(fueLiberado[i]== false)
                       bytesNoLiberados = bytesNoLiberados + tamanioPedidos[i];
               }
               if(bytesNoLiberados >0){
                   printf("No se han liberado %d bytes de memoria", bytesNoLiberados);
                   exit(0);
               }
            }

            int free2(char* punteroABloque)
            {
               static int cantLlamadosCorrectos = 0; //DAVID
               int pos, i;
               int salida = 0;
               for(pos=0; pos<cantPedidosMemoria && pedidos[pos]!=punteroABloque-8; pos++);
                   if(pedidos[pos] !=punteroABloque-8){
                       printf("Se intento liberar una posicion de memoria no valida. Anteriormente se llamo exitosamente a free %d veces\n", cantLlamadosCorrectos); //DAVID
			free2all();
                       exit(0);
                   }else{
			if (fueLiberado[pos]){ //DAVID
				printf("Se intentaron hacer 2 free del mismo buffer. Anteriormente se llamo exitosamente a free %d veces\n", cantLlamadosCorrectos); //DAVID
				free2all();//DAVID
				exit(0); //DAVID
			}	//DAVID
                       fueLiberado[pos] = true;
                       for (i = 0; i < 8; i++)
                           if(((char*)punteroABloque-8)[i] != 'A'|| ((char*)punteroABloque)[tamanioPedidos[pos] + i] != 'A'){
                              printf("Se ha escrito fuera del buffer\n");
                              free2all(); //DAVID
                              exit(0);
                           }
                   }
                   cantLlamadosCorrectos++;	//DAVID
                   return salida;
            }

void escrituraFueraBuffer(){
	char* buffer = malloc2(100);
	*(buffer-1) = 'X';
	free2(buffer);
}

void freeRepetido(){
	char* buffer = malloc2(100);
	free2(buffer);
	free2(buffer);
}

void sinFree(){
	char* buffer1, *buffer2;
	 buffer1 = malloc2(100);
	 buffer2 = malloc2(121);
}


int main(){
	freeRepetido();
	free2all();
	return 0;
}


