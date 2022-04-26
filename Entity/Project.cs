namespace CreateFolder.Entity;

public class Project
{
    public string ID { get; set;  }
    
    public string Title { get; set; }
    
    public string Description { get; set; }

    public List<File> file { get; set; } = new();
}