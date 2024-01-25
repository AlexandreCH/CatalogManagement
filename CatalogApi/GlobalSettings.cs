namespace CatalogApi;
public class GlobalSetting
{
    public const string DbName = "CatalogDv.v1.db";
    public const string RelativePath = "Infrastucture/Data";

    public GlobalSetting()
    {
        
    }

    public static GlobalSetting Instance { get; } = new GlobalSetting();

}
