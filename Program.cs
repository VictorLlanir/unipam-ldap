using LdapForNet;
using static LdapForNet.Native.Native;

try
{
    using (var connection = new LdapConnection())
    {
        connection.Connect("172.17.15.20", 389, LdapSchema.LDAP);

        connection.Bind(LdapAuthType.ExternalAd, new LdapCredential
        {
            UserName = "cn=nssldap,ou=people,dc=unipam,dc=edu,dc=br",
            Password = "60473822",
        });

        Console.WriteLine("connected");
    }
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
    Console.WriteLine("not connected");

    throw;
}