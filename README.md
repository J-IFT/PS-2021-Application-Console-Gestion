# PS-2021-Application-Console-Gestion

*PS = Projet Scolaire*

## 📚 Projet Scolaire | Réalisation d'une application console de gestion

Octobre 2021

Groupe : Juliette et Jeremy

La solution s'appelle toujours ProjetJulietteJeremyMailys mais Mailys ne fait plus partie de l'école donc du projet.

### 📎 Vidéo de démonstration :

Un aperçu en vidéo, c'est toujours mieux !

https://youtu.be/CFJALxunMHE

### 📌 Consignes du projet :

Réalisation d'une application console de gestion en C#.

L'examen comporte 2 parties.

Fonctionnalités attendues :

*1ère partie :

Pour cet examen, vous devez réaliser une petite application console en C# permettant de gérer des matières.


- Proposer un menu ✔️

Le menu vous permettra de choisir entre créer une matière et afficher l’ensemble des matières saisies.


- Implémenter les fonctions permettant de créer une matière ✔️

Une matière doit avoir les propriétés suivantes -> Nom : une chaine de caractères ; Code : un entier ; Nombre d’heures : un entier.


- Implémenter une fonction permettant d’afficher l’ensemble des matières créées ✔️

En suivant l'exemple donné par l'intervenant.


- Contrôle des saisies ✔️

Les opérations que vous venez de réaliser doivent inclure un contrôle des saisies utilisateur.
Pour cela, vous devez vous assurer que :
- Les saisies numériques (Code et nombre d’heures) soient bien réalisées sous forme numérique
- Les saisies correspondent à un entier strictement supérieur à 0
- Le nom de la matière n’est pas vide
- Le nom de la matière commence par une majuscule
- Le nom de la matière n’est pas un numérique (123 doit être rejeté par exemple)
Pour chaque saisie erronée, vous devrez proposer un message à l’utilisateur lui indiquant que la saisie n’est pas valide.
Idéalement un message très explicite doit être réalisé (par exemple : « Saisie incorrecte : le nom de la matière ne doit pas être vide » ou « Saisie incorrecte : le nom de la matière ne doit pas être un numérique »).


- Affichage du nombre total d’heures ✔️

Une fois les opérations précédentes réalisées, vous devez afficher le nombre total d’heures pour l’ensemble des matières.
Pour cela, vous devez ajouter une entrée au menu (3. Afficher le nombre total d’heures).
Lorsque l’utilisateur fera ce choix, vous devrez calculer puis afficher le nombre total d’heures de toutes les matières et l’afficher à l’utilisateur.


- Formatez l’affichage des numériques ✔️

Les numériques affichés sous la forme 480000 ne sont pas très lisible. Je souhaite avoir un affichage utilisant le « . » comme séparateur de millier, million, milliard… Par exemple 480.000.


*2ème partie :

Cet examen consiste à continuer l’application de gestion des formations développée lors du premier examen.


- Découpage en services ✔️

Réaliser le découpage en services : vous devez décomposer l’application (qui se trouve dans la classe Program.cs) pour créer les services nécessaires
- Sauf pour la partie principale (Program.cs), la gestion des dépendances entre les services doit se faire par le constructeur.
- Idéalement, pour chaque service, vous devez créer : l’interface et le service implémentant l’interface


- Gestion des formations ✔️

Vous devrez également implémenter une nouvelle fonctionnalité consistant à gérer les formations.
Chaque formation est composée d’un code, d’un nom et d’un niveau.
Vous devez créer les entrées du menu permettant :
- De créer une formation
- D’afficher les informations des formations.


- Modification de la gestion des communes ✔️

Les matières doivent être reliées aux formations.
Vous devez modifier :
- La création d’une matière : vous devez demander le code de la formation et la relier à la formation (on part du principe qu’une matière ne peut être attachée qu’à une formation)
- L’affichage d’une matière : vous devez afficher, en plus des informations de la matière, le nom de la formation.


- Comptage du nombre d’heures de la formation ✔️

Lors de l’affichage des informations d’une formation, vous devez en plus afficher le nombre d’heure total de cours (ie la somme des heures des matières qui la compose).

### 💻 Applications et langages utilisés :

+ C#
+ Visual Studio Code




## 🌸 Merci !
© J-IFT
