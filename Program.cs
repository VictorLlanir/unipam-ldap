using LdapForNet;
try
{
    using (var cn = new LdapConnection())
    {
        // connect
        cn.Connect("172.17.15.20", 389);
        // bind using kerberos credential cache file
        cn.Bind(userDn: "unipam.edu.br\\brunonoremberg", password: "885848099");
    }
}
catch (Exception e)
{

	throw;
}