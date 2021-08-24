﻿using AllNews.Data.Interfaces;
using AllNews.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace AllNews.Data.Repositores
{
    public class MoveTextRepository:Repository<MoveText>,IMoveTextRepository
    {
        public MoveTextRepository(AllNewsDbContext context):base(context)
        {

        }

        public IEnumerable<MoveText> GetLast8MoveText()
        {
            return GetAll().OrderByDescending(x=>x.UpdatedDate).Take(8).ToList();
        }
    }
}
