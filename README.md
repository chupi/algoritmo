algoritmo
=========

Algoritmo de búsqueda en vectores basado en regla de 3 simples 

Algoritmos hasta ahora
======================

Dicotomica(Divide y venceras): se mira la mitad del vector si lo que hay es menor de lo que buscamos, volvemos a buscar en la parte
inferior del vector, si es mayor buscamos en la parte superior del vector.Si se ha encontrado se sale del programa.

Con Centinela: se busca uno por uno hasta que se encuentra

Algoritmo "humano"
==================

Pero las personas no solemos buscar así.Si no que vemos mas o menos qual puede ser la posicion donde este lo que buscamos
y vamos a ella. Entonces si lo que hay en esa posicion es menor de lo que buscamos buscamos en lo que queda, si es mayor buscamos
en lo que hemos recorrido ya.

Algoritmo propuesto
===================

Lo que se propone es un algoritmo que se acerque a lo que hacen las personas.Para simular el "mas o menos" utilizamos la regla
de 3 simple que es lo que de forma inconsciente usamos.

De esta manera sea:
k: el origen del trozo del vector donde estamos buscando-->0 en origen
N: el final del trozo del vector donde estamos buscando--> el tamaño del vector -1 en origen

