using System;
using AfsTranslator.src.Repositories.Models;
using System.Text;
using System.Text.Json;
using AfsTranslator.src.Repositories.Dtos;
using System.Net.Http;

namespace AfsTranslator.src.Utils
{
	public static class Translate
	{

        public static async Task<TranslationLogDto?> GetExternalTranslatorAsync(string _text)
        {

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://api.funtranslations.com/translate/");

                    var translationData = new Translation
                    {
                        text = _text
                    };

                    var json = JsonSerializer.Serialize(translationData);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    var response = await client.PostAsync("yoda", content);

              
                    if (response.IsSuccessStatusCode)
                    {
                        var responseContent = await response.Content.ReadAsStringAsync();
                        var apiResponse = JsonSerializer.Deserialize<TranslationApiResponse>(responseContent, options);
                        if(apiResponse != null && apiResponse.Contents != null)
                        {
                            var translationLogDto = new TranslationLogDto
                            {
                                OriginalText = apiResponse.Contents.Text,
                                TranslatedText = apiResponse.Contents.Translated,
                                Translation = apiResponse.Contents.Translation,
                                Timestamp = DateTime.Now
                            };
                            return translationLogDto;
                        } else
                        {
                            Console.WriteLine("API Response is null");
                            return null;
                        }
                    }
                    else
                    {
                        Console.WriteLine("API Error Status Code: " + response.StatusCode);
                        Console.WriteLine("API Error Content: " + await response.Content.ReadAsStringAsync());

                        throw new HttpRequestException("API call was not successful.");
                    }
                }
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine("HTTP Request Error: " + ex.Message);
                throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred: " + ex.Message);
                throw;
            }
        }

    }
}

