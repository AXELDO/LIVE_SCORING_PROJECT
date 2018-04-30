# LIVE_SCORING

Description et ordre de compilation des projets :

1 - DataAccessLibrary : Gère l'accès aux données de la base CompetitionDB 

2 - WcfServiceLiveScoring : Expose les données de la base CompetitionDB à l'application WebAppLiveScoring

3 - WebAppLiveScoring : Présente les données de la base CompetitionDB


Pour tester l'application web WebAppLiveScoring :

1 - Initialiser la base de données CompetitionDB

- Modifier le type de sortie du projet DataAccessLibrary en sélectionnant le type "Application console".
- Sélectionner l'objet de démarrage "DataAcessLibrary.Init"
- Lancer l'exécutable généré. Il créera la base de données CompetitionDB sur une instance SQL Server localdb et l'alimentera avec des   données de démarrage.

2 - Démarrer le web service WcfServiceLiveScoring 

- Lancer l'exécutable généré
- Tester que le web service est operationnel via l'url : http://localhost:54513/ServiceLiveScoring/ScoreService/

3 - Lancer l'application WebAppLiveScoring

- Si la page de demarrage présente une liste de matchs, cela signifique que tout est OK. 
