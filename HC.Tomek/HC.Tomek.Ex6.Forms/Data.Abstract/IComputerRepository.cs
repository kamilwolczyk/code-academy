using HC.Tomek.Ex6.Forms.Data.Abstract.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace HC.Tomek.Ex6.Forms.Data.Abstract
{
    public interface IComputerRepository
    {
        List<Computer> GetComputers();
    }
}