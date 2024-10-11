// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json.Linq;

var followingText = DeserializeJsonFile(@"C:\Users\StrahinjaŠerbula\Downloads\instagram-serlokin-2024-09-27-2rbowS70\connections\followers_and_following\following.json");
var followersText = DeserializeJsonFile(@"C:\Users\StrahinjaŠerbula\Downloads\instagram-serlokin-2024-09-27-2rbowS70\connections\followers_and_following\followers_1.json");

var followers = JArray.Parse(followersText);
var following = JObject.Parse(followingText)["relationships_following"] as JArray;

// Extract the usernames from both files
var followerUsernames = ExtractNames(followers);
var followingUsernames = ExtractNames(following);

var notFollowingBack = followingUsernames.Except(followerUsernames).ToList();

if (notFollowingBack.Count == 0)
{
    Console.WriteLine("Everyone you follow is following you back.");
    return;
}

Console.WriteLine("Users you follow, but who are not following you back:");
foreach (var user in notFollowingBack)
{
    Console.WriteLine(user);
}

List<string> ExtractNames(JArray names)
{
    return names.Select(f => f["string_list_data"][0]["value"].ToString()).ToList();
}

string DeserializeJsonFile(string path)
{
    var json = File.ReadAllText(path);

    return json;
}