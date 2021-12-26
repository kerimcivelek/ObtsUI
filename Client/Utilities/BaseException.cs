using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ObtsUI.Client.Utilities
{
    public class BaseException
    {
      public static void ResponseException(string exception)
        {
            if (exception != null)
            {
                throw new Exception(exception);
            }
        }
    }
}
