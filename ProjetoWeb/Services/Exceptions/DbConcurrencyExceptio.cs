using System;


namespace ProjetoWeb.Services.Exceptions
{
    public class DbConcurrencyExceptio : ApplicationException
    {
        public DbConcurrencyExceptio(string message) : base(message)
        {

        }
    }
}
