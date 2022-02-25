using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class MemberDAO
    {
        private static List<MemberObject> ListOfUsers = new List<MemberObject>
        {
            new MemberObject{ MemberID = "1", MemberName = "Hien senpai", Email= "hienbui11@gmail.com",
            Password = "123456789", City = "Binh Dupng", Country = "Vietnam" },
            new MemberObject{ MemberID = "2", MemberName = "Eren king", Email= "hienbui12@gmail.com",
            Password = "11111", City = "Rose", Country = "Vietnam" },
            new MemberObject{ MemberID = "3", MemberName = "Thien vung tau", Email= "thienKing@gmail.com",
            Password = "11111", City = "Vung Tau", Country = "Vietnam" },
        };
        private static MemberDAO instance = null;
        private static readonly object instnaceLock = new object();
        private MemberDAO() { }
        public static MemberDAO Instance
        {
            get
            {
                lock (instnaceLock)
                {
                    if (instance == null)
                    {
                        instance = new MemberDAO();
                    }
                    return instance;
                }
            }
        }
        public List<MemberObject> GetListOfUsers => ListOfUsers;
        public MemberObject Login(string email, string password)
        {
            //using LINQ to Object
            MemberObject userAccount = ListOfUsers.SingleOrDefault(user => user.Email == email && user.Password == password);
            if (userAccount == null) return null;
            return userAccount;
        }
        public MemberObject GetUserByID(string UserID)
        {
            //using LINQ to Object
            MemberObject member = ListOfUsers.SingleOrDefault(user => user.MemberID == UserID);
            return member;
        }
        public void InsertAUser(MemberObject user)
        {
            MemberObject userProfile = GetUserByID(user.MemberID);
            if (userProfile != null)
            {
                throw new Exception("User already exists.");
            }
            else
            {
                ListOfUsers.Add(user);
            }
        }
        public void UpdateUserProfile(MemberObject user)
        {
            MemberObject userProfile = GetUserByID(user.MemberID);
            if (userProfile == null)
            {
                throw new Exception("User does not exist.");
            }
            else
            {
                var index = ListOfUsers.IndexOf(userProfile);
                ListOfUsers[index] = user;
            }
        }
        public void RemoveUserByID(string userID)
        {
            MemberObject user = GetUserByID(userID);
            if (user == null)
            {
                throw new Exception("User does not exists.");
            }
            else
            {
                ListOfUsers.Remove(user);
            }
        }
        public List<MemberObject> SortUserDescendingByName()
        {
            var listSortedDescending = ListOfUsers.OrderByDescending(user => user.MemberName).ToList();
            ListOfUsers = listSortedDescending;
            return ListOfUsers;
        }
    }
}
