using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;

namespace Core.Utilities.Security.Encryption
{
    public class SigningCredentialsHelper
    {
        // Web apinin kullanabileceği jwt oluşturulabilmesi için Credentials(securityKeyimiz) bize imzalama nesnesini döndürür.
        //securityKey -> anhatar olarak bunu kullan. Burada hashing işlemi yapacak. SecurityAlgorithms.HmacSha512Signature -> şifreleme olarak bunu kullan
        // Şifeleme için hangi anahtar ve hangi algoritma kullanılacağı verilir.
        public static SigningCredentials CreateSigningCredentials(SecurityKey securityKey)
        {
            return new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha512Signature);
        }
    }
}
