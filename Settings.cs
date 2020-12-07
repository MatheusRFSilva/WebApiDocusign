
public class Settings
{
    public string AuthorizationEndpoint { get; }
    public string ClientSecret { get; }
    public string ClientId { get; }
    public string TokenEndpoint { get; }
    public string UserInformationEndpoint { get; }
    public string RsaPrivateKey { get; set; }
    public string RsaPublicKey { get; set; }

    public Settings()
    {
        AuthorizationEndpoint = "https://account-d.docusign.com/oauth/auth";
        ClientSecret = "8d868d57-56df-4834-90ec-3aacdaf460d9";
        ClientId = "feb7e969-43d4-46dd-8447-b8f565986f2f";
        TokenEndpoint = "https://account-d.docusign.com/oauth/token";
        UserInformationEndpoint = "https://account-d.docusign.com/oauth/userinfo";
        RsaPrivateKey = @"MIIEpAIBAAKCAQEAgpaGm+7n2VVP8LBK2pUMbpzSK3XCGrGYzxRTOi2Yod3VlFhD
quNIUg70HD+FdaWMosEcgM/cCQ3oN6kYZ9lX1wlkoG9os+lILk7QdUT7M9PzDx6V
t52GJzK1q31q4qwq/dR2eG2cdhyd0evS9ySKvDfEvIxMsjfmm3nRQEPrAHZi8Jrm
9AnyLiqpkyK+12O3N1ZIBhY52aozm3Zw4waqd7EfGk3Zyz7nTIyGLBcLzE1U6/D4
wZuedywlmk1EZGc3eUApJhZLzBw0B8lTI2MmAuZBn3Sg0wiaNxfFv8N+a6ayxMZd
xcbMRwVg4NIUwiCxCwjbV74e+xecxd5fgv8A8wIDAQABAoIBABX5p7BQ7UIk+Z1a
xVXwNBXfHP0ERYRBc6IRXQoSxzciAgGDMuvscGyiqJCiXd6U28w9rAK/N9tsNDI9
qeY77Gy632yiIt/3t1ZXm/vH/m/T0HiwYGh0QTGSdoDjy5tWdqudV8xfQa+clDBR
u4AsbY5L4jcKcxOglZV/U+e5JjA+/hdTjt7DWvdajFN0N+2YyafqTP56e7iTkAnp
/Jz8mwpmJMWxO2ZFVBYrSCvW1LTH1boKAViKfu6uaE7yVg/ZUxWtJtrkbHg7aGvt
BI0VgydsX+FGhJvh0TYbffgveWLomvTdhgkel6S8gFCJd53USzRzpIp2duqnu/9G
58DjIf0CgYEAxyQJxpVfHGc1GAe6xCL9blsaf0lbR10HhHZAMVDIND2Zrm9K5kDS
7NRrWDw8s6DzLFweu+wuhcejsHx4QhODXIwyfu/FuTF7dBj/Q82QNN1AqoGAqoKs
BHS8FmEAmCE4mDnEjXTPrPLFtve0xbiHb/zeqBppCS4sZDUNw0ZRyjUCgYEAp9+z
xEQzIlDacMG4+3yRejSd0B+7guQWX33uCIjrR2U6VhTxKxmXe2pMRv36S6TAx/cu
dsJ3FBXhjDF3cFzP9qo9+DSXLUz5GtlFy41Y1pfmBXpOfnJJ35yfEcOiB2UFMpGW
m9RMlcOA1PUb3bH2LF4CENYJRpE8W2VaAUBbw4cCgYEAowPNPNJp2UZjIBizunsq
GnxZZHkYT4LH9JcYVUZbnOgQNcrE9Vd7UoNQnBozVpgad+WxAwSD0N9sD7zUdMKk
dc4OR/rfUIpBFPihfU95DM1RckIwoWP2jG9CyM7/PYl0WqhvTZyhpGHXl7+OK4yy
0emeGt4DvZAepqkHayLVMUECgYAnEMzRqJlJrA0ZXkuA4p0sFiB/dVL6g7+dGz4Q
aGRwKeNoctkokX0J8FOt1Z6wibd/EUuTwW9akjj5me1UjZSrrzRalUp09Uum7tbq
Jot87L5PmgW4MTp1ugneZWtIUz7hZLXqr33fAC7z39JLRgWmj33lkxl3fYbRMgW+
8s4n8wKBgQC9PjF/0SxBnlx76Re2rgV1vG1xuzpZ/mjxpYfaZVqwHQF1k6o0FwHf
yTu9tlQYCG17IL0g6YvSiI0uf1QeRyVYZTHqT7F7fOWvvV7AH0rhv7HjAuisG9tD
XgMXkD36RDqBkZ36kLH/3C+bepo/p7LDfRhmP4jXKVJlfHXjW+zBPw==";

        RsaPublicKey = @"MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAgpaGm+7n2VVP8LBK2pUM
bpzSK3XCGrGYzxRTOi2Yod3VlFhDquNIUg70HD+FdaWMosEcgM/cCQ3oN6kYZ9lX
1wlkoG9os+lILk7QdUT7M9PzDx6Vt52GJzK1q31q4qwq/dR2eG2cdhyd0evS9ySK
vDfEvIxMsjfmm3nRQEPrAHZi8Jrm9AnyLiqpkyK+12O3N1ZIBhY52aozm3Zw4waq
d7EfGk3Zyz7nTIyGLBcLzE1U6/D4wZuedywlmk1EZGc3eUApJhZLzBw0B8lTI2Mm
AuZBn3Sg0wiaNxfFv8N+a6ayxMZdxcbMRwVg4NIUwiCxCwjbV74e+xecxd5fgv8A
8wIDAQAB";

    }

}