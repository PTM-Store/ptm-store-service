using ptm_store_service.Data;
using ptm_store_service.Models.Request;
using ptm_store_service.Models.Response;
using System.Collections.Generic;

namespace ptm_store_service.Services.Interface
{
    public interface ITokenService
    {
        Token CreateToken(TokenRequestModel token);
        List<TokenResponseModel> GetTokenByUserId(int userId);
        TokenResponseModel GetTokenByAccessToken(string accessToken);
        int GetUserIdByToken(string accessToken);
    }
}
