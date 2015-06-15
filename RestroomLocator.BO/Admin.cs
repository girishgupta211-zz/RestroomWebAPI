using System;

namespace RestroomLocator.BO
{

    public class RestRoomInfo : RestRoom
    {
        public short? CleannessRating { get; set; }
        public short? PrivacyRating { get; set; }
    }

    public class RestRoom
    {
        public long RestRoomId { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string Lattitude { get; set; }
        public string Longitude { get; set; }
        public string Cost { get; set; }
        public string Category { get; set; }
        public string WhoCanAccess { get; set; }
        public string Timings { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; }
        public string Image { get; set; }
        public string LastChgUser { get; set; }
        public DateTime? LastChgDate { get; set; }
    }


    public class UserRating
    {
        public long UserRaingId { get; set; }
        public long RestRoomId { get; set; }
        public string UserName { get; set; }
        public short? CleannessRating { get; set; }
        public short? PrivacyRating { get; set; }
        public string Comment { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? LastChgDate { get; set; }
    }

    public enum Category
    {
        Male = 1,
        Female = 2,
        Handicapped = 3,
        ChildChangeRoom = 4        
    }


}

