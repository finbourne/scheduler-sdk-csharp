/*
 * FINBOURNE Scheduler API
 *
 * Contact: info@finbourne.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.Extensions.Configuration;

namespace Finbourne.Scheduler.Sdk.Extensions
{
    /// <summary>
    /// Configuration for the ClientCredentialsFlowTokenProvider, usually sourced from a "secrets.json" file
    /// </summary>
    public class ApiConfiguration
    {
        /// <summary>
        /// Url for the token provider
        /// </summary>
        public string TokenUrl { get; set; }

        /// <summary>
        /// Username
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Password
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// OAuth2 Client ID
        /// </summary>
        public string ClientId { get; set; }

        /// <summary>
        /// OAuth2 Client Secret
        /// </summary>
        public string ClientSecret { get;  set; }

        /// <summary>
        /// Api Url
        /// </summary>
        [ConfigurationKeyName("schedulerUrl")]
        public string BaseUrl { get; set; }

        /// <summary>
        /// Snake Case Api Url
        /// </summary>
        [ConfigurationKeyName("finbourne_schedulerUrl")]
        public string SnakeCaseBaseUrl { get; set; }

        /// <summary>
        /// Lower Case Api Url
        /// </summary>
        [ConfigurationKeyName("finbourne-schedulerUrl")]
        public string LowerCaseBaseUrl { get; set; }

        /// <summary>
        /// Client Application name
        /// </summary>
        public string ApplicationName { get; set; }
        
        /// <summary>
        /// Configurable via FBN_ACCESS_TOKEN env variable - get the value from LUSID web 'Your Profile'->'Personal access tokens'.
        /// Takes precedence over other authentication factors if set.
        /// </summary>
        [ConfigurationKeyName("accessToken")]
        public string PersonalAccessToken { get; set; }
        
        /// <summary>
        /// Exists for backwards compatibility - please use PersonalAccessToken instead (field name 'accessToken' in config)
        /// </summary>
        [ConfigurationKeyName("personalAccessToken")]
        public string AccessTokenOldName { get; set; }
        
        /// <summary>
        /// The client timeout in milliseconds. If left unset the default timeout will be used
        /// </summary>
        public int? TimeoutMs { get; set; }
        
        /// <summary>
        /// The number of retries when being rate limited. If left unset the default number of rate limit retries will be used
        /// </summary>
        public int? RateLimitRetries { get; set; }

        internal bool MissingPersonalAccessTokenVariables =>
            (string.IsNullOrWhiteSpace(PersonalAccessToken) && string.IsNullOrWhiteSpace(AccessTokenOldName)) ||
            (string.IsNullOrWhiteSpace(BaseUrl) && string.IsNullOrWhiteSpace(SnakeCaseBaseUrl) && string.IsNullOrWhiteSpace(LowerCaseBaseUrl));

        internal bool MissingSecretVariables =>
            string.IsNullOrWhiteSpace(TokenUrl) ||
            string.IsNullOrWhiteSpace(Username) ||
            string.IsNullOrWhiteSpace(Password) ||
            string.IsNullOrWhiteSpace(ClientId) ||
            string.IsNullOrWhiteSpace(ClientSecret) ||
            (string.IsNullOrWhiteSpace(BaseUrl) && string.IsNullOrWhiteSpace(SnakeCaseBaseUrl) && string.IsNullOrWhiteSpace(LowerCaseBaseUrl)) ;

        /// <summary>
        /// Checks if any of the required configuration values are missing
        /// </summary>
        /// <returns>true if there is any configuration details missing, call <see cref="GetMissingConfig"/> to obtain details of the missing configuration details</returns>
        public bool HasMissingConfig()
        {
            return MissingPersonalAccessTokenVariables && MissingSecretVariables;
        }

        /// <summary>
        /// Returns a list of the missing required configuration values
        /// </summary>
        /// <returns>List of missing configuration values or empty list if all configuration values are present</returns>
        public List<string> GetMissingConfig()
        {
            var missingConfig = new List<string>();

            if (!string.IsNullOrWhiteSpace(PersonalAccessToken) || !string.IsNullOrWhiteSpace(AccessTokenOldName))
            {
                if (MissingPersonalAccessTokenVariables)
                {
                    missingConfig.Add(nameof(BaseUrl));
                }
                return missingConfig; // in case PAC is to be used we don't care about the other properties
            }

            if (string.IsNullOrWhiteSpace(TokenUrl))
            {
                missingConfig.Add(nameof(TokenUrl));
            }

            if (string.IsNullOrWhiteSpace(Username))
            {
                missingConfig.Add(nameof(Username));
            }

            if (string.IsNullOrWhiteSpace(Password))
            {
                missingConfig.Add(nameof(Password));
            }

            if (string.IsNullOrWhiteSpace(ClientId))
            {
                missingConfig.Add(nameof(ClientId));
            }

            if (string.IsNullOrWhiteSpace(ClientSecret))
            {
                missingConfig.Add(nameof(ClientSecret));
            }

            if(string.IsNullOrWhiteSpace(BaseUrl) && string.IsNullOrWhiteSpace(SnakeCaseBaseUrl) && string.IsNullOrWhiteSpace(LowerCaseBaseUrl))
            {
                PropertyInfo propertyInfo = typeof(ApiConfiguration).GetProperty(nameof(BaseUrl));
                var attribute = (ConfigurationKeyNameAttribute)Attribute.GetCustomAttribute(propertyInfo!, typeof(ConfigurationKeyNameAttribute));

                missingConfig.Add(attribute!.Name);
            }
            
            return missingConfig;
        }  
    }
}