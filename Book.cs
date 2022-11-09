using System.Text.Json;
using System.Text.Json.Serialization;

namespace SereliazationHomework
{
    internal class Book
    {
        [JsonIgnore]
        public int PublishingHouseId { get; }

        [JsonPropertyName("Title")]
        public string Name { get; }

        public PublishingHouse PublishingHouse { get; }

        public Book(string name, PublishingHouse publishingHouse)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException($"'{nameof(name)}' cannot be null or empty.", nameof(name));
            }
            this.PublishingHouse = publishingHouse ?? throw new ArgumentNullException(nameof(publishingHouse));
            this.Name = name;
            this.PublishingHouseId = publishingHouse.Id;
        }

        public override string? ToString()
        {
            return "{\nPublishingHouseId:" + PublishingHouseId + "\nTitle:" + Name + "\nPublishingHouse:" + PublishingHouse.ToString() + "\n}";
        }
    }
}
