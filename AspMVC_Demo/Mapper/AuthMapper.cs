using AspMVC_Demo.Domain.Entities;
using AspMVC_Demo.Web.Models;

namespace AspMVC_Demo.Web.Mapper
{
    public static class AuthMapper
    {
        public static User ToUser(this RegisterUser user)
        {
            return new User
            {
                Pseudo = user.Pseudo,
                Email = user.Email,
                Password = user.Password,
            };

        }

    }
}
