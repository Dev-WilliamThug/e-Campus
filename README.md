I- Architecture du projet
  On est sur une architecture Hybride et sur un modèle Hybride c'est à dire que :
    1- Dans Areas vous verrez que j'ai séparé le dossier en fonction des acteurs car ça va laissé plus de flexibilité à chacun ( Sans oubliez qu'il y'a une maquette qu'on 
    s'est dit qu'on va respecter celle de Darla ) ce qui veut dire que chacun d'entre nous va travaillez là dans son dossier la plupart du temps ce sera pour le rendu 
    graphique de nos differentes vues.
  
    2- Dans les autres dossiers comme Classes, Services, etc. Vous verrez que là j'ai séparé en fonction des modules (Academie, Textbook, etc.) car là il y'a beaucoup de
    Chose qu'on aura en commun en fonction des modules.
  

II- ROle des dossiers
  Le dossier Areas c'est pour séparer l'application en fonction de chaque acteur (Principalement en terme de rendu) chacun d'entre nous ecrira le code des différentes
  vues lié à son acteurs.
  Le dossier Views va contenir les vues et les composants que tout nos modules partage par exemple la page de connexion 
  Le dossier Classes va contenir le code des differentes classes que nous allons retenir. Dans ce dossier j'ai encore séparé mais là en fonction des modules car chaque
  aura ses propres entités à gérer et aux dossiers des modules s'ajoute celui appeler Commune où l'on va stocker les classes qui sont exploiter par tout les modules.
  Le dossier Services est celui où sera stocker toute la logique métier toujours organiser en fonction des modules pour que nous puissions eviter au maximum de dupliquer
  les codes car en terme de logique métier on va presque tous utiliser les mêmes codes.
  Le dossier Data lui va contenir tout ce qui concernent la BD.
