﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using DataAccessLibrary.Models;

namespace WcfServiceLiveScoring
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IScoreService" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IScoreService
    {
        [OperationContract]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json, UriTemplate = "/GetAllScores/")]
        List<ScoreDataContract> GetAllScores();



    }
}
