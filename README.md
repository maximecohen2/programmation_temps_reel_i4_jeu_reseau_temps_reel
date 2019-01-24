# I4 - Programmation Temps Réel

Réaliser par Maxime Cohen

### Sujet: Jeu réseau temps-réel

Le projet consiste à proposer un jeu 2 joueurs temps-réel type Pong qui :

- Synchronise les deux machines au démarrage
- Envoi/Lit des messages datés de l'autre joueur pour extrapoler la situation actuelle de jeu

L'api REST fournie est utilisable comme suit, où 'k' est votre clé d'accès à l'API comme défini dans le fichier joint :
- Aide : GET http://syllab.com/PTRE839/help?k=...
- Ping : GET http://syllab.com/PTRE839/pings?k=...&t0=
- Envoi : POST http://syllab.com/PTRE839/msgs?k=...&to=...&data=... ('to' étant la clé du destinataire et data une chaîne contenant les données)
- Réception : GET http://syllab.com/PTRE839/msgs?k=.... (Attention, la lecture est bloquante et retire le message de la file)

Pour ceux que ça intéresse, le source du serveur est sur : https://gitlab.com/labasse/rtplay-api 

### Livrable

Code source zippé ou lien vers le code source.


### Information Complémentaire

Clé d'accès à l'API ('k'): 317319

### Rendu

Lien vers le dépot: https://github.com/maximecohen2/programmation_temps_reel_i4_jeu_reseau_temps_reel

