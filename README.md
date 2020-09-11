# Universidad Católica del Uruguay
<img src="https://ucu.edu.uy/sites/all/themes/univer/logo.png"> 

## Facultad de Ingeniería y Tecnologías
### Programación II

## UCU Vigenere.

### Introducción
El código de [Vigenere](https://en.wikipedia.org/wiki/Vigen%C3%A8re_cipher) es una variante de encriptación mejorada sobre el código del [Cesar](https://en.wikipedia.org/wiki/Caesar_cipher). En el algoritmo del Cesar, para encriptar, simplemente desplazamos las letras hacia la derecha según su posición en el abecedario. Por ejemplo, si utilizamos clave 3 nuestro abecedario encriptado luce así:

```
Texto plano:      ABCDEFGHIJKLMNOPQRSTUVWXYZ
Texto encriptado: DEFGHIJKLMNOPQRSTUVWXYZABC
```

Donde la letra A es reemplazada por la D, la B por la E, etc. Por ejemplo, si queremos encriptar la palabra Programacion con algoritmo del cesar y clave 3 obtenemos algo así:
```
Texto plano:      PROGRAMACION
Texto encriptado: SURJUDPDFLRQ
```

En el código de Vigenere, aplicamos los mismos principios, pero nuestra clave en lugar de ser un número es una palabra y utilizamos la posición de cada letra de la palabra como vector de ecriptación. Por ejemplo, siguiendo el ejemplo anterior, si utilizamos la palabra UCU como palabra clave tendremos:

```
Palabra clave: UCU
Vector: 20, 2, 20 -> La U es la letra 20 (siendo la A el indice 0) del abecedario y la C la letra 2
```

Entonces, para aplicar la encriptacion de vigenere a nuestro mensaje (Programación) haremos lo siguiente:
1 - Tomamos la primer letra del mensaje: P
2 - Tomamos la primer letra de la clave: U
3 - Convertimos la clave a número: 20
4 - Aplicamos el algoritmo del cesar a la letra P con clave 20: obtenemos una J. Esta sera la primer letra de nuestro mensaje encriptado
5 - Aplicamos los mismos pasos del 1 al 4 con las siguientes letras. Si nuestra clave es mas corta que nuestro mensaje, lo cual es este caso, cuando no tenemos más letras en la clave, volvemos al principio y repetimos. 

Finalmente, el resultado será el siguiente:
```
Texto plano:      PROGRAMACION
Texto encriptado: JTIATUGCWCQH
```
Finalmente, para este ejercicio, hemos agregado una variante adicional, llamada [Salt](https://en.wikipedia.org/wiki/Salt_(cryptography)) a nuestro algoritmo vigenere para crear el algoritmo **Vigenere UCU**. En este caso, nuestro Salt es simplemente un valor que agrega un desplazamiento adicional a nuestro código.

Por ejemplo, si aplicamos el algoritmo de encriptacion **Vigenere UCU** a la palabra PROGRAMACION, con clave UCU y Salt 5 obtendremos:

```
Texto plano:      PROGRAMACION
Texto encriptado: OYNFYZLHBHVM
```

### Ejercicio
En este repo, te hemos proporcionado una implementación del algoritmo **Vigenere UCU**, sin embargo, esta implementación tiene varios errores. Esto podrás verificarlo al ejecutar los tests. 

> :warning: **Advertencia!!** Este código NO es muy eficiente. 
> No lo tomes como referencia de una buena implementación de un algoritmo de encriptación

Será tu trabajo arreglar estos errores de los docentes y lograr desencryptar el mensaje que hemos dejado en el Program:

```
Texto encriptado: OYNFYZLHBHVM
```

Estos mensajes te daran una pista para encontrar el premio :gift: 
La primera persona en encontrar el premio y postear un screenshot de esto mas los **test funcionando** ganará un premio! 