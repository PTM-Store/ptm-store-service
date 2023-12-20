using ptm_store_service.Data;
using System.Collections.Generic;

namespace ptm_store_service.Repositories.Interface
{
    public interface ITokenRepository
    {
        void CreateToken(Token token);
        List<Token> FindByUserId(int userId);
        Token FindByAccessToken(string accessToken);
    }
}
