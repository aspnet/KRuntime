// <auto-generated />
namespace NuGet.Packaging
{
    using System.Globalization;
    using System.Reflection;
    using System.Resources;

    internal static class Strings
    {
        private static readonly ResourceManager _resourceManager
            = new ResourceManager("NuGet.Packaging.Strings", typeof(Strings).GetTypeInfo().Assembly);

        /// <summary>
        /// Nuspec file does not exist in package '{0}'
        /// </summary>
        internal static string MissingNuspec
        {
            get { return GetString("MissingNuspec"); }
        }

        /// <summary>
        /// Nuspec file does not exist in package '{0}'
        /// </summary>
        internal static string FormatMissingNuspec(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("MissingNuspec"), p0);
        }

        /// <summary>
        /// Package stream should be seekable
        /// </summary>
        internal static string PackageStreamShouldBeSeekable
        {
            get { return GetString("PackageStreamShouldBeSeekable"); }
        }

        /// <summary>
        /// Package stream should be seekable
        /// </summary>
        internal static string FormatPackageStreamShouldBeSeekable()
        {
            return GetString("PackageStreamShouldBeSeekable");
        }

        /// <summary>
        /// String argument '{0}' cannot be null or empty
        /// </summary>
        internal static string StringCannotBeNullOrEmpty
        {
            get { return GetString("StringCannotBeNullOrEmpty"); }
        }

        /// <summary>
        /// String argument '{0}' cannot be null or empty
        /// </summary>
        internal static string FormatStringCannotBeNullOrEmpty(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("StringCannotBeNullOrEmpty"), p0);
        }

        private static string GetString(string name, params string[] formatterNames)
        {
            var value = _resourceManager.GetString(name);

            System.Diagnostics.Debug.Assert(value != null);

            if (formatterNames != null)
            {
                for (var i = 0; i < formatterNames.Length; i++)
                {
                    value = value.Replace("{" + formatterNames[i] + "}", "{" + i + "}");
                }
            }

            return value;
        }
    }
}
