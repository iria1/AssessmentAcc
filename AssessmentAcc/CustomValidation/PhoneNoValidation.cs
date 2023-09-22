using Microsoft.Extensions.Configuration;
using System;
using System.ComponentModel.DataAnnotations;
using System.IO;
using RestSharp;
using Newtonsoft.Json;

namespace AssessmentAcc.CustomValidation
{
    public class PhoneNoValidation
    {
        public bool valid { get; set; }

        public string number { get; set; }

        public string local_format { get; set; }

        public string international_format { get; set; }

        public string country_prefix { get; set; }

        public string country_code { get; set; }

        public string country_name { get; set; }

        public string location { get; set; }

        public string carrier { get; set; }

        public string line_type { get; set; }
    }

    public class CustomPhoneNoValidation : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            try
            {
                var foo = AppSettings.Current;

                var url = foo.ApiUrl;
                var key = foo.ApiKey;
                var phoneNo = Convert.ToString(value);

                if (phoneNo.StartsWith("+62"))
                {
                    phoneNo = phoneNo.Remove(0, 3);
                }
                else if (phoneNo.StartsWith("0"))
                {
                    phoneNo = phoneNo.Remove(0, 1);
                }

                var options = new RestClientOptions(url);

                var client = new RestClient(options);

                var request = new RestRequest()
                    .AddParameter("access_key", key)
                    .AddParameter("number", phoneNo)
                    .AddParameter("country_code", "ID")
                    .AddParameter("format", 1);

                var response = client.Get(request);

                var bar = response.Content;

                var sna = JsonConvert.DeserializeObject<PhoneNoValidation>(bar);

                return sna.valid;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }

    public class AppSettings
    {
        private static AppSettings _appSettings;

        public string ApiUrl { get; set; }
        public string ApiKey { get; set; }


        public AppSettings(IConfiguration config)
        {
            this.ApiUrl = config.GetSection("PhoneNoValidator").GetValue<string>("ApiUrl");
            this.ApiKey = config.GetSection("PhoneNoValidator").GetValue<string>("ApiKey");

            // Now set Current
            _appSettings = this;
        }

        public static AppSettings Current
        {
            get
            {
                if (_appSettings == null)
                {
                    _appSettings = GetCurrentSettings();
                }

                return _appSettings;
            }
        }

        public static AppSettings GetCurrentSettings()
        {
            var builder = new ConfigurationBuilder()
                            .SetBasePath(Directory.GetCurrentDirectory())
                            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                            .AddEnvironmentVariables();

            IConfigurationRoot configuration = builder.Build();

            var settings = new AppSettings(configuration);

            return settings;
        }
    }
}
