using Contracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private ApplicationDbContext _appContext;
        private ITodoRepository _todo;
        private IUserRepository _user;

        public ITodoRepository Todo
        {
            get
            {
                if (_todo == null)
                {
                    _todo = new TodoRepository(_appContext);
                }
                return _todo;
            }
        }

        public IUserRepository User
        {
            get
            {
                if (_user == null)
                {
                    _user = new UserRepository(_appContext);
                }
                return _user;
            }
        }

        public RepositoryWrapper(ApplicationDbContext applicationContext)
        {
            _appContext = applicationContext;
        }

        public void Save()
        {
            _appContext.SaveChanges();
        }
    }
}
