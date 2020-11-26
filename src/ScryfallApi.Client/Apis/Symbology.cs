﻿using ScryfallApi.Client.Models;
using System.Threading.Tasks;

namespace ScryfallApi.Client.Apis
{
    public class Symbology : ISymbology
    {
        private readonly BaseRestService _restService;

        internal Symbology(BaseRestService restService)
        {
            _restService = restService;
        }

        /// <summary>
        /// Retrieve all card symbols
        /// </summary>
        /// <returns></returns>
        public Task<ResultList<Symbol>> Get() => _restService.GetAsync<ResultList<Symbol>>("/symbology");

        /// <summary>
        /// Parses the given mana cost parameter and returns Scryfall’s interpretation.
        /// </summary>
        /// <returns></returns>
        public Task<ManaCost> ParseMana(string cost) => _restService.GetAsync<ManaCost>("/symbology/parse-mana");
    }
}