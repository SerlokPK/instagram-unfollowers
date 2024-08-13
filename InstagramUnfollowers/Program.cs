// See https://aka.ms/new-console-template for more information
using InstagramUnfollowers.Models;
using Newtonsoft.Json;

Console.WriteLine("Reading files!");

var following = DeserializeJsonFile<Root>("<PATH>");
var followers = DeserializeJsonFile<List<RelationshipFollowing>>(@"<PATH>");

var followerNames = followers
    .SelectMany(x => x.StringListData)
    .Select(y => y.Value)
    .ToHashSet();

var followingNames = following.RelationshipsFollowing
    .SelectMany(x => x.StringListData)
    .Select(x => x.Value)
    .ToHashSet();

var commonNames = followerNames
    .Intersect(followingNames)
    .ToList();
var notFollowingNames = followerNames
    .Except(followingNames)
    .ToList();

Console.WriteLine($"Not followed by {notFollowingNames.Count} people");

T DeserializeJsonFile<T>(string path)
{
    var json = File.ReadAllText(path);

    return JsonConvert.DeserializeObject<T>(json);
}