﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SharedData.Models;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;

namespace RankingAppTest.Data.Services
{
    public class RankingService
    {
        HttpClient _httpClient;

        public RankingService(HttpClient client)
        {
            _httpClient = client;
        }
        // Create
        public async Task<GameResult> AddGameResult(GameResult gameResult)
        {
            string jsonStr = JsonConvert.SerializeObject(gameResult);
            var content = new StringContent(jsonStr, Encoding.UTF8, "application/json");
            var result = await _httpClient.PostAsync("api/ranking", content);

            if (result.IsSuccessStatusCode == false)
                throw new Exception("AddGameResult Failed");

            var resultContent = await result.Content.ReadAsStringAsync();
            GameResult resGameResult = JsonConvert.DeserializeObject<GameResult>(resultContent);
            return resGameResult;
        }

        //Read
        public async Task<List<GameResult>> GetGameResultAsync()
        {
            var result = await _httpClient.GetAsync("api/ranking");

            var resultContent = await result.Content.ReadAsStringAsync();
            List<GameResult> resGameResult = JsonConvert.DeserializeObject<List<GameResult>>(resultContent);

            return resGameResult;

        }

        // Update
        public async Task<bool> UpdateGameResult(GameResult gameResult)
        {
            string jsonStr = JsonConvert.SerializeObject(gameResult);
            var content = new StringContent(jsonStr, Encoding.UTF8, "application/json");
            var result = await _httpClient.PutAsync("api/ranking", content);

            if (result.IsSuccessStatusCode == false)
                throw new Exception("UpdateGameResult Failed");

            return true;
        }

        // Delete

        public async Task<bool> DeleteGameResult(GameResult gameResult)
        {
            var result = await _httpClient.DeleteAsync($"api/ranking/{gameResult.id}");

            if (result.IsSuccessStatusCode == false)
                throw new Exception("DeleteGameResult Failed");

            return true;
        }
    }
}
