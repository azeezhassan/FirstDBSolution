using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FirstDB.DAL
{
   public class StudentInfoDl
    {
        STUDENTEntities context = new STUDENTEntities(); 
   
        public void Save(StudentInfo StudentInfoObj)
        {
            context.StudentInfoes.Add(StudentInfoObj);
            context.SaveChanges();

        }

       // This is used to list all in d database
        public IEnumerable<StudentInfo> ListAll()
        {
            return context.StudentInfoes.ToList();
        
        }

        public void Search(StudentInfo StudentInfoObj)
        {
            var search = context.StudentInfoes.Where(c => c.Matric_Num == StudentInfoObj.Matric_Num).FirstOrDefault();
            search.Fullname = StudentInfoObj.Fullname;
            search.Address = StudentInfoObj.Address;
            search.Age = StudentInfoObj.Age;
            
        }

    }
}
