using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaDePesca.Resourse.Exceptions
{
    public class TratarException
    {
        public static void NHibernateException(Exception ex, ITransaction transaction)
        {
            if (!transaction.WasCommitted)
            {
                transaction.Rollback();
            }

            throw ex;
        }

        public static void NHibernateException(Exception ex)
        {
            throw ex;
        }
    }
}
