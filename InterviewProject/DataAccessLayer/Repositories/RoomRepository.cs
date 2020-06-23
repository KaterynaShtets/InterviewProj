using InterviewProject.Data;
using InterviewProject.EFCore;
using InterviewProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewProject.Repositories
{
    public class RoomRepository: Repository<Room, ApplicationContext>
    {
        public RoomRepository(ApplicationContext context): base(context) { }
    }
}
