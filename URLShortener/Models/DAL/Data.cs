using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URLShortener.Models.DAL
{
    public class Data
    {
        public Data()
        {

        }

        public string GetNewShortID(string strURLSubmission, string strIPAddress)
        {
            string strShortID = "";

            return strShortID;
        }

        public bool CheckAPIKey(string strAPIKey)
        {
            bool blnReturn = false;
            
            return blnReturn;
        }

        public string GetURLFromShortID(string strShortID, string strIPAddress)
        {
            string strURL = "";

            return strURL;
        }

        public void LogURLRequests(string strShortID, string strIPAddress)
        {

        }

        public void LogAPICall(string strAPIKey, string strAPICall, string strIPAddress)
        {

        }
    }
}
