﻿using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ContactManager
    {
        Repository<Contact> repocontact = new Repository<Contact>();
        public  int BLContactAdd(Contact c)
        {
            if (c.Mail=="" || c.Message=="" || c.Name=="" ||c.Subject==""||c.SurName==""||c.Mail.Length<=5||c.Subject.Length<=4)
            {
                return -1;
            }
            return repocontact.Insert(c);
        }
    }
}
