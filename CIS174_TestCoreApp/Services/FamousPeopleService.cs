using CIS174_TestCoreApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.SqlServer.Design;

namespace CIS174_TestCoreApp.Services
{
    public class FamousPeopleService
    {

        //static readonly AppDbContext _context;
        public static int CreateFamousPeople(FamousPeople cmd)
        {
            
            var fp = new FamousPeople
            {
                firstName = cmd.firstName,
                FamousPeopleId = cmd.FamousPeopleId,
                lastName = cmd.lastName,
                birthDate = cmd.birthDate,
                city = cmd.city,
                state = cmd.state,
                Achievements = cmd.Achievements?.Select(i=> new Achievements { 
                    AchievementsId = i.AchievementsId,
                    FamousPeopleId = i.FamousPeopleId,
                    name = i.name,
                    doa = i.doa
                
                
                }).ToList()
            };
           // _context.Add(fp);
           // _context.SaveChanges();
            return fp.FamousPeopleId;


        }
    }
}
