using System;


namespace SchemaLoader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calling GetSchemas");

            SchemaLoader.Managers.DocumentManager dMgr = new SchemaLoader.Managers.DocumentManager();

            dMgr.GetSchemas();


            Console.WriteLine("Finished GetSchemas");
        }
    }
}
