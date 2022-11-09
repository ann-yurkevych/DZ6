namespace SereliazationHomework
{
    internal class PublishingHouse
    {
        public int Id { get; }
        public string Name { get; }
        public string Adress { get; }

        public PublishingHouse(int Id, string Name, string Adress)
        {
            if (string.IsNullOrEmpty(Name))
            {
                throw new ArgumentException($"'{nameof(Name)}' cannot be null or empty.", nameof(Name));
            }

            if (string.IsNullOrEmpty(Adress))
            {
                throw new ArgumentException($"'{nameof(Adress)}' cannot be null or empty.", nameof(Adress));
            }

            this.Id = Id;
            this.Name = Name;
            this.Adress = Adress;
        }

        public override string? ToString()
        {
            return "Id:" + Id + " Name:" + Name + " Adress:" + Adress;
        }
    }
}
