using testproject.Debugging;

namespace testproject
{
    public class testprojectConsts
    {
        public const string LocalizationSourceName = "testproject";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "8dbb781e981147be974f7307c393a78d";
    }
}
