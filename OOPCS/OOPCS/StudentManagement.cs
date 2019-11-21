using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCS
{
    class StudentManagement
    {

        public PM23737[] GetStudent()
        {
            var db = new OOPCSEntities();
            return db.PM23737.ToArray();

        }
        public void AddClass(string name, string code, string hometown, bool gender)
        {
            var Class = new PM23737();
            Class.name = name;
            Class.code = code;
            Class.hometowm = hometown;
            Class.gender = gender;
            var db = new OOPCSEntities();
            db.PM23737.Add(Class);
            db.SaveChanges();
        }
        public void EditClass(int id, string name, string code,string hometown , bool gender)
        {
            var db = new OOPCSEntities();
            var Class = db.PM23737.Find(id);
            Class.name = name;
            Class.code = code;
            Class.hometowm = hometown;
            Class.gender = gender;
            db.Entry(Class).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();

        }

        public void DeleteStudent(int id)
        {
            var db = new OOPCSEntities();
            var @class = db.PM23737.Find(id);
            db.PM23737.Remove(@class);
            db.SaveChanges();

        }

        public PM23737 GetStudent(int id)
        {
            var db = new OOPCSEntities();
            var @class = db.PM23737.Find(id);
            return @class;
        }
    }
}