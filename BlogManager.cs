﻿using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BlogManager
    {
        private readonly Repository<Blog> repoblog = new Repository<Blog>();
        public List<Blog> GetAll()
        {
            return repoblog.List();
        }
        public List<Blog> GetBlogByID(int? id)
        {
            return repoblog.List(x => x.BlogID == id);
        }
        public List<Blog> GetBlogByAuthor(int? id)
        {
            return repoblog.List(x => x.AuthorID == id);
        }
        public List<Blog> GetBlogByCategory(int? id)
        {
            return repoblog.List(x => x.CategoryID == id);
        }

        public int BlogAddBL(Blog p)
        {
            if (p.BlogTitle == "" || p.BlogImage == "" || p.BlogTitle.Length <= 5 || p.BlogContent.Length <= 200)
            {
                return -1;
            }
            return repoblog.Insert(p);
        }
        public int DeleteBlogBL(int p)
        {

        Blog blog=repoblog.Find(x => x.BlogID == p);
            return repoblog.Delete(blog);
        }
    }
}