using Abp.Application.Services;
using Abp.Application.Services.Dto;
using System.Text.Json;
using SovTech.Authorization.Users;
using SovTech.Main.Dto;
using SovTech.Users.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SovTech.Main
{
    public class CategoriesAppService : SovTechAppServiceBase, ICategoriesAppService
    {
        public async Task<ListResultDto<string>> GetAllCategories()
        {
            try
            {
                var client = new HttpClient();
                //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var response = await client.GetAsync("https://api.chucknorris.io/jokes/categories");
                List<string> categories = new List<string>();

                if (response.IsSuccessStatusCode)
                {
                    var contents = response.Content.ReadAsStringAsync().Result.ToString();
                    categories = (List<string>)JsonSerializer.Deserialize<IList<string>>(contents);
                }
               
                return new ListResultDto<string>(categories);
            }
            catch (Exception e)
            {

                throw;
            } 
        }

        public async Task<string> GetAllCategoriesDetails(InputDto input)
        {
            try
            {
                var client = new HttpClient();
                var url = "https://api.chucknorris.io/jokes/random?category=" + input.filterText;
                var response = await client.GetAsync(url);
                var joke = "";

                if (response.IsSuccessStatusCode)
                {
                    var contents = response.Content.ReadAsStringAsync().Result.ToString();
                    var data = JsonSerializer.Deserialize<JokeDto>(contents);
                    joke = data.value;
                }

                return joke;
            }
            catch (Exception e)
            {

                throw;
            }
        }

        public async Task<ListResultDto<PeopleDto>> GetPeople(InputDto input)
        {
            try
            {
                var client = new HttpClient();
                var url = "https://swapi.dev/api/people/";

                if (input.filterText != null)
                {
                   url = "https://swapi.dev/api/people/?search=" + input.filterText;
                }
              
                var response = await client.GetAsync(url);
                List<PeopleDto> people = new List<PeopleDto>();
              

                if (response.IsSuccessStatusCode)
                {
                    var contents = response.Content.ReadAsStringAsync().Result.ToString();
                    var data = JsonSerializer.Deserialize<templateResponse>(contents);
                    people = (List<PeopleDto>)data.results;
                }

                return new ListResultDto<PeopleDto>(people);
            }
            catch (Exception e)
            {

                throw;
            }
        }

        public async Task<OutputData> search(InputDto input)
        {
            try
            {
                var client = new HttpClient();
                var url = "https://api.chucknorris.io/jokes/search?query=" + input.filterText;

                var response = await client.GetAsync(url);
                OutputData output = new OutputData();

                if (response.IsSuccessStatusCode)
                {
                    var contents = response.Content.ReadAsStringAsync().Result.ToString();
                    var data = JsonSerializer.Deserialize<templeteObject>(contents);
                    if(data.result.Count > 0)
                    {
                        output.Jokes = data.result.Select(x => x.value).ToList();
                    }
     
                }

                var peopleList = await GetPeople(input);
                if (peopleList.Items.Count > 0)
                    output.people = (List<PeopleDto>)peopleList.Items;

                return output;
            }
            catch (Exception e)
            {

                throw;
            }
        }
    }
}
