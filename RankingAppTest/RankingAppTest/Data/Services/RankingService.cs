﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RankingAppTest.Data.Models;

namespace RankingAppTest.Data.Services
{
    public class RankingService
    {
        ApplicationDbContext _context;

        public RankingService(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task<List<GameResult>> GetGameResultAsync()
        {
            List<GameResult> results = _context.GameResults
                                                .OrderByDescending(item => item.Score)
                                                .ToList();

            return Task.FromResult(results);
        }
    }
}
