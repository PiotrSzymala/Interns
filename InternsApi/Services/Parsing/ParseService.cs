﻿using InternsApi.Factory;
using InternsApi.Models.DTO;

namespace InternsApi.Services.Parsing
{
    public class ParseService : IParseService
    {
        private readonly ParserFactory _parserFactory;

        public ParseService(ParserFactory parserFactory)
        {
            _parserFactory = parserFactory;
        }

        public async Task ParseFile(FileResponseDto dto)
        {

            var parser = _parserFactory.CreateParser(dto.ResponseType);

            var interns = parser.Parse(dto.Response);

        }
    }
}