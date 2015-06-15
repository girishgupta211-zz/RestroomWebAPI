using System;
using System.Linq;
using RestroomLocator.Model;
using RestRoom = RestroomLocator.BO.RestRoom;


namespace RestroomLocator.BLL
{
    public static class Admin
    {
        public static bool AddRestroomDetails(RestRoom restroom)
        {
            try
            {
                using (var context = new RestroomLocatorEntities())
                {
                    var name = context.RestRooms.FirstOrDefault(room => room.Name == restroom.Name && room.Address == restroom.Address);
                    // If this restroom already exist then exit.
                    if (name != null)
                    {
                        return false;
                    }

                    var obj = new Model.RestRoom
                    {
                        Name = restroom.Name,
                        Address = restroom.Address,
                        Lattitude = restroom.Lattitude,
                        Longitude = restroom.Longitude,
                        Category = restroom.Category,
                        WhoCanAccess = restroom.WhoCanAccess,
                        Description = restroom.Description,
                        Timings = restroom.Timings,
                        LastChgDate = DateTime.UtcNow,
                        LastChgUser = "GGUPTA",
                        IsDeleted = false,
                    };
                    context.RestRooms.AddObject(obj);
                    context.SaveChanges();
                    return true;
                }

            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool DeleteRestroomById(int restroomId)
        {
            try
            {
                using (var context = new RestroomLocatorEntities())
                {
                    var restRoom = context.RestRooms.FirstOrDefault(a => a.RestRoomId == restroomId);
                    if (restRoom != null)
                    {
                        restRoom.IsDeleted = true;
                        context.SaveChanges();
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }


        public static bool EditRestroom(BO.RestRoom obj)
        {
            try
            {
                using (var context = new RestroomLocatorEntities())
                {
                    var restRoom = context.RestRooms.FirstOrDefault(a => a.RestRoomId == obj.RestRoomId);
                    if (restRoom != null)
                    {
                        restRoom.Name = obj.Name;
                        restRoom.City = obj.City;
                        restRoom.Address = obj.Address;
                        restRoom.Lattitude = obj.Lattitude;
                        restRoom.Longitude = obj.Longitude;
                        restRoom.Cost = obj.Cost;
                        restRoom.Timings = obj.Timings;
                        restRoom.Image = obj.Image;
                        restRoom.Category = obj.Category;
                        restRoom.WhoCanAccess = obj.WhoCanAccess;
                        restRoom.Description = obj.Description;
                        restRoom.LastChgDate = DateTime.UtcNow;
                        restRoom.LastChgUser = "GGUPTA";
                    }
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}
