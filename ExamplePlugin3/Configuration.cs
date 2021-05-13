using Rocket.API;

namespace SolokLibrary.ExamplePlugin3
{
    public class Configuration : IRocketPluginConfiguration
    {
        public string DatabaseAddress;
        public string DatabaseName;
        public string DatabasePassword;
        public uint DatabasePort;
        public string DatabaseTableName;
        public string DatabaseUsername;
        public string DatabaseCreateTableQuery;
        public void LoadDefaults()
        {
            DatabaseAddress = "127.0.0.1";
            DatabaseUsername = "root";
            DatabasePassword = "123456";
            DatabaseName = "unturned";
            DatabaseTableName = "exampleplugin3";
            DatabasePort = 3306;
            DatabaseCreateTableQuery = "`SteamID` VARCHAR(32) NOT NULL DEFAULT '0', `CharacterName` VARCHAR(50) NOT NULL DEFAULT 'NoName'," +
                                       " `LastUpdated` TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP," +
                                       " PRIMARY KEY (`SteamID`)";
        }
    }
}