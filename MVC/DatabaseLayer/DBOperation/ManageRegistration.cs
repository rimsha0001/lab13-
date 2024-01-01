using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessLayer;
using DatabaseLayer;
namespace DatabaseLayer.DBOperation
{
    public class ManageRegistration
    {
        public void AddReg(registrationModel regModel)
        {
            using (var DB = new MyDBEntities()) 
            {
                Registration registration = new Registration()
                {
                    Id = regModel.Id,
                    Name = regModel.Name,   
                    Smester=regModel.Smester,
                };
                DB.Registrations.Add(registration);
                DB.SaveChanges();
            }
        }
    }
}
