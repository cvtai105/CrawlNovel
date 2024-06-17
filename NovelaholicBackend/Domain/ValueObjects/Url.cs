using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.ValueObjects
{
    public class Url
    {
        public string Value { get; private set; } = string.Empty;
        public Url(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Url cannot be empty");
            }
            Value = value;
        }

        public async Task<string> ExtractDataAsync()
        {
            using HttpClient client = new();
            try
            {
                HttpResponseMessage response = await client.GetAsync(Value);
                response.EnsureSuccessStatusCode();
                string responseData = await response.Content.ReadAsStringAsync();
                return responseData;
            }
            catch (HttpRequestException e)
            {
                throw new InvalidOperationException("Error fetching data from the URL", e);
            }
        }
    }
}