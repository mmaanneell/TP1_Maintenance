using Microsoft.Extensions.Configuration;

namespace Managers
{
    public static class JSONConfigurationManager
    {
        public static GradeSettings GradeSettings { get; private set; }
        public static SalarySettings SalarySettings { get; private set; }

        public static void Initialize()
        {
            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: false)
                .AddEnvironmentVariables(prefix: "APP_")
                .Build();


            var settings = new GradeSettings();
            config.GetSection("GradeSettings").Bind(settings);
            GradeSettings = settings;


            var salarySettings = new SalarySettings();
            config.GetSection("Salaries").Bind(salarySettings);
            SalarySettings = salarySettings;
        }
    }
}
