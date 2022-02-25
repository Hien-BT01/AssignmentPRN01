using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class MemberRepository : IMemberRepository
    {
        public void DeleteUser(string userID) => MemberDAO.Instance.RemoveUserByID(userID);

        public IEnumerable<MemberObject> GetListOfUsers() => MemberDAO.Instance.GetListOfUsers;

        public MemberObject GetUserByID(string userID) => MemberDAO.Instance.GetUserByID(userID);

        public void InsertNewUser(MemberObject user) => MemberDAO.Instance.InsertAUser(user);

        public MemberObject Login(string email, string password) => MemberDAO.Instance.Login(email, password);
        public IEnumerable<MemberObject> SortDescending() => MemberDAO.Instance.SortUserDescendingByName();

        public void UpdateUser(MemberObject user) => MemberDAO.Instance.UpdateUserProfile(user);
    }
}
