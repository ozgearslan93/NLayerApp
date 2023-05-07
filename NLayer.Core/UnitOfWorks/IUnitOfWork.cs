using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.UnitOfWorks
{
    public interface IUnitOfWork
    {
        Task CommitAsync(); //Commit, bir veritabanı işlemi sırasında yapılan değişiklikleri kalıcı hale getirmek için kullanılan bir terimdir
        void Commit();
    }
}
