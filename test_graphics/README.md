*Projet réalisé par **Salmane Farid** (20038) & **Adil Chafik** (20132)*

---
# Rapport Projet POO "Ecosystème"
## Objectif
Ceci est un projet de 3ème année à l'ECAM pour le cours de programmation orientée objet.
L'énoncé est disponible ici : 
[quentin-lurkin.xyz](https://quentin.lurkin.xyz/courses/poo/projet2021/index.html)
___
## Utilisation du programme
Par défaut, le programme exécute un scénario dans lequel des animaux, des plantes, de la viande et des déchets organiques sont placées dans le plan, 
du temps est laissé à ces éléments pour épuiser leur énergie et se transformer au fil du temps.

Le programme est exécuté et affiche sur l'écran le changement des élements par les itérations du programme.
### Ajout d'un nouvel élément
Pour ajouter un nouvel élément, rendez-vous dans le fichier "Simulation.cs". Ajoutez-y un nouvel élément sur base la classe abstraite de votre choix (Plant, Animal, OrganicWaste, Meat). 
Féfinissez y les coordonnées ainsi que l'énergie et les points dits de vie.
Voici un exemple :
``` C#
	new Animal(20, 40, 5, 1)  //où: x=20, y=40, lifetime=5, energy=1
```
### Changement de la disposition de départ
Pour changer la disposition de départ des entités sur le plan, il faut rajouter/remplacer/modifier le code suivant dans le constructeur de la classe Simulation dans le fichier:
``` C#
simulation.cs;
```

___
## Fonctionnement général
Une instance *objects* de la classe *Simulation* va contenir tous les élements (instances d'une sous-classe de la classe abstraite *SimulationObject*). Durant chaque itération de *objects*, les objets vont un à un subir une mise à jour:
* Les organismes vont perdre de l'énergie et perdre de la vie (ou peut-être même disparaître)
* Les plantes vont se transformer en déchets organiques avec le temps ...
* Les animaux vont se déplacer, avant de se transformer en viande ...
* La viande va pourrir pour devenir un déchet organique
* ...


## Diagrammes
### Diagramme de classes
![Diagramme de classes](Diagramme_classe.png)
### Diagramme de séquence
![Diagramme de séquence](Diagramme_sequence.png)
___
## Principes SOLID
### Principe de Substitution de Liskov
La définition du principe est la suivante :
> Si q(x) est une propriété démontrable pour tout objet x de type T, Alors q(y) doit est vraie pour tout objet y de type S où S est un sous-type de T.

Il définit ce qu'est un **"bon" sous-type**.
Une façon de voir que ce principe a été utilisé est que tout objet peut être converti en une des ses sous-classes.

### Principe ouvert/fermé
Ce principe affirme qu'une entité (classe, méthode, module...) doit être __ouverte à l'extension mais fermée à la modification__.
Un exemple de l'utilisatin de ce principe dans ce projet est que lors de la création d'une nouvelle espèce d'organisme, je ne dois pas modifier les superclasses.