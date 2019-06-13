# Ens'INSIDE

## Présentation du projet

Petit visiteur que vous êtes, vous vous demandez sûrement si vous pouvez entrer dans telle ou telle salle, ou si au contraire vous allez déranger une classe entière. Plus de panique ! **Ens'Inside** est là pour vous. Cette application vous indiquera dans quelle salle se trouvent vos professeurs préférés et vos camarades, l'emploi du temps de telle ou telle salle, et vous guidera dans les endroits les plus secrets du bâtiment Lumière de l'ENSISA.

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
