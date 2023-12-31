using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace LoginApp.Models;

public class PreUser 
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }
    public required string Username { get; set; }
    public required string Email { get; set; }
    [BsonElement("Password")]
    public required string PasswordHash { get; set; }
    public int Token { get; set; } = new Random().Next(1000, 9000);
}