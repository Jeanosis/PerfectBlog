using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace PerfectBlog.Models
{
    public class AuthorizationManager
    {
        #region Properties

        public static User LoggedUser
        {
            get
            {
                if (DateTime.Now.Subtract(lastActivityTime).Minutes >= inactionInterval)
                    loggedUser = null;
                
                return loggedUser;
            }

            set
            {
                loggedUser = value;
                lastActivityTime = DateTime.Now;
            }
        }

        #endregion
        #region Variables

        private static int inactionInterval = 600;
        private static User loggedUser;
        private static DateTime lastActivityTime;
        
        #endregion
    }
}