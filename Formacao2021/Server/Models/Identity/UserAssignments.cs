using Formacao2021.Server.Data;
using Formacao2021.Shared.Models.Tabelas;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Formacao2021.Server.Models.Identity
{
    public class UserAssignments
    {
        public List<AssignedUhData> AssignedUhDataList { get; set; }

        public void PopulateAssignedUhData(AppDBContext db, AppUser appUser)
        {
            if (appUser == null) { throw new NullReferenceException(); }
            if (db == null) { throw new NullReferenceException(); }

            DbSet<Uh> todasUh = db.Uhs;
            HashSet<Guid> userUhs = new HashSet<Guid>(appUser.UserUhs.Select(u => u.UhID));
            AssignedUhDataList = new List<AssignedUhData>();

            foreach (Uh uh in todasUh)
            {
                AssignedUhDataList.Add(new AssignedUhData
                {
                    UhID = uh.UhID,
                    Name = uh.UhNome,
                    Assigned = userUhs.Contains(uh.UhID)
                });
            }
        }

        public void PopulateAllUhData(AppDBContext db)
        {
            if (db == null) { throw new NullReferenceException(); }

            DbSet<Uh> todasUh = db.Uhs;
            AssignedUhDataList = new List<AssignedUhData>();

            foreach (Uh uh in todasUh)
            {
                AssignedUhDataList.Add(new AssignedUhData
                {
                    UhID = uh.UhID,
                    Name = uh.UhNome,
                    Assigned = false
                });
            }
        }

        public static void UpdateUserUhs(AppDBContext db, string[] selectedUhs, AppUser userToUpdate)
        {
            if (userToUpdate == null) { throw new NullReferenceException(); }
            if (db == null) { throw new NullReferenceException(); }
            if (selectedUhs == null)
            {
                userToUpdate.UserUhs = new List<UserUh>();
                return;
            }

            HashSet<string> selectedUhsHS = new HashSet<string>(selectedUhs);
            HashSet<Guid> userUhs = new HashSet<Guid>(userToUpdate.UserUhs.Select(u => u.UhID));
            foreach (Uh uh in db.Uhs)
            {
                if (selectedUhsHS.Contains(uh.UhID.ToString()))
                {
                    if (!userUhs.Contains(uh.UhID))
                    {
                        userToUpdate.UserUhs.Add(
                            new UserUh
                            {
                                User = userToUpdate,
                                UhID = uh.UhID
                            });
                    }
                }
                else
                {
                    if (userUhs.Contains(uh.UhID))
                    {
                        UserUh uhToRemove = userToUpdate.UserUhs.SingleOrDefault(i => i.UhID == uh.UhID);
                        _ = db.Remove(uhToRemove);
                    }
                }
            }
        }

    }
}
