using Testings.Extensions;

namespace Testings;

public class PlatformsTree
{
    private readonly LRUCache<string, HashSet<string>> _cache = new();
    private Dictionary<string, Node> Heads { get; set; } = [];

    public void AddElement(string advertisingPlatform, string[] locations)
    {
        foreach (var location in locations)
        {
            var index = 0;
            var segments = location.GetSegments();       
            var key = segments[index++];

            var node = Heads.GetAndCreateIfNotExistNode(key);
            node.AddElement(
                advertisingPlatform,
                segments,
                index);
        }
    }

    public HashSet<string> GetElements(string location)
    {
        if (_cache.TryGetValue(location, out var cachedResult))
            return cachedResult;

        var result = new HashSet<string>();
        var index = 0;

        var segments = location.GetSegments();
        var key = segments[index];

        if (Heads.TryGetValue(key, out var node))
            node.GetElements(segments, result, index + 1);

        _cache.Add(location, result);

        return result;
    }
}