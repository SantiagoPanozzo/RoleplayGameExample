![Banner](./Assets/banner.png)

![UCU](https://github.com/ucudal/PII_Conceptos_De_POO/raw/master/Assets/logo-ucu.png)

### FIT - Universidad Católica del Uruguay

# Encuentros futuros de la Tierra Media

En este juego, varios personajes cobrarán vida en la Tierra Media.

## Personajes [Characters]

Existen diferentes tipos de personajes provenientes de distintas especies.

### [Magos _[Wizards]_](https://lotr.fandom.com/wiki/Wizards)

Los magos, también conocidos como Istari, tienen el dominio de la mágia, que provee capacidades de ataque y de defensa. La mágia es innata a ellos, aunque pueden adquirir más mediente el estudio de la asignatura, y mediante elementos que la potencian (por ejemplo, un [bastón mágico](https://ringsdb.com/bundles/cards/142008.png)).

### [Elfos _[Elves]_](https://lotr.fandom.com/wiki/Elves)

Los elfos son criaturas supernaturales que también poseen características mágicas, y en general son conocidos por ayudar a los demás.

### [Enanos _[Dwarves]_](https://lotr.fandom.com/wiki/Dwarves)

Los enanos son seres temperamentales, muy buenos en combate con las armas, físicamente fuertes, con mucha resistencia y leales a sus amigos.

## Elementos _[Items]_

Los personajes necesitan de ciertos elementos para poder combatir con sus enemigos. Estos elementos pueden ser ropaje (túnica, por ejemplo), armas (como un hacha o una espada), entre otros. 

Existe un elemento particularmente interesante, llamado libro de hechizos. El libro de hechizos es tan poderoso como hechizos tenga en él, y representa el conocimiento de un mago.

# Desafío

## Parte 0: Repo

Cada equipo deberá crear un repo para el desarrollo de este juego. Todos los miembros del equipo deberán tener acceso al repo.

## Parte 1: Modelado

En equipo, modelen las clases y las colaboraciones que son necesarias para representar los elementos del juego mencioandos.

Recuerden: los personajes deben poder tener items. Por ejemplo, los magos pueden tener un bastón mágico, un libro de hechizos (con hechizos), etc.

Deberán crear y subir al repositorio el modelo en forma de diagrama de clases.

## Parte 2: Creación

Cada equipo deberá crear las clases representadas en el modelo anterior. Cada integrante deberá crear, al menos:

- Un personaje  🧙‍♂️

- Dos elementos ⚔️ 🛡

> Recuerden crear el libro de hechizos y sus hechizos (existe un solo _tipo_ de hechizo por ahora).

### Personajes

Los personajes tienen, además de sus items, un nombre y una cantidad de vida limitada. 

Sus items pueden además quitarse o cambiarse por otros similares (por ejemplo, darle a un mago un bastón mágico nuevo, o simplemente quitarle el que tiene).

### Elementos

Los elementos tienen un valor de ataque y un valor de defensa. Es posible que en algunos casos alguno de estos valores sea 0. Por ejemplo, un elemento "Armadura" puede tener valor de ataque 0.

> [Inspiración](https://ringsdb.com/find?q=t%3Aattachment)

## Parte 3: Cobrando poder

Agregar al proyecto el siguiente comportamiento:

- Obtener el valor total de ataque de un personaje. ⚔️

- Obtener el valor total de defensa de un personaje. 🛡

- Atacar a un personaje (disminuir su vida en cierta cantidad) 🗡

- Curar a un personaje (recuperar su vida inicial) 🚑

Justificar con comentarios en el código las decisiones que tomaron para resolver esta parte del desafío, incluyendo si utilizaron algun patrón o principio.

## Parte 4: Testing

Deberán escribir casos de test para probar su programa. Como equipo tendrán que evaluar qué casos de test son necesarios, y deberán incluír la justificación de cada caso de test como comentario en el código del proyecto.

Todos los integrantes del equipo deben participar de la escritura de tests (contribuyendo al menos uno de los casos).


