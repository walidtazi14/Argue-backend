using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend_project.Dtos
{
    public class UserForListDto
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public DateTime LastActive { get; set; }
        public string PolticalStanding { get; set; }
        public string Introduction { get; set; }
        public string Country { get; set; }
        public string PictureUrl { get; set; }

    }
}
