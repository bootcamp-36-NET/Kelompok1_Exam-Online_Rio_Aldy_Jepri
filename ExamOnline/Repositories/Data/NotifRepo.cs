using ExamOnline.Context;
using ExamOnline.Models;
using Microsoft.AspNetCore.Identity.UI.Pages.Internal.Account;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamOnline.Repositories.Data
{
    public class NotifRepo : GeneralRepo<Notifications, MyContext>
    {
        private MyContext _context;
        public NotifRepo(MyContext context) : base(context)
        {
            this._context = context;
        }
        
        public override async Task<int> Create(Notifications notifications)
        {
            if(notifications == null)
            {
                return 0;
            }
            else
            {
                Notifications item = new Notifications()
                {
                    EmployeeId = notifications.EmployeeId,
                    Message = notifications.EmployeeId + " mengajukan untuk reschedule exam pada " + notifications.RequestedDate.Date,
                    CreatedDate = DateTimeOffset.Now,
                    RequestedDate = notifications.RequestedDate
                    
                };

                int saveProcess = await base.Create(item);
                
                if(saveProcess == null)
                {
                    return 0;
                }
                else
                {
                    return saveProcess;
                }
                
            }
        }


        public List<Notifications> GetByEmployeeId(string Id)
        {
            List<Notifications> notifList = null;

            notifList = _context.notifications.Where(x => x.EmployeeId == Id).ToList();
            
            if(notifList == null)
            {
                return null;
            }
            return notifList;
        }

        public Notifications ReadNotification(string Id)
        {
            var item = _context.notifications.Where(x => x.Id == Id).SingleOrDefault();
            
            if(item == null)
            {
                return null;
            }
            else
            {
                item.isDelete = true;

                var updatedItem = _context.notifications.Update(item);
                if(updatedItem == null)
                {
                    return null;
                }
                else
                {
                    _context.SaveChanges();
                    return item;
                }
                
            }
        }
    }
}
