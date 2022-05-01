using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class SubscribeMailManager
    {
        Repository<SubscribeMail>repoSubscribemail=new Repository<SubscribeMail>();
        public int BLAdd(SubscribeMail p )
        {
            ////@gmail.com
            //if (p.Mail.Length<= 2 || p.Mail.Length >= 150)
            //{
            //    return -1;
            //}
            return repoSubscribemail.Insert(p);
        }
    }
}
