using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BizzLayer
{
    public static class AdminService
    {
        public static IQueryable<Personel> GetPersonel(Personel searchCrit)
        {
            try
            {
                CarWorkshopModelContext dc = new CarWorkshopModelContext();
                var result = from el in dc.Personel
                             where
                             (String.IsNullOrEmpty(searchCrit.last_name) || el.last_name.Contains(searchCrit.last_name))
                             &&
                             (String.IsNullOrEmpty(searchCrit.first_name) || el.first_name.Contains(searchCrit.first_name))
                             &&
                             (String.IsNullOrEmpty(searchCrit.role) || el.role.Contains(searchCrit.role))
                             select el;
                return result;
            }
            catch(System.Data.Entity.Core.EntityException e)
            {
                throw new ServiceException("Database connection error!");
            }
            
        }

        public static IQueryable<Personel> GetPersonelActive(Personel searchCrit)
        {
            var result = GetPersonel(searchCrit);
            result = from el in result
                     where
					 el.date_retire == null || el.date_retire > System.DateTime.Now
                     select el;
            return result;
        }

        public static Personel GetPersonelWithPassword(Personel searchCrit)
        {
            try
            {
                searchCrit.password = Md5Hash(searchCrit.password);
                CarWorkshopModelContext dc = new CarWorkshopModelContext();
                var result = from el in dc.Personel
                             where
                             (el.username == searchCrit.username)
                             &&
                             (el.password == searchCrit.password)
                             &&
                             ((el.date_retire == null) || (el.date_retire > System.DateTime.Now))
                             select el;
                return result.SingleOrDefault<Personel>();
            }catch(System.Data.Entity.Core.EntityException e)
            {
                throw new ServiceException("Database connection error!");
            }
        }

        public static void UpdatePersonel(Personel personel)
        {
            try
            {
                CarWorkshopModelContext dc = new CarWorkshopModelContext();
				if(!string.IsNullOrEmpty(personel.password))
					personel.password = Md5Hash(personel.password);
                var res = (from el in dc.Personel
                           where el.id_personel == personel.id_personel
                           select el).SingleOrDefault();
                if(res == null)
                {
                    return;
                }
                res.first_name = personel.first_name;
                res.last_name = personel.last_name;
                if(!string.IsNullOrEmpty(personel.password) && res.password != personel.password)
                {
                    res.password = personel.password;
                }
                res.date_retire = personel.date_retire;
                res.role = personel.role;
                dc.SaveChanges();
            } catch (System.Data.Entity.Core.EntityException e)
            {
                throw new ServiceException("Database connection error!");
            }
        }

        public static void DeletePersonel(Personel personel)
        {
            try
            {
                CarWorkshopModelContext dc = new CarWorkshopModelContext();
                var res = (from el in dc.Personel
                           where el.id_personel == personel.id_personel
                           select el).SingleOrDefault();
                if (res == null)
                {
                    return;
                }
                dc.Personel.Remove(res);
                dc.SaveChanges();
            }
            catch (System.Data.Entity.Core.EntityException e)
            {
                throw new ServiceException("Database connection error!");
            }
        }

        public static void NewPersonel(Personel personel)
        {
            try
            {
                CarWorkshopModelContext dc = new CarWorkshopModelContext();
                personel.password = Md5Hash(personel.password);
                var res = (from el in dc.Personel
                           where el.username == personel.username
                           select el).SingleOrDefault();
                if (res == null)
                {
                    dc.Personel.Add(personel);
                    dc.SaveChanges();
                    return;
                }
                throw new ServiceException("Username already exists!");
            }
            catch (System.Data.Entity.Core.EntityException e)
            {
                throw new ServiceException("Database connection error!");
            }
        }

        private static string Md5Hash(string value)
        {
            if(value == null)
            {
                return value;
            }
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(value);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }
    }
}
