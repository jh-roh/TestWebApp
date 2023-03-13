using Note.IDAL;
using Note.Model;
using System;
using System.Collections.Generic;

namespace Note.BLL
{
    public class UserBll
    {
        //private UserDal _userDal = new UserDal();

        private readonly IUserDal _userDal;

        public UserBll(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public User GetUser(int userNo)
        {
            if(userNo <= 0)
            {
                throw new AggregateException();
            }

            return _userDal.GetUser(userNo);
        }

        public List<User> GetUserList()
        {
            return _userDal.GetUserList();
        }

        public bool SaveUser(User user)
        {
            if (user == null) throw new ArgumentNullException();

            return _userDal.SaveUser(user);
        }
    }
}
