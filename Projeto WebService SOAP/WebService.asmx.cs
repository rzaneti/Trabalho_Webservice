﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Projeto_WebService_SOAP
{
    /// <summary>
    /// Descrição resumida de WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que esse serviço da web seja chamado a partir do script, usando ASP.NET AJAX, remova os comentários da linha a seguir. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {

        [WebMethod]
        public string GetMusicName()
        {
            return "sweet child o mine";
        }

        [WebMethod]
        public string GetCalculatedNumber()
        {
            return (10*10).ToString();
        }

        [WebMethod]
        public string GetDateTime()
        {
            return DateTime.Now.ToString();
        }
    }
}
