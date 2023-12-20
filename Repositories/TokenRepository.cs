using ptm_store_service.Data;
using ptm_store_service.Repositories.Interface;
using System.Collections.Generic;
using System.Linq;

namespace ptm_store_service.Repositories
{
    public class TokenRepository : ITokenRepository
    {
        private readonly MyDbContext _context;

        public TokenRepository(MyDbContext context)
        {
            _context = context;
        }

        public void CreateToken(Token token)
        {
            _context.Tokens.Add(token);
            _context.SaveChanges();
        }

        public Token FindByAccessToken(string accessToken)
        {
            var token = _context.Tokens.SingleOrDefault(tok => tok.AccessToken == accessToken);
            if (token == null)
            {
                return null;
            }
            return token;
        }

        public List<Token> FindByUserId(int userId)
        {
            var tokens = _context.Tokens.Where(tok => tok.UserId == userId).ToList();
            return tokens;
        }
    }
}
