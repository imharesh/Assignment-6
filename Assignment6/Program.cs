using System;
using System.Net;
using System.Threading.Tasks;
class Program
{
    // main method - Asynchronous
    static async Task Main(string[] args)
    {
       // input from user 
         Console.Write("Enter URL : ");
         string url = Console.ReadLine();

        // create the  http request and response
        using (HttpClient client = new HttpClient())
          { 
            // using GetAsync - for get request 
            HttpResponseMessage response = await client.GetAsync(url);
            // using ReadAsStringAsync - read the content
            string responseText = await response.Content.ReadAsStringAsync();

         
            Console.WriteLine("Downloaded and saved to A.txt.");
            // write the data in file 
            File.WriteAllText("A.txt", responseText);
            
          }
    }
}

