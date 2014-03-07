algoritmo
=========

Algoritmo de búsqueda en vectores basado en regla de 3 simples 

Algoritmos hasta ahora
======================

Dicotómica(Divide y vencerás): se mira la mitad del vector si lo que hay es menor de lo que buscamos, volvemos a buscar en la parte
inferior del vector, si es mayor buscamos en la parte superior del vector.Si se ha encontrado se sale del programa.

Con Centinela: se busca uno por uno hasta que se encuentra

Algoritmo "humano"
==================

Pero las personas no solemos buscar así.Si no que vemos más o menos qual puede ser la posición donde este lo que buscamos
y vamos a ella. Entonces si lo que hay en esa posicion es menor de lo que buscamos buscamos en lo que queda, si es mayor buscamos
en lo que hemos recorrido ya.

Algoritmo propuesto
===================

Lo que se propone es un algoritmo que se acerque a lo que hacen las personas.Para simular el "más o menos" utilizamos la regla
de 3 simple que es lo que de forma inconsciente usamos.

De esta manera sea:
k: el origen del trozo del vector donde estamos buscando-->0 en origen
N: el final del trozo del vector donde estamos buscando--> el tamaño del vector -1 en origen
v: el vector donde se busca
Si la diferencia N-k es proporcional a v[n]-v[k]
entonces propi-el índice donde está el valor menos k- es decir la distancia que hay desde donde empezamos hasta que encontramos el valor es proporcional al valor buscado menos v[k}
Es decir:
N-k -----------> v[N]-v[k]
propi-k ------->x-v[k]

(n-k)/propi-k = (v[n]-v[k])/(x-v[k])
(n-k)(x-v[k]) = (propi-k)(v[n]-v[k])
(n-K)(x-v[k])/(v[n]-v[k]) = propi-k
propi = ((n-K)(x-v[k])/(v[n]-v[k]))+k;


