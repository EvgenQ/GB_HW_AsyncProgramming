namespace HomeWork_1
{
    internal class Program
    {
        private static readonly CancellationTokenSource cts = new CancellationTokenSource();
        private static readonly HttpClient _httpClient = new HttpClient();
        static string GetPosts()
        {
            string content = string.Empty;

            for (int i = 4; i <= 14; i++)
            {
                var response = _httpClient.GetAsync($"https://jsonplaceholder.typicode.com/posts/{i}");
                // Если число превышает допустимое количество {id} постов
                if (response.Result.Content.ReadAsStringAsync().Result == "{}")
                {
                    return content;
                }
                else
                {
                    content += $"\n{response.Result.Content.ReadAsStringAsync().Result}\n";
                }
            }

            return content;
        }
        static async Task<string> GetPostsAsync()
        {
            string result = string.Empty;

            Console.WriteLine("Continue GetPostsAsync\n");

            result = await Task.Run(() => GetPosts());

            using (StreamWriter file = new StreamWriter($"{Directory.GetCurrentDirectory()}\\info.txt"))
            {
                file.WriteLine(result);

                Console.WriteLine($"Информация записана в файл.\nПо адресу: {Directory.GetCurrentDirectory()}\\info.txt\n");
            }
            Console.WriteLine("End GetPostsAsync\n");
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Begin Main\n");
            Console.WriteLine("Begin GetPostsAsync\n");
            var content = GetPostsAsync();
            Console.WriteLine("Continue Main\n");
            Console.WriteLine(content.Result);
            Console.WriteLine("End Main");
            Console.ReadLine();

        }
    }
}