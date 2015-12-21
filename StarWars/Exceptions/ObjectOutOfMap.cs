namespace StarWars.Exceptions
{
    using System;
    public class ObjectOutOfMap : Exception
    {
        public ObjectOutOfMap(string massage) : base(massage)
        {

        }
    }
}
