using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace EbaObra.WebApi.Security
{
    public class SigningConfiguration
    {
        private const string SECRET_KEY = "327608fd-fe3b-4d47-9252-ac514d8f99d1";
        public SigningCredentials SigningCredentials { get; }
        private readonly SymmetricSecurityKey _signingKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(SECRET_KEY));

        public SigningConfiguration()
        {
            SigningCredentials = new SigningCredentials(_signingKey, SecurityAlgorithms.HmacSha256);
        }
    }
}