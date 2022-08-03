using SovTech.Debugging;

namespace SovTech
{
    public class SovTechConsts
    {
        public const string LocalizationSourceName = "SovTech";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "3b0a87bfdc714c589c035bf47e1d0b36";
    }
}
