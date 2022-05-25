using Microsoft.AspNetCore.Mvc;
namespace ViewComponents.ViewComponents
{
    public class WeatherSummary : ViewComponent
    {
        public string Invoke()
        {
            string data = "this is weather informatoin";
            return data;
        }
    }
}

//Bootstrap
//Controller
//Taghelpers
//Seciton
//RazorView
//Layout
//Partial Views