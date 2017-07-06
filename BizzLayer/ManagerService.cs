using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BizzLayer
{
    public static class ManagerService
    {
        public static IQueryable<Client> GetClients(Client searchCrit)
        {
            try
            {
                CarWorkshopModelContext dc = new CarWorkshopModelContext();
                var result = from el in dc.Client
                             where
                             (String.IsNullOrEmpty(searchCrit.name) || el.name.Contains(searchCrit.name))
							 &&
                             (String.IsNullOrEmpty(searchCrit.last_name) || el.last_name.Contains(searchCrit.last_name))
							 &&
                             (String.IsNullOrEmpty(searchCrit.first_name) || el.first_name.Contains(searchCrit.first_name))
							 &&
                             (String.IsNullOrEmpty(searchCrit.city) || el.city.Contains(searchCrit.city))
							 &&
                             (String.IsNullOrEmpty(searchCrit.flat) || el.flat.Contains(searchCrit.flat))
							 &&
                             (String.IsNullOrEmpty(searchCrit.home) || el.home.Contains(searchCrit.home))
							 &&
                             (String.IsNullOrEmpty(searchCrit.street) || el.street.Contains(searchCrit.street))
							 &&
							 (String.IsNullOrEmpty(searchCrit.country) || el.country.Contains(searchCrit.country))
							 ||
                             (el.id_client == searchCrit.id_client)
                             select el;
                return result;
            }
            catch (System.Data.Entity.Core.EntityException e)
            {
                throw new ServiceException("Database connection error!");
            }
        }

        public static void UpdateClient(Client client)
        {
            try
            {
                CarWorkshopModelContext dc = new CarWorkshopModelContext();
                var result = (from el in dc.Client
                              where
                              el.id_client == client.id_client
                              select el).SingleOrDefault();
                if(result==null)
                {
                    return;
                }
                result.name = client.name;
                result.first_name = client.first_name;
                result.last_name = client.last_name;
                result.home = client.home;
                result.city = client.city;
                result.flat = client.flat;
                result.street = client.street;
                result.PESEL_NIP = client.PESEL_NIP;
                result.country = client.country;
                dc.SaveChanges();
            }
            catch (System.Data.Entity.Core.EntityException e)
            {
                throw new ServiceException("Database connection error!");
            }
        }

        public static void DeleteClient(Client client)
        {
            try
            {
                CarWorkshopModelContext dc = new CarWorkshopModelContext();
                var res = (from el in dc.Client
                           where el.id_client == client.id_client
                           select el).SingleOrDefault();
                if (res == null)
                {
                    return;
                }
                dc.Client.Remove(res);
                dc.SaveChanges();
            }
            catch (System.Data.Entity.Core.EntityException e)
            {
                throw new ServiceException("Database connection error!");
            }
        }

        public static void NewClient(Client client)
        {
            try
            {
                CarWorkshopModelContext dc = new CarWorkshopModelContext();
                //var res = (from el in dc.Client
                  //         where el.username == personel.username
                    //       select el).SingleOrDefault();
                //if (res == null)
                //{
                    dc.Client.Add(client);
                    dc.SaveChanges();
                    return;
                //}
                //throw new ServiceException("Username already exists!");
            }
            catch (System.Data.Entity.Core.EntityException e)
            {
                throw new ServiceException("Database connection error!");
            }
        }

        public static IQueryable<DataLayer.Object> GetObjects(DataLayer.Object searchCrit)
        {
            try
            {
                CarWorkshopModelContext dc = new CarWorkshopModelContext();
                var result = from el in dc.Object
                             where
                             (String.IsNullOrEmpty(searchCrit.body_type) || el.body_type.StartsWith(searchCrit.body_type))	
							 &&
                             (String.IsNullOrEmpty(searchCrit.manufacturer) || el.manufacturer.StartsWith(searchCrit.manufacturer))
							 &&
                             (String.IsNullOrEmpty(searchCrit.model) || el.model.StartsWith(searchCrit.model))
							 &&
                             (String.IsNullOrEmpty(searchCrit.name) || el.name.StartsWith(searchCrit.name))
							 &&
                             (String.IsNullOrEmpty(searchCrit.other) || el.other.StartsWith(searchCrit.other))
							 &&
                             (String.IsNullOrEmpty(searchCrit.engine) || el.engine.StartsWith(searchCrit.engine))
                             &&
                             (String.IsNullOrEmpty(searchCrit.registration_number) || el.registration_number.StartsWith(searchCrit.registration_number))
                             &&
                             ((searchCrit.year == null) || (el.year == searchCrit.year))
							 &&
							 (searchCrit.id_client == 0)
							 &&
							 (searchCrit.id_object == 0)
							 ||
							 (el.id_client == searchCrit.id_client)
							 ||
							 (el.id_object == searchCrit.id_object)
							 select el;
                return result;
            }
            catch (System.Data.Entity.Core.EntityException e)
            {
                throw new ServiceException("Database connection error!");
            }
        }

        public static void UpdateObject(DataLayer.Object obj)
        {
            try
            {
                CarWorkshopModelContext dc = new CarWorkshopModelContext();
                var result = (from el in dc.Object
                              where
                              el.id_object == obj.id_object
                              select el).SingleOrDefault();
                if (result == null)
                {
                    return;
                }
                result.name = obj.name;
                result.body_type = obj.body_type;
                result.id_client = obj.id_client;
                result.manufacturer = obj.manufacturer;
                result.model = obj.model;
                result.other = obj.other;
                result.year = obj.year;
                result.engine = obj.engine;
                result.registration_number = obj.registration_number;
                dc.SaveChanges();
            }
            catch (System.Data.Entity.Core.EntityException e)
            {
                throw new ServiceException("Database connection error!");
            }
        }

        public static void DeleteObject(DataLayer.Object obj)
        {
            try
            {
                CarWorkshopModelContext dc = new CarWorkshopModelContext();
                var res = (from el in dc.Object
                           where el.id_object == obj.id_object
                           select el).SingleOrDefault();
                if (res == null)
                {
                    return;
                }
                dc.Object.Remove(res);
                dc.SaveChanges();
            }
            catch (System.Data.Entity.Core.EntityException e)
            {
                throw new ServiceException("Database connection error!");
            }
        }

        public static void NewObject(DataLayer.Object obj)
        {
            try
            {
                CarWorkshopModelContext dc = new CarWorkshopModelContext();
                var res = (from el in dc.Object
                           where el.registration_number == obj.registration_number
                           select el).SingleOrDefault();
                if (res == null)
                {
                    dc.Object.Add(obj);
                    dc.SaveChanges();
                    return;
                }
                throw new ServiceException("Object already exists!");
            }
            catch (System.Data.Entity.Core.EntityException e)
            {
                throw new ServiceException("Database connection error!");
            }
        }

        public static IQueryable<Request> GetRequests(Request searchCrit)
        {
            try
            {
                CarWorkshopModelContext dc = new CarWorkshopModelContext();
                var result = from el in dc.Request
                             where
                             (String.IsNullOrEmpty(searchCrit.description) || el.description.StartsWith(searchCrit.description))
							 &&
                             ((searchCrit.id_object == null) || (el.id_object == searchCrit.id_object))
                             &&
                             ((searchCrit.id_request == 0) || (el.id_request == searchCrit.id_request))
                             &&
                             ((searchCrit.id_personel == null) || (el.id_personel == searchCrit.id_personel))
							 &&
                             (String.IsNullOrEmpty(searchCrit.status) || el.status.StartsWith(searchCrit.status))
							 &&
                             (String.IsNullOrEmpty(searchCrit.result) || el.result.StartsWith(searchCrit.result))
							 &&
                             ((searchCrit.date_fin_cancel == null) || (el.date_fin_cancel == searchCrit.date_fin_cancel))
							 &&
                             ((searchCrit.date_request == null) || 
							 (
								 (el.date_request.Value.Year == searchCrit.date_request.Value.Year)
								 &&
								 (el.date_request.Value.Month == searchCrit.date_request.Value.Month)
								 &&
								 (el.date_request.Value.Day == searchCrit.date_request.Value.Day)
							 ))
							 
							 select el;
                return result;
            }
            catch (System.Data.Entity.Core.EntityException e)
            {
                throw new ServiceException("Database connection error!");
            }
        }

        public static void UpdateRequest(Request request)
        {
            try
            {
                CarWorkshopModelContext dc = new CarWorkshopModelContext();
                var result = (from el in dc.Request
                              where
                              el.id_request == request.id_request
                              select el).SingleOrDefault();
                if (result == null)
                {
                    return;
                }
                result.date_fin_cancel = request.date_fin_cancel;
                result.date_request = request.date_request;
                result.description = request.description;
                result.id_object = request.id_object;
                result.id_personel = request.id_personel;
                result.result = request.result;
                result.status = request.status;
                dc.SaveChanges();
            }
            catch (System.Data.Entity.Core.EntityException e)
            {
                throw new ServiceException("Database connection error!");
            }
        }

        public static void DeleteRequest(Request request)
        {
            try
            {
                CarWorkshopModelContext dc = new CarWorkshopModelContext();
                var res = (from el in dc.Request
                           where el.id_request == request.id_request
                           select el).SingleOrDefault();
                if (res == null)
                {
                    return;
                }
                dc.Request.Remove(res);
                dc.SaveChanges();
            }
            catch (System.Data.Entity.Core.EntityException e)
            {
                throw new ServiceException("Database connection error!");
            }
        }

        public static void NewRequest(Request request)
        {
            try
            {
                CarWorkshopModelContext dc = new CarWorkshopModelContext();
                dc.Request.Add(request);
                dc.SaveChanges();
                return;
            }
            catch (System.Data.Entity.Core.EntityException e)
            {
                throw new ServiceException("Database connection error!");
            } 
        }

        public static IQueryable<Activity> GetActivities(Activity searchCrit)
        {
            try
            {
                CarWorkshopModelContext dc = new CarWorkshopModelContext();
                var result = from el in dc.Activity
                             where
                             (String.IsNullOrEmpty(searchCrit.description) || el.description.StartsWith(searchCrit.description))
							 &&
                             ((searchCrit.id_personel == null) || (el.id_personel == searchCrit.id_personel))
							 &&
                             (String.IsNullOrEmpty(searchCrit.status) || el.status.StartsWith(searchCrit.status))
							 &&
                             (String.IsNullOrEmpty(searchCrit.result) || el.result.StartsWith(searchCrit.result))
							 &&
                             ((searchCrit.date_fin_cancel == null) || (el.date_fin_cancel == searchCrit.date_fin_cancel))
							 &&
                             (String.IsNullOrEmpty(searchCrit.act_type) || el.act_type.StartsWith(searchCrit.act_type))
							 &&
                             ((searchCrit.seq_no == null) || (el.seq_no == searchCrit.seq_no))
							 &&
							 ((searchCrit.id_activity == 0) || (el.id_activity == searchCrit.id_activity))
							 &&
							 (searchCrit.id_request == null || searchCrit.id_request == 0 || (el.id_request == searchCrit.id_request))
							 &&
							 ((searchCrit.date_request == null) || (
							 									  	 (el.date_request.Value.Year == searchCrit.date_request.Value.Year)
																  	 &&
																  	 (el.date_request.Value.Month == searchCrit.date_request.Value.Month)
																  	 &&
																  	 (el.date_request.Value.Day == searchCrit.date_request.Value.Day)
																  ))
							 select el;
                return result;
            }
            catch (System.Data.Entity.Core.EntityException e)
            {
                throw new ServiceException("Database connection error!");
            }
        }

        public static void UpdateActivity(Activity activity)
        {
            try
            {
                CarWorkshopModelContext dc = new CarWorkshopModelContext();
                var result = (from el in dc.Activity
                              where
                              el.id_activity == activity.id_activity
                              select el).SingleOrDefault();
                if (result == null)
                {
                    return;
                }
                result.date_fin_cancel = activity.date_fin_cancel;
                result.date_request = activity.date_request;
                result.description = activity.description;
                result.id_activity = activity.id_activity;
                result.id_personel = activity.id_personel;
                result.result = activity.result;
                result.status = activity.status;
                result.act_type = activity.act_type;
                result.seq_no = activity.seq_no;
                dc.SaveChanges();
            }
            catch (System.Data.Entity.Core.EntityException e)
            {
                throw new ServiceException("Database connection error!");
            }
        }

        public static void DeleteActivity(Activity activity)
        {
            try
            {
                CarWorkshopModelContext dc = new CarWorkshopModelContext();
                var res = (from el in dc.Activity
                           where el.id_activity == activity.id_activity
                           select el).SingleOrDefault();
                if (res == null)
                {
                    return;
                }
                dc.Activity.Remove(res);
                dc.SaveChanges();
            }
            catch (System.Data.Entity.Core.EntityException e)
            {
                throw new ServiceException("Database connection error!");
            }
        }

        public static void NewActivity(Activity activity)
        {
            try
            {
                CarWorkshopModelContext dc = new CarWorkshopModelContext();
                Activity sequneceSearch = new Activity();
                sequneceSearch.id_request = activity.id_request;
                var sequence = from el in dc.Activity
                               where
                               el.id_request == sequneceSearch.id_request
                               select el;
                if(sequence.ToArray().Length == 0)
                {
                    activity.seq_no = 1;
                }else
                {
                    activity.seq_no = sequence.ToArray().Last().seq_no + 1;
                }
                dc.Activity.Add(activity);
                dc.SaveChanges();
                return;
            } catch (ServiceException e)
            {
                throw e;
            } catch (System.Data.Entity.Core.EntityException e)
            {
                throw new ServiceException("Database connection error!");
            }
        }

        public static void NewActType(Act_dict type)
        {
            try
            {
                CarWorkshopModelContext dc = new CarWorkshopModelContext();
                var res = (from el in dc.Act_dict
                          where (el.act_name == type.act_name)
                          ||
                          (el.act_type == type.act_type)
                          select el).SingleOrDefault();
                if (res == null)
                {
                    dc.Act_dict.Add(type);
                    dc.SaveChanges();
                    return;
                }
                throw new ServiceException("Type already exists!");
            }
            catch (System.Data.Entity.Core.EntityException e)
            {
                throw new ServiceException("Database connection error!");
            }
        }

        public static IQueryable<Act_dict> GetActTypes()
        {
            try
            {
                CarWorkshopModelContext dc = new CarWorkshopModelContext();
                var res = from el in dc.Act_dict
                          select el;
                return res;
            }
            catch (System.Data.Entity.Core.EntityException e)
            {
                throw new ServiceException("Database connection error!");
            }
        }

        public static void NewObjectType(Object_type type)
        {
            try
            {
                CarWorkshopModelContext dc = new CarWorkshopModelContext();
                var res = (from el in dc.Object_type
                           where (el.name_type == type.name_type)
                           ||
                           (el.code_type == type.code_type)
                           select el).SingleOrDefault();
                if (res == null)
                {
                    dc.Object_type.Add(type);
                    dc.SaveChanges();
                    return;
                }
                throw new ServiceException("Type already exists!");
            }
            catch (System.Data.Entity.Core.EntityException e)
            {
                throw new ServiceException("Database connection error!");
            }
        }

        public static IQueryable<Object_type> GetObjectTypes()
        {
            try
            {
                CarWorkshopModelContext dc = new CarWorkshopModelContext();
                var res = from el in dc.Object_type
                          select el;
                return res;
            }
            catch (System.Data.Entity.Core.EntityException e)
            {
                throw new ServiceException("Database connection error!");
            }
        }
    }
}
