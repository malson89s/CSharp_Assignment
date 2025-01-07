using System.Text.Json;

namespace Business.Services;

public class FileService
{
    private readonly string _directoryPath;
    private readonly string _filePath;


    public FileService(string directoryPath = "Data", string fileName = "list.json")
    {
        _directoryPath = directoryPath;
        _filePath = Path.Combine(_directoryPath, fileName);
    }

    //Sparar till fil
    public void SaveContentToFile(string content)
    {
        if (!string.IsNullOrEmpty(content))
        {
            if (!Directory.Exists(_directoryPath))
                Directory.CreateDirectory(_directoryPath);

            File.WriteAllText(_filePath, content);
        }
    }


    //Hämtar från fil
    public string? GetContentFromFile()
    {
        if (File.Exists(_filePath))
            return File.ReadAllText(_filePath);

        return null;
    }
}
