using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IMemberRepository
    {
        IEnumerable<MemberObject> GetListOfUsers();
        IEnumerable<MemberObject> SortDescending();
        void InsertNewUser(MemberObject user);

        void UpdateUser(MemberObject user);
        void DeleteUser(string userID);
        MemberObject GetUserByID(string userID);
        MemberObject Login(string email, string password);
    }
}
