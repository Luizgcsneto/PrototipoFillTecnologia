using System.IdentityModel.Tokens.Jwt;

namespace PrototipoFillTecnologia.Server.Token
{
    public class TokenJwt
    {
        private JwtSecurityToken _token;

        internal TokenJwt(JwtSecurityToken token)
        {
            this._token = token;
        }

        public DateTime ValidTo => _token.ValidTo;

        public string value => new JwtSecurityTokenHandler().WriteToken(this._token);
    }
}
