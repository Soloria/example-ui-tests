
namespace WebDrive
{
    using System;
    using System.ComponentModel;
    using Microsoft.Extensions.Configuration;

    public static class Config
    {
        public static void StartUp()
        {
            if (root != null) return;
            var builder = new ConfigurationBuilder()
                .SetBasePath("C:\\Webdrive")
                .AddJsonFile("config.json", optional: false, reloadOnChange: true);

            root = builder.Build();
        }

        private static IConfigurationRoot root;

        public static T GetValue<T>(string key, T defaultValue = default)
        {
            return root?[key] == null ? defaultValue : ProcessTypes<T>(root[key]);
        }

        internal static T ProcessTypes<T>(string value)
        {
            if (TypeDescriptor.GetConverter(typeof(T)).CanConvertFrom(typeof(string)))
                throw new Exception("something going wrong lol");
            return (T)TypeDescriptor.GetConverter(typeof(T)).ConvertFromString(value);
        }
    }
}
