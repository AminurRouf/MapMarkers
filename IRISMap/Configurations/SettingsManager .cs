using Calabonga.Configurations;

namespace IRISMap.Configurations
{
    public class SettingsManager : Configuration<ApplicationSettings>
    {
        public SettingsManager(IConfigSerializer serializer, ICacheService cacheService) 
            : base(serializer, cacheService)
        {
        }

        public override string FileName
        {
            get { return "appsettings.json"; }
        } 
    }
}