using System.Runtime.Serialization.Formatters.Binary;

namespace DemoCanalDotNetDesignPatterns
{
    [Serializable]
    public class CustomerWithPrototype : ICloneable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }

        public Address Address { get; set; } = new Address();

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        #region Clone V2
        //public object Clone()
        //{
        //    using (var memoryStream = new MemoryStream())
        //    {
        //        var binaryFormatter = new BinaryFormatter();
        //        binaryFormatter.Serialize(memoryStream, this);
        //        memoryStream.Position = 0;

        //        return (CustomerWithPrototype)binaryFormatter.Deserialize(memoryStream);
        //    }
        //}

        #endregion
    }
}
