# Ens'INSIDE

## Présentation du projet

Petit visiteur que vous êtes, vous vous demandez sûrement si vous pouvez entrer dans telle ou telle salle, ou si au contraire vous allez déranger une classe entière. Plus de panique ! **Ens'Inside** est là pour vous. Cette application vous indiquera dans quelle salle se trouvent vos professeurs préférés et vos camarades, l'emploi du temps de telle ou telle salle, et vous guidera dans les endroits les plus secrets du bâtiment Lumière de l'ENSISA.

## Axes de réflexion

Après un brainstorming entre les différents membres du groupe, il en a découlé un bon nombre d'idées qu'il a fallu par la suite canaliser afin de rentrer dans les délais du projet.

### Axes principaux
Les axes principaux de réflexions sont les suivant :
  - Détection de chaque panonceau de salle
  - L'affichage de l'emploi du temps
  - L'affichage de la disponibilité
  - L'affichage des équipements et des pannes
  - Gestion de différents profils  

### Axes secondaires
Les axes moins prioritaires auquels nous avons pensé :
  - Check in/check out des professeurs dans leur bureau
  - Recherche de salle
  - Jeu de prise en main de l'application
  - Emploi du temps des événements
  - Réalité augmentée sur les projets de l'école pour en afficher une explication
  - Différents petits jeux interactifs au sein de l'application

## Fonctionnalités du prototype

Le prototype a été développé sur Unity en C# avec la technologie Vuforia (pour la réalité augmentée).

### Inscription - connexion
L'utilisateur s'inscrit à la première utilisation, puis se connecte.

### Menu
Une fois connecté, il est redirigé vers l'écran principal. Ce dernier comporte une caméra permettant de détecter le panonceau des salles. Lorsqu'un panonceau est détecté, il est décodé. Il est alors affiché le nom de la salle ansi que deux boutons virtuels en réalité augmentée : un bouton "emploi du temps" et un autre "informations". Ils permettent, par un simple passage du doigt devant le bouton, d'affichier l'emploi du temps de la salle en question afin de savoir si elle est occupée ou non et également toutes les informations utiles de la salle.

### Salle
Les informations de la salle comprennent son type (exemple : salle de TP), son numéro, son étage, le nombre de places et le nombre d'ordinateurs. L'emploi du temps comprend les informations pour la semaine courante (avec les informations des cours à chaque horaire), et il est possible de voir les semaines précédentes et suivantes.



L'emploi du temps de chaque salle du bâiment Lumière de l'ENSISA est récupérer d'une basse de données en ligne (c.f. Iariss). Les informations ainsi récupérées, nous remplissons notre base de données locale. A chaque fois que l'utilisateur souhaite accéder à une information, le programme cherche la donnée correspondante dans la base de données locale.



## Développeurs

* Benjamin Chapoulie (chef de projet) ;
* Büşra Dağlı ;
* Manon Heyser ;
* Pierre Mantegazza ;
* Lisa Moulis ;
* Batiste Pretesac ;
* Lucas Schloesslin.
