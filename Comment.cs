﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Comment
    {
        [Key]
        public int CommentID { get; set; }
        [StringLength(50)]
        public string UserName { get; set; }
        [StringLength(30)]
        public string Mail { get; set; }
        [StringLength(200)]
        public string CommentText { get; set; }
        public DateTime CommentDate { get; set; }
        public int BlogID { get; set; }
        public string UserImage { get; set; }
        public virtual Blog Blogs { get; set; }
    }
}
