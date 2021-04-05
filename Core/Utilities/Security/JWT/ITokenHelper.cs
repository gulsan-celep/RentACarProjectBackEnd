using Core.Entities.Concrete;
using System.Collections.Generic;

namespace Core.Utilities.Security.JWT
{
    public interface ITokenHelper
    {
        // Bizim için token üretecek fonksiyon. Bizim için hangi claimlerin tokenı olsun veritabınına ekleyecek
        // ilgili kullanıcın, ilgili kullanıcının claimlerine içerecek bir token üretecek. 

        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
    }
}
