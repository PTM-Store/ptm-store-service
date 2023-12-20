using ptm_store_service.Data;
using ptm_store_service.Models.Request;
using ptm_store_service.Models.Response;
using ptm_store_service.Repositories.Interface;
using ptm_store_service.Services.Interface;
using System.Collections.Generic;
using System.Linq;

namespace ptm_store_service.Services
{
    public class TokenService : ITokenService
    {
        private readonly ITokenRepository _tokenRepository;

        public TokenService(ITokenRepository tokenRepository)
        {
            _tokenRepository = tokenRepository;
        }

        public Token CreateToken(TokenRequestModel tokenRequestModel)
        {
            var token = new Token
            {
                AccessToken = tokenRequestModel.AccessToken,
                RefreshToken = tokenRequestModel.RefreshToken,
                UserId = tokenRequestModel.UserId
            };
            _tokenRepository.CreateToken(token);
            return token;
        }

        public TokenResponseModel GetTokenByAccessToken(string accessToken)
        {
            var token = _tokenRepository.FindByAccessToken(accessToken);
            var tokenResponseModel = new TokenResponseModel
            {
                Id = token.Id,
                AccessToken = token.AccessToken,
                RefreshToken = token.RefreshToken,
                UserId = token.UserId
            };
            return tokenResponseModel;
        }

        public List<TokenResponseModel> GetTokenByUserId(int userId)
        {
            var tokens = _tokenRepository.FindByUserId(userId);
            var tokensResponseModel = tokens.Select(token => new TokenResponseModel
            {
                Id = token.Id,
                AccessToken = token.AccessToken,
                RefreshToken = token.RefreshToken,
            }).ToList();

            return tokensResponseModel;
        }

        public int GetUserIdByToken(string accessToken)
        {
            var token = _tokenRepository.FindByAccessToken(accessToken);
            var userId = token.UserId;
            return userId;
        }
    }
}
