using TrainingAngular.Debugging;

namespace TrainingAngular
{
    public class TrainingAngularConsts
    {
        public const string LocalizationSourceName = "TrainingAngular";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "7db69a3d699146ca9b6fb3a9cbd9c910";
    }
}
