using Facade_Pattern;
using System;
using System.Collections.Generic;

namespace Facade
{
    public class DatabaseService
    {
        private SqlDBService sqlDBService;
        private MongoDBService mongoDBService;

        public DatabaseService()
        {
            sqlDBService = new SqlDBService();
            mongoDBService = new MongoDBService();
        }

        public bool SaveData(List<string> userData)
        {
            sqlDBService.Save(userData[0]);
            mongoDBService.Save(userData[1]);

            return true;
        }
    }
}
