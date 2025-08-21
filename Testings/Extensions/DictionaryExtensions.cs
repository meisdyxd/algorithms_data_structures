namespace Testings.Extensions;

public static class DictionaryExtensions
{
    public static Node GetAndCreateIfNotExistNode(
        this Dictionary<string, Node> dictionary, 
        string key)
    {
        if (!dictionary.TryGetValue(key, out var node))
        {
            node = new Node();
            dictionary[key] = node;
        }
        return node;
    }
}
