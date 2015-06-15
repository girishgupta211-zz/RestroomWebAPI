using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using RestroomLocator.BO;
using RestroomLocator.Model;
using RestRoom = RestroomLocator.BO.RestRoom;

namespace RestroomLocator.BLL
{
    public class Public
    {
        public static List<RestRoom> FetchAllRestrooms()
        {
            try
            {
                using (var context = new RestroomLocatorEntities())
                {
                    var restroomInfoList = new List<RestRoom>();
                    var restroomList = context.RestRooms.ToList();
                    foreach (var restRoom in restroomList)
                    {
                        var a = new RestRoom();

                        a.Name = restRoom.Name;
                        a.Address = restRoom.Address;
                        a.Category = restRoom.Category;
                        a.City = restRoom.City;
                        a.Cost = restRoom.Cost;
                        a.Description = restRoom.Description;
                        a.Lattitude = restRoom.Lattitude;
                        a.Longitude = restRoom.Longitude;
                        a.Image = restRoom.Image;
                        a.LastChgDate = restRoom.LastChgDate;
                        a.LastChgUser = restRoom.LastChgUser;
                        restroomInfoList.Add(a);
                    }
                    return restroomInfoList;
                }


                //    }

                //foreach (var usersRating in userRating)
                //                {
                //                    //var restRoom = context.RestRoom.FirstOrDefault(a => a.RestRoomId == usersRating.RestRoomId);
                //                    var restRoom = context.RestRoom.ToList();

                //                //    if (restRoom != null)
                //                //    {
                //                //        var restroomInfo = new RestRoomInfo
                //                //        {                                
                //                //            Name = restRoom.Name,
                //                //            Address = restRoom.Address,
                //                //            Category = restRoom.Category,
                //                //            City = restRoom.City,                                
                //                //            Cost = restRoom.Cost,
                //                //            Description = restRoom.Description,
                //                //            Lattitude = restRoom.Lattitude,
                //                //            Longitude = restRoom.Longitude,
                //                //            Image = restRoom.Image,                                
                //                //            LastChgDate = restRoom.LastChgDate,
                //                //            LastChgUser = restRoom.LastChgUser,
                //                //            CleannessRating = usersRating.CleannessRating,
                //                //            PrivacyRating = usersRating.PrivacyRating

                //                //        };
                //                //        restroomInfoList.Add(restroomInfo);
                //                //    }
                //                //}
                //                return restroomInfoList;
                //            }                   
                //        }
                //        catch (Exception)
                //        {
                //            return new List<RestRoomInfo>();                
                //        }
                //    }

                //public static List<RestRoomInfo> FetchNearbyRestrooms(int distance , string lattitude , string longitude)
                //{
                //    try
                //    {
                //        return new List<RestRoomInfo>();
                //    }
                //    catch (Exception)
                //    {
                //        return new List<RestRoomInfo>();
                //    }
                //}
            }
            catch (Exception)
            {
                return new List<RestRoom>();
            }
        }


    }
}
