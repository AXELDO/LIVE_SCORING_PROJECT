using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DataAccessLibrary;
using DataAccessLibrary.Models;


namespace WcfServiceLiveScoring
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "ScoreService" à la fois dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez ScoreService.svc ou ScoreService.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class ScoreService : IScoreService
    {
        public List<ScoreDataContract> GetAllScores()
        {
            var scores = Factory.GetAllScores();


            List<ScoreDataContract> listToReturn = new List<ScoreDataContract>();
            scores.ForEach(s =>
            {
                listToReturn.Add(new ScoreDataContract
                {
                    ScoreID = s.ScoreID,
                    Comments = s.Comments,
                    LocalName = s.LocalName,
                    LocalScore = s.LocalScore,
                    MatchDate = s.MatchDate,
                    VisitName = s.VisitName,
                    VisitScore = s.VisitScore

                });
            });
            
            
            return listToReturn;

        }
    }
}
