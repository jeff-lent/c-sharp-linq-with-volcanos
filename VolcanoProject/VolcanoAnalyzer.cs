using System.Text.Json;

namespace VolcanoProject;

public class VolcanoAnalyzer
{
    private List<Volcano>? volcanos;

    public void loadVolcanoes(string pathOpt = "volcano.json")
    {
        try
        {
            using (StreamReader r = new StreamReader(pathOpt))
            {
                string json = r.ReadToEnd();
                volcanos = JsonSerializer.Deserialize<List<Volcano>>(json);
            }
        }
        catch(Exception)
        {
            throw;
        }
    }

    public int numVolcanoes()
    {
        if(volcanos is not null)
        {
            return volcanos.Count;
        }
        return 0;
    }
    //add methods here to meet the requirements in README.md
}